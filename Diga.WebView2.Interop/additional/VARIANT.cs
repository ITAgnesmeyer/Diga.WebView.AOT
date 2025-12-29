
using System;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{

    /// <summary>
    /// Binary-kompatibel zu Win32 VARIANT (x64).
    /// Größe: 24 bytes auf x64.
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Pack = 8)]
    public unsafe struct VARIANT
    {
        // --- "struct { VARTYPE vt; WORD r1; WORD r2; WORD r3; ... }"
        [FieldOffset(0)] public VARTYPE vt;
        [FieldOffset(2)] public ushort wReserved1;
        [FieldOffset(4)] public ushort wReserved2;
        [FieldOffset(6)] public ushort wReserved3;

        // --- union { ... } beginnt bei Offset 8 (auf x64)
        [FieldOffset(8)] public VariantUnion data;

        // --- äußeres union-Overlay: DECIMAL decVal; (überlappt ab Offset 0)
        // wReserved in DECIMAL liegt auf Offset 0 und teilt sich Speicher mit vt.
        [FieldOffset(0)] public DECIMAL decVal;

        [StructLayout(LayoutKind.Explicit)]
        public unsafe struct VariantUnion
        {
            // Werte (nicht-byref)
            [FieldOffset(0)] public long llVal;     // VT_I8
            [FieldOffset(0)] public int lVal;      // VT_I4
            [FieldOffset(0)] public byte bVal;      // VT_UI1
            [FieldOffset(0)] public short iVal;      // VT_I2
            [FieldOffset(0)] public float fltVal;    // VT_R4
            [FieldOffset(0)] public double dblVal;    // VT_R8
            [FieldOffset(0)] public short boolVal;   // VARIANT_BOOL (VT_BOOL), -1/0
            [FieldOffset(0)] public int scode;     // VT_ERROR
            [FieldOffset(0)] public long cyVal;     // CY ist 64-bit scaled int
            [FieldOffset(0)] public double date;      // DATE ist double
            [FieldOffset(0)] public IntPtr bstrVal;   // BSTR
            [FieldOffset(0)] public IntPtr punkVal;   // IUnknown*
            [FieldOffset(0)] public IntPtr pdispVal;  // IDispatch*
            [FieldOffset(0)] public IntPtr parray;    // SAFEARRAY*

            // ByRef-Zeiger
            [FieldOffset(0)] public byte* pbVal;
            [FieldOffset(0)] public short* piVal;
            [FieldOffset(0)] public int* plVal;
            [FieldOffset(0)] public long* pllVal;
            [FieldOffset(0)] public float* pfltVal;
            [FieldOffset(0)] public double* pdblVal;
            [FieldOffset(0)] public short* pboolVal;   // VARIANT_BOOL*
            [FieldOffset(0)] public int* pscode;
            [FieldOffset(0)] public long* pcyVal;
            [FieldOffset(0)] public double* pdate;
            [FieldOffset(0)] public IntPtr* pbstrVal;   // BSTR*
            [FieldOffset(0)] public IntPtr* ppunkVal;   // IUnknown**
            [FieldOffset(0)] public IntPtr* ppdispVal;  // IDispatch**
            [FieldOffset(0)] public IntPtr* pparray;    // SAFEARRAY**
            [FieldOffset(0)] public VARIANT* pvarVal;   // VARIANT*
            [FieldOffset(0)] public void* byref;      // generic

            // Weitere Integer-Typen
            [FieldOffset(0)] public sbyte cVal;     // VT_I1
            [FieldOffset(0)] public ushort uiVal;    // VT_UI2
            [FieldOffset(0)] public uint ulVal;    // VT_UI4
            [FieldOffset(0)] public ulong ullVal;   // VT_UI8
            [FieldOffset(0)] public int intVal;   // VT_INT
            [FieldOffset(0)] public uint uintVal;  // VT_UINT

            // RECORD
            [FieldOffset(0)] public BRECORD record;   // VT_RECORD
        }
    }
}
