using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.shim
{
    /// <summary>
    /// Shim-Wrapper für ICoreWebView2ClientCertificate
    /// </summary>
    public class CoreWebView2ClientCertificateShim : IDisposable
    {
        private ComObjectHolder<ICoreWebView2ClientCertificate> _Iface;
        private bool disposedValue;
        private SafeHandle handle = new SafeFileHandle(nint.Zero, true);

        /// <summary>
        /// Gets the wrapped COM interface.
        /// </summary>
        private ICoreWebView2ClientCertificate Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(CoreWebView2ClientCertificateShim) + " Iface is null");
                    throw new InvalidOperationException(nameof(CoreWebView2ClientCertificateShim) + " Iface is null");
                }

                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<ICoreWebView2ClientCertificate>(value);
        }

        /// <summary>
        /// Initializes a new instance of the CoreWebView2ClientCertificateShim class.
        /// </summary>
        /// <param name="iface">The COM interface to wrap</param>
        public CoreWebView2ClientCertificateShim(ICoreWebView2ClientCertificate iface)
        {
            Iface = iface;
        }

        #region Properties

        /// <summary>
        /// Gets the Subject property.
        /// </summary>
        public string Subject
        {
            get => Iface.GetSubject();
        }

        /// <summary>
        /// Gets the Issuer property.
        /// </summary>
        public string Issuer
        {
            get => Iface.GetIssuer();
        }

        /// <summary>
        /// Gets the ValidFrom property.
        /// </summary>
        public double ValidFrom
        {
            get => Iface.GetValidFrom();
        }

        /// <summary>
        /// Gets the ValidTo property.
        /// </summary>
        public double ValidTo
        {
            get => Iface.GetValidTo();
        }

        /// <summary>
        /// Gets the DerEncodedSerialNumber property.
        /// </summary>
        public string DerEncodedSerialNumber
        {
            get => Iface.GetDerEncodedSerialNumber();
        }

        /// <summary>
        /// Gets the DisplayName property.
        /// </summary>
        public string DisplayName
        {
            get => Iface.GetDisplayName();
        }

        /// <summary>
        /// Gets the PemEncodedIssuerCertificateChain property.
        /// </summary>
        public ICoreWebView2StringCollection PemEncodedIssuerCertificateChain
        {
            get => Iface.GetPemEncodedIssuerCertificateChain();
        }

        /// <summary>
        /// Gets the Kind property.
        /// </summary>
        public COREWEBVIEW2_CLIENT_CERTIFICATE_KIND Kind
        {
            get => Iface.GetKind();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Wraps the ToPemEncoding method.
        /// </summary>
        public string ToPemEncoding()
        {
            return Iface.ToPemEncoding();
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
        ///~CoreWebView2ClientCertificateShim()
        ///{
        ///    Dispose(disposing: false);
        ///}
    }
}
