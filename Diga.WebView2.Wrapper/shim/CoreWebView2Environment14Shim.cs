using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.shim
{
    /// <summary>
    /// Shim-Wrapper für ICoreWebView2Environment14
    /// </summary>
    public class CoreWebView2Environment14Shim : CoreWebView2Environment13Shim
    {
        private ComObjectHolder<ICoreWebView2Environment14> _Iface;
        private SafeHandle handle = new SafeFileHandle(nint.Zero, true);

        /// <summary>
        /// Gets the wrapped COM interface.
        /// </summary>
        private ICoreWebView2Environment14 Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(CoreWebView2Environment14Shim) + " Iface is null");
                    throw new InvalidOperationException(nameof(CoreWebView2Environment14Shim) + " Iface is null");
                }

                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<ICoreWebView2Environment14>(value);
        }

        /// <summary>
        /// Initializes a new instance of the CoreWebView2Environment14Shim class.
        /// </summary>
        /// <param name="iface">The COM interface to wrap</param>
        public CoreWebView2Environment14Shim(ICoreWebView2Environment14 iface) : base((ICoreWebView2Environment13)iface)
        {
            Iface = iface;
        }

        #region Methods

        /// <summary>
        /// Wraps the CreateWebFileSystemFileHandle method.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="permission"></param>
        public ICoreWebView2FileSystemHandle CreateWebFileSystemFileHandle(string path, COREWEBVIEW2_FILE_SYSTEM_HANDLE_PERMISSION permission)
        {
            return Iface.CreateWebFileSystemFileHandle(path, permission);
        }

        /// <summary>
        /// Wraps the CreateWebFileSystemDirectoryHandle method.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="permission"></param>
        public ICoreWebView2FileSystemHandle CreateWebFileSystemDirectoryHandle(string path, COREWEBVIEW2_FILE_SYSTEM_HANDLE_PERMISSION permission)
        {
            return Iface.CreateWebFileSystemDirectoryHandle(path, permission);
        }

        /// <summary>
        /// Wraps the CreateObjectCollection method.
        /// </summary>
        /// <param name="length"></param>
        /// <param name="items"></param>
        public ICoreWebView2ObjectCollection CreateObjectCollection(uint length, object items)
        {
            return Iface.CreateObjectCollection(length, items);
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
