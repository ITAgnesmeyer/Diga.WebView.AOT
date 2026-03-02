using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.shim
{
    /// <summary>
    /// Shim-Wrapper für ICoreWebView2_28
    /// </summary>
    public class CoreWebView2_28Shim : CoreWebView2_27Shim
    {
        private ComObjectHolder<ICoreWebView2_28> _Iface;
        private SafeHandle handle = new SafeFileHandle(nint.Zero, true);

        /// <summary>
        /// Gets the wrapped COM interface.
        /// </summary>
        private ICoreWebView2_28 Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(CoreWebView2_28Shim) + " Iface is null");
                    throw new InvalidOperationException(nameof(CoreWebView2_28Shim) + " Iface is null");
                }

                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<ICoreWebView2_28>(value);
        }

        /// <summary>
        /// Initializes a new instance of the CoreWebView2_28Shim class.
        /// </summary>
        /// <param name="iface">The COM interface to wrap</param>
        public CoreWebView2_28Shim(ICoreWebView2_28 iface) : base((ICoreWebView2_27)iface)
        {
            Iface = iface;
        }

        #region Properties

        /// <summary>
        /// Gets the Find property.
        /// </summary>
        public ICoreWebView2Find Find
        {
            get => Iface.GetFind();
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
