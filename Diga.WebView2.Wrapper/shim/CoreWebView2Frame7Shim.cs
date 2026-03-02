using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.shim
{
    /// <summary>
    /// Shim-Wrapper für ICoreWebView2Frame7
    /// </summary>
    public class CoreWebView2Frame7Shim : CoreWebView2Frame6Shim
    {
        private ComObjectHolder<ICoreWebView2Frame7> _Iface;
        private SafeHandle handle = new SafeFileHandle(nint.Zero, true);

        /// <summary>
        /// Gets the wrapped COM interface.
        /// </summary>
        private ICoreWebView2Frame7 Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(CoreWebView2Frame7Shim) + " Iface is null");
                    throw new InvalidOperationException(nameof(CoreWebView2Frame7Shim) + " Iface is null");
                }

                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<ICoreWebView2Frame7>(value);
        }

        /// <summary>
        /// Initializes a new instance of the CoreWebView2Frame7Shim class.
        /// </summary>
        /// <param name="iface">The COM interface to wrap</param>
        public CoreWebView2Frame7Shim(ICoreWebView2Frame7 iface) : base((ICoreWebView2Frame6)iface)
        {
            Iface = iface;
        }

        #region Methods

        /// <summary>
        /// Wraps the add_FrameCreated method.
        /// </summary>
        /// <param name="eventHandler"></param>
        /// <param name="token"></param>
        public void add_FrameCreated(ICoreWebView2FrameChildFrameCreatedEventHandler eventHandler, out EventRegistrationToken token)
        {
            Iface.add_FrameCreated(eventHandler, out token);
        }

        /// <summary>
        /// Wraps the remove_FrameCreated method.
        /// </summary>
        /// <param name="token"></param>
        public void remove_FrameCreated(EventRegistrationToken token)
        {
            Iface.remove_FrameCreated(token);
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
