using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.shim
{
    /// <summary>
    /// Shim-Wrapper für ICoreWebView2SaveFileSecurityCheckStartingEventArgs
    /// </summary>
    public class CoreWebView2SaveFileSecurityCheckStartingEventArgsShim : EventArgs, IDisposable
    {
        private ComObjectHolder<ICoreWebView2SaveFileSecurityCheckStartingEventArgs> _Iface;
        private bool disposedValue;
        private SafeHandle handle = new SafeFileHandle(nint.Zero, true);

        /// <summary>
        /// Gets the wrapped COM interface.
        /// </summary>
        private ICoreWebView2SaveFileSecurityCheckStartingEventArgs Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(CoreWebView2SaveFileSecurityCheckStartingEventArgsShim) + " Iface is null");
                    throw new InvalidOperationException(nameof(CoreWebView2SaveFileSecurityCheckStartingEventArgsShim) + " Iface is null");
                }

                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<ICoreWebView2SaveFileSecurityCheckStartingEventArgs>(value);
        }

        /// <summary>
        /// Initializes a new instance of the CoreWebView2SaveFileSecurityCheckStartingEventArgsShim class.
        /// </summary>
        /// <param name="iface">The COM interface to wrap</param>
        public CoreWebView2SaveFileSecurityCheckStartingEventArgsShim(ICoreWebView2SaveFileSecurityCheckStartingEventArgs iface)
        {
            Iface = iface;
        }

        #region Properties

        /// <summary>
        /// Gets the CancelSave property.
        /// </summary>
        public bool CancelSave
        {
            get => Iface.GetCancelSave();
            set => Iface.SetCancelSave(value);
        }

        /// <summary>
        /// Gets the DocumentOriginUri property.
        /// </summary>
        public string DocumentOriginUri
        {
            get => Iface.GetDocumentOriginUri();
        }

        /// <summary>
        /// Gets the FileExtension property.
        /// </summary>
        public string FileExtension
        {
            get => Iface.GetFileExtension();
        }

        /// <summary>
        /// Gets the FilePath property.
        /// </summary>
        public string FilePath
        {
            get => Iface.GetFilePath();
        }

        /// <summary>
        /// Gets the SuppressDefaultPolicy property.
        /// </summary>
        public bool SuppressDefaultPolicy
        {
            get => Iface.GetSuppressDefaultPolicy();
            set => Iface.SetSuppressDefaultPolicy(value);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Wraps the GetDeferral method.
        /// </summary>
        public ICoreWebView2Deferral GetDeferral()
        {
            return Iface.GetDeferral();
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
        ///~CoreWebView2SaveFileSecurityCheckStartingEventArgsShim()
        ///{
        ///    Dispose(disposing: false);
        ///}
    }
}
