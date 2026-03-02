using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.shim
{
    /// <summary>
    /// Shim-Wrapper für ICoreWebView2CompositionController3
    /// </summary>
    public class CoreWebView2CompositionController3Shim : CoreWebView2CompositionController2Shim
    {
        private ComObjectHolder<ICoreWebView2CompositionController3> _Iface;
        private SafeHandle handle = new SafeFileHandle(nint.Zero, true);

        /// <summary>
        /// Gets the wrapped COM interface.
        /// </summary>
        private ICoreWebView2CompositionController3 Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(CoreWebView2CompositionController3Shim) + " Iface is null");
                    throw new InvalidOperationException(nameof(CoreWebView2CompositionController3Shim) + " Iface is null");
                }

                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<ICoreWebView2CompositionController3>(value);
        }

        /// <summary>
        /// Initializes a new instance of the CoreWebView2CompositionController3Shim class.
        /// </summary>
        /// <param name="iface">The COM interface to wrap</param>
        public CoreWebView2CompositionController3Shim(ICoreWebView2CompositionController3 iface) : base((ICoreWebView2CompositionController2)iface)
        {
            Iface = iface;
        }

        #region Methods

        /// <summary>
        /// Wraps the DragEnter method.
        /// </summary>
        /// <param name="dataObject"></param>
        /// <param name="keyState"></param>
        /// <param name="point"></param>
        public uint DragEnter(IDataObject dataObject, uint keyState, POINT point)
        {
            return Iface.DragEnter(dataObject, keyState, point);
        }

        /// <summary>
        /// Wraps the DragLeave method.
        /// </summary>
        public void DragLeave()
        {
            Iface.DragLeave();
        }

        /// <summary>
        /// Wraps the DragOver method.
        /// </summary>
        /// <param name="keyState"></param>
        /// <param name="point"></param>
        public uint DragOver(uint keyState, POINT point)
        {
            return Iface.DragOver(keyState, point);
        }

        /// <summary>
        /// Wraps the Drop method.
        /// </summary>
        /// <param name="dataObject"></param>
        /// <param name="keyState"></param>
        /// <param name="point"></param>
        public uint Drop(IDataObject dataObject, uint keyState, POINT point)
        {
            return Iface.Drop(dataObject, keyState, point);
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
