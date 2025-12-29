// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.tagPOINT
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1E8B0323-528E-4C9C-8FF8-A486637C87E1
// Assembly location: O:\webview2\V1096133\Diga.WebView2.Interop.dll

using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace Diga.WebView2.Interop
{
    [Guid("492AB1FF-FF27-4A23-93A8-540A4B9DAC37")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    [GeneratedComInterface]
    public partial interface IRpcObject
    {
        [return: MarshalAs(UnmanagedType.LPWStr)]
        string get_id();
        void set_id([MarshalAs(UnmanagedType.LPWStr)] string id);

        [return: MarshalAs(UnmanagedType.LPWStr)]
        string get_objId();

        void set_objId([MarshalAs(UnmanagedType.LPWStr)] string id);

        [return: MarshalAs(UnmanagedType.LPWStr)]
        string get_varname();

        void set_varname([MarshalAs(UnmanagedType.LPWStr)] string id);

        [return: MarshalAs(UnmanagedType.LPWStr)]
        string get_action();

        void set_action([MarshalAs(UnmanagedType.LPWStr)] string id);

        [return: MarshalAs(UnmanagedType.LPWStr)]
        string get_param();

        void set_param([MarshalAs(UnmanagedType.LPWStr)] string id);

        [return: MarshalAs(UnmanagedType.Interface)]
        object get_item();

        void set_item([MarshalAs(UnmanagedType.Interface)] object obj);

        [return: MarshalAs(UnmanagedType.LPWStr)]
        string idFullName();

        [return: MarshalAs(UnmanagedType.LPWStr)]
        string idName();
        [return: MarshalAs(UnmanagedType.Interface)]
        object Clone();
    }
}
