// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.tagPOINT
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1E8B0323-528E-4C9C-8FF8-A486637C87E1
// Assembly location: O:\webview2\V1096133\Diga.WebView2.Interop.dll

using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace Diga.WebView2.Interop
{


    [Guid("EF53ABF2-4216-40D3-AB11-02D31EF37C49")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    [GeneratedComInterface]
    public unsafe partial interface IRpcHandler : IDispatch
    {
        [DispId(1)]
        [return: MarshalAs(UnmanagedType.Interface)]
        object GetNewRpc();
        [DispId(2)]
        void UnloadDom();
        [DispId(3)]
        [return: MarshalAs(UnmanagedType.Bool)]
        bool ReleaseObject([MarshalAs(UnmanagedType.Interface)] object obj);
        [DispId(4)]
        [return: MarshalAs(UnmanagedType.Bool)]
        bool Handle([MarshalAs(UnmanagedType.LPWStr)] string id, [MarshalAs(UnmanagedType.LPWStr)] string eventName, [MarshalAs(UnmanagedType.Interface)] object obj);

    }
}
