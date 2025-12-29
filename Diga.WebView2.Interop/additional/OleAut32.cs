

using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
    public static partial class OleAut32
    {
        [LibraryImport("oleaut32.dll")]
        public static partial void VariantInit(out VARIANT pvarg);

        [LibraryImport("oleaut32.dll")]
        public static partial int VariantClear(ref VARIANT pvarg); // returns HRESULT
    }
}
