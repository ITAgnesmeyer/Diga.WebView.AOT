using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;
using Microsoft.Win32.SafeHandles;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Wrapper.Implementation
{

    public class WebView2Frame4Interface : WebView2Frame3Interface //, ICoreWebView2Frame4
    {
        private ComObjectHolder<ICoreWebView2Frame4> _Args;
        private ICoreWebView2Frame4 Args
        {
            get
            {
                if (_Args == null)
                {
                    Debug.Print(nameof(WebView2Frame3Interface) + " Args is null");
                    throw new InvalidOperationException(nameof(WebView2Frame3Interface) + " Args is null");
                }

                return _Args.Interface;
            }
            set
            {
                _Args = new ComObjectHolder<ICoreWebView2Frame4>(value);
            }
        }

        public WebView2Frame4Interface(ICoreWebView2Frame4 args) : base(args)
        {
            if (args == null)
                throw new ArgumentNullException(nameof(args));
            Args = args;
        }

        public void PostSharedBufferToScript([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2SharedBuffer sharedBuffer, [In] COREWEBVIEW2_SHARED_BUFFER_ACCESS access, [In, MarshalAs(UnmanagedType.LPWStr)] string additionalDataAsJson)
        {
            Args.PostSharedBufferToScript(sharedBuffer, access, additionalDataAsJson);
        }

        private bool disposedValue;
        protected override void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {

                    _Args = null;
                }

                disposedValue = true;
            }
            base.Dispose(disposing);
        }
    }

    public class WebView2Frame3Interface : WebView2Frame2Interface
    {
        private ComObjectHolder<ICoreWebView2Frame3> _Args;
        private ICoreWebView2Frame3 Args
        {
            get
            {
                if (_Args == null)
                {
                    Debug.Print(nameof(WebView2Frame3Interface) + " Args is null");
                    throw new InvalidOperationException(nameof(WebView2Frame3Interface) + " Args is null");
                }

                return _Args.Interface;
            }
            set
            {
                _Args = new ComObjectHolder<ICoreWebView2Frame3>(value);
            }
        }

        public WebView2Frame3Interface(ICoreWebView2Frame3 args) : base(args)
        {
            if (args == null)
                throw new ArgumentNullException(nameof(args));
            Args = args;
        }
        public ICoreWebView2Frame3 GetInterface() => Args;

        public void add_PermissionRequested([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2FramePermissionRequestedEventHandler handler, out EventRegistrationToken token)
        {
            Args.add_PermissionRequested(handler, out token);
        }

        public void remove_PermissionRequested([In] EventRegistrationToken token)
        {
            Args.remove_PermissionRequested(token);
        }
        private bool disposedValue;
        protected override void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {

                    _Args = null;
                }

                disposedValue = true;
            }
            base.Dispose(disposing);
        }
    }
    public class WebView2Frame2Interface : WebView2FrameInterface
    {
        private ComObjectHolder<ICoreWebView2Frame2> _Args;
        private ICoreWebView2Frame2 Args
        {
            get
            {
                if (_Args == null)
                {
                    Debug.Print(nameof(WebView2Frame2Interface) + " Args is null");
                    throw new InvalidOperationException(nameof(WebView2Frame2Interface) + " Args is null");
                }

                return _Args.Interface;
            }
            set
            {
                _Args = new ComObjectHolder<ICoreWebView2Frame2>(value);
            }
        }

        public WebView2Frame2Interface(ICoreWebView2Frame2 args) : base(args)
        {
            if (args == null)
                throw new ArgumentNullException(nameof(args));
            Args = args;
        }
        public void add_NavigationStarting([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2FrameNavigationStartingEventHandler eventHandler, out EventRegistrationToken token)
        {
            Args.add_NavigationStarting(eventHandler, out token);
        }

        public void remove_NavigationStarting([In] EventRegistrationToken token)
        {
            Args.remove_NavigationStarting(token);
        }

        public void add_ContentLoading([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2FrameContentLoadingEventHandler eventHandler, out EventRegistrationToken token)
        {
            Args.add_ContentLoading(eventHandler, out token);
        }

        public void remove_ContentLoading([In] EventRegistrationToken token)
        {
            Args.remove_ContentLoading(token);
        }

        public void add_NavigationCompleted([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2FrameNavigationCompletedEventHandler eventHandler, out EventRegistrationToken token)
        {
            Args.add_NavigationCompleted(eventHandler, out token);
        }

        public void remove_NavigationCompleted([In] EventRegistrationToken token)
        {
            Args.remove_NavigationCompleted(token);
        }

        public void add_DOMContentLoaded([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2FrameDOMContentLoadedEventHandler eventHandler, out EventRegistrationToken token)
        {
            Args.add_DOMContentLoaded(eventHandler, out token);
        }

        public void remove_DOMContentLoaded([In] EventRegistrationToken token)
        {
            Args.remove_DOMContentLoaded(token);
        }

        public void ExecuteScript([In, MarshalAs(UnmanagedType.LPWStr)] string javaScript, [In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2ExecuteScriptCompletedHandler handler)
        {
            Args.ExecuteScript(javaScript, handler);
        }

        public void PostWebMessageAsJson([In, MarshalAs(UnmanagedType.LPWStr)] string webMessageAsJson)
        {
            Args.PostWebMessageAsJson(webMessageAsJson);
        }

        public void PostWebMessageAsString([In, MarshalAs(UnmanagedType.LPWStr)] string webMessageAsString)
        {
            Args.PostWebMessageAsString(webMessageAsString);
        }

        public void add_WebMessageReceived([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2FrameWebMessageReceivedEventHandler handler, out EventRegistrationToken token)
        {
            Args.add_WebMessageReceived(handler, out token);
        }

        public void remove_WebMessageReceived([In] EventRegistrationToken token)
        {
            Args.remove_WebMessageReceived(token);
        }

        private bool disposedValue;
        protected override void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {

                    _Args = null;
                }

                disposedValue = true;
            }
            base.Dispose(disposing);
        }
    }
    public class WebView2FrameInterface : IDisposable
    {
        private ComObjectHolder<ICoreWebView2Frame> _Args;
        private bool disposedValue;

        /// Wraps in SafeHandle so resources can be released if consumer forgets to call Dispose. Recommended
        ///             pattern for any type that is not sealed.
        ///             https://docs.microsoft.com/dotnet/api/system.idisposable#idisposable-and-the-inheritance-hierarchy
        private SafeHandle handle = new SafeFileHandle(nint.Zero, true);

        private ICoreWebView2Frame Args
        {
            get
            {
                if (_Args == null)
                {
                    Debug.Print(nameof(WebView2FrameInterface) + " Args is null");
                    throw new InvalidOperationException(nameof(WebView2FrameInterface) + " Args is null");
                }

                return _Args.Interface;
            }
            set
            {
                _Args = new ComObjectHolder<ICoreWebView2Frame>(value);
            }
        }

        public WebView2FrameInterface(ICoreWebView2Frame args)
        {
            if (args == null)
                throw new ArgumentNullException(nameof(args));
            Args = args;

        }
        public string name => Args.Getname();

        public void add_NameChanged([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2FrameNameChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            Args.add_NameChanged(eventHandler, out token);
        }

        public void remove_NameChanged([In] EventRegistrationToken token)
        {
            Args.remove_NameChanged(token);
        }

        public void AddHostObjectToScriptWithOrigins([In, MarshalAs(UnmanagedType.LPWStr)] string name, object @object, [In] uint originsCount, [In, MarshalAs(UnmanagedType.LPWStr)] string origins)
        {
            Args.AddHostObjectToScriptWithOrigins(name, @object, originsCount, origins);
        }

        public void RemoveHostObjectFromScript([In, MarshalAs(UnmanagedType.LPWStr)] string name)
        {
            Args.RemoveHostObjectFromScript(name);
        }

        public void add_Destroyed([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2FrameDestroyedEventHandler eventHandler, out EventRegistrationToken token)
        {
            Args.add_Destroyed(eventHandler, out token);
        }

        public void remove_Destroyed([In] EventRegistrationToken token)
        {
            Args.remove_Destroyed(token);
        }

        public int IsDestroyed()
        {
            return Args.IsDestroyed();
        }


        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    handle.Dispose();
                    _Args = null;
                }

                disposedValue = true;
            }
        }



        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }


    }
}
