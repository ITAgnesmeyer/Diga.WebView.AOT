using Diga.WebView2.Interop;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Wrapper
{
    internal partial class Native
    {
        public const string
            EXTERNAL_DLL = "lib\\Diga.WebView2.Native.dll";


        [LibraryImport(EXTERNAL_DLL, StringMarshalling = StringMarshalling.Utf16)]
        [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvStdcall) })]
        public static partial int ShowInfo();

        //[DllImport(EXTERNAL_DLL, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, SetLastError = true)]
        
        [LibraryImport(EXTERNAL_DLL, StringMarshalling = StringMarshalling.Utf16)]
        [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvStdcall) })]
        public static partial int CompareVersion(
            [MarshalAs(UnmanagedType.LPWStr)] string version1,
            [MarshalAs(UnmanagedType.LPWStr)] string version2,
            out int result);

        //[DllImport(EXTERNAL_DLL, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode,
        //    SetLastError = true)]
        [LibraryImport(EXTERNAL_DLL,StringMarshalling = StringMarshalling.Utf16)]
        [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvStdcall) })]
        public static partial  int GetAvailableVersion(
            [MarshalAs(UnmanagedType.LPWStr)] string browserExecutableFolder,
            [MarshalAs(UnmanagedType.LPWStr)] out string versionInfo);

        [LibraryImport(EXTERNAL_DLL)]
        [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvStdcall) })]
        public static partial int CreateEnvironment([MarshalAs(UnmanagedType.Interface)] ICoreWebView2CreateCoreWebView2EnvironmentCompletedHandler environmentCreatedHandler);

        //[DllImport(EXTERNAL_DLL, EntryPoint = "CreateEnvironment", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
        //public static extern int CreateEnvironmentX(IntPtr envecreateHandler);

        [LibraryImport(EXTERNAL_DLL, EntryPoint = "GetCurrentVersion", StringMarshalling = StringMarshalling.Utf16)]
        [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvStdcall) })]
        public static partial int GetCurrentVersion(out string versionInfo);

        [LibraryImport(EXTERNAL_DLL,EntryPoint = "CreateEnvironmentWithOptions", StringMarshalling = StringMarshalling.Utf16)]
        [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvStdcall) })]
        public unsafe static partial int CreateEnvironmentWithOptions(
            [MarshalAs(UnmanagedType.LPWStr)] string browserExecutableFolder,
            [MarshalAs(UnmanagedType.LPWStr)] string userDataFolder,
            [MarshalAs(UnmanagedType.Interface)] ICoreWebView2EnvironmentOptions   environmentOptions,
            [MarshalAs(UnmanagedType.Interface)] ICoreWebView2CreateCoreWebView2EnvironmentCompletedHandler environmentCreatedHandler);
       
        [DllImport("user32.dll", EntryPoint = "GetClientRect")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetClientRect([In] IntPtr hWnd, [Out] out RECT lpRect);

        [LibraryImport(EXTERNAL_DLL, EntryPoint = "CreateEnvironmentOptions",StringMarshalling = StringMarshalling.Utf16)]
        [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvStdcall) })]
        public unsafe static partial int CreateEnvironmentOptions([MarshalAs(UnmanagedType.Interface)]  out ICoreWebView2EnvironmentOptions5 environmentOptions);


        [LibraryImport(EXTERNAL_DLL, EntryPoint = "GetIDispatchVariant", StringMarshalling = StringMarshalling.Utf16)]
        [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvStdcall) })]
        public static partial int GetIDispatchVariant([MarshalAs(UnmanagedType.Interface)] object obj, nint varaint);


    }
}
