using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.shim;

namespace Diga.WebView2.Wrapper.EventArguments
{
    public class ClientCertificateRequestedEventArgs : ClientCertificateRequestedEventArgsInterface
    {
        public ClientCertificateRequestedEventArgs(ICoreWebView2ClientCertificateRequestedEventArgs args) : base(args)
        {

        }
    }
}
