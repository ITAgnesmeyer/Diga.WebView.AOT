using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.shim
{
    /// <summary>
    /// Shim-Wrapper für ICoreWebView2FrameInfo
    /// </summary>
    public class CoreWebView2FrameInfoShim : IDisposable
    {
        private ComObjectHolder<ICoreWebView2FrameInfo> _Iface;
        private bool disposedValue;
        private SafeHandle handle = new SafeFileHandle(nint.Zero, true);

        /// <summary>
        /// Gets the wrapped COM interface.
        /// </summary>
        private ICoreWebView2FrameInfo Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(CoreWebView2FrameInfoShim) + " Iface is null");
                    throw new InvalidOperationException(nameof(CoreWebView2FrameInfoShim) + " Iface is null");
                }

                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<ICoreWebView2FrameInfo>(value);
        }

        /// <summary>
        /// Initializes a new instance of the CoreWebView2FrameInfoShim class.
        /// </summary>
        /// <param name="iface">The COM interface to wrap</param>
        public CoreWebView2FrameInfoShim(ICoreWebView2FrameInfo iface)
        {
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

        /// <summary>
        /// Gets the Source property.
        /// </summary>
        public string Source
        {
            get => Iface.GetSource();
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
        ///~CoreWebView2FrameInfoShim()
        ///{
        ///    Dispose(disposing: false);
        ///}
    }
}
