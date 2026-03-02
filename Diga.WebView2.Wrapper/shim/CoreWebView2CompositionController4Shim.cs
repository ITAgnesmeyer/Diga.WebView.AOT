using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.shim
{
    /// <summary>
    /// Shim-Wrapper für ICoreWebView2CompositionController4
    /// </summary>
    public class CoreWebView2CompositionController4Shim : CoreWebView2CompositionController3Shim
    {
        private ComObjectHolder<ICoreWebView2CompositionController4> _Iface;
        private SafeHandle handle = new SafeFileHandle(nint.Zero, true);

        /// <summary>
        /// Gets the wrapped COM interface.
        /// </summary>
        private ICoreWebView2CompositionController4 Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(CoreWebView2CompositionController4Shim) + " Iface is null");
                    throw new InvalidOperationException(nameof(CoreWebView2CompositionController4Shim) + " Iface is null");
                }

                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<ICoreWebView2CompositionController4>(value);
        }

        /// <summary>
        /// Initializes a new instance of the CoreWebView2CompositionController4Shim class.
        /// </summary>
        /// <param name="iface">The COM interface to wrap</param>
        public CoreWebView2CompositionController4Shim(ICoreWebView2CompositionController4 iface) : base((ICoreWebView2CompositionController3)iface)
        {
            Iface = iface;
        }

        #region Methods

        /// <summary>
        /// Wraps the GetNonClientRegionAtPoint method.
        /// </summary>
        /// <param name="point"></param>
        public COREWEBVIEW2_NON_CLIENT_REGION_KIND GetNonClientRegionAtPoint(POINT point)
        {
            return Iface.GetNonClientRegionAtPoint(point);
        }

        /// <summary>
        /// Wraps the QueryNonClientRegion method.
        /// </summary>
        /// <param name="kind"></param>
        public ICoreWebView2RegionRectCollectionView QueryNonClientRegion(COREWEBVIEW2_NON_CLIENT_REGION_KIND kind)
        {
            return Iface.QueryNonClientRegion(kind);
        }

        /// <summary>
        /// Wraps the add_NonClientRegionChanged method.
        /// </summary>
        /// <param name="eventHandler"></param>
        /// <param name="token"></param>
        public void add_NonClientRegionChanged(ICoreWebView2NonClientRegionChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            Iface.add_NonClientRegionChanged(eventHandler, out token);
        }

        /// <summary>
        /// Wraps the remove_NonClientRegionChanged method.
        /// </summary>
        /// <param name="token"></param>
        public void remove_NonClientRegionChanged(EventRegistrationToken token)
        {
            Iface.remove_NonClientRegionChanged(token);
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
