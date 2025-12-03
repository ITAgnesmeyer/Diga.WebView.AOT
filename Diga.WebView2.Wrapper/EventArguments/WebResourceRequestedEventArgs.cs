using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Implementation;

namespace Diga.WebView2.Wrapper.EventArguments
{

    public class WebResourceRequestedEventArgs: WebResourceRequestedEventArgsInterface
    {
        public WebResourceRequestedEventArgs(ICoreWebView2WebResourceRequestedEventArgs args):base(args) 
        {
            
        }
        public new WebResourceRequest Request => new WebResourceRequest(base.Request);
        public new WebResourceResponse Response
        {
            get
            {
                if (base.Response == null)
                {
                    return null;
                }
                return new WebResourceResponse(base.Response);
            }
            set
            {
                base.Response = value.ToInterface();
            }
        }
        public new WebView2Deferral GetDeferral() => new WebView2Deferral(base.GetDeferral());
    }
}
