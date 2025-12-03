using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Implementation;

namespace Diga.WebView2.Wrapper
{
    public class CookieList: CookieListInterface
    {
        public CookieList(ICoreWebView2CookieList args):base(args)
        {
            
        }

        public new Cookie GetValueAtIndex(uint index)
        {
            var c = base.GetValueAtIndex(index);
            return new Cookie(c);
        }
    }
}
