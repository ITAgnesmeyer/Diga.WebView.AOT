using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;
using Microsoft.Win32.SafeHandles;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Wrapper.Implementation
{
    public class WebView2Settings8Interface : WebView2Settings7Interface//, ICoreWebView2Settings8
    {
        private ComObjectHolder<ICoreWebView2Settings8> _Settings;

        private ICoreWebView2Settings8 Settings
        {
            get
            {
                if (_Settings == null)
                {
                    Debug.Print(nameof(WebView2Settings8Interface) + "." + nameof(Settings) + " is null");
                    throw new InvalidOperationException(nameof(WebView2Settings8Interface) + "." + nameof(Settings) + " is null");

                }
                return _Settings.Interface;
            }
            set => _Settings = new ComObjectHolder<ICoreWebView2Settings8>(value);
        }
        public WebView2Settings8Interface(ICoreWebView2Settings8 settings) : base(settings)
        {
            Settings = settings ?? throw new ArgumentNullException(nameof(settings));
        }
        public int IsReputationCheckingRequired { get => Settings.GetIsReputationCheckingRequired(); set => Settings.SetIsReputationCheckingRequired(value); }

        private bool _IsDisposed;
        protected override void Dispose(bool disposing)
        {
            if (_IsDisposed) return;
            if (disposing)
            {
                _Settings = null;
                _IsDisposed = true;
            }


            base.Dispose(disposing);
        }
    }
    public class WebView2Settings7Interface : WebView2Settings6Interface
    {
        private ComObjectHolder<ICoreWebView2Settings7> _Settings;
        private ICoreWebView2Settings7 Settings
        {
            get
            {
                if (_Settings == null)
                {
                    Debug.Print(nameof(WebView2Settings7Interface) + "." + nameof(Settings) + " is null");
                    throw new InvalidOperationException(nameof(WebView2Settings7Interface) + "." + nameof(Settings) + " is null");

                }
                return _Settings.Interface;
            }
            set => _Settings = new ComObjectHolder<ICoreWebView2Settings7>(value);
        }

        public WebView2Settings7Interface(ICoreWebView2Settings7 settings) : base(settings)
        {
            Settings = settings ?? throw new ArgumentNullException(nameof(settings));
        }

        private bool _IsDisposed;
        protected override void Dispose(bool disposing)
        {
            if (_IsDisposed) return;
            if (disposing)
            {
                _Settings = null;
                _IsDisposed = true;
            }


            base.Dispose(disposing);
        }

        public COREWEBVIEW2_PDF_TOOLBAR_ITEMS HiddenPdfToolbarItems { get => Settings.GetHiddenPdfToolbarItems(); set => Settings.SetHiddenPdfToolbarItems(value); }
    }
    public class WebView2Settings6Interface : WebView2Settings5Interface
    {
        private ComObjectHolder<ICoreWebView2Settings6> _Settings;
        private ICoreWebView2Settings6 Settings
        {
            get
            {
                if (_Settings == null)
                {
                    Debug.Print(nameof(WebView2Settings6Interface) + "." + nameof(Settings) + " is null");
                    throw new InvalidOperationException(nameof(WebView2Settings6Interface) + "." + nameof(Settings) + " is null");

                }
                return _Settings.Interface;
            }
            set => _Settings = new ComObjectHolder<ICoreWebView2Settings6>(value);
        }

        public WebView2Settings6Interface(ICoreWebView2Settings6 settings) : base(settings)
        {
            Settings = settings ?? throw new ArgumentNullException(nameof(settings));
        }

        public int IsSwipeNavigationEnabled { get => Settings.GetIsSwipeNavigationEnabled(); set => Settings.SetIsSwipeNavigationEnabled(value); }
        private bool _IsDisposed;
        protected override void Dispose(bool disposing)
        {
            if (_IsDisposed) return;
            if (disposing)
            {
                _Settings = null;
                _IsDisposed = true;
            }


            base.Dispose(disposing);
        }
    }
    public class WebView2Settings5Interface : WebView2Settings4Interface
    {
        private ComObjectHolder<ICoreWebView2Settings5> _Settings;
        private ICoreWebView2Settings5 Settings
        {
            get
            {
                if (_Settings == null)
                {
                    Debug.Print(nameof(WebView2Settings5Interface) + "." + nameof(Settings) + " is null");
                    throw new InvalidOperationException(nameof(WebView2Settings5Interface) + "." + nameof(Settings) + " is null");

                }
                return _Settings.Interface;
            }
            set => _Settings = new ComObjectHolder<ICoreWebView2Settings5>(value);
        }
        public WebView2Settings5Interface(ICoreWebView2Settings5 settings) : base(settings)
        {
            Settings = settings ?? throw new ArgumentNullException(nameof(settings));
        }

        public int IsPinchZoomEnabled { get => Settings.GetIsPinchZoomEnabled(); set => Settings.SetIsPinchZoomEnabled(value); }
        private bool _IsDisposed;
        protected override void Dispose(bool disposing)
        {
            if (_IsDisposed) return;
            if (disposing)
            {
                _Settings = null;
                _IsDisposed = true;
            }


            base.Dispose(disposing);
        }
    }

    public class WebView2Settings4Interface : WebView2Settings3Interface
    {
        private ComObjectHolder<ICoreWebView2Settings4> _Settings;
        private ICoreWebView2Settings4 Settings
        {
            get
            {
                if (_Settings == null)
                {
                    Debug.Print(nameof(WebView2Settings4Interface) + "." + nameof(Settings) + " is null");
                    throw new InvalidOperationException(nameof(WebView2Settings4Interface) + "." + nameof(Settings) + " is null");

                }
                return _Settings.Interface;
            }
            set => _Settings = new ComObjectHolder<ICoreWebView2Settings4>(value);
        }
        public WebView2Settings4Interface(ICoreWebView2Settings4 settings) : base(settings)
        {
            Settings = settings ?? throw new ArgumentNullException(nameof(settings));
        }

        public int IsPasswordAutosaveEnabled { get => Settings.GetIsPasswordAutosaveEnabled(); set => Settings.SetIsPasswordAutosaveEnabled(value); }
        public int IsGeneralAutofillEnabled { get => Settings.GetIsGeneralAutofillEnabled(); set => Settings.SetIsGeneralAutofillEnabled(value); }
        private bool _IsDisposed;
        protected override void Dispose(bool disposing)
        {
            if (_IsDisposed) return;
            if (disposing)
            {
                _Settings = null;
                _IsDisposed = true;
            }


            base.Dispose(disposing);
        }
    }

    public class WebView2Settings3Interface : WebView2Settings2Interface
    {
        private ComObjectHolder<ICoreWebView2Settings3> _Settings;
        private ICoreWebView2Settings3 Settings
        {
            get
            {
                if (_Settings == null)
                {
                    Debug.Print(nameof(WebView2Settings3Interface) + "." + nameof(Settings) + " is null");
                    throw new InvalidOperationException(nameof(WebView2Settings3Interface) + "." + nameof(Settings) + " is null");

                }
                return _Settings.Interface;
            }
            set => _Settings = new ComObjectHolder<ICoreWebView2Settings3>(value);
        }
        public WebView2Settings3Interface(ICoreWebView2Settings3 settings) : base(settings)
        {
            Settings = settings ?? throw new ArgumentNullException(nameof(settings));
        }

        public int AreBrowserAcceleratorKeysEnabled { get => Settings.GetAreBrowserAcceleratorKeysEnabled(); set => Settings.SetAreBrowserAcceleratorKeysEnabled(value); }
        private bool _IsDisposed;
        protected override void Dispose(bool disposing)
        {
            if (_IsDisposed) return;
            if (disposing)
            {
                _Settings = null;
                _IsDisposed = true;
            }


            base.Dispose(disposing);
        }
    }
    public class WebView2Settings2Interface : WebView2SettingsInterface
    {
        private ComObjectHolder<ICoreWebView2Settings2> _Settings;

        private ICoreWebView2Settings2 Settings
        {
            get
            {
                if (_Settings == null)
                {
                    Debug.Print(nameof(WebView2Settings2Interface) + "." + nameof(Settings) + " is null");
                    throw new InvalidOperationException(nameof(WebView2Settings2Interface) + "." + nameof(Settings) + " is null");

                }
                return _Settings.Interface;
            }
            set
            {
                _Settings = new ComObjectHolder<ICoreWebView2Settings2>(value);
            }
        }

        public WebView2Settings2Interface(ICoreWebView2Settings2 settings) : base(settings)
        {
            Settings = settings ?? throw new ArgumentNullException(nameof(settings));
        }

        public string UserAgent { get => Settings.GetUserAgent(); set => Settings.SetUserAgent(value); }
        private bool _IsDisposed;
        protected override void Dispose(bool disposing)
        {
            if (_IsDisposed) return;
            if (disposing)
            {
                _Settings = null;
                _IsDisposed = true;
            }


            base.Dispose(disposing);
        }
    }
    public class WebView2SettingsInterface : IDisposable
    {
        private ComObjectHolder<ICoreWebView2Settings> _Settings;
        /// Wraps in SafeHandle so resources can be released if consumer forgets to call Dispose. Recommended
        ///             pattern for any type that is not sealed.
        ///             https://docs.microsoft.com/dotnet/api/system.idisposable#idisposable-and-the-inheritance-hierarchy
        private readonly SafeHandle handle = new SafeFileHandle(nint.Zero, true);
        private ICoreWebView2Settings Settings
        {
            get
            {
                if (_Settings == null)
                {
                    Debug.Print(nameof(WebView2SettingsInterface) + "." + nameof(Settings) + " is null");
                    throw new InvalidOperationException(nameof(WebView2SettingsInterface) + "." + nameof(Settings) + " is null");

                }
                return _Settings.Interface;
            }
            set => _Settings = new ComObjectHolder<ICoreWebView2Settings>(value);
        }



        public WebView2SettingsInterface(ICoreWebView2Settings settings)
        {
            if (settings == null)
                throw new ArgumentNullException(nameof(settings));
            Settings = settings;
        }

        public int IsScriptEnabled { get => Settings.GetIsScriptEnabled(); set => Settings.SetIsScriptEnabled(value); }
        public int IsWebMessageEnabled { get => Settings.GetIsWebMessageEnabled(); set => Settings.SetIsWebMessageEnabled(value); }
        public int AreDefaultScriptDialogsEnabled { get => Settings.GetAreDefaultScriptDialogsEnabled(); set => Settings.SetAreDefaultScriptDialogsEnabled(value); }
        public int IsStatusBarEnabled { get => Settings.GetIsStatusBarEnabled(); set => Settings.SetIsStatusBarEnabled(value); }
        public int AreDevToolsEnabled { get => Settings.GetAreDevToolsEnabled(); set => Settings.SetAreDevToolsEnabled(value); }
        public int AreDefaultContextMenusEnabled { get => Settings.GetAreDefaultContextMenusEnabled(); set => Settings.SetAreDefaultContextMenusEnabled(value); }
        public int AreHostObjectsAllowed { get => Settings.GetAreHostObjectsAllowed(); set => Settings.SetAreHostObjectsAllowed(value); }
        public int IsZoomControlEnabled { get => Settings.GetIsZoomControlEnabled(); set => Settings.SetIsZoomControlEnabled(value); }
        public int IsBuiltInErrorPageEnabled { get => Settings.GetIsBuiltInErrorPageEnabled(); set => Settings.SetIsBuiltInErrorPageEnabled(value); }

        private bool _IsDisposed;
        protected virtual void Dispose(bool disposing)
        {
            if (_IsDisposed) return;
            if (disposing)
            {
                handle.Dispose();
                _Settings = null;
                _IsDisposed = true;
            }
        }


        public void Dispose()
        {
            // Ändern Sie diesen Code nicht. Fügen Sie Bereinigungscode in der Methode "Dispose(bool disposing)" ein.
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
