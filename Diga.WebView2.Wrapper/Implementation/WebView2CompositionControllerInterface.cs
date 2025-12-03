using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;
using Microsoft.Win32.SafeHandles;
using System.Diagnostics;
using System.Runtime.InteropServices;
namespace Diga.WebView2.Wrapper.Implementation
{
    public class WebView2CompositionController2Interface : WebView2CompositionControllerInterface
    {
        private ComObjectHolder<ICoreWebView2CompositionController2> _Controller;
        private ICoreWebView2CompositionController2 Controller
        {
            get
            {
                if (_Controller == null)
                {
                    Debug.Print(nameof(WebView2CompositionController2Interface) + "=>" + nameof(Controller) + " is null");

                    throw new InvalidOperationException(nameof(WebView2CompositionController2Interface) + "=>" + nameof(Controller) + " is null");
                }
                return _Controller.Interface;
            }
            set
            {
                _Controller = new ComObjectHolder<ICoreWebView2CompositionController2>(value);
            }
        }
        public WebView2CompositionController2Interface(ICoreWebView2CompositionController2 controller) : base(controller)
        {
            Controller = controller ?? throw new ArgumentNullException(nameof(controller));
        }
        public object UIAProvider => Controller.AutomationProvider();
        private bool _IsDisposed;
        protected override void Dispose(bool disposing)
        {
            if (_IsDisposed) return;

            if (disposing)
            {
                _Controller = null;
                _IsDisposed = true;
            }
            base.Dispose(disposing);
        }



    }
    public class WebView2CompositionControllerInterface : IDisposable
    {
        private ComObjectHolder<ICoreWebView2CompositionController> _Controller;
        private ICoreWebView2CompositionController Controller
        {
            get
            {
                if (_Controller == null)
                {
                    Debug.Print(nameof(WebView2CompositionControllerInterface) + "=>" + nameof(Controller) + " is null");

                    throw new InvalidOperationException(nameof(WebView2CompositionControllerInterface) + "=>" + nameof(Controller) + " is null");
                }
                return _Controller.Interface;
            }
            set => _Controller = new ComObjectHolder<ICoreWebView2CompositionController>(value);
        }

        /// Wraps in SafeHandle so resources can be released if consumer forgets to call Dispose. Recommended
        ///             pattern for any type that is not sealed.
        ///             https://docs.microsoft.com/dotnet/api/system.idisposable#idisposable-and-the-inheritance-hierarchy
        private SafeHandle handle = new SafeFileHandle(nint.Zero, true);
        public WebView2CompositionControllerInterface(ICoreWebView2CompositionController controller)
        {
            if (controller == null)
                throw new ArgumentNullException(nameof(controller));
            Controller = controller;

        }

        public object RootVisualTarget { get => Controller.GetRootVisualTarget(); set => Controller.SetRootVisualTarget(value); }

        public void SendMouseInput([In] COREWEBVIEW2_MOUSE_EVENT_KIND eventKind, [In] COREWEBVIEW2_MOUSE_EVENT_VIRTUAL_KEYS virtualKeys, [In] uint mouseData, [In] tagPOINT point)
        {
            Controller.SendMouseInput(eventKind, virtualKeys, mouseData, point);
        }

        public void SendPointerInput([In] COREWEBVIEW2_POINTER_EVENT_KIND eventKind, [In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2PointerInfo pointerInfo)
        {
            Controller.SendPointerInput(eventKind, pointerInfo);
        }

        public nint Cursor => Controller.GetCursor();

        public uint SystemCursorId => Controller.GetSystemCursorId();

        public void add_CursorChanged([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2CursorChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            Controller.add_CursorChanged(eventHandler, out token);
        }

        public void remove_CursorChanged([In] EventRegistrationToken token)
        {
            Controller.remove_CursorChanged(token);
        }

        private bool _IsDisposed;
        protected virtual void Dispose(bool disposing)
        {
            if (!_IsDisposed)
            {
                if (disposing)
                {
                    handle.Dispose();
                    _Controller = null;
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
