using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;
using Microsoft.Win32.SafeHandles;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Wrapper.Implementation
{



    public class NewWindowRequestedEventArgs2Interface : NewWindowRequestedEventArgsInterface
    {
        private ComObjectHolder<ICoreWebView2NewWindowRequestedEventArgs2> _Args;
        private ICoreWebView2NewWindowRequestedEventArgs2 Args
        {
            get
            {
                if (_Args == null)
                {
                    Debug.Print(nameof(NewWindowRequestedEventArgsInterface) + "=>" + nameof(Args) + " is null");

                    throw new InvalidOperationException(nameof(NewWindowRequestedEventArgsInterface) + "=>" + nameof(Args) + " is null");
                }
                return _Args.Interface;
            }
            set => _Args = new ComObjectHolder<ICoreWebView2NewWindowRequestedEventArgs2>(value);
        }
        public NewWindowRequestedEventArgs2Interface(ICoreWebView2NewWindowRequestedEventArgs2 args) : base(args)
        {
            Args = args ?? throw new ArgumentNullException(nameof(args));
        }
        public string name => Args.Getname();

        private bool _IsDisposed;
        protected override void Dispose(bool disposing)
        {
            if (_IsDisposed) return;
            if (disposing)
            {
                _Args = null;
            }

            _IsDisposed = true;
            base.Dispose(disposing);
        }
    }
    public class NewWindowRequestedEventArgsInterface : IDisposable
    {
        private ComObjectHolder<ICoreWebView2NewWindowRequestedEventArgs> _Args;
        private bool _IsDisposed;
        /// Wraps in SafeHandle so resources can be released if consumer forgets to call Dispose. Recommended
        ///             pattern for any type that is not sealed.
        ///             https://docs.microsoft.com/dotnet/api/system.idisposable#idisposable-and-the-inheritance-hierarchy
        private readonly SafeHandle handle = new SafeFileHandle(nint.Zero, true);
        private ICoreWebView2NewWindowRequestedEventArgs Args
        {
            get
            {
                if (_Args == null)
                {
                    Debug.Print(nameof(NewWindowRequestedEventArgsInterface) + "=>" + nameof(Args) + " is null");

                    throw new InvalidOperationException(nameof(NewWindowRequestedEventArgsInterface) + "=>" + nameof(Args) + " is null");
                }
                return _Args.Interface;
            }
            set { _Args = new ComObjectHolder<ICoreWebView2NewWindowRequestedEventArgs>(value); }
        }
        public NewWindowRequestedEventArgsInterface(ICoreWebView2NewWindowRequestedEventArgs args)
        {
            Args = args ?? throw new ArgumentNullException(nameof(args));
        }
        public string uri => Args.Geturi();

        public ICoreWebView2 NewWindow { get => Args.GetNewWindow(); set => Args.SetNewWindow(value); }
        public int Handled { get => Args.GetHandled(); set => Args.SetHandled(value); }

        public int IsUserInitiated => Args.GetIsUserInitiated();

        [return: MarshalAs(UnmanagedType.Interface)]
        public ICoreWebView2Deferral GetDeferral()
        {
            return Args.GetDeferral();
        }

        public ICoreWebView2WindowFeatures WindowFeatures => Args.GetWindowFeatures();

        protected virtual void Dispose(bool disposing)
        {
            if (!_IsDisposed)
            {
                if (disposing)
                {
                    handle.Dispose();
                    _Args = null;
                }

                _IsDisposed = true;
            }
        }


        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
