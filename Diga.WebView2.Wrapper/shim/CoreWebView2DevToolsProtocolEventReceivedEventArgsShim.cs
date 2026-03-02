using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.shim
{
    /// <summary>
    /// Shim-Wrapper für ICoreWebView2DevToolsProtocolEventReceivedEventArgs
    /// </summary>
    public class CoreWebView2DevToolsProtocolEventReceivedEventArgsShim : EventArgs, IDisposable
    {
        private ComObjectHolder<ICoreWebView2DevToolsProtocolEventReceivedEventArgs> _Iface;
        private bool disposedValue;
        private SafeHandle handle = new SafeFileHandle(nint.Zero, true);

        /// <summary>
        /// Gets the wrapped COM interface.
        /// </summary>
        private ICoreWebView2DevToolsProtocolEventReceivedEventArgs Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(CoreWebView2DevToolsProtocolEventReceivedEventArgsShim) + " Iface is null");
                    throw new InvalidOperationException(nameof(CoreWebView2DevToolsProtocolEventReceivedEventArgsShim) + " Iface is null");
                }

                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<ICoreWebView2DevToolsProtocolEventReceivedEventArgs>(value);
        }

        /// <summary>
        /// Initializes a new instance of the CoreWebView2DevToolsProtocolEventReceivedEventArgsShim class.
        /// </summary>
        /// <param name="iface">The COM interface to wrap</param>
        public CoreWebView2DevToolsProtocolEventReceivedEventArgsShim(ICoreWebView2DevToolsProtocolEventReceivedEventArgs iface)
        {
            Iface = iface;
        }

        #region Properties

        /// <summary>
        /// Gets the ParameterObjectAsJson property.
        /// </summary>
        public string ParameterObjectAsJson
        {
            get => Iface.GetParameterObjectAsJson();
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
        ///~CoreWebView2DevToolsProtocolEventReceivedEventArgsShim()
        ///{
        ///    Dispose(disposing: false);
        ///}
    }
}
