// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.tagPOINT
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1E8B0323-528E-4C9C-8FF8-A486637C87E1
// Assembly location: O:\webview2\V1096133\Diga.WebView2.Interop.dll

using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
    /// <summary>
    /// COM DECIMAL (nicht .NET decimal!), exakt wie Win32 tagDEC.
    /// In VARIANT überlappt decVal.wReserved die vt-Position.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct DECIMAL
    {
        public ushort wReserved; // überlappt VARIANT.vt (ushort)
        public byte scale;
        public byte sign;
        public uint Hi32;
        public ulong Lo64;
    }
}
