using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.shim
{
    /// <summary>
    /// Shim-Wrapper für ICoreWebView2EnvironmentOptions2
    /// </summary>
    public class CoreWebView2EnvironmentOptions2Shim : IDisposable
    {
        private ComObjectHolder<ICoreWebView2EnvironmentOptions2> _Iface;
        private bool disposedValue;
        private SafeHandle handle = new SafeFileHandle(nint.Zero, true);

        /// <summary>
        /// Gets the wrapped COM interface.
        /// </summary>
        private ICoreWebView2EnvironmentOptions2 Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(CoreWebView2EnvironmentOptions2Shim) + " Iface is null");
                    throw new InvalidOperationException(nameof(CoreWebView2EnvironmentOptions2Shim) + " Iface is null");
                }

                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<ICoreWebView2EnvironmentOptions2>(value);
        }

        /// <summary>
        /// Initializes a new instance of the CoreWebView2EnvironmentOptions2Shim class.
        /// </summary>
        /// <param name="iface">The COM interface to wrap</param>
        public CoreWebView2EnvironmentOptions2Shim(ICoreWebView2EnvironmentOptions2 iface)
        {
            Iface = iface;
        }

        #region Properties

        /// <summary>
        /// Gets the ExclusiveUserDataFolderAccess property.
        /// </summary>
        public bool ExclusiveUserDataFolderAccess
        {
            get => (CBOOL)Iface.GetExclusiveUserDataFolderAccess();
            set => Iface.SetExclusiveUserDataFolderAccess((CBOOL)value);
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
        ///~CoreWebView2EnvironmentOptions2Shim()
        ///{
        ///    Dispose(disposing: false);
        ///}
    }
}
