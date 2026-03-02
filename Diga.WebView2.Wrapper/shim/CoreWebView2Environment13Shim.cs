using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.shim
{
    /// <summary>
    /// Shim-Wrapper für ICoreWebView2Environment13
    /// </summary>
    public class CoreWebView2Environment13Shim : CoreWebView2Environment12Shim
    {
        private ComObjectHolder<ICoreWebView2Environment13> _Iface;
        private SafeHandle handle = new SafeFileHandle(nint.Zero, true);

        /// <summary>
        /// Gets the wrapped COM interface.
        /// </summary>
        private ICoreWebView2Environment13 Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(CoreWebView2Environment13Shim) + " Iface is null");
                    throw new InvalidOperationException(nameof(CoreWebView2Environment13Shim) + " Iface is null");
                }

                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<ICoreWebView2Environment13>(value);
        }

        /// <summary>
        /// Initializes a new instance of the CoreWebView2Environment13Shim class.
        /// </summary>
        /// <param name="iface">The COM interface to wrap</param>
        public CoreWebView2Environment13Shim(ICoreWebView2Environment13 iface) : base((ICoreWebView2Environment12)iface)
        {
            Iface = iface;
        }

        #region Methods

        /// <summary>
        /// Wraps the GetProcessExtendedInfos method.
        /// </summary>
        /// <param name="handler"></param>
        public void GetProcessExtendedInfos(ICoreWebView2GetProcessExtendedInfosCompletedHandler handler)
        {
            Iface.GetProcessExtendedInfos(handler);
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
