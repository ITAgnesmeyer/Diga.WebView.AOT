using Diga.WebView2.Interop;
using System.Runtime.InteropServices.Marshalling;

namespace TestWindow
{
    [GeneratedComClass]
    public partial class MyHostInvokeTarget : IHostInvokeTarget
    {
        public int InvokeByName(
            string memberName,
            ushort dispatchFlags,
            string jsonArgs,
            out string bstrResult)
        {
            // DispatchFlags auswerten, JSON parsen, Methode/Property ausführen
            bstrResult = "{\"ok\":true,\"result\":3}";
            return 0; // S_OK
        }
    }
}
