using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.shim
{
    /// <summary>
    /// Shim-Wrapper für ICoreWebView2Settings9
    /// </summary>
    public class CoreWebView2Settings9Shim : CoreWebView2Settings8Shim
    {
        private ComObjectHolder<ICoreWebView2Settings9> _Iface;
        private SafeHandle handle = new SafeFileHandle(nint.Zero, true);

        /// <summary>
        /// Gets the wrapped COM interface.
        /// </summary>
        private ICoreWebView2Settings9 Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(CoreWebView2Settings9Shim) + " Iface is null");
                    throw new InvalidOperationException(nameof(CoreWebView2Settings9Shim) + " Iface is null");
                }

                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<ICoreWebView2Settings9>(value);
        }

        /// <summary>
        /// Initializes a new instance of the CoreWebView2Settings9Shim class.
        /// </summary>
        /// <param name="iface">The COM interface to wrap</param>
        public CoreWebView2Settings9Shim(ICoreWebView2Settings9 iface) : base((ICoreWebView2Settings8)iface)
        {
            Iface = iface;
        }

        #region Properties

        /// <summary>
        /// Gets the IsNonClientRegionSupportEnabled property.
        /// </summary>
        public bool IsNonClientRegionSupportEnabled
        {
            get => Iface.GetIsNonClientRegionSupportEnabled();
            set => Iface.SetIsNonClientRegionSupportEnabled(value);
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
