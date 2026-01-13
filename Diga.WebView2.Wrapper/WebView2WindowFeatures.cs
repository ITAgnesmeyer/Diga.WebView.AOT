using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.shim;

namespace Diga.WebView2.Wrapper
{
    public class WebView2WindowFeatures: CoreWebView2WindowFeaturesShim
    {
        public WebView2WindowFeatures(ICoreWebView2WindowFeatures args) : base(args)
        {
        }


    }
}
