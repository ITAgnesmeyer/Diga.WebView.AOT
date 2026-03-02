using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.shim
{
    /// <summary>
    /// Shim-Wrapper für ICoreWebView2ProcessInfo
    /// </summary>
    public class CoreWebView2ProcessInfoShim : IDisposable
    {
        private ComObjectHolder<ICoreWebView2ProcessInfo> _Iface;
        private bool disposedValue;
        private SafeHandle handle = new SafeFileHandle(nint.Zero, true);

        /// <summary>
        /// Gets the wrapped COM interface.
        /// </summary>
        private ICoreWebView2ProcessInfo Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(CoreWebView2ProcessInfoShim) + " Iface is null");
                    throw new InvalidOperationException(nameof(CoreWebView2ProcessInfoShim) + " Iface is null");
                }

                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<ICoreWebView2ProcessInfo>(value);
        }

        /// <summary>
        /// Initializes a new instance of the CoreWebView2ProcessInfoShim class.
        /// </summary>
        /// <param name="iface">The COM interface to wrap</param>
        public CoreWebView2ProcessInfoShim(ICoreWebView2ProcessInfo iface)
        {
            Iface = iface;
        }

        #region Properties

        /// <summary>
        /// Gets the ProcessId property.
        /// </summary>
        public int ProcessId
        {
            get => Iface.GetProcessId();
        }

        /// <summary>
        /// Gets the Kind property.
        /// </summary>
        public COREWEBVIEW2_PROCESS_KIND Kind
        {
            get => Iface.GetKind();
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
        ///~CoreWebView2ProcessInfoShim()
        ///{
        ///    Dispose(disposing: false);
        ///}
    }
}
