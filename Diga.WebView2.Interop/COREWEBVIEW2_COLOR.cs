using System;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop;

[StructLayout(LayoutKind.Sequential)]
public struct COREWEBVIEW2_COLOR
{
    /// <summary>255 is opaque.</summary>
    public byte A;
    /// <summary>Specifies the intensity of the Red color.</summary>
    public byte R;
    /// <summary>Specifies the intensity of the Green color.</summary>
    public byte G;
    /// <summary>Specifies the intensity of the Blue color.</summary>
    public byte B;
}
