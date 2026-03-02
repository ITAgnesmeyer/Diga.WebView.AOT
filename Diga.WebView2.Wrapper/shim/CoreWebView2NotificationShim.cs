using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.shim
{
    /// <summary>
    /// Shim-Wrapper für ICoreWebView2Notification
    /// </summary>
    public class CoreWebView2NotificationShim : IDisposable
    {
        private ComObjectHolder<ICoreWebView2Notification> _Iface;
        private bool disposedValue;
        private SafeHandle handle = new SafeFileHandle(nint.Zero, true);

        /// <summary>
        /// Gets the wrapped COM interface.
        /// </summary>
        private ICoreWebView2Notification Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(CoreWebView2NotificationShim) + " Iface is null");
                    throw new InvalidOperationException(nameof(CoreWebView2NotificationShim) + " Iface is null");
                }

                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<ICoreWebView2Notification>(value);
        }

        /// <summary>
        /// Initializes a new instance of the CoreWebView2NotificationShim class.
        /// </summary>
        /// <param name="iface">The COM interface to wrap</param>
        public CoreWebView2NotificationShim(ICoreWebView2Notification iface)
        {
            Iface = iface;
        }

        #region Properties

        /// <summary>
        /// Gets the Body property.
        /// </summary>
        public string Body
        {
            get => Iface.GetBody();
        }

        /// <summary>
        /// Gets the Direction property.
        /// </summary>
        public COREWEBVIEW2_TEXT_DIRECTION_KIND Direction
        {
            get => Iface.GetDirection();
        }

        /// <summary>
        /// Gets the Language property.
        /// </summary>
        public string Language
        {
            get => Iface.GetLanguage();
        }

        /// <summary>
        /// Gets the Tag property.
        /// </summary>
        public string Tag
        {
            get => Iface.GetTag();
        }

        /// <summary>
        /// Gets the IconUri property.
        /// </summary>
        public string IconUri
        {
            get => Iface.GetIconUri();
        }

        /// <summary>
        /// Gets the Title property.
        /// </summary>
        public string Title
        {
            get => Iface.GetTitle();
        }

        /// <summary>
        /// Gets the BadgeUri property.
        /// </summary>
        public string BadgeUri
        {
            get => Iface.GetBadgeUri();
        }

        /// <summary>
        /// Gets the BodyImageUri property.
        /// </summary>
        public string BodyImageUri
        {
            get => Iface.GetBodyImageUri();
        }

        /// <summary>
        /// Gets the ShouldRenotify property.
        /// </summary>
        public bool ShouldRenotify
        {
            get => Iface.GetShouldRenotify();
        }

        /// <summary>
        /// Gets the RequiresInteraction property.
        /// </summary>
        public bool RequiresInteraction
        {
            get => Iface.GetRequiresInteraction();
        }

        /// <summary>
        /// Gets the IsSilent property.
        /// </summary>
        public bool IsSilent
        {
            get => Iface.GetIsSilent();
        }

        /// <summary>
        /// Gets the Timestamp property.
        /// </summary>
        public double Timestamp
        {
            get => Iface.GetTimestamp();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Wraps the add_CloseRequested method.
        /// </summary>
        /// <param name="eventHandler"></param>
        /// <param name="token"></param>
        public void add_CloseRequested(ICoreWebView2NotificationCloseRequestedEventHandler eventHandler, out EventRegistrationToken token)
        {
            Iface.add_CloseRequested(eventHandler, out token);
        }

        /// <summary>
        /// Wraps the remove_CloseRequested method.
        /// </summary>
        /// <param name="token"></param>
        public void remove_CloseRequested(EventRegistrationToken token)
        {
            Iface.remove_CloseRequested(token);
        }

        /// <summary>
        /// Wraps the ReportShown method.
        /// </summary>
        public void ReportShown()
        {
            Iface.ReportShown();
        }

        /// <summary>
        /// Wraps the ReportClicked method.
        /// </summary>
        public void ReportClicked()
        {
            Iface.ReportClicked();
        }

        /// <summary>
        /// Wraps the ReportClosed method.
        /// </summary>
        public void ReportClosed()
        {
            Iface.ReportClosed();
        }

        /// <summary>
        /// Wraps the GetVibrationPattern method.
        /// </summary>
        /// <param name="count"></param>
        /// <param name="vibrationPattern"></param>
        public void GetVibrationPattern(out uint count, out ulong vibrationPattern)
        {
            Iface.GetVibrationPattern(out count, out vibrationPattern);
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
        ///~CoreWebView2NotificationShim()
        ///{
        ///    Dispose(disposing: false);
        ///}
    }
}
