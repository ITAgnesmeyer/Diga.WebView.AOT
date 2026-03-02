using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.shim
{
    /// <summary>
    /// Shim-Wrapper für ICoreWebView2FrameInfoCollection
    /// </summary>
    public class CoreWebView2FrameInfoCollectionShim : IDisposable
    {
        private ComObjectHolder<ICoreWebView2FrameInfoCollection> _Iface;
        private bool disposedValue;
        private SafeHandle handle = new SafeFileHandle(nint.Zero, true);

        /// <summary>
        /// Gets the wrapped COM interface.
        /// </summary>
        private ICoreWebView2FrameInfoCollection Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(CoreWebView2FrameInfoCollectionShim) + " Iface is null");
                    throw new InvalidOperationException(nameof(CoreWebView2FrameInfoCollectionShim) + " Iface is null");
                }

                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<ICoreWebView2FrameInfoCollection>(value);
        }

        /// <summary>
        /// Initializes a new instance of the CoreWebView2FrameInfoCollectionShim class.
        /// </summary>
        /// <param name="iface">The COM interface to wrap</param>
        public CoreWebView2FrameInfoCollectionShim(ICoreWebView2FrameInfoCollection iface)
        {
            Iface = iface;
        }

        #region Methods

        /// <summary>
        /// Wraps the GetIterator method.
        /// </summary>
        public ICoreWebView2FrameInfoCollectionIterator GetIterator()
        {
            return Iface.GetIterator();
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
        ///~CoreWebView2FrameInfoCollectionShim()
        ///{
        ///    Dispose(disposing: false);
        ///}
    }
}
