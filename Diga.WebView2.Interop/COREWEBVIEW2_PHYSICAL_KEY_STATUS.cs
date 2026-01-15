using System;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop;

[StructLayout(LayoutKind.Sequential)]
public struct COREWEBVIEW2_PHYSICAL_KEY_STATUS
{
    /// <summary>Specifies the repeat count for the current message.</summary>
    public uint RepeatCount;
    /// <summary>Specifies the scan code.</summary>
    public uint ScanCode;
    /// <summary>Indicates that the key is an extended key.</summary>
    public bool IsExtendedKey;
    /// <summary>Indicates that a menu key is held down (context code).</summary>
    public bool IsMenuKeyDown;
    /// <summary>Indicates that the key was held down.</summary>
    public bool WasKeyDown;
    /// <summary>Indicates that the key was released.</summary>
    public bool IsKeyReleased;
}
