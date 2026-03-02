using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.shim
{
    /// <summary>
    /// Shim-Wrapper für ICoreWebView2SaveAsUIShowingEventArgs
    /// </summary>
    public class CoreWebView2SaveAsUIShowingEventArgsShim : EventArgs, IDisposable
    {
        private ComObjectHolder<ICoreWebView2SaveAsUIShowingEventArgs> _Iface;
        private bool disposedValue;
        private SafeHandle handle = new SafeFileHandle(nint.Zero, true);

        /// <summary>
        /// Gets the wrapped COM interface.
        /// </summary>
        private ICoreWebView2SaveAsUIShowingEventArgs Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(CoreWebView2SaveAsUIShowingEventArgsShim) + " Iface is null");
                    throw new InvalidOperationException(nameof(CoreWebView2SaveAsUIShowingEventArgsShim) + " Iface is null");
                }

                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<ICoreWebView2SaveAsUIShowingEventArgs>(value);
        }

        /// <summary>
        /// Initializes a new instance of the CoreWebView2SaveAsUIShowingEventArgsShim class.
        /// </summary>
        /// <param name="iface">The COM interface to wrap</param>
        public CoreWebView2SaveAsUIShowingEventArgsShim(ICoreWebView2SaveAsUIShowingEventArgs iface)
        {
            Iface = iface;
        }

        #region Properties

        /// <summary>
        /// Gets the ContentMimeType property.
        /// </summary>
        public string ContentMimeType
        {
            get => Iface.GetContentMimeType();
        }

        /// <summary>
        /// Gets the Cancel property.
        /// </summary>
        public bool Cancel
        {
            get => Iface.GetCancel();
            set => Iface.SetCancel(value);
        }

        /// <summary>
        /// Gets the SuppressDefaultDialog property.
        /// </summary>
        public bool SuppressDefaultDialog
        {
            get => Iface.GetSuppressDefaultDialog();
            set => Iface.SetSuppressDefaultDialog(value);
        }

        /// <summary>
        /// Gets the SaveAsFilePath property.
        /// </summary>
        public string SaveAsFilePath
        {
            get => Iface.GetSaveAsFilePath();
            set => Iface.SetSaveAsFilePath(value);
        }

        /// <summary>
        /// Gets the AllowReplace property.
        /// </summary>
        public bool AllowReplace
        {
            get => Iface.GetAllowReplace();
            set => Iface.SetAllowReplace(value);
        }

        /// <summary>
        /// Gets the Kind property.
        /// </summary>
        public COREWEBVIEW2_SAVE_AS_KIND Kind
        {
            get => Iface.GetKind();
            set => Iface.SetKind(value);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Wraps the GetDeferral method.
        /// </summary>
        public ICoreWebView2Deferral GetDeferral()
        {
            return Iface.GetDeferral();
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
        ///~CoreWebView2SaveAsUIShowingEventArgsShim()
        ///{
        ///    Dispose(disposing: false);
        ///}
    }
}
