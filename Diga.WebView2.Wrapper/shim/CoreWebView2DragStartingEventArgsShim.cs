using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.shim
{
    /// <summary>
    /// Shim-Wrapper für ICoreWebView2DragStartingEventArgs
    /// </summary>
    public class CoreWebView2DragStartingEventArgsShim : EventArgs, IDisposable
    {
        private ComObjectHolder<ICoreWebView2DragStartingEventArgs> _Iface;
        private bool disposedValue;
        private SafeHandle handle = new SafeFileHandle(nint.Zero, true);

        /// <summary>
        /// Gets the wrapped COM interface.
        /// </summary>
        private ICoreWebView2DragStartingEventArgs Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(CoreWebView2DragStartingEventArgsShim) + " Iface is null");
                    throw new InvalidOperationException(nameof(CoreWebView2DragStartingEventArgsShim) + " Iface is null");
                }

                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<ICoreWebView2DragStartingEventArgs>(value);
        }

        /// <summary>
        /// Initializes a new instance of the CoreWebView2DragStartingEventArgsShim class.
        /// </summary>
        /// <param name="iface">The COM interface to wrap</param>
        public CoreWebView2DragStartingEventArgsShim(ICoreWebView2DragStartingEventArgs iface)
        {
            Iface = iface;
        }

        #region Properties

        /// <summary>
        /// Gets the AllowedDropEffects property.
        /// </summary>
        public uint AllowedDropEffects
        {
            get => Iface.GetAllowedDropEffects();
        }

        /// <summary>
        /// Gets the Data property.
        /// </summary>
        public IDataObject Data
        {
            get => Iface.GetData();
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
        /// Gets the Position property.
        /// </summary>
        public POINT Position
        {
            get => Iface.GetPosition();
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
        ///~CoreWebView2DragStartingEventArgsShim()
        ///{
        ///    Dispose(disposing: false);
        ///}
    }
}
