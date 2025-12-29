// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.tagPOINT
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1E8B0323-528E-4C9C-8FF8-A486637C87E1
// Assembly location: O:\webview2\V1096133\Diga.WebView2.Interop.dll

using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace Diga.WebView2.Interop
{
    [GeneratedComInterface(StringMarshalling = StringMarshalling.Utf16)]
    [Guid("6205965B-1A33-4AF8-9FEE-FD2B1A9FBE49")] // <-- MUSS zu deiner C++ IID_IHostWrapper passen
    public partial interface IHostWrapper
    {
        // COM-Style: HRESULT (int) + out-Parameter
        // (Keine Exceptions über die COM-Grenze)
        [PreserveSig]
        int add_HostInvokeTarget(
            IHostInvokeTarget target,
            out EventRegistrationToken token);

        [PreserveSig]
        int remove_HostInvokeTarget(
            EventRegistrationToken token);
    }
}
