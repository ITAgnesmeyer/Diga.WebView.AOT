using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.shim
{
    /// <summary>
    /// Shim-Wrapper für ICoreWebView2EnvironmentOptions
    /// </summary>
    public class CoreWebView2EnvironmentOptionsShim : IDisposable
    {
        private ComObjectHolder<ICoreWebView2EnvironmentOptions> _Iface;
        private bool disposedValue;
        private SafeHandle handle = new SafeFileHandle(nint.Zero, true);

        /// <summary>
        /// Gets the wrapped COM interface.
        /// </summary>
        private ICoreWebView2EnvironmentOptions Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(CoreWebView2EnvironmentOptionsShim) + " Iface is null");
                    throw new InvalidOperationException(nameof(CoreWebView2EnvironmentOptionsShim) + " Iface is null");
                }

                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<ICoreWebView2EnvironmentOptions>(value);
        }

        /// <summary>
        /// Initializes a new instance of the CoreWebView2EnvironmentOptionsShim class.
        /// </summary>
        /// <param name="iface">The COM interface to wrap</param>
        public CoreWebView2EnvironmentOptionsShim(ICoreWebView2EnvironmentOptions iface)
        {
            Iface = iface;
        }

        #region Properties

        /// <summary>
        /// Gets the AdditionalBrowserArguments property.
        /// </summary>
        public string AdditionalBrowserArguments
        {
            get => Iface.GetAdditionalBrowserArguments();
            set => Iface.SetAdditionalBrowserArguments(value);
        }

        /// <summary>
        /// Gets the Language property.
        /// </summary>
        public string Language
        {
            get => Iface.GetLanguage();
            set => Iface.SetLanguage(value);
        }

        /// <summary>
        /// Gets the TargetCompatibleBrowserVersion property.
        /// </summary>
        public string TargetCompatibleBrowserVersion
        {
            get => Iface.GetTargetCompatibleBrowserVersion();
            set => Iface.SetTargetCompatibleBrowserVersion(value);
        }

        /// <summary>
        /// Gets the AllowSingleSignOnUsingOSPrimaryAccount property.
        /// </summary>
        public bool AllowSingleSignOnUsingOSPrimaryAccount
        {
            get => (CBOOL)Iface.GetAllowSingleSignOnUsingOSPrimaryAccount();
            set => Iface.SetAllowSingleSignOnUsingOSPrimaryAccount((CBOOL)value);
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
        ///~CoreWebView2EnvironmentOptionsShim()
        ///{
        ///    Dispose(disposing: false);
        ///}
    }
}
