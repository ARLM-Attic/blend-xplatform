using System;
using System.Text;
using xPlatform.Flags;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace xPlatform.x86.gdi32
{
    [Serializable]
    public partial class gdi32 : ModuleBase<gdi32>
    {
        [NonSerialized]
        public const string ModuleName = "gdi32.dll";
    }

    #region Bitmap functions

    partial class gdi32
    {
        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AlphaBlend(
            [In] IntPtr hdcDest,
            [In] int nXOriginDest,
            [In] int nYOriginDest,
            [In] int nWidthDest,
            [In] int nHeightDest,
            [In] IntPtr hdcSrc,
            [In] int nXOriginSrc,
            [In] int nYOriginSrc,
            [In] int nWidthSrc,
            [In] int nHeightSrc,
            [In] BLENDFUNCTION blendFunction);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int BitBlt(
            [In] IntPtr hdcDest,
            [In] int nXDest,
            [In] int nYDest,
            [In] int nWidth,
            [In] int nHeight,
            [In] IntPtr hdcSrc,
            [In] int nXSrc,
            [In] int nYSrc,
            [In] uint dwRop);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern IntPtr CreateBitmap(
            [In] int nWidth,
            [In] int nHeight,
            [In] uint cPlanes,
            [In] uint cBitsPerPel,
            [In, Const] IntPtr lpvBits);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern IntPtr CreateBitmapIndirect(
            [In, Const] IntPtr lpbm);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern IntPtr CreateBitmapIndirect(
            [In, Const] ref BITMAP lpbm);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern IntPtr CreateCompatibleBitmap(
            [In] IntPtr hdc,
            [In] int nWidth,
            [In] int nHeight);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern IntPtr CreateDIBitmap(
            [In] IntPtr hdc,
            [In, Const] IntPtr lpbmih,
            [In] uint fdwInit,
            [In, Const] IntPtr lpbInit,
            [In, Const] IntPtr lpbmi,
            [In] uint fuUsage);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern IntPtr CreateDIBitmap(
            [In] IntPtr hdc,
            [In, Const] ref BITMAPINFOHEADER lpbmih,
            [In] uint fdwInit,
            [In, Const] IntPtr lpbInit,
            [In, Const] ref BITMAPINFO lpbmi,
            [In] uint fuUsage);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern IntPtr CreateDIBSection(
            [In] IntPtr hdc,
            [In, Const] IntPtr pbmi,
            [In] uint iUsage,
            [Out] IntPtr ppvBits,
            [In] IntPtr hSection,
            [In] uint dwOffset);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern IntPtr CreateDIBSection(
            [In] IntPtr hdc,
            [In, Const] ref BITMAPINFO pbmi,
            [In] uint iUsage,
            [Out] out IntPtr ppvBits,
            [In] IntPtr hSection,
            [In] uint dwOffset);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int ExtFloodFill(
            [In] IntPtr hdc,
            [In] int nXStart,
            [In] int nYStart,
            [In] uint crColor,
            [In] uint fuFillType);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GetBitmapDimensionsEx(
            [In] IntPtr hBitmap,
            [Out] IntPtr lpDimension);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GetBitmapDimensionsEx(
            [In] IntPtr hBitmap,
            [Out] out SIZE lpDimension);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetDIBColorTable(
            [In] IntPtr hdc,
            [In] uint uStartIndex,
            [In] uint cEntries,
            [Out] IntPtr pColors);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetDIBColorTable(
            [In] IntPtr hdc,
            [In] uint uStartIndex,
            [In] uint cEntries,
            [Out] RGBQUAD[] pColors);
    }

    #endregion // Bitmap functions
}
