using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.shim
{
    /// <summary>
    /// Shim-Wrapper für ICoreWebView2FrameInfo2
    /// </summary>
    public class CoreWebView2FrameInfo2Shim : CoreWebView2FrameInfoShim
    {
        private ComObjectHolder<ICoreWebView2FrameInfo2> _Iface;
        private SafeHandle handle = new SafeFileHandle(nint.Zero, true);

        /// <summary>
        /// Gets the wrapped COM interface.
        /// </summary>
        private ICoreWebView2FrameInfo2 Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(CoreWebView2FrameInfo2Shim) + " Iface is null");
                    throw new InvalidOperationException(nameof(CoreWebView2FrameInfo2Shim) + " Iface is null");
                }

                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<ICoreWebView2FrameInfo2>(value);
        }

        /// <summary>
        /// Initializes a new instance of the CoreWebView2FrameInfo2Shim class.
        /// </summary>
        /// <param name="iface">The COM interface to wrap</param>
        public CoreWebView2FrameInfo2Shim(ICoreWebView2FrameInfo2 iface) : base((ICoreWebView2FrameInfo)iface)
        {
            Iface = iface;
        }

        #region Properties

        /// <summary>
        /// Gets the ParentFrameInfo property.
        /// </summary>
        public ICoreWebView2FrameInfo ParentFrameInfo
        {
            get => Iface.GetParentFrameInfo();
        }

        /// <summary>
        /// Gets the FrameId property.
        /// </summary>
        public uint FrameId
        {
            get => Iface.GetFrameId();
        }

        /// <summary>
        /// Gets the FrameKind property.
        /// </summary>
        public COREWEBVIEW2_FRAME_KIND FrameKind
        {
            get => Iface.GetFrameKind();
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
