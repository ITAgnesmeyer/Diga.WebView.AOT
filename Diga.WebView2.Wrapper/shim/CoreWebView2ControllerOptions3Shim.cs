using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.shim
{
    /// <summary>
    /// Shim-Wrapper für ICoreWebView2ControllerOptions3
    /// </summary>
    public class CoreWebView2ControllerOptions3Shim : CoreWebView2ControllerOptions2Shim
    {
        private ComObjectHolder<ICoreWebView2ControllerOptions3> _Iface;
        private SafeHandle handle = new SafeFileHandle(nint.Zero, true);

        /// <summary>
        /// Gets the wrapped COM interface.
        /// </summary>
        private ICoreWebView2ControllerOptions3 Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(CoreWebView2ControllerOptions3Shim) + " Iface is null");
                    throw new InvalidOperationException(nameof(CoreWebView2ControllerOptions3Shim) + " Iface is null");
                }

                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<ICoreWebView2ControllerOptions3>(value);
        }

        /// <summary>
        /// Initializes a new instance of the CoreWebView2ControllerOptions3Shim class.
        /// </summary>
        /// <param name="iface">The COM interface to wrap</param>
        public CoreWebView2ControllerOptions3Shim(ICoreWebView2ControllerOptions3 iface) : base((ICoreWebView2ControllerOptions2)iface)
        {
            Iface = iface;
        }

        #region Properties

        /// <summary>
        /// Gets the DefaultBackgroundColor property.
        /// </summary>
        public COREWEBVIEW2_COLOR DefaultBackgroundColor
        {
            get => Iface.GetDefaultBackgroundColor();
            set => Iface.SetDefaultBackgroundColor(value);
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
