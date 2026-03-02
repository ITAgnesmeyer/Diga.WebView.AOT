using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace Diga.WebView2.Interop;

[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("3b149321-83c3-5d1f-b03f-a42899bc1c15")]
[GeneratedComInterface]
public partial interface ICoreWebView2DragStartingEventHandler
{
    void Invoke([MarshalAs(UnmanagedType.Interface)] ICoreWebView2CompositionController sender, [MarshalAs(UnmanagedType.Interface)] ICoreWebView2DragStartingEventArgs args);

}
