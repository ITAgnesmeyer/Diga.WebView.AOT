using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.shim
{
    /// <summary>
    /// Shim-Wrapper für ICoreWebView2Profile8
    /// </summary>
    public class CoreWebView2Profile8Shim : CoreWebView2Profile7Shim
    {
        private ComObjectHolder<ICoreWebView2Profile8> _Iface;
        private SafeHandle handle = new SafeFileHandle(nint.Zero, true);

        /// <summary>
        /// Gets the wrapped COM interface.
        /// </summary>
        private ICoreWebView2Profile8 Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(CoreWebView2Profile8Shim) + " Iface is null");
                    throw new InvalidOperationException(nameof(CoreWebView2Profile8Shim) + " Iface is null");
                }

                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<ICoreWebView2Profile8>(value);
        }

        /// <summary>
        /// Initializes a new instance of the CoreWebView2Profile8Shim class.
        /// </summary>
        /// <param name="iface">The COM interface to wrap</param>
        public CoreWebView2Profile8Shim(ICoreWebView2Profile8 iface) : base((ICoreWebView2Profile7)iface)
        {
            Iface = iface;
        }

        #region Methods

        /// <summary>
        /// Wraps the Delete method.
        /// </summary>
        public void Delete()
        {
            Iface.Delete();
        }

        /// <summary>
        /// Wraps the add_Deleted method.
        /// </summary>
        /// <param name="eventHandler"></param>
        /// <param name="token"></param>
        public void add_Deleted(ICoreWebView2ProfileDeletedEventHandler eventHandler, out EventRegistrationToken token)
        {
            Iface.add_Deleted(eventHandler, out token);
        }

        /// <summary>
        /// Wraps the remove_Deleted method.
        /// </summary>
        /// <param name="token"></param>
        public void remove_Deleted(EventRegistrationToken token)
        {
            Iface.remove_Deleted(token);
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
