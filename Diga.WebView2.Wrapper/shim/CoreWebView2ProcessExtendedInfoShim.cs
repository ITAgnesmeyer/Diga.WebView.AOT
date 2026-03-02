using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.shim
{
    /// <summary>
    /// Shim-Wrapper für ICoreWebView2ProcessExtendedInfo
    /// </summary>
    public class CoreWebView2ProcessExtendedInfoShim : IDisposable
    {
        private ComObjectHolder<ICoreWebView2ProcessExtendedInfo> _Iface;
        private bool disposedValue;
        private SafeHandle handle = new SafeFileHandle(nint.Zero, true);

        /// <summary>
        /// Gets the wrapped COM interface.
        /// </summary>
        private ICoreWebView2ProcessExtendedInfo Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(CoreWebView2ProcessExtendedInfoShim) + " Iface is null");
                    throw new InvalidOperationException(nameof(CoreWebView2ProcessExtendedInfoShim) + " Iface is null");
                }

                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<ICoreWebView2ProcessExtendedInfo>(value);
        }

        /// <summary>
        /// Initializes a new instance of the CoreWebView2ProcessExtendedInfoShim class.
        /// </summary>
        /// <param name="iface">The COM interface to wrap</param>
        public CoreWebView2ProcessExtendedInfoShim(ICoreWebView2ProcessExtendedInfo iface)
        {
            Iface = iface;
        }

        #region Properties

        /// <summary>
        /// Gets the ProcessInfo property.
        /// </summary>
        public ICoreWebView2ProcessInfo ProcessInfo
        {
            get => Iface.GetProcessInfo();
        }

        /// <summary>
        /// Gets the AssociatedFrameInfos property.
        /// </summary>
        public ICoreWebView2FrameInfoCollection AssociatedFrameInfos
        {
            get => Iface.GetAssociatedFrameInfos();
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
        ///~CoreWebView2ProcessExtendedInfoShim()
        ///{
        ///    Dispose(disposing: false);
        ///}
    }
}
