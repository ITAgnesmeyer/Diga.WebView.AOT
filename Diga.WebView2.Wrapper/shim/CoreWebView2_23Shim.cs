using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.shim
{
    /// <summary>
    /// Shim-Wrapper für ICoreWebView2_23
    /// </summary>
    public class CoreWebView2_23Shim : CoreWebView2_22Shim
    {
        private ComObjectHolder<ICoreWebView2_23> _Iface;
        private SafeHandle handle = new SafeFileHandle(nint.Zero, true);

        /// <summary>
        /// Gets the wrapped COM interface.
        /// </summary>
        private ICoreWebView2_23 Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(CoreWebView2_23Shim) + " Iface is null");
                    throw new InvalidOperationException(nameof(CoreWebView2_23Shim) + " Iface is null");
                }

                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<ICoreWebView2_23>(value);
        }

        /// <summary>
        /// Initializes a new instance of the CoreWebView2_23Shim class.
        /// </summary>
        /// <param name="iface">The COM interface to wrap</param>
        public CoreWebView2_23Shim(ICoreWebView2_23 iface) : base((ICoreWebView2_22)iface)
        {
            Iface = iface;
        }

        #region Methods

        /// <summary>
        /// Wraps the PostWebMessageAsJsonWithAdditionalObjects method.
        /// </summary>
        /// <param name="webMessageAsJson"></param>
        /// <param name="additionalObjects"></param>
        public void PostWebMessageAsJsonWithAdditionalObjects(string webMessageAsJson, ICoreWebView2ObjectCollectionView additionalObjects)
        {
            Iface.PostWebMessageAsJsonWithAdditionalObjects(webMessageAsJson, additionalObjects);
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
