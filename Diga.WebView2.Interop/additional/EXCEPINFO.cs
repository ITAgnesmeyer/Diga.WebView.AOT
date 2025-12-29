// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.tagPOINT
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1E8B0323-528E-4C9C-8FF8-A486637C87E1
// Assembly location: O:\webview2\V1096133\Diga.WebView2.Interop.dll

using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
    [StructLayout(LayoutKind.Sequential)]
    public struct EXCEPINFO
    {
        public ushort wCode;
        public ushort wReserved;
        public nint bstrSource;       // BSTR
        public nint bstrDescription;  // BSTR
        public nint bstrHelpFile;     // BSTR
        public uint dwHelpContext;
        public nint pvReserved;
        public nint pfnDeferredFillIn;
        public int scode;            // SCODE/HRESULT
    }
}
