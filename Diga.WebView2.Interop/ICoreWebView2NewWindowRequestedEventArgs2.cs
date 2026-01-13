using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace Diga.WebView2.Interop;

[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("bbc7baed-74c6-4c92-b63a-7f5aeae03de3")]
[GeneratedComInterface]
public partial interface ICoreWebView2NewWindowRequestedEventArgs2 : ICoreWebView2NewWindowRequestedEventArgs
{
    [return: MarshalAs(UnmanagedType.LPWStr)]
    string GetName();

}
