using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.shim
{
    /// <summary>
    /// Shim-Wrapper für ICoreWebView2NewWindowRequestedEventArgs3
    /// </summary>
    public class CoreWebView2NewWindowRequestedEventArgs3Shim : CoreWebView2NewWindowRequestedEventArgs2Shim
    {
        private ComObjectHolder<ICoreWebView2NewWindowRequestedEventArgs3> _Iface;
        //private SafeHandle handle = new SafeFileHandle(nint.Zero, true);
        private bool disposedValue;
        /// <summary>
        /// Gets the wrapped COM interface.
        /// </summary>
        private ICoreWebView2NewWindowRequestedEventArgs3 Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(CoreWebView2NewWindowRequestedEventArgs3Shim) + " Iface is null");
                    throw new InvalidOperationException(nameof(CoreWebView2NewWindowRequestedEventArgs3Shim) + " Iface is null");
                }

                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<ICoreWebView2NewWindowRequestedEventArgs3>(value);
        }

        /// <summary>
        /// Initializes a new instance of the CoreWebView2NewWindowRequestedEventArgs3Shim class.
        /// </summary>
        /// <param name="iface">The COM interface to wrap</param>
        public CoreWebView2NewWindowRequestedEventArgs3Shim(ICoreWebView2NewWindowRequestedEventArgs3 iface) : base((ICoreWebView2NewWindowRequestedEventArgs2)iface)
        {
            if(iface == null) throw new ArgumentNullException(nameof(iface));
            Iface = iface;
        }

        #region Properties

        /// <summary>
        /// Gets the OriginalSourceFrameInfo property.
        /// </summary>
        public ICoreWebView2FrameInfo OriginalSourceFrameInfo
        {
            get => Iface.GetOriginalSourceFrameInfo();
        }

        #endregion


        /// <summary>
        /// Protected override dispose method.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if(!disposedValue)
            {
                if (disposing)
                {

                    _Iface = null;
                }
                
                disposedValue = true;
            }
            base.Dispose(disposing);
        }
    }
}
