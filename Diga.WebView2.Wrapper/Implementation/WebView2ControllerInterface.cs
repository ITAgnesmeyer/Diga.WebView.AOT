using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;
using Microsoft.Win32.SafeHandles;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Wrapper.Implementation
{

    public class WebView2Controller4Interface : WebView2Controller3Interface
    {
        private ComObjectHolder<ICoreWebView2Controller4> _Controller;
        private ICoreWebView2Controller4 Controller
        {
            get
            {
                if (_Controller == null)
                {
                    Debug.Print(nameof(WebView2Controller4Interface) + "=>" + nameof(Controller) + " is null");

                    throw new InvalidOperationException(nameof(WebView2Controller4Interface) + "=>" + nameof(Controller) + " is null");
                }
                return _Controller.Interface;
            }
            set => _Controller = new ComObjectHolder<ICoreWebView2Controller4>(value);
        }
        public WebView2Controller4Interface(ICoreWebView2Controller4 controller) : base(controller)
        {
            Controller = controller ?? throw new ArgumentNullException(nameof(controller));
        }

        public int AllowExternalDrop { get => Controller.GetAllowExternalDrop(); set => Controller.SetAllowExternalDrop(value); }
    }
    public class WebView2Controller3Interface : WebView2Controller2Interface
    {
        private ComObjectHolder<ICoreWebView2Controller3> _Controller;
        public WebView2Controller3Interface(ICoreWebView2Controller3 controller) : base(controller)
        {
            if (controller == null)
                throw new ArgumentNullException(nameof(controller));

            Controller = controller;
        }
        public double RasterizationScale { get => Controller.GetRasterizationScale(); set => Controller.SetRasterizationScale(value); }
        public int ShouldDetectMonitorScaleChanges { get => Controller.GetShouldDetectMonitorScaleChanges(); set => Controller.SetShouldDetectMonitorScaleChanges(value); }

        public void add_RasterizationScaleChanged(ICoreWebView2RasterizationScaleChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            Controller.add_RasterizationScaleChanged(eventHandler, out token);
        }

        public void remove_RasterizationScaleChanged([In] EventRegistrationToken token)
        {
            Controller.remove_RasterizationScaleChanged(token);
        }

        public COREWEBVIEW2_BOUNDS_MODE BoundsMode { get => Controller.GetBoundsMode(); set => Controller.SetBoundsMode(value); }
        private ICoreWebView2Controller3 Controller
        {
            get
            {
                if (_Controller == null)
                {
                    Debug.Print(nameof(WebView2Controller3Interface) + "=>" + nameof(Controller) + " is null");

                    throw new InvalidOperationException(nameof(WebView2Controller3Interface) + "=>" + nameof(Controller) + " is null");
                }
                return _Controller.Interface;
            }
            set => _Controller = new ComObjectHolder<ICoreWebView2Controller3>(value);
        }

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
    public class WebView2Controller2Interface : WebView2ControllerInterface
    {
        private ComObjectHolder<ICoreWebView2Controller2> _Controller;
        public WebView2Controller2Interface(ICoreWebView2Controller2 controller) : base(controller)
        {
            if (controller == null)
                throw new ArgumentNullException(nameof(controller));

            Controller = controller;
        }
        public COREWEBVIEW2_COLOR DefaultBackgroundColor { get => Controller.GetDefaultBackgroundColor(); set => Controller.SetDefaultBackgroundColor(value); }
        private ICoreWebView2Controller2 Controller
        {
            get
            {
                if (_Controller == null)
                {
                    Debug.Print(nameof(WebView2Controller2Interface) + "=>" + nameof(Controller) + " is null");

                    throw new InvalidOperationException(nameof(WebView2Controller2Interface) + "=>" + nameof(Controller) + " is null");
                }
                return _Controller.Interface;
            }
            set => _Controller = new ComObjectHolder<ICoreWebView2Controller2>(value);
        }

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
    public class WebView2ControllerInterface : IDisposable
    {
        private ComObjectHolder<ICoreWebView2Controller> _Controller;
        private bool _IsDesposed;

        /// Wraps in SafeHandle so resources can be released if consumer forgets to call Dispose. Recommended
        ///             pattern for any type that is not sealed.
        ///             https://docs.microsoft.com/dotnet/api/system.idisposable#idisposable-and-the-inheritance-hierarchy
        private SafeHandle handle = new SafeFileHandle(nint.Zero, true);
        public WebView2ControllerInterface(ICoreWebView2Controller controller)
        {
            Controller = controller ?? throw new ArgumentNullException(nameof(controller));
        }
        public int IsVisible { get => Controller.GetIsVisible(); set => Controller.SetIsVisible(value); }
        public RECT Bounds { get => Controller.GetBounds(); set => Controller.SetBounds(value); }
        public double ZoomFactor { get => Controller.GetZoomFactor(); set => Controller.SetZoomFactor(value); }

        public void add_ZoomFactorChanged([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2ZoomFactorChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            Controller.add_ZoomFactorChanged(eventHandler, out token);
        }

        public void remove_ZoomFactorChanged([In] EventRegistrationToken token)
        {
            Controller.remove_ZoomFactorChanged(token);
        }

        public void SetBoundsAndZoomFactor([In] RECT Bounds, [In] double ZoomFactor)
        {
            Controller.SetBoundsAndZoomFactor(Bounds, ZoomFactor);
        }

        public void MoveFocus([In] COREWEBVIEW2_MOVE_FOCUS_REASON reason)
        {
            Controller.MoveFocus(reason);
        }

        public void add_MoveFocusRequested([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2MoveFocusRequestedEventHandler eventHandler, out EventRegistrationToken token)
        {
            Controller.add_MoveFocusRequested(eventHandler, out token);
        }

        public void remove_MoveFocusRequested([In] EventRegistrationToken token)
        {
            Controller.remove_MoveFocusRequested(token);
        }

        public void add_GotFocus([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2FocusChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            Controller.add_GotFocus(eventHandler, out token);
        }

        public void remove_GotFocus([In] EventRegistrationToken token)
        {
            Controller.remove_GotFocus(token);
        }

        public void add_LostFocus([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2FocusChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            Controller.add_LostFocus(eventHandler, out token);
        }

        public void remove_LostFocus([In] EventRegistrationToken token)
        {
            Controller.remove_LostFocus(token);
        }

        public void add_AcceleratorKeyPressed([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2AcceleratorKeyPressedEventHandler eventHandler, out EventRegistrationToken token)
        {
            Controller.add_AcceleratorKeyPressed(eventHandler, out token);
        }

        public void remove_AcceleratorKeyPressed([In] EventRegistrationToken token)
        {
            Controller.remove_AcceleratorKeyPressed(token);
        }

        public nint ParentWindow { get => Controller.GetParentWindow(); set => Controller.SetParentWindow(value); }

        public void NotifyParentWindowPositionChanged()
        {
            Controller.NotifyParentWindowPositionChanged();
        }

        public void Close()
        {
            try
            {
                Controller.Close();
            }
            catch (Exception ex)
            {
                Debug.Print("Controller.Close Exception:" + ex.ToString());

            }


        }

        public ICoreWebView2 CoreWebView2 => Controller.GetCoreWebView2();

        private ICoreWebView2Controller Controller
        {
            get
            {
                if (_Controller == null)
                {
                    Debug.Print(nameof(WebView2ControllerInterface) + "Controller is null");

                    throw new InvalidOperationException("Controller is null!");
                }

                return _Controller.Interface;
            }
            set => _Controller = new ComObjectHolder<ICoreWebView2Controller>(value);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_IsDesposed)
            {
                if (disposing)
                {
                    handle.Dispose();
                    _Controller = null;
                }


                _IsDesposed = true;
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
