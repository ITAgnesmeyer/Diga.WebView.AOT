using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.shim
{
    /// <summary>
    /// Shim-Wrapper für ICoreWebView2ObjectCollection
    /// </summary>
    public class CoreWebView2ObjectCollectionShim : CoreWebView2ObjectCollectionViewShim
    {
        private ComObjectHolder<ICoreWebView2ObjectCollection> _Iface;
        private SafeHandle handle = new SafeFileHandle(nint.Zero, true);

        /// <summary>
        /// Gets the wrapped COM interface.
        /// </summary>
        private ICoreWebView2ObjectCollection Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(CoreWebView2ObjectCollectionShim) + " Iface is null");
                    throw new InvalidOperationException(nameof(CoreWebView2ObjectCollectionShim) + " Iface is null");
                }

                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<ICoreWebView2ObjectCollection>(value);
        }

        /// <summary>
        /// Initializes a new instance of the CoreWebView2ObjectCollectionShim class.
        /// </summary>
        /// <param name="iface">The COM interface to wrap</param>
        public CoreWebView2ObjectCollectionShim(ICoreWebView2ObjectCollection iface) : base((ICoreWebView2ObjectCollectionView)iface)
        {
            Iface = iface;
        }

        #region Methods

        /// <summary>
        /// Wraps the RemoveValueAtIndex method.
        /// </summary>
        /// <param name="index"></param>
        public void RemoveValueAtIndex(uint index)
        {
            Iface.RemoveValueAtIndex(index);
        }

        /// <summary>
        /// Wraps the InsertValueAtIndex method.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="value"></param>
        public void InsertValueAtIndex(uint index, object value)
        {
            Iface.InsertValueAtIndex(index, value);
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
