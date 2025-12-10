using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;
using Microsoft.Win32.SafeHandles;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Wrapper.shim
{
    public class PermissionRequestedEventArgs2Interface : PermissionRequestedEventArgsInterface
    {
        private ComObjectHolder<ICoreWebView2PermissionRequestedEventArgs2> _Args;
        private ICoreWebView2PermissionRequestedEventArgs2 Args
        {
            get
            {
                if (_Args == null)
                {
                    Debug.Print(nameof(PermissionRequestedEventArgs2Interface) + " Args is null");
                    throw new InvalidOperationException(nameof(PermissionRequestedEventArgs2Interface) + " Args is null");
                }

                return _Args.Interface;
            }
            set
            {
                _Args = new ComObjectHolder<ICoreWebView2PermissionRequestedEventArgs2>(value);
            }
        }
        public PermissionRequestedEventArgs2Interface(ICoreWebView2PermissionRequestedEventArgs2 args) : base(args)
        {
            Args = args;
        }
        public int Handled { get => Args.GetHandled(); set => Args.SetHandled(value); }
        private bool disposedValue;
        protected override void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {


                    _Args = null;
                }

                disposedValue = true;
            }
            base.Dispose(disposing);
        }
    }
    public class PermissionRequestedEventArgsInterface : EventArgs
    {
        private ComObjectHolder<ICoreWebView2PermissionRequestedEventArgs> _Args;
        private bool disposedValue;

        /// Wraps in SafeHandle so resources can be released if consumer forgets to call Dispose. Recommended
        ///             pattern for any type that is not sealed.
        ///             https://docs.microsoft.com/dotnet/api/system.idisposable#idisposable-and-the-inheritance-hierarchy
        private SafeHandle handle = new SafeFileHandle(nint.Zero, true);
        private ICoreWebView2PermissionRequestedEventArgs Args
        {
            get
            {
                if (_Args == null)
                {
                    Debug.Print(nameof(PermissionRequestedEventArgsInterface) + " Args is null");
                    throw new InvalidOperationException(nameof(PermissionRequestedEventArgsInterface) + " Args is null");
                }

                return _Args.Interface;
            }
            set
            {
                _Args = new ComObjectHolder<ICoreWebView2PermissionRequestedEventArgs>(value);
            }
        }
        public PermissionRequestedEventArgsInterface(ICoreWebView2PermissionRequestedEventArgs args)
        {
            Args = args;
        }

        public string uri => Args.Geturi();

        public COREWEBVIEW2_PERMISSION_KIND PermissionKind => Args.GetPermissionKind();

        public int IsUserInitiated => Args.GetIsUserInitiated();

        public COREWEBVIEW2_PERMISSION_STATE State { get => Args.GetState(); set => Args.SetState(value); }

        [return: MarshalAs(UnmanagedType.Interface)]
        public ICoreWebView2Deferral GetDeferral()
        {
            return Args.GetDeferral();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {

                    handle.Dispose();
                    _Args = null;
                }

                disposedValue = true;
            }
        }



        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
