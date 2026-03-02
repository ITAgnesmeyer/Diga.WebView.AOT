using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.shim
{
    /// <summary>
    /// Shim-Wrapper für ICoreWebView2_25
    /// </summary>
    public class CoreWebView2_25Shim : CoreWebView2_24Shim
    {
        private ComObjectHolder<ICoreWebView2_25> _Iface;
        private SafeHandle handle = new SafeFileHandle(nint.Zero, true);

        /// <summary>
        /// Gets the wrapped COM interface.
        /// </summary>
        private ICoreWebView2_25 Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(CoreWebView2_25Shim) + " Iface is null");
                    throw new InvalidOperationException(nameof(CoreWebView2_25Shim) + " Iface is null");
                }

                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<ICoreWebView2_25>(value);
        }

        /// <summary>
        /// Initializes a new instance of the CoreWebView2_25Shim class.
        /// </summary>
        /// <param name="iface">The COM interface to wrap</param>
        public CoreWebView2_25Shim(ICoreWebView2_25 iface) : base((ICoreWebView2_24)iface)
        {
            Iface = iface;
        }

        #region Methods

        /// <summary>
        /// Wraps the add_SaveAsUIShowing method.
        /// </summary>
        /// <param name="eventHandler"></param>
        /// <param name="token"></param>
        public void add_SaveAsUIShowing(ICoreWebView2SaveAsUIShowingEventHandler eventHandler, out EventRegistrationToken token)
        {
            Iface.add_SaveAsUIShowing(eventHandler, out token);
        }

        /// <summary>
        /// Wraps the remove_SaveAsUIShowing method.
        /// </summary>
        /// <param name="token"></param>
        public void remove_SaveAsUIShowing(EventRegistrationToken token)
        {
            Iface.remove_SaveAsUIShowing(token);
        }

        /// <summary>
        /// Wraps the ShowSaveAsUI method.
        /// </summary>
        /// <param name="handler"></param>
        public void ShowSaveAsUI(ICoreWebView2ShowSaveAsUICompletedHandler handler)
        {
            Iface.ShowSaveAsUI(handler);
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
