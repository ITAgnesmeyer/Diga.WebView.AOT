using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.shim
{
    /// <summary>
    /// Shim-Wrapper für ICoreWebView2_22
    /// </summary>
    public class CoreWebView2_22Shim : CoreWebView2_21Shim
    {
        private ComObjectHolder<ICoreWebView2_22> _Iface;
        private SafeHandle handle = new SafeFileHandle(nint.Zero, true);

        /// <summary>
        /// Gets the wrapped COM interface.
        /// </summary>
        private ICoreWebView2_22 Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(CoreWebView2_22Shim) + " Iface is null");
                    throw new InvalidOperationException(nameof(CoreWebView2_22Shim) + " Iface is null");
                }

                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<ICoreWebView2_22>(value);
        }

        /// <summary>
        /// Initializes a new instance of the CoreWebView2_22Shim class.
        /// </summary>
        /// <param name="iface">The COM interface to wrap</param>
        public CoreWebView2_22Shim(ICoreWebView2_22 iface) : base((ICoreWebView2_21)iface)
        {
            Iface = iface;
        }

        #region Methods

        /// <summary>
        /// Wraps the AddWebResourceRequestedFilterWithRequestSourceKinds method.
        /// </summary>
        /// <param name="uri"></param>
        /// <param name="ResourceContext"></param>
        /// <param name="requestSourceKinds"></param>
        public void AddWebResourceRequestedFilterWithRequestSourceKinds(string uri, COREWEBVIEW2_WEB_RESOURCE_CONTEXT ResourceContext, COREWEBVIEW2_WEB_RESOURCE_REQUEST_SOURCE_KINDS requestSourceKinds)
        {
            Iface.AddWebResourceRequestedFilterWithRequestSourceKinds(uri, ResourceContext, requestSourceKinds);
        }

        /// <summary>
        /// Wraps the RemoveWebResourceRequestedFilterWithRequestSourceKinds method.
        /// </summary>
        /// <param name="uri"></param>
        /// <param name="ResourceContext"></param>
        /// <param name="requestSourceKinds"></param>
        public void RemoveWebResourceRequestedFilterWithRequestSourceKinds(string uri, COREWEBVIEW2_WEB_RESOURCE_CONTEXT ResourceContext, COREWEBVIEW2_WEB_RESOURCE_REQUEST_SOURCE_KINDS requestSourceKinds)
        {
            Iface.RemoveWebResourceRequestedFilterWithRequestSourceKinds(uri, ResourceContext, requestSourceKinds);
        }

        #endregion


        /// <summary>
        /// Protected override dispose method.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                handle?.Dispose();
                _Iface = null;
            }
            base.Dispose(disposing);
        }
    }
}
