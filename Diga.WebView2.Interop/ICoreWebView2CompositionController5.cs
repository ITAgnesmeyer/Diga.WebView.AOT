using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace Diga.WebView2.Interop;

[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("8d0f82eb-7c33-5a4c-9108-84ca28ccc3b4")]
[GeneratedComInterface]
public partial interface ICoreWebView2CompositionController5 : ICoreWebView2CompositionController4
{
    void add_DragStarting([MarshalAs(UnmanagedType.Interface)] ICoreWebView2DragStartingEventHandler eventHandler, out EventRegistrationToken token);

    void remove_DragStarting(EventRegistrationToken token);

}
