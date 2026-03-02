using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.shim
{
    /// <summary>
    /// Shim-Wrapper für ICoreWebView2FileSystemHandle
    /// </summary>
    public class CoreWebView2FileSystemHandleShim : IDisposable
    {
        private ComObjectHolder<ICoreWebView2FileSystemHandle> _Iface;
        private bool disposedValue;
        private SafeHandle handle = new SafeFileHandle(nint.Zero, true);

        /// <summary>
        /// Gets the wrapped COM interface.
        /// </summary>
        private ICoreWebView2FileSystemHandle Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(CoreWebView2FileSystemHandleShim) + " Iface is null");
                    throw new InvalidOperationException(nameof(CoreWebView2FileSystemHandleShim) + " Iface is null");
                }

                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<ICoreWebView2FileSystemHandle>(value);
        }

        /// <summary>
        /// Initializes a new instance of the CoreWebView2FileSystemHandleShim class.
        /// </summary>
        /// <param name="iface">The COM interface to wrap</param>
        public CoreWebView2FileSystemHandleShim(ICoreWebView2FileSystemHandle iface)
        {
            Iface = iface;
        }

        #region Properties

        /// <summary>
        /// Gets the Kind property.
        /// </summary>
        public COREWEBVIEW2_FILE_SYSTEM_HANDLE_KIND Kind
        {
            get => Iface.GetKind();
        }

        /// <summary>
        /// Gets the Path property.
        /// </summary>
        public string Path
        {
            get => Iface.GetPath();
        }

        /// <summary>
        /// Gets the Permission property.
        /// </summary>
        public COREWEBVIEW2_FILE_SYSTEM_HANDLE_PERMISSION Permission
        {
            get => Iface.GetPermission();
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
        ///~CoreWebView2FileSystemHandleShim()
        ///{
        ///    Dispose(disposing: false);
        ///}
    }
}
