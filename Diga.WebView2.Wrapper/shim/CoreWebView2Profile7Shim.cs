using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.shim
{
    /// <summary>
    /// Shim-Wrapper für ICoreWebView2Profile7
    /// </summary>
    public class CoreWebView2Profile7Shim : CoreWebView2Profile6Shim
    {
        private ComObjectHolder<ICoreWebView2Profile7> _Iface;
        private SafeHandle handle = new SafeFileHandle(nint.Zero, true);

        /// <summary>
        /// Gets the wrapped COM interface.
        /// </summary>
        private ICoreWebView2Profile7 Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(CoreWebView2Profile7Shim) + " Iface is null");
                    throw new InvalidOperationException(nameof(CoreWebView2Profile7Shim) + " Iface is null");
                }

                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<ICoreWebView2Profile7>(value);
        }

        /// <summary>
        /// Initializes a new instance of the CoreWebView2Profile7Shim class.
        /// </summary>
        /// <param name="iface">The COM interface to wrap</param>
        public CoreWebView2Profile7Shim(ICoreWebView2Profile7 iface) : base((ICoreWebView2Profile6)iface)
        {
            Iface = iface;
        }

        #region Methods

        /// <summary>
        /// Wraps the AddBrowserExtension method.
        /// </summary>
        /// <param name="extensionFolderPath"></param>
        /// <param name="handler"></param>
        public void AddBrowserExtension(string extensionFolderPath, ICoreWebView2ProfileAddBrowserExtensionCompletedHandler handler)
        {
            Iface.AddBrowserExtension(extensionFolderPath, handler);
        }

        /// <summary>
        /// Wraps the GetBrowserExtensions method.
        /// </summary>
        /// <param name="handler"></param>
        public void GetBrowserExtensions(ICoreWebView2ProfileGetBrowserExtensionsCompletedHandler handler)
        {
            Iface.GetBrowserExtensions(handler);
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
