using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;
using Microsoft.Win32.SafeHandles;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Wrapper.Implementation
{


    public class WebView2Profile6Interface : WebView2Profile5Interface
    {
        private ComObjectHolder<ICoreWebView2Profile6> _Iface;
        private ICoreWebView2Profile6 Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(WebView2Profile6Interface) + "=>" + nameof(Iface) + " is null");

                    throw new InvalidOperationException(nameof(WebView2Profile6Interface) + "=>" + nameof(Iface) + " is null");
                }
                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<ICoreWebView2Profile6>(value);
        }
        public WebView2Profile6Interface(ICoreWebView2Profile6 iface) : base(iface)
        {
            Iface = iface ?? throw new ArgumentNullException(nameof(iface));
        }

        private bool _IsDisposed;
        protected override void Dispose(bool disposing)
        {
            if (_IsDisposed) return;
            if (disposing)
            {
                _Iface = null;
                _IsDisposed = true;
            }
            base.Dispose(disposing);
        }
        public int IsPasswordAutosaveEnabled { get => this.Iface.GetIsPasswordAutosaveEnabled(); set => this.Iface.SetIsPasswordAutosaveEnabled(value); }
        public int IsGeneralAutofillEnabled { get => this.Iface.GetIsGeneralAutofillEnabled(); set => this.Iface.SetIsGeneralAutofillEnabled( value); }
    }



    public class WebView2Profile5Interface : WebView2Profile4Interface
    {
        private ComObjectHolder<ICoreWebView2Profile5> _Iface;
        private ICoreWebView2Profile5 Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(WebView2Profile5Interface) + "=>" + nameof(Iface) + " is null");

                    throw new InvalidOperationException(nameof(WebView2Profile5Interface) + "=>" + nameof(Iface) + " is null");
                }
                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<ICoreWebView2Profile5>(value);
        }
        public WebView2Profile5Interface(ICoreWebView2Profile5 iface) : base(iface)
        {
            Iface = iface ?? throw new ArgumentNullException(nameof(iface));
        }

        private bool _IsDisposed;
        protected override void Dispose(bool disposing)
        {
            if (_IsDisposed) return;
            if (disposing)
            {
                _Iface = null;
                _IsDisposed = true;
            }
            base.Dispose(disposing);
        }
        public ICoreWebView2CookieManager CookieManager => this.Iface.GetCookieManager();
    }



    public class WebView2Profile4Interface : WebView2Profile3Interface
    {
        private ComObjectHolder<ICoreWebView2Profile4> _Iface;
        private ICoreWebView2Profile4 Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(WebView2Profile4Interface) + "=>" + nameof(Iface) + " is null");

                    throw new InvalidOperationException(nameof(WebView2Profile4Interface) + "=>" + nameof(Iface) + " is null");
                }
                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<ICoreWebView2Profile4>(value);
        }
        public WebView2Profile4Interface(ICoreWebView2Profile4 iface) : base(iface)
        {
            Iface = iface ?? throw new ArgumentNullException(nameof(iface));
        }

        private bool _IsDisposed;
        protected override void Dispose(bool disposing)
        {
            if (_IsDisposed) return;
            if (disposing)
            {
                _Iface = null;
                _IsDisposed = true;
            }
            base.Dispose(disposing);
        }
        public void SetPermissionState([In] COREWEBVIEW2_PERMISSION_KIND PermissionKind, [In, MarshalAs(UnmanagedType.LPWStr)] string origin, [In] COREWEBVIEW2_PERMISSION_STATE State, [In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2SetPermissionStateCompletedHandler completedHandler)
        {
            this.Iface.SetPermissionState(PermissionKind, origin, State, completedHandler);
        }

        public void GetNonDefaultPermissionSettings([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2GetNonDefaultPermissionSettingsCompletedHandler completedHandler)
        {
            this.Iface.GetNonDefaultPermissionSettings(completedHandler);
        }
    }


    public class WebView2Profile3Interface : WebView2Profile2Interface
    {
        private ComObjectHolder<ICoreWebView2Profile3> _Iface;
        private ICoreWebView2Profile3 Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(WebView2Profile3Interface) + "=>" + nameof(Iface) + " is null");

                    throw new InvalidOperationException(nameof(WebView2Profile3Interface) + "=>" + nameof(Iface) + " is null");
                }
                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<ICoreWebView2Profile3>(value);
        }
        public WebView2Profile3Interface(ICoreWebView2Profile3 iface) : base(iface)
        {
            Iface = iface ?? throw new ArgumentNullException(nameof(iface));
        }

        private bool _IsDisposed;
        protected override void Dispose(bool disposing)
        {
            if (_IsDisposed) return;
            if (disposing)
            {
                _Iface = null;
                _IsDisposed = true;
            }
            base.Dispose(disposing);
        }


        public COREWEBVIEW2_TRACKING_PREVENTION_LEVEL PreferredTrackingPreventionLevel { get => this.Iface.GetPreferredTrackingPreventionLevel(); set => this.Iface.SetPreferredTrackingPreventionLevel(value); }
    }


    public class WebView2Profile2Interface : WebView2ProfileInterface
    {
        private ComObjectHolder<ICoreWebView2Profile2> _Profile;
        private ICoreWebView2Profile2 Profile
        {
            get
            {
                if (_Profile == null)
                {
                    Debug.Print(nameof(WebView2Settings3Interface) + "." + nameof(Profile) + " is null");
                    throw new InvalidOperationException(nameof(WebView2Settings3Interface) + "." + nameof(Profile) + " is null");

                }
                return _Profile.Interface;
            }
            set
            {
                _Profile = new ComObjectHolder<ICoreWebView2Profile2>(value);
            }
        }

        public ICoreWebView2Profile2 GetInterface()
        {
            return Profile;
        }
        public WebView2Profile2Interface(ICoreWebView2Profile2 profile) : base(profile)
        {
            Profile = profile ?? throw new ArgumentNullException(nameof(profile));
        }

        public void ClearBrowsingData([In] COREWEBVIEW2_BROWSING_DATA_KINDS dataKinds, [In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2ClearBrowsingDataCompletedHandler handler)
        {
            Profile.ClearBrowsingData(dataKinds, handler);
        }

        public void ClearBrowsingDataInTimeRange([In] COREWEBVIEW2_BROWSING_DATA_KINDS dataKinds, [In] double startTime, [In] double endTime, [In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2ClearBrowsingDataCompletedHandler handler)
        {
            Profile.ClearBrowsingDataInTimeRange(dataKinds, startTime, endTime, handler);
        }

        public void ClearBrowsingDataAll([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2ClearBrowsingDataCompletedHandler handler)
        {
            Profile.ClearBrowsingDataAll(handler);
        }
    }
    public class WebView2ProfileInterface : IDisposable
    {
        private ComObjectHolder<ICoreWebView2Profile> _Args;
        private bool disposedValue;

        /// Wraps in SafeHandle so resources can be released if consumer forgets to call Dispose. Recommended
        ///             pattern for any type that is not sealed.
        ///             https://docs.microsoft.com/dotnet/api/system.idisposable#idisposable-and-the-inheritance-hierarchy
        private readonly SafeHandle handle = new SafeFileHandle(nint.Zero, true);

        private ICoreWebView2Profile Args
        {
            get
            {
                if (_Args == null)
                {
                    Debug.Print(nameof(WebView2ProfileInterface) + " Args is null");
                    throw new InvalidOperationException(nameof(WebView2ProfileInterface) + " Args is null");
                }

                return _Args.Interface;
            }
            set => _Args = new ComObjectHolder<ICoreWebView2Profile>(value);
        }

        public WebView2ProfileInterface(ICoreWebView2Profile profile)
        {
            Args = profile ?? throw new ArgumentNullException(nameof(profile));
        }


        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    handle.Dispose();
                }
                disposedValue = true;
            }
        }



        public void Dispose()
        {
            // Ändern Sie diesen Code nicht. Fügen Sie Bereinigungscode in der Methode "Dispose(bool disposing)" ein.
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        public string ProfileName => Args.GetProfileName();

        public int IsInPrivateModeEnabled => Args.GetIsInPrivateModeEnabled();

        public string ProfilePath => Args.GetProfilePath();

        public string DefaultDownloadFolderPath { get => Args.GetDefaultDownloadFolderPath(); set => Args.SetDefaultDownloadFolderPath(value); }
        public COREWEBVIEW2_PREFERRED_COLOR_SCHEME PreferredColorScheme { get => Args.GetPreferredColorScheme(); set => Args.SetPreferredColorScheme(value); }
    }
}
