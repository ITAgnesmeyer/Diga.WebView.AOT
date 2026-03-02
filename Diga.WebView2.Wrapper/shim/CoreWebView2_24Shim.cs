using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.shim
{
    /// <summary>
    /// Shim-Wrapper für ICoreWebView2_24
    /// </summary>
    public class CoreWebView2_24Shim : CoreWebView2_23Shim
    {
        private ComObjectHolder<ICoreWebView2_24> _Iface;
        private SafeHandle handle = new SafeFileHandle(nint.Zero, true);

        /// <summary>
        /// Gets the wrapped COM interface.
        /// </summary>
        private ICoreWebView2_24 Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(CoreWebView2_24Shim) + " Iface is null");
                    throw new InvalidOperationException(nameof(CoreWebView2_24Shim) + " Iface is null");
                }

                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<ICoreWebView2_24>(value);
        }

        /// <summary>
        /// Initializes a new instance of the CoreWebView2_24Shim class.
        /// </summary>
        /// <param name="iface">The COM interface to wrap</param>
        public CoreWebView2_24Shim(ICoreWebView2_24 iface) : base((ICoreWebView2_23)iface)
        {
            Iface = iface;
        }

        #region Methods

        /// <summary>
        /// Wraps the add_NotificationReceived method.
        /// </summary>
        /// <param name="eventHandler"></param>
        /// <param name="token"></param>
        public void add_NotificationReceived(ICoreWebView2NotificationReceivedEventHandler eventHandler, out EventRegistrationToken token)
        {
            Iface.add_NotificationReceived(eventHandler, out token);
        }

        /// <summary>
        /// Wraps the remove_NotificationReceived method.
        /// </summary>
        /// <param name="token"></param>
        public void remove_NotificationReceived(EventRegistrationToken token)
        {
            Iface.remove_NotificationReceived(token);
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
