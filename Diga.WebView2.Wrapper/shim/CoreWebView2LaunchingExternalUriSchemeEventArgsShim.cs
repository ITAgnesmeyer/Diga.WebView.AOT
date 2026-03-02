using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.shim
{
    /// <summary>
    /// Shim-Wrapper für ICoreWebView2LaunchingExternalUriSchemeEventArgs
    /// </summary>
    public class CoreWebView2LaunchingExternalUriSchemeEventArgsShim : EventArgs, IDisposable
    {
        private ComObjectHolder<ICoreWebView2LaunchingExternalUriSchemeEventArgs> _Iface;
        private bool disposedValue;
        private SafeHandle handle = new SafeFileHandle(nint.Zero, true);

        /// <summary>
        /// Gets the wrapped COM interface.
        /// </summary>
        private ICoreWebView2LaunchingExternalUriSchemeEventArgs Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(CoreWebView2LaunchingExternalUriSchemeEventArgsShim) + " Iface is null");
                    throw new InvalidOperationException(nameof(CoreWebView2LaunchingExternalUriSchemeEventArgsShim) + " Iface is null");
                }

                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<ICoreWebView2LaunchingExternalUriSchemeEventArgs>(value);
        }

        /// <summary>
        /// Initializes a new instance of the CoreWebView2LaunchingExternalUriSchemeEventArgsShim class.
        /// </summary>
        /// <param name="iface">The COM interface to wrap</param>
        public CoreWebView2LaunchingExternalUriSchemeEventArgsShim(ICoreWebView2LaunchingExternalUriSchemeEventArgs iface)
        {
            Iface = iface;
        }

        #region Properties

        /// <summary>
        /// Gets the Uri property.
        /// </summary>
        public string Uri
        {
            get => Iface.GetUri();
        }

        /// <summary>
        /// Gets the InitiatingOrigin property.
        /// </summary>
        public string InitiatingOrigin
        {
            get => Iface.GetInitiatingOrigin();
        }

        /// <summary>
        /// Gets the IsUserInitiated property.
        /// </summary>
        public bool IsUserInitiated
        {
            get => (CBOOL)Iface.GetIsUserInitiated();
        }

        /// <summary>
        /// Gets the Cancel property.
        /// </summary>
        public bool Cancel
        {
            get => (CBOOL)Iface.GetCancel();
            set => Iface.SetCancel((CBOOL)value);
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
        ///~CoreWebView2LaunchingExternalUriSchemeEventArgsShim()
        ///{
        ///    Dispose(disposing: false);
        ///}
    }
}
