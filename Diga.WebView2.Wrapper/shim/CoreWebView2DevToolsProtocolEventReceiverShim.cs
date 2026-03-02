using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.shim
{
    /// <summary>
    /// Shim-Wrapper für ICoreWebView2DevToolsProtocolEventReceiver
    /// </summary>
    public class CoreWebView2DevToolsProtocolEventReceiverShim : IDisposable
    {
        private ComObjectHolder<ICoreWebView2DevToolsProtocolEventReceiver> _Iface;
        private bool disposedValue;
        private SafeHandle handle = new SafeFileHandle(nint.Zero, true);

        /// <summary>
        /// Gets the wrapped COM interface.
        /// </summary>
        private ICoreWebView2DevToolsProtocolEventReceiver Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(CoreWebView2DevToolsProtocolEventReceiverShim) + " Iface is null");
                    throw new InvalidOperationException(nameof(CoreWebView2DevToolsProtocolEventReceiverShim) + " Iface is null");
                }

                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<ICoreWebView2DevToolsProtocolEventReceiver>(value);
        }

        /// <summary>
        /// Initializes a new instance of the CoreWebView2DevToolsProtocolEventReceiverShim class.
        /// </summary>
        /// <param name="iface">The COM interface to wrap</param>
        public CoreWebView2DevToolsProtocolEventReceiverShim(ICoreWebView2DevToolsProtocolEventReceiver iface)
        {
            Iface = iface;
        }

        #region Methods

        /// <summary>
        /// Wraps the add_DevToolsProtocolEventReceived method.
        /// </summary>
        /// <param name="eventHandler"></param>
        /// <param name="token"></param>
        public void add_DevToolsProtocolEventReceived(ICoreWebView2DevToolsProtocolEventReceivedEventHandler eventHandler, out EventRegistrationToken token)
        {
            Iface.add_DevToolsProtocolEventReceived(eventHandler, out token);
        }

        /// <summary>
        /// Wraps the remove_DevToolsProtocolEventReceived method.
        /// </summary>
        /// <param name="token"></param>
        public void remove_DevToolsProtocolEventReceived(EventRegistrationToken token)
        {
            Iface.remove_DevToolsProtocolEventReceived(token);
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
        ///~CoreWebView2DevToolsProtocolEventReceiverShim()
        ///{
        ///    Dispose(disposing: false);
        ///}
    }
}
