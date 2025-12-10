using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.shim;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.EventArguments
{
    public class MoveFocusRequestedEventArgs: MoveFocusRequestedEventArgsInterface
    {
        public MoveFocusRequestedEventArgs(ICoreWebView2MoveFocusRequestedEventArgs args):base(args)
        {
            
        }

        public new bool Handled
        {
            get => (CBOOL)base.Handled;
            set => base.Handled = (CBOOL)value;
        }
    }
}
