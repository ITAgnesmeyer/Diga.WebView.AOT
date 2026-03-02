using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.shim
{
    /// <summary>
    /// Shim-Wrapper für ICoreWebView2Frame5
    /// </summary>
    public class CoreWebView2Frame5Shim : CoreWebView2Frame4Shim
    {
        private ComObjectHolder<ICoreWebView2Frame5> _Iface;
        private SafeHandle handle = new SafeFileHandle(nint.Zero, true);

        /// <summary>
        /// Gets the wrapped COM interface.
        /// </summary>
        private ICoreWebView2Frame5 Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(CoreWebView2Frame5Shim) + " Iface is null");
                    throw new InvalidOperationException(nameof(CoreWebView2Frame5Shim) + " Iface is null");
                }

                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<ICoreWebView2Frame5>(value);
        }

        /// <summary>
        /// Initializes a new instance of the CoreWebView2Frame5Shim class.
        /// </summary>
        /// <param name="iface">The COM interface to wrap</param>
        public CoreWebView2Frame5Shim(ICoreWebView2Frame5 iface) : base((ICoreWebView2Frame4)iface)
        {
            Iface = iface;
        }

        #region Properties

        /// <summary>
        /// Gets the FrameId property.
        /// </summary>
        public uint FrameId
        {
            get => Iface.GetFrameId();
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
