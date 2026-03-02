using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.shim
{
    /// <summary>
    /// Shim-Wrapper für ICoreWebView2Frame6
    /// </summary>
    public class CoreWebView2Frame6Shim : CoreWebView2Frame5Shim
    {
        private ComObjectHolder<ICoreWebView2Frame6> _Iface;
        private SafeHandle handle = new SafeFileHandle(nint.Zero, true);

        /// <summary>
        /// Gets the wrapped COM interface.
        /// </summary>
        private ICoreWebView2Frame6 Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(CoreWebView2Frame6Shim) + " Iface is null");
                    throw new InvalidOperationException(nameof(CoreWebView2Frame6Shim) + " Iface is null");
                }

                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<ICoreWebView2Frame6>(value);
        }

        /// <summary>
        /// Initializes a new instance of the CoreWebView2Frame6Shim class.
        /// </summary>
        /// <param name="iface">The COM interface to wrap</param>
        public CoreWebView2Frame6Shim(ICoreWebView2Frame6 iface) : base((ICoreWebView2Frame5)iface)
        {
            Iface = iface;
        }

        #region Methods

        /// <summary>
        /// Wraps the add_ScreenCaptureStarting method.
        /// </summary>
        /// <param name="eventHandler"></param>
        /// <param name="token"></param>
        public void add_ScreenCaptureStarting(ICoreWebView2FrameScreenCaptureStartingEventHandler eventHandler, out EventRegistrationToken token)
        {
            Iface.add_ScreenCaptureStarting(eventHandler, out token);
        }

        /// <summary>
        /// Wraps the remove_ScreenCaptureStarting method.
        /// </summary>
        /// <param name="token"></param>
        public void remove_ScreenCaptureStarting(EventRegistrationToken token)
        {
            Iface.remove_ScreenCaptureStarting(token);
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
