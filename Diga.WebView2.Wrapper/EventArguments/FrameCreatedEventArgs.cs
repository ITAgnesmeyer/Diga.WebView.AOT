using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.shim;

namespace Diga.WebView2.Wrapper.EventArguments
{

    public class FrameCreatedEventArgs: FrameCreatedEventArgsInterface
    {
        public FrameCreatedEventArgs(ICoreWebView2FrameCreatedEventArgs args):base(args)
        {
            
        }

        public new Frame Frame => new Frame((ICoreWebView2Frame4)base.Frame);
    }
}
