// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.tagPOINT
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1E8B0323-528E-4C9C-8FF8-A486637C87E1
// Assembly location: O:\webview2\V1096133\Diga.WebView2.Interop.dll

using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace Diga.WebView2.Interop
{


    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    [Guid("00020400-0000-0000-C000-000000000046")]
    [GeneratedComInterface]
    public unsafe partial interface IDispatch
    {
        // HRESULT GetTypeInfoCount([out] UINT* pctinfo) :contentReference[oaicite:2]{index=2}
        [PreserveSig]
        int GetTypeInfoCount(out uint pctinfo);

        // HRESULT GetTypeInfo(UINT iTInfo, LCID lcid, ITypeInfo** ppTInfo)
        // ITypeInfo* als nint, weil du die Implementierung selbst machst.
        [PreserveSig]
        int GetTypeInfo(uint iTInfo, uint lcid, out nint ppTInfo);

        // HRESULT GetIDsOfNames(REFIID riid, LPOLESTR* rgszNames, UINT cNames, LCID lcid, DISPID* rgDispId) :contentReference[oaicite:3]{index=3}
        [PreserveSig]
        int GetIDsOfNames(in Guid riid, char** rgszNames, uint cNames, uint lcid, int* rgDispId);

        // HRESULT Invoke(DISPID dispIdMember, REFIID riid, LCID lcid, WORD wFlags,
        //               DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, UINT* puArgErr) :contentReference[oaicite:4]{index=4}
        [PreserveSig]
        int Invoke(
            int dispIdMember,
            in Guid riid,
            uint lcid,
            ushort wFlags,
            DISPPARAMS* pDispParams,
            VARIANT* pVarResult,
            EXCEPINFO* pExcepInfo,
            uint* puArgErr);
    }
}
