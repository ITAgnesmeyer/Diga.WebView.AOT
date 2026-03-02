using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.shim
{
    /// <summary>
    /// Shim-Wrapper für ICoreWebView2ScreenCaptureStartingEventArgs
    /// </summary>
    public class CoreWebView2ScreenCaptureStartingEventArgsShim : EventArgs, IDisposable
    {
        private ComObjectHolder<ICoreWebView2ScreenCaptureStartingEventArgs> _Iface;
        private bool disposedValue;
        private SafeHandle handle = new SafeFileHandle(nint.Zero, true);

        /// <summary>
        /// Gets the wrapped COM interface.
        /// </summary>
        private ICoreWebView2ScreenCaptureStartingEventArgs Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(CoreWebView2ScreenCaptureStartingEventArgsShim) + " Iface is null");
                    throw new InvalidOperationException(nameof(CoreWebView2ScreenCaptureStartingEventArgsShim) + " Iface is null");
                }

                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<ICoreWebView2ScreenCaptureStartingEventArgs>(value);
        }

        /// <summary>
        /// Initializes a new instance of the CoreWebView2ScreenCaptureStartingEventArgsShim class.
        /// </summary>
        /// <param name="iface">The COM interface to wrap</param>
        public CoreWebView2ScreenCaptureStartingEventArgsShim(ICoreWebView2ScreenCaptureStartingEventArgs iface)
        {
            Iface = iface;
        }

        #region Properties

        /// <summary>
        /// Gets the Cancel property.
        /// </summary>
        public bool Cancel
        {
            get => Iface.GetCancel();
            set => Iface.SetCancel(value);
        }

        /// <summary>
        /// Gets the Handled property.
        /// </summary>
        public bool Handled
        {
            get => Iface.GetHandled();
            set => Iface.SetHandled(value);
        }

        /// <summary>
        /// Gets the OriginalSourceFrameInfo property.
        /// </summary>
        public ICoreWebView2FrameInfo OriginalSourceFrameInfo
        {
            get => Iface.GetOriginalSourceFrameInfo();
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
        ///~CoreWebView2ScreenCaptureStartingEventArgsShim()
        ///{
        ///    Dispose(disposing: false);
        ///}
    }
}
