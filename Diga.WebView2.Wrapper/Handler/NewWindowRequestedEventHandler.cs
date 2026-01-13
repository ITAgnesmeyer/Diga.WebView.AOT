using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;
using System.Diagnostics;
using System.Runtime.InteropServices.Marshalling;

namespace Diga.WebView2.Wrapper
{

    [GeneratedComClass]
    public partial class NewWindowRequestedEventHandler : ICoreWebView2NewWindowRequestedEventHandler
    {
        public event EventHandler<NewWindowRequestedEventArgs> NewWindowRequested;

        protected virtual void OnNewWindowRequested(NewWindowRequestedEventArgs e)
        {
            NewWindowRequested?.Invoke(this, e);
        }

        public void Invoke(ICoreWebView2 sender, ICoreWebView2NewWindowRequestedEventArgs args)
        {
            try
            {
                object arg = args;

                //args.SetHandled(true);


                if (arg is ICoreWebView2NewWindowRequestedEventArgs3 args3)
                {
                    OnNewWindowRequested(new NewWindowRequestedEventArgs(args3));
                    return;
                }

                //OnNewWindowRequested(new NewWindowRequestedEventArgs((ICoreWebView2NewWindowRequestedEventArgs3)arg));
            }
            catch (Exception ex)
            {
                Debug.Print("NewWindowRequestedEventHandler Exception:" + ex.ToString());

            }

        }
    }
}
