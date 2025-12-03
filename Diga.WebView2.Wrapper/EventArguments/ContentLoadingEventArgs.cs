using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Implementation;
using Diga.WebView2.Wrapper.Types;
using Microsoft.Win32.SafeHandles;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Wrapper.EventArguments
{



   






    public class ContentLoadingEventArgs : EventArgs
    {
        public ContentLoadingEventArgs(bool isErrorPage, ulong navigationId)
        {
            this.IsErrorPage = isErrorPage;
            this.NavigationId = navigationId;
        }

        public bool IsErrorPage { get; }
        public ulong NavigationId { get; }

    }
}
