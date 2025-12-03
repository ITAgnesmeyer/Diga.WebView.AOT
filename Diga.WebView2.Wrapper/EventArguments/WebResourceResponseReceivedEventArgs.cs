using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Implementation;

namespace Diga.WebView2.Wrapper.EventArguments
{
    public class WebResourceResponseReceivedEventArgs: WebResourceResponseReceivedEventArgsInterface
    {
        public WebResourceResponseReceivedEventArgs(ICoreWebView2WebResourceResponseReceivedEventArgs args):base(args)
        {
            
        }

        public new WebResourceRequest Request => new WebResourceRequest(base.Request);
       
     }
}
