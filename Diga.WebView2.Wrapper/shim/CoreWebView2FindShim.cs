using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.shim
{
    /// <summary>
    /// Shim-Wrapper für ICoreWebView2Find
    /// </summary>
    public class CoreWebView2FindShim : IDisposable
    {
        private ComObjectHolder<ICoreWebView2Find> _Iface;
        private bool disposedValue;
        private SafeHandle handle = new SafeFileHandle(nint.Zero, true);

        /// <summary>
        /// Gets the wrapped COM interface.
        /// </summary>
        private ICoreWebView2Find Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(CoreWebView2FindShim) + " Iface is null");
                    throw new InvalidOperationException(nameof(CoreWebView2FindShim) + " Iface is null");
                }

                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<ICoreWebView2Find>(value);
        }

        /// <summary>
        /// Initializes a new instance of the CoreWebView2FindShim class.
        /// </summary>
        /// <param name="iface">The COM interface to wrap</param>
        public CoreWebView2FindShim(ICoreWebView2Find iface)
        {
            Iface = iface;
        }

        #region Properties

        /// <summary>
        /// Gets the ActiveMatchIndex property.
        /// </summary>
        public int ActiveMatchIndex
        {
            get => Iface.GetActiveMatchIndex();
        }

        /// <summary>
        /// Gets the MatchCount property.
        /// </summary>
        public int MatchCount
        {
            get => Iface.GetMatchCount();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Wraps the add_ActiveMatchIndexChanged method.
        /// </summary>
        /// <param name="eventHandler"></param>
        /// <param name="token"></param>
        public void add_ActiveMatchIndexChanged(ICoreWebView2FindActiveMatchIndexChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            Iface.add_ActiveMatchIndexChanged(eventHandler, out token);
        }

        /// <summary>
        /// Wraps the remove_ActiveMatchIndexChanged method.
        /// </summary>
        /// <param name="token"></param>
        public void remove_ActiveMatchIndexChanged(EventRegistrationToken token)
        {
            Iface.remove_ActiveMatchIndexChanged(token);
        }

        /// <summary>
        /// Wraps the add_MatchCountChanged method.
        /// </summary>
        /// <param name="eventHandler"></param>
        /// <param name="token"></param>
        public void add_MatchCountChanged(ICoreWebView2FindMatchCountChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            Iface.add_MatchCountChanged(eventHandler, out token);
        }

        /// <summary>
        /// Wraps the remove_MatchCountChanged method.
        /// </summary>
        /// <param name="token"></param>
        public void remove_MatchCountChanged(EventRegistrationToken token)
        {
            Iface.remove_MatchCountChanged(token);
        }

        /// <summary>
        /// Wraps the Start method.
        /// </summary>
        /// <param name="options"></param>
        /// <param name="handler"></param>
        public void Start(ICoreWebView2FindOptions options, ICoreWebView2FindStartCompletedHandler handler)
        {
            Iface.Start(options, handler);
        }

        /// <summary>
        /// Wraps the FindNext method.
        /// </summary>
        public void FindNext()
        {
            Iface.FindNext();
        }

        /// <summary>
        /// Wraps the FindPrevious method.
        /// </summary>
        public void FindPrevious()
        {
            Iface.FindPrevious();
        }

        /// <summary>
        /// Wraps the Stop method.
        /// </summary>
        public void Stop()
        {
            Iface.Stop();
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
        ///~CoreWebView2FindShim()
        ///{
        ///    Dispose(disposing: false);
        ///}
    }
}
