using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.shim
{
    /// <summary>
    /// Shim-Wrapper für ICoreWebView2PermissionSetting
    /// </summary>
    public class CoreWebView2PermissionSettingShim : IDisposable
    {
        private ComObjectHolder<ICoreWebView2PermissionSetting> _Iface;
        private bool disposedValue;
        private SafeHandle handle = new SafeFileHandle(nint.Zero, true);

        /// <summary>
        /// Gets the wrapped COM interface.
        /// </summary>
        private ICoreWebView2PermissionSetting Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(CoreWebView2PermissionSettingShim) + " Iface is null");
                    throw new InvalidOperationException(nameof(CoreWebView2PermissionSettingShim) + " Iface is null");
                }

                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<ICoreWebView2PermissionSetting>(value);
        }

        /// <summary>
        /// Initializes a new instance of the CoreWebView2PermissionSettingShim class.
        /// </summary>
        /// <param name="iface">The COM interface to wrap</param>
        public CoreWebView2PermissionSettingShim(ICoreWebView2PermissionSetting iface)
        {
            Iface = iface;
        }

        #region Properties

        /// <summary>
        /// Gets the PermissionKind property.
        /// </summary>
        public COREWEBVIEW2_PERMISSION_KIND PermissionKind
        {
            get => Iface.GetPermissionKind();
        }

        /// <summary>
        /// Gets the PermissionOrigin property.
        /// </summary>
        public string PermissionOrigin
        {
            get => Iface.GetPermissionOrigin();
        }

        /// <summary>
        /// Gets the PermissionState property.
        /// </summary>
        public COREWEBVIEW2_PERMISSION_STATE PermissionState
        {
            get => Iface.GetPermissionState();
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
        ///~CoreWebView2PermissionSettingShim()
        ///{
        ///    Dispose(disposing: false);
        ///}
    }
}
