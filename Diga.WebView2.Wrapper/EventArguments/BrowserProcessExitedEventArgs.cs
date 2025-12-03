using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Implementation;

namespace Diga.WebView2.Wrapper.EventArguments
{
    public class BrowserProcessExitedEventArgs : BrowserProcessExitedEventArgsInterface
    {
        

        public BrowserProcessExitedEventArgs(ICoreWebView2BrowserProcessExitedEventArgs iface) : base(iface)
        {

        }
    }
}
