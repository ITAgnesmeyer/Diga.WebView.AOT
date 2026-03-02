using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.shim
{
    /// <summary>
    /// Shim-Wrapper für ICoreWebView2FindOptions
    /// </summary>
    public class CoreWebView2FindOptionsShim : IDisposable
    {
        private ComObjectHolder<ICoreWebView2FindOptions> _Iface;
        private bool disposedValue;
        private SafeHandle handle = new SafeFileHandle(nint.Zero, true);

        /// <summary>
        /// Gets the wrapped COM interface.
        /// </summary>
        private ICoreWebView2FindOptions Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(CoreWebView2FindOptionsShim) + " Iface is null");
                    throw new InvalidOperationException(nameof(CoreWebView2FindOptionsShim) + " Iface is null");
                }

                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<ICoreWebView2FindOptions>(value);
        }

        /// <summary>
        /// Initializes a new instance of the CoreWebView2FindOptionsShim class.
        /// </summary>
        /// <param name="iface">The COM interface to wrap</param>
        public CoreWebView2FindOptionsShim(ICoreWebView2FindOptions iface)
        {
            Iface = iface;
        }

        #region Properties

        /// <summary>
        /// Gets the FindTerm property.
        /// </summary>
        public string FindTerm
        {
            get => Iface.GetFindTerm();
            set => Iface.SetFindTerm(value);
        }

        /// <summary>
        /// Gets the IsCaseSensitive property.
        /// </summary>
        public bool IsCaseSensitive
        {
            get => Iface.GetIsCaseSensitive();
            set => Iface.SetIsCaseSensitive(value);
        }

        /// <summary>
        /// Gets the ShouldHighlightAllMatches property.
        /// </summary>
        public bool ShouldHighlightAllMatches
        {
            get => Iface.GetShouldHighlightAllMatches();
            set => Iface.SetShouldHighlightAllMatches(value);
        }

        /// <summary>
        /// Gets the ShouldMatchWord property.
        /// </summary>
        public bool ShouldMatchWord
        {
            get => Iface.GetShouldMatchWord();
            set => Iface.SetShouldMatchWord(value);
        }

        /// <summary>
        /// Gets the SuppressDefaultFindDialog property.
        /// </summary>
        public bool SuppressDefaultFindDialog
        {
            get => Iface.GetSuppressDefaultFindDialog();
            set => Iface.SetSuppressDefaultFindDialog(value);
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
        ///~CoreWebView2FindOptionsShim()
        ///{
        ///    Dispose(disposing: false);
        ///}
    }
}
