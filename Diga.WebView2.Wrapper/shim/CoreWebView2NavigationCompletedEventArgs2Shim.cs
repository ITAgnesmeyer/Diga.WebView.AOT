using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.shim
{
    /// <summary>
    /// Shim-Wrapper für ICoreWebView2NavigationCompletedEventArgs2
    /// </summary>
    public class CoreWebView2NavigationCompletedEventArgs2Shim : CoreWebView2NavigationCompletedEventArgsShim
    {
        private ComObjectHolder<ICoreWebView2NavigationCompletedEventArgs2> _Iface;
        private SafeHandle handle = new SafeFileHandle(nint.Zero, true);

        /// <summary>
        /// Gets the wrapped COM interface.
        /// </summary>
        private ICoreWebView2NavigationCompletedEventArgs2 Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(CoreWebView2NavigationCompletedEventArgs2Shim) + " Iface is null");
                    throw new InvalidOperationException(nameof(CoreWebView2NavigationCompletedEventArgs2Shim) + " Iface is null");
                }

                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<ICoreWebView2NavigationCompletedEventArgs2>(value);
        }

        /// <summary>
        /// Initializes a new instance of the CoreWebView2NavigationCompletedEventArgs2Shim class.
        /// </summary>
        /// <param name="iface">The COM interface to wrap</param>
        public CoreWebView2NavigationCompletedEventArgs2Shim(ICoreWebView2NavigationCompletedEventArgs2 iface) : base((ICoreWebView2NavigationCompletedEventArgs)iface)
        {
            Iface = iface;
        }

        #region Properties

        /// <summary>
        /// Gets the HttpStatusCode property.
        /// </summary>
        public int HttpStatusCode
        {
            get => Iface.GetHttpStatusCode();
        }

        #endregion


        /// <summary>
        /// Protected override dispose method.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                handle?.Dispose();
                _Iface = null;
            }
            base.Dispose(disposing);
        }
    }
}
