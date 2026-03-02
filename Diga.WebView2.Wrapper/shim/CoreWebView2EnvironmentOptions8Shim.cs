using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.shim
{
    /// <summary>
    /// Shim-Wrapper für ICoreWebView2EnvironmentOptions8
    /// </summary>
    public class CoreWebView2EnvironmentOptions8Shim : IDisposable
    {
        private ComObjectHolder<ICoreWebView2EnvironmentOptions8> _Iface;
        private bool disposedValue;
        private SafeHandle handle = new SafeFileHandle(nint.Zero, true);

        /// <summary>
        /// Gets the wrapped COM interface.
        /// </summary>
        private ICoreWebView2EnvironmentOptions8 Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(CoreWebView2EnvironmentOptions8Shim) + " Iface is null");
                    throw new InvalidOperationException(nameof(CoreWebView2EnvironmentOptions8Shim) + " Iface is null");
                }

                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<ICoreWebView2EnvironmentOptions8>(value);
        }

        /// <summary>
        /// Initializes a new instance of the CoreWebView2EnvironmentOptions8Shim class.
        /// </summary>
        /// <param name="iface">The COM interface to wrap</param>
        public CoreWebView2EnvironmentOptions8Shim(ICoreWebView2EnvironmentOptions8 iface)
        {
            Iface = iface;
        }

        #region Properties

        /// <summary>
        /// Gets the ScrollBarStyle property.
        /// </summary>
        public COREWEBVIEW2_SCROLLBAR_STYLE ScrollBarStyle
        {
            get => Iface.GetScrollBarStyle();
            set => Iface.SetScrollBarStyle(value);
        }

        #endregion


        /// <summary>
        /// Protected virtual dispose method.
        /// </summary>
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    handle?.Dispose();
                    _Iface = null;
                }
                disposedValue = true;
            }
        }

        /// <summary>
        /// Disposes the shim class and releases the COM object.
        /// </summary>
        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Finalizer for fallback cleanup.
        /// </summary>
        ///~CoreWebView2EnvironmentOptions8Shim()
        ///{
        ///    Dispose(disposing: false);
        ///}
    }
}
