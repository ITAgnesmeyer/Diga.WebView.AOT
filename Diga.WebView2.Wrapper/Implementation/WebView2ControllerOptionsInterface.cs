using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;
using Microsoft.Win32.SafeHandles;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Wrapper.Implementation
{
    public class WebView2ControllerOptions2Interface : WebView2ControllerOptionsInterface //, ICoreWebView2ControllerOptions2
    {
        private ComObjectHolder<ICoreWebView2ControllerOptions2> _Options;
        private bool _IsDesposed;
        private ICoreWebView2ControllerOptions2 Options
        {
            get
            {
                if (_Options == null)
                {
                    Debug.Print(nameof(WebView2ControllerOptionsInterface) + "WebView2ControllerOptions2Interface is null");

                    throw new InvalidOperationException("WebView2ControllerOptions2Interface is null!");
                }

                return _Options.Interface;
            }
            set => _Options = new ComObjectHolder<ICoreWebView2ControllerOptions2>(value);
        }
        public WebView2ControllerOptions2Interface(ICoreWebView2ControllerOptions2 options) : base(options)
        {
            Options = options ?? throw new ArgumentNullException(nameof(options));
        }

        public string ScriptLocale { get => Options.GetScriptLocale(); set => Options.SetScriptLocale(value); }
        protected override void Dispose(bool disposing)
        {
            if (!_IsDesposed)
            {
                if (disposing)
                {
                    _Options = null;
                }
                _IsDesposed = true;
            }

            base.Dispose(disposing);
        }
    }
    public class WebView2ControllerOptionsInterface : IDisposable
    {
        private ComObjectHolder<ICoreWebView2ControllerOptions> _Options;
        private bool _IsDesposed;

        /// Wraps in SafeHandle so resources can be released if consumer forgets to call Dispose. Recommended
        ///             pattern for any type that is not sealed.
        ///             https://docs.microsoft.com/dotnet/api/system.idisposable#idisposable-and-the-inheritance-hierarchy
        private SafeHandle handle = new SafeFileHandle(nint.Zero, true);


        private ICoreWebView2ControllerOptions Options
        {
            get
            {
                if (_Options == null)
                {
                    Debug.Print(nameof(WebView2ControllerOptionsInterface) + "WebView2ControllerOptionsInterface is null");

                    throw new InvalidOperationException("WebView2ControllerOptionsInterface is null!");
                }

                return _Options.Interface;
            }
            set => _Options = new ComObjectHolder<ICoreWebView2ControllerOptions>(value);
        }

        public WebView2ControllerOptionsInterface(ICoreWebView2ControllerOptions options)
        {
            Options = options ?? throw new ArgumentNullException(nameof(options));
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_IsDesposed)
            {
                if (disposing)
                {
                    handle.Dispose();
                    _Options = null;
                }


                _IsDesposed = true;
            }
        }


        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        public string ProfileName { get => Options.GetProfileName(); set => Options.SetProfileName(value); }
        public int IsInPrivateModeEnabled { get => Options.GetIsInPrivateModeEnabled(); set => Options.SetIsInPrivateModeEnabled(value); }
    }
}
