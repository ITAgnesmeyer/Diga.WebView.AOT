using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace Diga.WebView2.Interop;

[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("34acb11c-fc37-4418-9132-f9c21d1eafb9")]
[GeneratedComInterface]
public partial interface ICoreWebView2NewWindowRequestedEventArgs
{
    [return: MarshalAs(UnmanagedType.LPWStr)]
    string GetUri();

    void SetNewWindow([MarshalAs(UnmanagedType.Interface)] ICoreWebView2 value);

    [return: MarshalAs(UnmanagedType.Interface)]
    ICoreWebView2 GetNewWindow();

    void SetHandled([MarshalAs(UnmanagedType.Bool)] bool value);

    [return: MarshalAs(UnmanagedType.Bool)]
    bool GetHandled();

    [return: MarshalAs(UnmanagedType.Bool)]
    bool GetIsUserInitiated();

    [return: MarshalAs(UnmanagedType.Interface)]
    ICoreWebView2Deferral GetDeferral();

    [return: MarshalAs(UnmanagedType.Interface)]
    ICoreWebView2WindowFeatures GetWindowFeatures();

}
