using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Implementation;
using System.Security.Permissions;

namespace Diga.WebView2.Wrapper.EventArguments
{
    public class AcceleratorKeyPressedEventArgs : AcceleratorKeyPressedEventArgsInterface
    {
      
        public AcceleratorKeyPressedEventArgs(ICoreWebView2AcceleratorKeyPressedEventArgs args):base(args)
        {
        }



    }
}
