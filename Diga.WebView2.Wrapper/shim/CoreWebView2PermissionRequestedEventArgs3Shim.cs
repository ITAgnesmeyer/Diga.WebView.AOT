using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.shim
{
    /// <summary>
    /// Shim-Wrapper für ICoreWebView2PermissionRequestedEventArgs3
    /// </summary>
    public class CoreWebView2PermissionRequestedEventArgs3Shim : CoreWebView2PermissionRequestedEventArgs2Shim
    {
        private ComObjectHolder<ICoreWebView2PermissionRequestedEventArgs3> _Iface;
        private SafeHandle handle = new SafeFileHandle(nint.Zero, true);

        /// <summary>
        /// Gets the wrapped COM interface.
        /// </summary>
        private ICoreWebView2PermissionRequestedEventArgs3 Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(CoreWebView2PermissionRequestedEventArgs3Shim) + " Iface is null");
                    throw new InvalidOperationException(nameof(CoreWebView2PermissionRequestedEventArgs3Shim) + " Iface is null");
                }

                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<ICoreWebView2PermissionRequestedEventArgs3>(value);
        }

        /// <summary>
        /// Initializes a new instance of the CoreWebView2PermissionRequestedEventArgs3Shim class.
        /// </summary>
        /// <param name="iface">The COM interface to wrap</param>
        public CoreWebView2PermissionRequestedEventArgs3Shim(ICoreWebView2PermissionRequestedEventArgs3 iface) : base((ICoreWebView2PermissionRequestedEventArgs2)iface)
        {
            Iface = iface;
        }

        #region Properties

        /// <summary>
        /// Gets the SavesInProfile property.
        /// </summary>
        public bool SavesInProfile
        {
            get => (CBOOL)Iface.GetSavesInProfile();
            set => Iface.SetSavesInProfile((CBOOL)value);
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
