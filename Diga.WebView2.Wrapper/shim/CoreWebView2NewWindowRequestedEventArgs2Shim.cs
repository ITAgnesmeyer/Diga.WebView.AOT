using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.shim
{
    /// <summary>
    /// Shim-Wrapper für ICoreWebView2NewWindowRequestedEventArgs2
    /// </summary>
    public class CoreWebView2NewWindowRequestedEventArgs2Shim : CoreWebView2NewWindowRequestedEventArgsShim
    {
        private ComObjectHolder<ICoreWebView2NewWindowRequestedEventArgs2> _Iface;
        //private SafeHandle handle = new SafeFileHandle(nint.Zero, true);
        private bool disposedValue;
        /// <summary>
        /// Gets the wrapped COM interface.
        /// </summary>
        private ICoreWebView2NewWindowRequestedEventArgs2 Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(CoreWebView2NewWindowRequestedEventArgs2Shim) + " Iface is null");
                    throw new InvalidOperationException(nameof(CoreWebView2NewWindowRequestedEventArgs2Shim) + " Iface is null");
                }

                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<ICoreWebView2NewWindowRequestedEventArgs2>(value);
        }

        /// <summary>
        /// Initializes a new instance of the CoreWebView2NewWindowRequestedEventArgs2Shim class.
        /// </summary>
        /// <param name="iface">The COM interface to wrap</param>
        public CoreWebView2NewWindowRequestedEventArgs2Shim(ICoreWebView2NewWindowRequestedEventArgs2 iface) : base((ICoreWebView2NewWindowRequestedEventArgs)iface)
        {
            if (iface == null) throw new ArgumentNullException(nameof(iface));
            Iface = iface;
        }

        #region Properties

        /// <summary>
        /// Gets the Name property.
        /// </summary>
        public string Name
        {
            get => Iface.GetName();
        }

        #endregion


        /// <summary>
        /// Protected override dispose method.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    //handle?.Dispose();
                    _Iface = null;
                }
                disposedValue = true;
            }
            base.Dispose(disposing);
        }
    }
}
