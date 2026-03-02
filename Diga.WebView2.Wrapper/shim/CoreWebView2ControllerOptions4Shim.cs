using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.shim
{
    /// <summary>
    /// Shim-Wrapper für ICoreWebView2ControllerOptions4
    /// </summary>
    public class CoreWebView2ControllerOptions4Shim : CoreWebView2ControllerOptions3Shim
    {
        private ComObjectHolder<ICoreWebView2ControllerOptions4> _Iface;
        private SafeHandle handle = new SafeFileHandle(nint.Zero, true);

        /// <summary>
        /// Gets the wrapped COM interface.
        /// </summary>
        private ICoreWebView2ControllerOptions4 Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(CoreWebView2ControllerOptions4Shim) + " Iface is null");
                    throw new InvalidOperationException(nameof(CoreWebView2ControllerOptions4Shim) + " Iface is null");
                }

                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<ICoreWebView2ControllerOptions4>(value);
        }

        /// <summary>
        /// Initializes a new instance of the CoreWebView2ControllerOptions4Shim class.
        /// </summary>
        /// <param name="iface">The COM interface to wrap</param>
        public CoreWebView2ControllerOptions4Shim(ICoreWebView2ControllerOptions4 iface) : base((ICoreWebView2ControllerOptions3)iface)
        {
            Iface = iface;
        }

        #region Properties

        /// <summary>
        /// Gets the AllowHostInputProcessing property.
        /// </summary>
        public bool AllowHostInputProcessing
        {
            get => Iface.GetAllowHostInputProcessing();
            set => Iface.SetAllowHostInputProcessing(value);
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
