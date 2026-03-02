using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.shim
{
    /// <summary>
    /// Shim-Wrapper für ICoreWebView2CompositionController5
    /// </summary>
    public class CoreWebView2CompositionController5Shim : CoreWebView2CompositionController4Shim
    {
        private ComObjectHolder<ICoreWebView2CompositionController5> _Iface;
        private SafeHandle handle = new SafeFileHandle(nint.Zero, true);

        /// <summary>
        /// Gets the wrapped COM interface.
        /// </summary>
        private ICoreWebView2CompositionController5 Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(CoreWebView2CompositionController5Shim) + " Iface is null");
                    throw new InvalidOperationException(nameof(CoreWebView2CompositionController5Shim) + " Iface is null");
                }

                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<ICoreWebView2CompositionController5>(value);
        }

        /// <summary>
        /// Initializes a new instance of the CoreWebView2CompositionController5Shim class.
        /// </summary>
        /// <param name="iface">The COM interface to wrap</param>
        public CoreWebView2CompositionController5Shim(ICoreWebView2CompositionController5 iface) : base((ICoreWebView2CompositionController4)iface)
        {
            Iface = iface;
        }

        #region Methods

        /// <summary>
        /// Wraps the add_DragStarting method.
        /// </summary>
        /// <param name="eventHandler"></param>
        /// <param name="token"></param>
        public void add_DragStarting(ICoreWebView2DragStartingEventHandler eventHandler, out EventRegistrationToken token)
        {
            Iface.add_DragStarting(eventHandler, out token);
        }

        /// <summary>
        /// Wraps the remove_DragStarting method.
        /// </summary>
        /// <param name="token"></param>
        public void remove_DragStarting(EventRegistrationToken token)
        {
            Iface.remove_DragStarting(token);
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
