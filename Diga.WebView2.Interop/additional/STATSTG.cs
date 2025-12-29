

using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{


    [StructLayout(LayoutKind.Sequential,Pack =4)]
    public struct STATSTG
    {
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pwcsName;
        public uint type;
        public ulong cbSize;
        public FILETIME mtime;
        public FILETIME ctime;
        public FILETIME atime;
        public uint grfMode;
        public uint grfLocksSupported; [ComAliasName("Diga.WebView2.Interop.GUID")]
        public GUID clsid;
        public uint grfStateBits;
        public uint reserved;
    }
}
