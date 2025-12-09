using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Wrapper.Implementation
{
    public class ContextMenuRequestedEventArgsInterface : EventArgs, IDisposable//,ICoreWebView2ContextMenuRequestedEventArgs
    {
        private ComObjectHolder<ICoreWebView2ContextMenuRequestedEventArgs> _Args;
        private bool disposedValue;
        ///// Wraps in SafeHandle so resources can be released if consumer forgets to call Dispose. Recommended
        /////             pattern for any type that is not sealed.
        /////             https://docs.microsoft.com/dotnet/api/system.idisposable#idisposable-and-the-inheritance-hierarchy
        //private SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);
        private ICoreWebView2ContextMenuRequestedEventArgs Args
        {
            get
            {
                if (_Args == null)
                {
                    Debug.Print(nameof(ContextMenuRequestedEventArgsInterface) + "." + nameof(_Args) + " is null");
                    throw new InvalidOperationException(nameof(ContextMenuRequestedEventArgsInterface) + "." + nameof(_Args) + " is null");

                }
                return _Args.Interface;
            }
        }

        public ContextMenuRequestedEventArgsInterface(object args)
        {
            if (args == null) throw new ArgumentNullException(nameof(args));
            _Args = new ComObjectHolder<ICoreWebView2ContextMenuRequestedEventArgs>(args);
        }

        public ICoreWebView2ContextMenuItemCollection MenuItems => Args.GetMenuItems();

        public ICoreWebView2ContextMenuTarget ContextMenuTarget => Args.GetContextMenuTarget();

        public POINT Location => Args.GetLocation();

        public int SelectedCommandId { get => Args.GetSelectedCommandId(); set => Args.SetSelectedCommandId(value); }
        public int Handled { get => Args.GetHandled(); set => Args.SetHandled(value); }

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
                    //handle.Dispose();
                    //_Args = null;
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
