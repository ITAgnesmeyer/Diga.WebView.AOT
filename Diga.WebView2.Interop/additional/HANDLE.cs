using System;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct HANDLE
    {
        public nint handle;
    }
}
