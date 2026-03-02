using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.shim
{
    /// <summary>
    /// Shim-Wrapper für ICoreWebView2NavigationCompletedEventArgs
    /// </summary>
    public class CoreWebView2NavigationCompletedEventArgsShim : EventArgs, IDisposable
    {
        private ComObjectHolder<ICoreWebView2NavigationCompletedEventArgs> _Iface;
        private bool disposedValue;
        private SafeHandle handle = new SafeFileHandle(nint.Zero, true);

        /// <summary>
        /// Gets the wrapped COM interface.
        /// </summary>
        private ICoreWebView2NavigationCompletedEventArgs Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(CoreWebView2NavigationCompletedEventArgsShim) + " Iface is null");
                    throw new InvalidOperationException(nameof(CoreWebView2NavigationCompletedEventArgsShim) + " Iface is null");
                }

                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<ICoreWebView2NavigationCompletedEventArgs>(value);
        }

        /// <summary>
        /// Initializes a new instance of the CoreWebView2NavigationCompletedEventArgsShim class.
        /// </summary>
        /// <param name="iface">The COM interface to wrap</param>
        public CoreWebView2NavigationCompletedEventArgsShim(ICoreWebView2NavigationCompletedEventArgs iface)
        {
            Iface = iface;
        }

        #region Properties

        /// <summary>
        /// Gets the IsSuccess property.
        /// </summary>
        public bool IsSuccess
        {
            get => (CBOOL)Iface.GetIsSuccess();
        }

        /// <summary>
        /// Gets the WebErrorStatus property.
        /// </summary>
        public COREWEBVIEW2_WEB_ERROR_STATUS WebErrorStatus
        {
            get => Iface.GetWebErrorStatus();
        }

        /// <summary>
        /// Gets the NavigationId property.
        /// </summary>
        public ulong NavigationId
        {
            get => Iface.GetNavigationId();
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
        ///~CoreWebView2NavigationCompletedEventArgsShim()
        ///{
        ///    Dispose(disposing: false);
        ///}
    }
}
