using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.shim
{
    /// <summary>
    /// Shim-Wrapper für ICoreWebView2FrameInfoCollectionIterator
    /// </summary>
    public class CoreWebView2FrameInfoCollectionIteratorShim : IDisposable
    {
        private ComObjectHolder<ICoreWebView2FrameInfoCollectionIterator> _Iface;
        private bool disposedValue;
        private SafeHandle handle = new SafeFileHandle(nint.Zero, true);

        /// <summary>
        /// Gets the wrapped COM interface.
        /// </summary>
        private ICoreWebView2FrameInfoCollectionIterator Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(CoreWebView2FrameInfoCollectionIteratorShim) + " Iface is null");
                    throw new InvalidOperationException(nameof(CoreWebView2FrameInfoCollectionIteratorShim) + " Iface is null");
                }

                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<ICoreWebView2FrameInfoCollectionIterator>(value);
        }

        /// <summary>
        /// Initializes a new instance of the CoreWebView2FrameInfoCollectionIteratorShim class.
        /// </summary>
        /// <param name="iface">The COM interface to wrap</param>
        public CoreWebView2FrameInfoCollectionIteratorShim(ICoreWebView2FrameInfoCollectionIterator iface)
        {
            Iface = iface;
        }

        #region Properties

        /// <summary>
        /// Gets the HasCurrent property.
        /// </summary>
        public bool HasCurrent
        {
            get => (CBOOL)Iface.GetHasCurrent();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Wraps the GetCurrent method.
        /// </summary>
        public ICoreWebView2FrameInfo GetCurrent()
        {
            return Iface.GetCurrent();
        }

        /// <summary>
        /// Wraps the MoveNext method.
        /// </summary>
        public bool MoveNext()
        {
            return (CBOOL)Iface.MoveNext();
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
        ///~CoreWebView2FrameInfoCollectionIteratorShim()
        ///{
        ///    Dispose(disposing: false);
        ///}
    }
}
