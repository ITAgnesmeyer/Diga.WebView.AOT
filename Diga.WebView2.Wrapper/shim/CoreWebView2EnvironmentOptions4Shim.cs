using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.shim
{
    /// <summary>
    /// Shim-Wrapper für ICoreWebView2EnvironmentOptions4
    /// </summary>
    public class CoreWebView2EnvironmentOptions4Shim : IDisposable
    {
        private ComObjectHolder<ICoreWebView2EnvironmentOptions4> _Iface;
        private bool disposedValue;
        private SafeHandle handle = new SafeFileHandle(nint.Zero, true);

        /// <summary>
        /// Gets the wrapped COM interface.
        /// </summary>
        private ICoreWebView2EnvironmentOptions4 Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(CoreWebView2EnvironmentOptions4Shim) + " Iface is null");
                    throw new InvalidOperationException(nameof(CoreWebView2EnvironmentOptions4Shim) + " Iface is null");
                }

                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<ICoreWebView2EnvironmentOptions4>(value);
        }

        /// <summary>
        /// Initializes a new instance of the CoreWebView2EnvironmentOptions4Shim class.
        /// </summary>
        /// <param name="iface">The COM interface to wrap</param>
        public CoreWebView2EnvironmentOptions4Shim(ICoreWebView2EnvironmentOptions4 iface)
        {
            Iface = iface;
        }

        #region Methods

        /// <summary>
        /// Wraps the GetCustomSchemeRegistrations method.
        /// </summary>
        /// <param name="count"></param>
        /// <param name="schemeRegistrations"></param>
        public void GetCustomSchemeRegistrations(out uint count, nint schemeRegistrations)
        {
            Iface.GetCustomSchemeRegistrations(out count, schemeRegistrations);
        }

        /// <summary>
        /// Wraps the SetCustomSchemeRegistrations method.
        /// </summary>
        /// <param name="count"></param>
        /// <param name="schemeRegistrations"></param>
        public void SetCustomSchemeRegistrations(uint count,ref ICoreWebView2CustomSchemeRegistration schemeRegistrations)
        {
            Iface.SetCustomSchemeRegistrations(count, ref schemeRegistrations);
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
        ///~CoreWebView2EnvironmentOptions4Shim()
        ///{
        ///    Dispose(disposing: false);
        ///}
    }
}
