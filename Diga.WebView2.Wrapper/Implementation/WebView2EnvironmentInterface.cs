using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;
using Microsoft.Win32.SafeHandles;
using System.Diagnostics;
using System.Runtime.InteropServices;


namespace Diga.WebView2.Wrapper.Implementation
{
    public class WebView2Environment12Interface : WebView2Environment11Interface //, ICoreWebView2Environment12
    {
        private ComObjectHolder<ICoreWebView2Environment12> _Environment;
        private ICoreWebView2Environment12 Environment
        {
            get
            {
                if (_Environment == null)
                {
                    Debug.Print(nameof(WebView2Environment12Interface) + "." + nameof(Environment) + " is null");
                    throw new InvalidOperationException(nameof(WebView2Environment12Interface) + "." + nameof(Environment) + " is null");

                }
                return _Environment.Interface;
            }
            set => _Environment = new ComObjectHolder<ICoreWebView2Environment12>(value);
        }
        public WebView2Environment12Interface(ICoreWebView2Environment12 environment) :
            base(environment)
        {
            Environment = environment ?? throw new ArgumentNullException(nameof(environment));
        }

        [return: MarshalAs(UnmanagedType.Interface)]
        public ICoreWebView2SharedBuffer CreateSharedBuffer([In] ulong Size)
        {
            return Environment.CreateSharedBuffer(Size);
        }
    }
    public class WebView2Environment11Interface : WebView2Environment10Interface //, ICoreWebView2Environment11
    {
        private ComObjectHolder<ICoreWebView2Environment11> _Environment;

        private ICoreWebView2Environment11 Environment
        {
            get
            {
                if (_Environment == null)
                {
                    Debug.Print(nameof(WebView2Environment11Interface) + "." + nameof(Environment) + " is null");
                    throw new InvalidOperationException(nameof(WebView2Environment11Interface) + "." + nameof(Environment) + " is null");

                }
                return _Environment.Interface;
            }
            set => _Environment = new ComObjectHolder<ICoreWebView2Environment11>(value);
        }

        public WebView2Environment11Interface(ICoreWebView2Environment11 environment) : base(environment)
        {
            Environment = environment ?? throw new ArgumentNullException(nameof(environment));
        }

        public string FailureReportFolderPath => Environment.GetFailureReportFolderPath();
    }
    public class WebView2Environment10Interface : WebView2Environment9Interface //, ICoreWebView2Environment10
    {
        private ComObjectHolder<ICoreWebView2Environment10> _Environment;
        private ICoreWebView2Environment10 Environment
        {
            get
            {
                if (_Environment == null)
                {
                    Debug.Print(nameof(WebView2Environment10Interface) + "." + nameof(Environment) + " is null");
                    throw new InvalidOperationException(nameof(WebView2Environment10Interface) + "." + nameof(Environment) + " is null");

                }
                return _Environment.Interface;
            }
            set { _Environment = new ComObjectHolder<ICoreWebView2Environment10>(value); }
        }

        public WebView2Environment10Interface(ICoreWebView2Environment10 environment) : base(environment)
        {
            Environment = environment ?? throw new ArgumentNullException(nameof(environment));
        }

        [return: MarshalAs(UnmanagedType.Interface)]
        public ICoreWebView2ControllerOptions CreateCoreWebView2ControllerOptions()
        {
            return Environment.CreateCoreWebView2ControllerOptions();
        }

