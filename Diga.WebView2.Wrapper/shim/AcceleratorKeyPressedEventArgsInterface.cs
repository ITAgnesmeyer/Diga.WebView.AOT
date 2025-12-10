using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;
using System.Diagnostics;

namespace Diga.WebView2.Wrapper.shim
{




    public class AcceleratorKeyPressedEventArgsInterface //: ICoreWebView2AcceleratorKeyPressedEventArgs
    {
        private ComObjectHolder<ICoreWebView2AcceleratorKeyPressedEventArgs> _Args;
        private ICoreWebView2AcceleratorKeyPressedEventArgs Args
        {
            get
            {
                if (_Args == null)
                {
                    Debug.Print(nameof(AcceleratorKeyPressedEventArgsInterface) + "=>" + nameof(Args) + " is null");

                    throw new InvalidOperationException(nameof(AcceleratorKeyPressedEventArgsInterface) + "=>" + nameof(Args) + " is null");
                }
                return _Args.Interface;
            }
            set { _Args = new ComObjectHolder<ICoreWebView2AcceleratorKeyPressedEventArgs>(value); }
        }

        public AcceleratorKeyPressedEventArgsInterface(ICoreWebView2AcceleratorKeyPressedEventArgs args)
        {
            this.Args =args ?? throw new ArgumentNullException(nameof(args));
        }

        public COREWEBVIEW2_KEY_EVENT_KIND KeyEventKind => this.Args.GetKeyEventKind();

        public uint VirtualKey => this.Args.GetVirtualKey();

        public int KeyEventLParam => this.Args.GetKeyEventLParam();

        public COREWEBVIEW2_PHYSICAL_KEY_STATUS PhysicalKeyStatus => this.Args.GetPhysicalKeyStatus();

        public int Handled { get => this.Args.GetHandled(); set => this.Args.SetHandled(value); }
    }
}
