using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;
using Microsoft.Win32.SafeHandles;
using System.Diagnostics;
using System.Runtime.InteropServices;
namespace Diga.WebView2.Wrapper.shim
{

    public class WebMessageReceivedEventArgs2Intefrace : WebMessageReceivedEventArgsInterface
    {
        private ComObjectHolder<ICoreWebView2WebMessageReceivedEventArgs2> _Iface;

        private ICoreWebView2WebMessageReceivedEventArgs2 Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(WebMessageReceivedEventArgs2Intefrace) + "=>" + nameof(Iface) + " is null");

                    throw new InvalidOperationException(nameof(WebMessageReceivedEventArgs2Intefrace) + "=>" + nameof(Iface) + " is null");
                }

                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<ICoreWebView2WebMessageReceivedEventArgs2>(value);
        }

        public WebMessageReceivedEventArgs2Intefrace(ICoreWebView2WebMessageReceivedEventArgs2 iface) : base(iface)
        {
            Iface = iface ?? throw new ArgumentNullException(nameof(iface));
        }
        private bool _IsDisposed;
        protected override void Dispose(bool disposing)
        {
            if (this._IsDisposed) return;
            if (disposing)
            {
                this._Iface = null;
                this._IsDisposed = true;
            }
            base.Dispose(disposing);
        }

        public ICoreWebView2ObjectCollectionView AdditionalObjects => Iface.GetAdditionalObjects();

    }
    public class WebMessageReceivedEventArgsInterface : EventArgs, IDisposable
    {
        private ComObjectHolder<ICoreWebView2WebMessageReceivedEventArgs> _Iface;
        private bool _IsDesposed;

        /// Wraps in SafeHandle so resources can be released if consumer forgets to call Dispose. Recommended
        ///             pattern for any type that is not sealed.
        ///             https://docs.microsoft.com/dotnet/api/system.idisposable#idisposable-and-the-inheritance-hierarchy
        private SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);
        public WebMessageReceivedEventArgsInterface(ICoreWebView2WebMessageReceivedEventArgs iface)
        {
            Iface = iface ?? throw new ArgumentNullException(nameof(iface));
        }

        private ICoreWebView2WebMessageReceivedEventArgs Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(WebMessageReceivedEventArgsInterface) + "=>" + nameof(Iface) + " is null");

                    throw new InvalidOperationException(nameof(WebMessageReceivedEventArgsInterface) + "=>" + nameof(Iface) + " is null");
                }

                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<ICoreWebView2WebMessageReceivedEventArgs>(value);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_IsDesposed)
            {
                if (disposing)
                {
                    handle.Dispose();
                    _Iface = null;
                }

                _IsDesposed = true;
            }
        }

        public void Dispose()
        {
            // Ändern Sie diesen Code nicht. Fügen Sie Bereinigungscode in der Methode "Dispose(bool disposing)" ein.
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        public string Source => this.Iface.GetSource();

        public string webMessageAsJson => this.Iface.GetwebMessageAsJson();

        [return: MarshalAs(UnmanagedType.LPWStr)]
        public string TryGetWebMessageAsString()
        {
            return this.Iface.TryGetWebMessageAsString();
        }
    }
}
