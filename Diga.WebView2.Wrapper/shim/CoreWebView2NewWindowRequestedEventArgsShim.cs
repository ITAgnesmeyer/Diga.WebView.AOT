using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.shim
{
    /// <summary>
    /// Shim-Wrapper für ICoreWebView2NewWindowRequestedEventArgs
    /// </summary>
    public class CoreWebView2NewWindowRequestedEventArgsShim : EventArgs,IDisposable
    {
        private ComObjectHolder<ICoreWebView2NewWindowRequestedEventArgs> _Iface;
        //private bool disposedValue;
        private SafeHandle handle = new SafeFileHandle(nint.Zero, true);
        private bool disposedValue1;

        /// <summary>
        /// Gets the wrapped COM interface.
        /// </summary>
        private ICoreWebView2NewWindowRequestedEventArgs Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(CoreWebView2NewWindowRequestedEventArgsShim) + " Iface is null");
                    throw new InvalidOperationException(nameof(CoreWebView2NewWindowRequestedEventArgsShim) + " Iface is null");
                }

                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<ICoreWebView2NewWindowRequestedEventArgs>(value);
        }

        /// <summary>
        /// Initializes a new instance of the CoreWebView2NewWindowRequestedEventArgsShim class.
        /// </summary>
        /// <param name="iface">The COM interface to wrap</param>
        public CoreWebView2NewWindowRequestedEventArgsShim(ICoreWebView2NewWindowRequestedEventArgs iface)
        {
            if (iface == null) throw new ArgumentNullException(nameof(iface));

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
        /// Gets the NewWindow property.
        /// </summary>
        public ICoreWebView2 NewWindow
        {
            get => Iface.GetNewWindow();
            set => Iface.SetNewWindow(value);
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
        /// Gets the IsUserInitiated property.
        /// </summary>
        public bool IsUserInitiated
        {
            get => Iface.GetIsUserInitiated();
        }

        /// <summary>
        /// Gets the WindowFeatures property.
        /// </summary>
        public ICoreWebView2WindowFeatures WindowFeatures
        {
            get 
            {
                var feature = Iface.GetWindowFeatures();
                return feature;
            }
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

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue1)
            {
                if (disposing)
                {
                    handle?.Dispose();
                    _Iface = null;
                }

                disposedValue1 = true;
            }
        }

      
        public void Dispose()
        {
            // Ändern Sie diesen Code nicht. Fügen Sie Bereinigungscode in der Methode "Dispose(bool disposing)" ein.
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        #endregion





    }
}
