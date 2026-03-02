using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace Diga.WebView2.Interop;

[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("8b8d9c7e-2f1a-4e6b-9d5a-3c8f7b9e1a2d")]
[GeneratedComInterface]
public partial interface ICoreWebView2DragStartingEventArgs
{
    uint GetAllowedDropEffects();

    IDataObject GetData();

    [return: MarshalAs(UnmanagedType.Bool)]
    bool GetHandled();

    void SetHandled([MarshalAs(UnmanagedType.Bool)] bool value);

    POINT GetPosition();

    [return: MarshalAs(UnmanagedType.Interface)]
    ICoreWebView2Deferral GetDeferral();

}
