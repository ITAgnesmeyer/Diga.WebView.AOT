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
    [Guid("B952EA6F-C1BA-4A0E-8B8D-446234D8D23A")] // MUSS zu IID_IHostInvokeTarget in C++ passen
    public partial interface IHostInvokeTarget
    {
        // COM-Style Callback:
        // - HRESULT als Rückgabewert (PreserveSig)
        // - BSTR als Ergebnis (Ownership: C++ muss SysFreeString aufrufen)
        [PreserveSig]
        int InvokeByName(
            string memberName,
            ushort dispatchFlags,    // DISPATCH_METHOD / DISPATCH_PROPERTYGET / DISPATCH_PROPERTYPUT
            string jsonArgs,
            [MarshalUsing(typeof(BStrStringMarshaller))] out string bstrResult
        );
    }
}