        public void CreateCoreWebView2ControllerWithOptions(nint ParentWindow, [In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2ControllerOptions options, [In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2CreateCoreWebView2ControllerCompletedHandler handler)
        {
            Environment.CreateCoreWebView2ControllerWithOptions(ParentWindow, options, handler);
        }

        public void CreateCoreWebView2CompositionControllerWithOptions(nint ParentWindow, [In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2ControllerOptions options, [In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2CreateCoreWebView2CompositionControllerCompletedHandler handler)
        {
            Environment.CreateCoreWebView2CompositionControllerWithOptions(ParentWindow, options, handler);
        }
    }

    public class WebView2Environment9Interface : WebView2Environment8Interface
    {
        private ComObjectHolder<ICoreWebView2Environment9> _Environment;
        private ICoreWebView2Environment9 Environment
        {
            get
            {
                if (_Environment == null)
                {
                    Debug.Print(nameof(WebView2Environment9Interface) + "." + nameof(Environment) + " is null");
                    throw new InvalidOperationException(nameof(WebView2Environment9Interface) + "." + nameof(Environment) + " is null");

                }
                return _Environment.Interface;
            }
            set { _Environment = new ComObjectHolder<ICoreWebView2Environment9>(value); }
        }

        public WebView2Environment9Interface(ICoreWebView2Environment9 environment) : base(environment)
        {
            Environment = environment ?? throw new ArgumentNullException(nameof(environment));
        }



        [return: MarshalAs(UnmanagedType.Interface)]
        public ICoreWebView2ContextMenuItem CreateContextMenuItem([In, MarshalAs(UnmanagedType.LPWStr)] string Label, [MarshalAs(UnmanagedType.Interface), In] IStream iconStream, [In] COREWEBVIEW2_CONTEXT_MENU_ITEM_KIND Kind)
        {
            return Environment.CreateContextMenuItem(Label, iconStream, Kind);
        }
    }
    public class WebView2Environment8Interface : WebView2Environment7Interface //, ICoreWebView2Environment8
    {
        private ComObjectHolder<ICoreWebView2Environment8> _Environment;
        private ICoreWebView2Environment8 Environment
        {
            get
            {
                if (_Environment == null)
                {
                    Debug.Print(nameof(WebView2Environment8Interface) + "." + nameof(Environment) + " is null");
                    throw new InvalidOperationException(nameof(WebView2Environment8Interface) + "." + nameof(Environment) + " is null");

                }
                return _Environment.Interface;
            }
            set { _Environment = new ComObjectHolder<ICoreWebView2Environment8>(value); }
        }

        public WebView2Environment8Interface(ICoreWebView2Environment8 environment) : base(environment)
        {
            Environment = environment ?? throw new ArgumentNullException(nameof(environment));
        }

        public void add_ProcessInfosChanged([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2ProcessInfosChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            Environment.add_ProcessInfosChanged(eventHandler, out token);
        }

        public void remove_ProcessInfosChanged([In] EventRegistrationToken token)
        {
            Environment.remove_ProcessInfosChanged(token);
        }

        [return: MarshalAs(UnmanagedType.Interface)]
        public ICoreWebView2ProcessInfoCollection GetProcessInfos()
        {
            return Environment.GetProcessInfos();
        }
    }
    public class WebView2Environment7Interface : WebView2Environment6Interface //, ICoreWebView2Environment7
    {
        private ComObjectHolder<ICoreWebView2Environment7> _Environment;
        private ICoreWebView2Environment7 Environment
        {
            get
            {
                if (_Environment == null)
                {
                    Debug.Print(nameof(WebView2Environment7Interface) + "." + nameof(Environment) + " is null");
                    throw new InvalidOperationException(nameof(WebView2Environment7Interface) + "." + nameof(Environment) + " is null");

                }
                return _Environment.Interface;
            }
            set { _Environment = new ComObjectHolder<ICoreWebView2Environment7>(value); }
        }

        public WebView2Environment7Interface(ICoreWebView2Environment7 environment) : base(environment)
        {
            Environment = environment ?? throw new ArgumentNullException(nameof(environment));
        }

        public string UserDataFolder => Environment.GetUserDataFolder();
        private bool _IsDisposed;
        protected override void Dispose(bool disposing)
        {
            if (_IsDisposed) return;
            if (disposing)
            {
                _Environment = null;
                _IsDisposed = true;
            }
        }
    }
    public class WebView2Environment6Interface : WebView2Environment5Interface//, ICoreWebView2Environment6
    {
        private ComObjectHolder<ICoreWebView2Environment6> _Environment;
        private ICoreWebView2Environment6 Environment
        {
            get
            {
                if (_Environment == null)
                {
                    Debug.Print(nameof(WebView2Environment6Interface) + "." + nameof(Environment) + " is null");
                    throw new InvalidOperationException(nameof(WebView2Environment6Interface) + "." + nameof(Environment) + " is null");

                }
                return _Environment.Interface;
            }
            set => _Environment = new ComObjectHolder<ICoreWebView2Environment6>(value);
        }
        public WebView2Environment6Interface(ICoreWebView2Environment6 environment) : base(environment)
        {
            Environment = environment ?? throw new ArgumentNullException(nameof(environment));
        }

        [return: MarshalAs(UnmanagedType.Interface)]
        public ICoreWebView2PrintSettings CreatePrintSettings()
        {
            return Environment.CreatePrintSettings();
        }
        private bool _IsDisposed;
        protected override void Dispose(bool disposing)
        {
            if (_IsDisposed) return;
            if (disposing)
            {
                _Environment = null;
                _IsDisposed = true;
            }
            base.Dispose(disposing);
        }
    }

    public class WebView2Environment5Interface : WebView2Environment4Interface
    {
        private ComObjectHolder<ICoreWebView2Environment5> _Environment;
        private ICoreWebView2Environment5 Environment
        {
            get
            {
                if (_Environment == null)
                {
                    Debug.Print(nameof(WebView2Environment5Interface) + "." + nameof(Environment) + " is null");
                    throw new InvalidOperationException(nameof(WebView2Environment5Interface) + "." + nameof(Environment) + " is null");

                }
                return _Environment.Interface;
            }
            set => _Environment = new ComObjectHolder<ICoreWebView2Environment5>(value);
        }

        public WebView2Environment5Interface(ICoreWebView2Environment5 environment) : base(environment)
        {
            Environment = environment ?? throw new ArgumentNullException(nameof(environment));
        }

        public void add_BrowserProcessExited([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2BrowserProcessExitedEventHandler eventHandler, out EventRegistrationToken token)
        {
            Environment.add_BrowserProcessExited(eventHandler, out token);
        }

        public void remove_BrowserProcessExited([In] EventRegistrationToken token)
        {
            Environment.remove_BrowserProcessExited(token);
        }
        private bool _IsDisposed;
        protected override void Dispose(bool disposing)
        {
            if (_IsDisposed) return;
            if (disposing)
            {
                _Environment = null;
                _IsDisposed = true;
            }
            base.Dispose(disposing);
        }
    }
    public class WebView2Environment4Interface : WebView2Environment3Interface //, ICoreWebView2Environment4
    {
        private ComObjectHolder<ICoreWebView2Environment4> _Environment;
        private ICoreWebView2Environment4 Environment
        {
            get
            {
                if (_Environment == null)
                {
                    Debug.Print(nameof(WebView2Environment4Interface) + "." + nameof(Environment) + " is null");
                    throw new InvalidOperationException(nameof(WebView2Environment4Interface) + "." + nameof(Environment) + " is null");

                }
                return _Environment.Interface;
            }
            set => _Environment = new ComObjectHolder<ICoreWebView2Environment4>(value);
        }

        public WebView2Environment4Interface(ICoreWebView2Environment4 environment) : base(environment)
        {
            Environment = environment ?? throw new ArgumentNullException(nameof(environment));
        }

        [return: MarshalAs(UnmanagedType.IUnknown)]
        public object GetProviderForHwnd(nint hwnd)
        {
            return Environment.GetProviderForHwnd(hwnd);
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _Environment = null;
            }
            base.Dispose(disposing);
        }
    }
    public class WebView2Environment3Interface : WebView2Environment2Interface //, ICoreWebView2Environment3
    {
        private ComObjectHolder<ICoreWebView2Environment3> _Environment;

        private ICoreWebView2Environment3 Environment
        {
            get
            {
                if (_Environment == null)
                {
                    Debug.Print(nameof(WebView2Environment3Interface) + "." + nameof(Environment) + " is null");
                    throw new InvalidOperationException(nameof(WebView2Environment3Interface) + "." + nameof(Environment) + " is null");

                }
                return _Environment.Interface;
            }
            set { _Environment = new ComObjectHolder<ICoreWebView2Environment3>(value); }
        }


        public WebView2Environment3Interface(ICoreWebView2Environment3 environment) : base(environment)
        {
            if (environment == null)
                throw new ArgumentNullException(nameof(environment));

            Environment = environment;
        }

        public void CreateCoreWebView2CompositionController(nint ParentWindow, [MarshalAs(UnmanagedType.Interface)] ICoreWebView2CreateCoreWebView2CompositionControllerCompletedHandler handler)
        {
            Environment.CreateCoreWebView2CompositionController(ParentWindow, handler);
        }

        [return: MarshalAs(UnmanagedType.Interface)]
        public ICoreWebView2PointerInfo CreateCoreWebView2PointerInfo()
        {
            return Environment.CreateCoreWebView2PointerInfo();
        }
        private bool _IsDisposed;
        protected override void Dispose(bool disposing)
        {
            if (_IsDisposed) return;

            if (disposing)
            {
                _Environment = null;
                _IsDisposed = true;
            }
            base.Dispose(disposing);
        }
    }
    public class WebView2Environment2Interface : WebView2EnvironmentInterface //, ICoreWebView2Environment2
    {
        private ComObjectHolder<ICoreWebView2Environment2> _Environment;
        private ICoreWebView2Environment2 Environment
        {
            get
            {
                if (_Environment == null)
                {
                    Debug.Print(nameof(WebView2Environment2Interface) + "." + nameof(Environment) + " is null");
                    throw new InvalidOperationException(nameof(WebView2Environment2Interface) + "." + nameof(Environment) + " is null");

                }
                return _Environment.Interface;
            }
            set => _Environment = new ComObjectHolder<ICoreWebView2Environment2>(value);
        }

        public WebView2Environment2Interface(ICoreWebView2Environment2 environment) : base(environment)
        {
            Environment = environment ?? throw new ArgumentNullException(nameof(environment));
        }

        [return: MarshalAs(UnmanagedType.Interface)]
        public ICoreWebView2WebResourceRequest CreateWebResourceRequest([In, MarshalAs(UnmanagedType.LPWStr)] string uri, [In, MarshalAs(UnmanagedType.LPWStr)] string Method, [In, MarshalAs(UnmanagedType.Interface)] IStream postData, [In, MarshalAs(UnmanagedType.LPWStr)] string Headers)
        {
            return Environment.CreateWebResourceRequest(uri, Method, postData, Headers);
        }
        private bool _IsDisposed;
        protected override void Dispose(bool disposing)
        {
            if (_IsDisposed) return;
            if (disposing)
            {
                _Environment = null;
                _IsDisposed = true;
            }
            base.Dispose(disposing);
        }
    }
    public class WebView2EnvironmentInterface : IDisposable
    {
        private ComObjectHolder<ICoreWebView2Environment> _Environment;
        private bool _IsDisposed;
        /// Wraps in SafeHandle so resources can be released if consumer forgets to call Dispose. Recommended
        ///             pattern for any type that is not sealed.
        ///             https://docs.microsoft.com/dotnet/api/system.idisposable#idisposable-and-the-inheritance-hierarchy
        private readonly SafeHandle handle = new SafeFileHandle(nint.Zero, true);
        private ICoreWebView2Environment Environment
        {
            get
            {
                if (_Environment == null)
                {
                    Debug.Print(nameof(WebView2EnvironmentInterface) + "." + nameof(Environment) + " is null");
                    throw new InvalidOperationException(nameof(WebView2EnvironmentInterface) + "." + nameof(Environment) + " is null");

                }
                return _Environment.Interface;
            }
            set => _Environment = new ComObjectHolder<ICoreWebView2Environment>(value);
        }
        public WebView2EnvironmentInterface(ICoreWebView2Environment environment)
        {
            Environment = environment ?? throw new ArgumentNullException(nameof(environment));
        }
        public void CreateCoreWebView2Controller(nint ParentWindow, [MarshalAs(UnmanagedType.Interface)] ICoreWebView2CreateCoreWebView2ControllerCompletedHandler handler)
        {
            Environment.CreateCoreWebView2Controller(ParentWindow, handler);
        }

        [return: MarshalAs(UnmanagedType.Interface)]
        public ICoreWebView2WebResourceResponse CreateWebResourceResponse([In, MarshalAs(UnmanagedType.Interface)] IStream Content, [In] int StatusCode, [In, MarshalAs(UnmanagedType.LPWStr)] string ReasonPhrase, [In, MarshalAs(UnmanagedType.LPWStr)] string Headers)
        {
            return Environment.CreateWebResourceResponse(Content, StatusCode, ReasonPhrase, Headers);
        }

        public string BrowserVersionString => Environment.GetBrowserVersionString();

        public void add_NewBrowserVersionAvailable([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2NewBrowserVersionAvailableEventHandler eventHandler, out EventRegistrationToken token)
        {
            Environment.add_NewBrowserVersionAvailable(eventHandler, out token);
        }

        public void remove_NewBrowserVersionAvailable([In] EventRegistrationToken token)
        {
            Environment.remove_NewBrowserVersionAvailable(token);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_IsDisposed)
            {
                if (disposing)
                {
                    handle.Dispose();
                    _Environment = null;
                }

                _IsDisposed = true;
            }
        }



        public void Dispose()
        {

            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
