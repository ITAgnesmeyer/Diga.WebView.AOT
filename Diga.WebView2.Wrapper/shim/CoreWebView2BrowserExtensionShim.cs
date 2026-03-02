using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.shim
{
    /// <summary>
    /// Shim-Wrapper für ICoreWebView2BrowserExtension
    /// </summary>
    public class CoreWebView2BrowserExtensionShim : IDisposable
    {
        private ComObjectHolder<ICoreWebView2BrowserExtension> _Iface;
        private bool disposedValue;
        private SafeHandle handle = new SafeFileHandle(nint.Zero, true);

        /// <summary>
        /// Gets the wrapped COM interface.
        /// </summary>
        private ICoreWebView2BrowserExtension Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(CoreWebView2BrowserExtensionShim) + " Iface is null");
                    throw new InvalidOperationException(nameof(CoreWebView2BrowserExtensionShim) + " Iface is null");
                }

                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<ICoreWebView2BrowserExtension>(value);
        }

        /// <summary>
        /// Initializes a new instance of the CoreWebView2BrowserExtensionShim class.
        /// </summary>
        /// <param name="iface">The COM interface to wrap</param>
        public CoreWebView2BrowserExtensionShim(ICoreWebView2BrowserExtension iface)
        {
            Iface = iface;
        }

        #region Properties

        /// <summary>
        /// Gets the Id property.
        /// </summary>
        public string Id
        {
            get => Iface.GetId();
        }

        /// <summary>
        /// Gets the Name property.
        /// </summary>
        public string Name
        {
            get => Iface.GetName();
        }

        /// <summary>
        /// Gets the IsEnabled property.
        /// </summary>
        public bool IsEnabled
        {
            get => Iface.GetIsEnabled();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Wraps the Remove method.
        /// </summary>
        /// <param name="handler"></param>
        public void Remove(ICoreWebView2BrowserExtensionRemoveCompletedHandler handler)
        {
            Iface.Remove(handler);
        }

        /// <summary>
        /// Wraps the Enable method.
        /// </summary>
        /// <param name="isEnabled"></param>
        /// <param name="handler"></param>
        public void Enable(bool isEnabled, ICoreWebView2BrowserExtensionEnableCompletedHandler handler)
        {
            Iface.Enable(isEnabled, handler);
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
        ///~CoreWebView2BrowserExtensionShim()
        ///{
        ///    Dispose(disposing: false);
        ///}
    }
}
