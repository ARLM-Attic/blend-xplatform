using System;
using System.Text;
using xPlatform.Flags;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace xPlatform.x86.gdi32
{
    [Serializable]
    public partial class gdi32 : ModuleBase
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

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetDIBits(
            [In] IntPtr hdc,
            [In] IntPtr hbmp,
            [In] uint uStartScan,
            [In] uint cScanLines,
            [Out] IntPtr lpvBits,
            [In, Out] IntPtr lpbi,
            [In] uint uUsage);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetDIBits(
            [In] IntPtr hdc,
            [In] IntPtr hbmp,
            [In] uint uStartScan,
            [In] uint cScanLines,
            [Out] IntPtr lpvBits,
            [In, Out] ref BITMAPINFO lpbi,
            [In] uint uUsage);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetPixel(
            [In] IntPtr hdc,
            [In] int nXPos,
            [In] int nYPos);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GetStretchBltMode(
            [In] IntPtr hdc);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GradientFill(
            [In] IntPtr hdc,
            [In] IntPtr pVertex,
            [In] uint dwNumVertex,
            [In] IntPtr pMesh,
            [In] uint dwNumMesh,
            [In] uint dwMode);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GradientFill(
            [In] IntPtr hdc,
            [In] TRIVERTEX[] pVertex,
            [In] uint dwNumVertex,
            [In] IntPtr pMesh,
            [In] uint dwNumMesh,
            [In] uint dwMode);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GradientFill(
            [In] IntPtr hdc,
            [In] IntPtr pVertex,
            [In] uint dwNumVertex,
            [In] GRADIENT_TRIANGLE[] pMesh,
            [In] uint dwNumMesh,
            [In] uint dwMode);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GradientFill(
            [In] IntPtr hdc,
            [In] TRIVERTEX[] pVertex,
            [In] uint dwNumVertex,
            [In] GRADIENT_TRIANGLE[] pMesh,
            [In] uint dwNumMesh,
            [In] uint dwMode);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GradientFill(
            [In] IntPtr hdc,
            [In] IntPtr pVertex,
            [In] uint dwNumVertex,
            [In] GRADIENT_RECT[] pMesh,
            [In] uint dwNumMesh,
            [In] uint dwMode);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GradientFill(
            [In] IntPtr hdc,
            [In] TRIVERTEX[] pVertex,
            [In] uint dwNumVertex,
            [In] GRADIENT_RECT[] pMesh,
            [In] uint dwNumMesh,
            [In] uint dwMode);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern IntPtr LoadBitmapA(
            [In] IntPtr hInstance,
            [In, Const] IntPtr lpBitmapName);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi)]
        public static extern IntPtr LoadBitmapA(
            [In] IntPtr hInstance,
            [In] string lpBitmapName);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern IntPtr LoadBitmapW(
            [In] IntPtr hInstance,
            [In, Const] IntPtr lpBitmapName);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr LoadBitmapW(
            [In] IntPtr hInstance,
            [In] string lpBitmapName);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int MaskBlt(
            [In] IntPtr hdcDest,
            [In] int nXDest,
            [In] int nYDest,
            [In] int nWidth,
            [In] int nHeight,
            [In] IntPtr hdcSrc,
            [In] int nXSrc,
            [In] int nYSrc,
            [In] IntPtr hbmMask,
            [In] int xMask,
            [In] int yMask,
            [In] uint dwRop);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int PlgBlt(
            [In] IntPtr hdcDest,
            [In, Const] IntPtr lpPoint,
            [In] IntPtr hdcSrc,
            [In] int nXSrc,
            [In] int nYSrc,
            [In] int nWidth,
            [In] int nHeight,
            [In] IntPtr hbmMask,
            [In] int xMask,
            [In] int yMask);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int PlgBlt(
            [In] IntPtr hdcDest,
            [In, Const] POINT[] lpPoint,
            [In] IntPtr hdcSrc,
            [In] int nXSrc,
            [In] int nYSrc,
            [In] int nWidth,
            [In] int nHeight,
            [In] IntPtr hbmMask,
            [In] int xMask,
            [In] int yMask);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int SetBitmapDimensionEx(
            [In] IntPtr hBitmap,
            [In] int nWidth,
            [In] int nHeight,
            [Out] IntPtr lpSize);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int SetBitmapDimensionEx(
            [In] IntPtr hBitmap,
            [In] int nWidth,
            [In] int nHeight,
            [Out] out SIZE lpSize);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint SetDIBColorTable(
            [In] IntPtr hdc,
            [In] uint uStartIndex,
            [In] uint cEntries,
            [In, Const] IntPtr pColors);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint SetDIBColorTable(
            [In] IntPtr hdc,
            [In] uint uStartIndex,
            [In] uint cEntries,
            [In, Const] RGBQUAD[] pColors);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int SetDIBits(
            [In] IntPtr hdc,
            [In] IntPtr hbmp,
            [In] uint uStartScan,
            [In] uint cScanLines,
            [In, Const] IntPtr lpvBits,
            [In, Const] IntPtr lpbmi,
            [In] uint fuColorUse);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int SetDIBits(
            [In] IntPtr hdc,
            [In] IntPtr hbmp,
            [In] uint uStartScan,
            [In] uint cScanLines,
            [In, Const] IntPtr lpvBits,
            [In, Const] ref BITMAPINFO lpbmi,
            [In] uint fuColorUse);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int SetDIBitsToDevice(
            [In] IntPtr hdc,
            [In] int XDest,
            [In] int YDest,
            [In] uint dwWidth,
            [In] uint dwHeight,
            [In] int XSrc,
            [In] int YSrc,
            [In] uint uStartScan,
            [In] uint cScanLines,
            [In, Const] IntPtr lpvBits,
            [In, Const] IntPtr lpbmi,
            [In] uint fuColorUse);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int SetDIBitsToDevice(
            [In] IntPtr hdc,
            [In] int XDest,
            [In] int YDest,
            [In] uint dwWidth,
            [In] uint dwHeight,
            [In] int XSrc,
            [In] int YSrc,
            [In] uint uStartScan,
            [In] uint cScanLines,
            [In, Const] IntPtr lpvBits,
            [In, Const] ref BITMAPINFO lpbmi,
            [In] uint fuColorUse);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint SetPixel(
            [In] IntPtr hdc,
            [In] int X,
            [In] int Y,
            [In] uint crColor);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int SetPixelV(
            [In] IntPtr hdc,
            [In] int X,
            [In] int Y,
            [In] uint crColor);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int SetStretchBltMode(
            [In] IntPtr hdc,
            [In] int iStretchMode);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int StretchBlt(
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
            [In] uint dwRop);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int StretchDIBits(
            [In] IntPtr hdc,
            [In] int XDest,
            [In] int YDest,
            [In] int nDestWidth,
            [In] int nDestHeight,
            [In] int XSrc,
            [In] int YSrc,
            [In] int nSrcWidth,
            [In] int nSrcHeight,
            [In, Const] IntPtr lpBits,
            [In, Const] IntPtr lpBitsInfo,
            [In] uint iUsage,
            [In] uint dwRop);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int StretchDIBits(
            [In] IntPtr hdc,
            [In] int XDest,
            [In] int YDest,
            [In] int nDestWidth,
            [In] int nDestHeight,
            [In] int XSrc,
            [In] int YSrc,
            [In] int nSrcWidth,
            [In] int nSrcHeight,
            [In, Const] IntPtr lpBits,
            [In, Const] ref BITMAPINFO lpBitsInfo,
            [In] uint iUsage,
            [In] uint dwRop);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int TransparentBlt(
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
            [In] uint crTransparent);
    }

    #endregion // Bitmap functions

    #region Brush functions

    partial class gdi32
    {
        [DllImport(ModuleName, SetLastError = true)]
        public static extern IntPtr CreateBrushIndirect(
            [In, Const] IntPtr lplb);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern IntPtr CreateBrushIndirect(
            [In, Const] ref LOGBRUSH lplb);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern IntPtr CreateDIBPatternBrush(
            [In] IntPtr hglbDIBPacked,
            [In] uint fuColorSpec);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern IntPtr CreateDIBPatternBrushPt(
            [In, Const] IntPtr lpPackedDIB,
            [In] uint iUsage);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern IntPtr CreateHatchBrush(
            [In] int fnStyle,
            [In] uint clrref);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern IntPtr CreatePatternBrush(
            [In] IntPtr hbmp);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern IntPtr CreateSolidBrush(
            [In] uint crColor);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetBrushOrgEx(
            [In] IntPtr hdc,
            [Out] IntPtr lppt);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetBrushOrgEx(
            [In] IntPtr hdc,
            [Out] out POINT lppt);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern IntPtr GetSysColorBrush(
            [In] int nIndex);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int PatBlt(
            [In] IntPtr hdc,
            [In] int nXLeft,
            [In] int nYLeft,
            [In] int nWidth,
            [In] int nHeight,
            [In] uint dwRop);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int SetBrushOrgEx(
            [In] IntPtr hdc,
            [In] int nXOrg,
            [In] int nYOrg,
            [Out] IntPtr lppt);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int SetBrushOrgEx(
            [In] IntPtr hdc,
            [In] int nXOrg,
            [In] int nYOrg,
            [Out] out POINT lppt);
    }

    #endregion // Brush functions

    #region Clipping functions

    partial class gdi32
    {
        [DllImport(ModuleName, SetLastError = true)]
        public static extern int ExcludeClipRect(
            [In] IntPtr hdc,
            [In] int nLeftRect,
            [In] int nTopRect,
            [In] int nRightRect,
            [In] int nBottomRect);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int ExtSelectClipRgn(
            [In] IntPtr hdc,
            [In] IntPtr hrgn,
            [In] int fnMode);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GetClipBox(
            [In] IntPtr hdc,
            [Out] IntPtr lprc);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GetClipBox(
            [In] IntPtr hdc,
            [Out] out RECT lprc);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GetClipRgn(
            [In] IntPtr hdc,
            [In] IntPtr hrgn);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GetMetaRgn(
            [In] IntPtr hdc,
            [In] IntPtr hrgn);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GetRandomRgn(
            [In] IntPtr hdc,
            [In] IntPtr hrgn,
            [In] int iNum);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int IntersectClipRect(
            [In] IntPtr hdc,
            [In] int nLeftRect,
            [In] int nTopRect,
            [In] int nRightRect,
            [In] int nBottomRect);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int OffsetClipRgn(
            [In] IntPtr hdc,
            [In] int nXOffset,
            [In] int nYOffset);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int PtVisible(
            [In] IntPtr hdc,
            [In] int X,
            [In] int Y);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int RectVisible(
            [In] IntPtr hdc,
            [In, Const] IntPtr lprc);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int RectVisible(
            [In] IntPtr hdc,
            [In, Const] ref RECT lprc);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int SelectClipPath(
            [In] IntPtr hdc,
            [In] int iMode);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int SelectClipRgn(
            [In] IntPtr hdc,
            [In] IntPtr hrgn);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int SetMetaRgn(
            [In] IntPtr hdc);
    }

    #endregion // Clipping functions

    #region Color functions

    partial class gdi32
    {
        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AnimatePalette(
            [In] IntPtr hpal,
            [In] uint iStartIndex,
            [In] uint cEntries,
            [In, Const] IntPtr pps);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AnimatePalette(
            [In] IntPtr hpal,
            [In] uint iStartIndex,
            [In] uint cEntries,
            [In, Const] ref PALETTEENTRY pps);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern IntPtr CreateHalftonePalette(
            [In] IntPtr hdc);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern IntPtr CreatePalette(
            [In, Const] IntPtr lplgpl);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern IntPtr CreatePalette(
            [In, Const] ref LOGPALETTE lplgpl);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GetColorAdjustment(
            [In] IntPtr hdc,
            [Out] IntPtr lpca);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetColorAdjustment(
            [In] IntPtr hdc,
            [Out] out COLORADJUSTMENT lpca);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetNearestColor(
            [In] IntPtr hdc,
            [In] uint crColor);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetNearestPaletteIndex(
            [In] IntPtr hpal,
            [In] uint crColor);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetPaletteEntries(
            [In] IntPtr hpal,
            [In] uint iStartIndex,
            [In] uint nEntries,
            [Out] IntPtr lpps);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetPaletteEntries(
            [In] IntPtr hpal,
            [In] uint iStartIndex,
            [In] uint nEntries,
            [Out] PALETTEENTRY[] lpps);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetSystemPaletteEntries(
            [In] IntPtr hdc,
            [In] uint iStartIndex,
            [In] uint nEntries,
            [Out] IntPtr lpps);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetSystemPaletteEntries(
            [In] IntPtr hdc,
            [In] uint iStartIndex,
            [In] uint nEntries,
            [Out] PALETTEENTRY[] lpps);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetSystemPaletteUse(
            [In] IntPtr hdc);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint RealizePalette(
            [In] IntPtr hdc);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int ResizePalette(
            [In] IntPtr hpal,
            [In] uint nEntries);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern IntPtr SelectPalette(
            [In] IntPtr hdc,
            [In] IntPtr hpal,
            [In] int bForceBackground);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int SetColorAdjustment(
            [In] IntPtr hdc,
            [In, Const] IntPtr lpca);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int SetColorAdjustment(
            [In] IntPtr hdc,
            [In, Const] ref COLORADJUSTMENT lpca);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint SetPaletteEntries(
            [In] IntPtr hpal,
            [In] uint iStart,
            [In] uint cEntries,
            [In, Const] IntPtr lppe);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint SetPaletteEntries(
            [In] IntPtr hpal,
            [In] uint iStart,
            [In] uint cEntries,
            [In, Const] PALETTEENTRY[] lppe);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint SetSystemPaletteUse(
            [In] IntPtr hdc,
            [In] uint uUsage);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int UnrealizeObject(
            [In] IntPtr hgdiobj);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int UpdateColors(
            [In] IntPtr hdc);
    }

    #endregion // Color functions

    #region Coordinate space and transformation functions

    partial class gdi32
    {
        [DllImport(ModuleName, SetLastError = true)]
        public static extern int ClientToScreen(
            [In] IntPtr hWnd,
            [In, Out] IntPtr lpPoint);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int ClientToScreen(
            [In] IntPtr hWnd,
            [In, Out] ref POINT lpPoint);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int CombineTransform(
            [Out] IntPtr lpxformResult,
            [In, Const] IntPtr lpxform1,
            [In, Const] IntPtr lpxform2);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int CombineTransform(
            [Out] out XFORM lpxformResult,
            [In, Const] ref XFORM lpxform1,
            [In, Const] ref XFORM lpxform2);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int DPtoLP(
            [In] IntPtr hdc,
            [In, Out] IntPtr lpPoints,
            [In] int nCount);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int DPtoLP(
            [In] IntPtr hdc,
            [In, Out] POINT[] lpPoints,
            [In] int nCount);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GetCurrentPositionEx(
            [In] IntPtr hdc,
            [Out] IntPtr lpPoint);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GetCurrentPositionEx(
            [In] IntPtr hdc,
            [Out] out POINT lpPoint);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GetGraphicsMode(
            [In] IntPtr hdc);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GetMapMode(
            [In] IntPtr hdc);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GetViewportExtEx(
            [In] IntPtr hdc,
            [Out] IntPtr lpSize);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GetViewportExtEx(
            [In] IntPtr hdc,
            [Out] out SIZE lpSize);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GetViewportOrgEx(
            [In] IntPtr hdc,
            [Out] IntPtr lpPoint);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GetViewportOrgEx(
            [In] IntPtr hdc,
            [Out] out POINT lpPoint);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GetWindowExtEx(
            [In] IntPtr hdc,
            [Out] IntPtr lpSize);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GetWindowExtEx(
            [In] IntPtr hdc,
            [Out] out SIZE lpSize);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GetWindowOrgEx(
            [In] IntPtr hdc,
            [Out] IntPtr lpPoint);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GetWindowOrgEx(
            [In] IntPtr hdc,
            [Out] out POINT lpPoint);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GetWorldTransform(
            [In] IntPtr hdc,
            [Out] IntPtr lpXform);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GetWorldTransform(
            [In] IntPtr hdc,
            [Out] out XFORM lpXform);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int LPtoDP(
            [In] IntPtr hdc,
            [In, Out] POINT[] lpPoints,
            [In] int nCount);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int MapWindowPoints(
            [In] IntPtr hWndFrom,
            [In] IntPtr hWndTo,
            [In, Out] IntPtr lpPoints,
            [In] uint cPoints);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int MapWindowPoints(
            [In] IntPtr hWndFrom,
            [In] IntPtr hWndTo,
            [In, Out] POINT[] lpPoints,
            [In] uint cPoints);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int ModifyWorldTransform(
            [In] IntPtr hdc,
            [In, Const] IntPtr lpXform,
            [In] uint iMode);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int ModifyWorldTransform(
            [In] IntPtr hdc,
            [In, Const] ref XFORM lpXform,
            [In] uint iMode);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int OffsetViewportOrgEx(
            [In] IntPtr hdc,
            [In] int nXOffset,
            [In] int nYOffset,
            [Out] IntPtr lpPoint);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int OffsetViewportOrgEx(
            [In] IntPtr hdc,
            [In] int nXOffset,
            [In] int nYOffset,
            [Out] out POINT lpPoint);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int OffsetWindowOrgEx(
            [In] IntPtr hdc,
            [In] int nXOffset,
            [In] int nYOffset,
            [Out] IntPtr lpPoint);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int OffsetWindowOrgEx(
            [In] IntPtr hdc,
            [In] int nXOffset,
            [In] int nYOffset,
            [Out] out POINT lpPoint);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int ScaleViewportExtEx(
            [In] IntPtr hdc,
            [In] int Xnum,
            [In] int Xdenom,
            [In] int Ynum,
            [In] int Ydenom,
            [Out] IntPtr lpSize);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int ScaleViewportExtEx(
            [In] IntPtr hdc,
            [In] int Xnum,
            [In] int Xdenom,
            [In] int Ynum,
            [In] int Ydenom,
            [Out] out SIZE lpSize);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int ScaleWindowExtEx(
            [In] IntPtr hdc,
            [In] int Xnum,
            [In] int Xdenom,
            [In] int Ynum,
            [In] int Ydenom,
            [Out] IntPtr lpSize);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int ScaleWindowExtEx(
            [In] IntPtr hdc,
            [In] int Xnum,
            [In] int Xdenom,
            [In] int Ynum,
            [In] int Ydenom,
            [Out] out SIZE lpSize);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int ScreenToClient(
            [In] IntPtr hWnd,
            [In] IntPtr lpPoint);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int ScreenToClient(
            [In] IntPtr hWnd,
            [In] ref POINT lpPoint);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int SetGraphicsMode(
            [In] IntPtr hdc,
            [In] int iMode);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int SetMapMode(
            [In] IntPtr hdc,
            [In] int fnMapMode);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int SetViewportExtEx(
            [In] IntPtr hdc,
            [In] int nXExtent,
            [In] int nYExtent,
            [Out] IntPtr lpSize);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int SetViewportExtEx(
            [In] IntPtr hdc,
            [In] int nXExtent,
            [In] int nYExtent,
            [Out] out SIZE lpSize);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int SetWindowExtEx(
            [In] IntPtr hdc,
            [In] int nXExtent,
            [In] int nYExtent,
            [Out] IntPtr lpSize);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int SetWindowExtEx(
            [In] IntPtr hdc,
            [In] int nXExtent,
            [In] int nYExtent,
            [Out] out SIZE lpSize);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int SetViewportOrgEx(
            [In] IntPtr hdc,
            [In] int X,
            [In] int Y,
            [Out] IntPtr lpSize);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int SetViewportOrgEx(
            [In] IntPtr hdc,
            [In] int X,
            [In] int Y,
            [Out] out SIZE lpSize);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int SetWindowOrgEx(
            [In] IntPtr hdc,
            [In] int X,
            [In] int Y,
            [Out] IntPtr lpSize);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int SetWindowOrgEx(
            [In] IntPtr hdc,
            [In] int X,
            [In] int Y,
            [Out] out SIZE lpSize);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int SetWorldTransform(
            [In] IntPtr hdc,
            [In, Const] IntPtr lpXform);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int SetWorldTransform(
            [In] IntPtr hdc,
            [In, Const] ref XFORM lpXform);
    }

    #endregion // Coordinate space and transformation functions

    #region Device context functions

    partial class gdi32
    {
        [DllImport(ModuleName, SetLastError = true)]
        public static extern int CancelDC(
            [In] IntPtr hdc);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int ChangeDisplayMode(
            [In] IntPtr lpDevMode,
            [In] uint dwflags);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int ChangeDisplaySettingsExA(
            [Const, In] IntPtr lpszDeviceName,
            [In] IntPtr lpDevMode,
            IntPtr hwnd,
            [In] uint dwflags,
            [In] IntPtr lParam);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int ChangeDisplaySettingsExA(
            [In] string lpszDeviceName,
            [In] ref DEVMODE lpDevMode,
            IntPtr hwnd,
            [In] uint dwflags,
            [In] IntPtr lParam);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int ChangeDisplaySettingsExW(
            [Const, In] IntPtr lpszDeviceName,
            [In] IntPtr lpDevMode,
            IntPtr hwnd,
            [In] uint dwflags,
            [In] IntPtr lParam);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int ChangeDisplaySettingsExW(
            [In] string lpszDeviceName,
            [In] ref DEVMODE lpDevMode,
            IntPtr hwnd,
            [In] uint dwflags,
            [In] IntPtr lParam);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern IntPtr CreateCompatibleDC(
            [In] IntPtr hdc);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern IntPtr CreateDCA(
            [In, Const] IntPtr lpszDriver,
            [In, Const] IntPtr lpszDevice,
            IntPtr lpszOutput,
            [In, Const] IntPtr lpInitData);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern IntPtr CreateDCA(
            [In] string lpszDriver,
            [In] string lpszDevice,
            IntPtr lpszOutput,
            [In, Const] ref DEVMODE lpInitData);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern IntPtr CreateDCW(
            [In, Const] IntPtr lpszDriver,
            [In, Const] IntPtr lpszDevice,
            IntPtr lpszOutput,
            [In, Const] IntPtr lpInitData);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern IntPtr CreateDCW(
            [In] string lpszDriver,
            [In] string lpszDevice,
            IntPtr lpszOutput,
            [In, Const] ref DEVMODE lpInitData);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern IntPtr CreateICA(
            [In, Const] IntPtr lpszDriver,
            [In, Const] IntPtr lpszDevice,
            IntPtr lpszOutput,
            [In, Const] IntPtr lpdvmInit);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern IntPtr CreateICA(
            [In] string lpszDriver,
            [In] string lpszDevice,
            IntPtr lpszOutput,
            [In, Const] ref DEVMODE lpdvmInit);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern IntPtr CreateICW(
            [In, Const] IntPtr lpszDriver,
            [In, Const] IntPtr lpszDevice,
            IntPtr lpszOutput,
            [In, Const] IntPtr lpdvmInit);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern IntPtr CreateICW(
            [In] string lpszDriver,
            [In] string lpszDevice,
            IntPtr lpszOutput,
            [In, Const] ref DEVMODE lpdvmInit);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int DeleteDC(
            [In] IntPtr hdc);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int DeleteObject(
            [In] IntPtr hObject);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int DrawEscape(
            [In] IntPtr hdc,
            [In] int nEscape,
            [In] int cbInput,
            [In, Const] IntPtr lpszInData);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int EnumDisplayDeviceA(
            [In, Const] IntPtr lpDevice,
            [In] uint iDevNum,
            [Out] out DISPLAY_DEVICE lpDisplayDevice,
            [In] uint dwFlags);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, SetLastError = true), CLSCompliant(false)]
        public static extern int EnumDisplayDeviceA(
            [In] string lpDevice,
            [In] uint iDevNum,
            [Out] out DISPLAY_DEVICE lpDisplayDevice,
            [In] uint dwFlags);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int EnumDisplayDeviceW(
            [In, Const] IntPtr lpDevice,
            [In] uint iDevNum,
            [Out] out DISPLAY_DEVICE lpDisplayDevice,
            [In] uint dwFlags);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, SetLastError = true), CLSCompliant(false)]
        public static extern int EnumDisplayDeviceW(
            [In] string lpDevice,
            [In] uint iDevNum,
            [Out] out DISPLAY_DEVICE lpDisplayDevice,
            [In] uint dwFlags);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int EnumDisplaySettingsA(
            [In, Const] IntPtr lpszDeviceName,
            [In] uint iModeNum,
            [Out] out DEVMODE lpDevMode);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, SetLastError = true), CLSCompliant(false)]
        public static extern int EnumDisplaySettingsA(
            [In] string lpszDeviceName,
            [In] uint iModeNum,
            [Out] out DEVMODE lpDevMode);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int EnumDisplaySettingsW(
            [In, Const] IntPtr lpszDeviceName,
            [In] uint iModeNum,
            [Out] out DEVMODE lpDevMode);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, SetLastError = true), CLSCompliant(false)]
        public static extern int EnumDisplaySettingsW(
            [In] string lpszDeviceName,
            [In] uint iModeNum,
            [Out] out DEVMODE lpDevMode);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int EnumDisplaySettingsExA(
            [In, Const] IntPtr lpszDeviceName,
            [In] uint iModeNum,
            [Out] out DEVMODE lpDevMode,
            [In] uint dwFlags);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, SetLastError = true), CLSCompliant(false)]
        public static extern int EnumDisplaySettingsExA(
            [In] string lpszDeviceName,
            [In] uint iModeNum,
            [Out] out DEVMODE lpDevMode,
            [In] uint dwFlags);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int EnumDisplaySettingsExW(
            [In, Const] IntPtr lpszDeviceName,
            [In] uint iModeNum,
            [Out] out DEVMODE lpDevMode,
            [In] uint dwFlags);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, SetLastError = true), CLSCompliant(false)]
        public static extern int EnumDisplaySettingsExW(
            [In] string lpszDeviceName,
            [In] uint iModeNum,
            [Out] out DEVMODE lpDevMode,
            [In] uint dwFlags);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int EnumObjects(
            [In] IntPtr hdc,
            [In] int nObjectType,
            [In] IntPtr lpObjectFunc,
            [In] IntPtr lParam);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int EnumObjects(
            [In] IntPtr hdc,
            [In] int nObjectType,
            [In] EnumObjectsProc lpObjectFunc,
            [In] IntPtr lParam);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern IntPtr GetCurrentObject(
            [In] IntPtr hdc,
            [In] uint uObjectType);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern IntPtr GetDC(
            [In] IntPtr hWnd);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetDCBrushColor(
            [In] IntPtr hdc);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern IntPtr GetDCEx(
            [In] IntPtr hWnd,
            [In] IntPtr hrgnClip,
            [In] uint flags);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GetDCOrgEx(
            [In] IntPtr hdc,
            [Out] IntPtr lpPoint);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GetDCOrgEx(
            [In] IntPtr hdc,
            [Out] out POINT lpPoint);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetDCPenColor(
            [In] IntPtr hdc);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GetDeviceCaps(
            [In] IntPtr hdc,
            [In] int nIndex);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetLayout(
            [In] IntPtr hdc);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GetObject(
            [In] IntPtr hgdiobj,
            [In] int cbBuffer,
            [Out] IntPtr lpvObject);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetObjectType(
            [In] IntPtr h);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern IntPtr GetStockObject(
            [In] int fnObject);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int ReleaseDC(
            [In] IntPtr hWnd,
            [In] IntPtr hDC);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern IntPtr ResetDCA(
            [In] IntPtr hdc,
            [Const, In] IntPtr lpInitData);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern IntPtr ResetDCA(
            [In] IntPtr hdc,
            [Const, In] ref DEVMODE lpInitData);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern IntPtr ResetDCW(
            [In] IntPtr hdc,
            [Const, In] IntPtr lpInitData);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern IntPtr ResetDCW(
            [In] IntPtr hdc,
            [Const, In] ref DEVMODE lpInitData);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int RestoreDC(
            [In] IntPtr hdc,
            [In] int nSavedDC);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int SaveDC(
            [In] IntPtr hdc);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern IntPtr SelectObject(
            [In] IntPtr hdc,
            [In] IntPtr hgdiobj);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint SetDCBrushColor(
            [In] IntPtr hdc,
            [In] uint crColor);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint SetDCPenColor(
            [In] IntPtr hdc,
            [In] uint crColor);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint SetLayout(
            [In] IntPtr hdc,
            [In] uint dwLayout);
    }

    #endregion // Device context functions

    #region Filled shape functions

    partial class gdi32
    {
        [DllImport(ModuleName, SetLastError = true)]
        public static extern int Chord(
            [In] IntPtr hdc,
            [In] int nLeftRect,
            [In] int nTopRect,
            [In] int nRightRect,
            [In] int nBottomRect,
            [In] int nXRadia11,
            [In] int nYRadia11,
            [In] int nXRadia12,
            [In] int nYRadia12);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int Ellipse(
            [In] IntPtr hdc,
            [In] int nLeftRect,
            [In] int nTopRect,
            [In] int nRightRect,
            [In] int nBottomRect);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int FillRect(
            [In] IntPtr hDC,
            [Const, In] IntPtr lprc,
            [In] IntPtr hbr);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int FillRect(
            [In] IntPtr hDC,
            [In] ref RECT lprc,
            [In] IntPtr hbr);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int FrameRect(
            [In] IntPtr hDC,
            [Const, In] IntPtr lprc,
            [In] IntPtr hbr);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int FrameRect(
            [In] IntPtr hDC,
            [In] ref RECT lprc,
            [In] IntPtr hbr);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int InvertRect(
            [In] IntPtr hDC,
            [Const, In] IntPtr lprc);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int InvertRect(
            [In] IntPtr hDC,
            [In] ref RECT lprc);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int Pie(
            [In] IntPtr hdc,
            [In] int nLeftRect,
            [In] int nTopRect,
            [In] int nRightRect,
            [In] int nBottomRect,
            [In] int nXRadia11,
            [In] int nYRadia11,
            [In] int nXRadia12,
            [In] int nYRadia12);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int Polygon(
            [In] IntPtr hdc,
            [Const, In] IntPtr lpPoints,
            [In] int nCount);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int Polygon(
            [In] IntPtr hdc,
            [In] POINT[] lpPoints,
            [In] int nCount);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int PolyPolygon(
            [In] IntPtr hdc,
            [Const, In] IntPtr lpPoints,
            [Const, In] IntPtr lpPolyCounts,
            [In] int nCount);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int PolyPolygon(
            [In] IntPtr hdc,
            [In] POINT[] lpPoints,
            [In] int[] lpPolyCounts,
            [In] int nCount);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int Rectangle(
            [In] IntPtr hdc,
            [In] int nLeftRect,
            [In] int nTopRect,
            [In] int nRightRect,
            [In] int nBottomRect);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int RoundRect(
            [In] IntPtr hdc,
            [In] int nLeftRect,
            [In] int nTopRect,
            [In] int nRightRect,
            [In] int nBottomRect,
            [In] int nWidth,
            [In] int nHeight);
    }

    #endregion // Filled shape functions

    #region Font and text functions

    partial class gdi32
    {
        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern IntPtr AddFontMemResourcesEx(
            [In] IntPtr pbFont,
            [In] uint cbFont,
            [In] IntPtr pdv,
            [In] IntPtr pcFonts);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern IntPtr AddFontMemResourcesEx(
            [In] IntPtr pbFont,
            [In] uint cbFont,
            [In] IntPtr pdv,
            [In] ref uint pcFonts);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int AddFontResourceA(
            [In, Const] IntPtr lpszFileName);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi)]
        public static extern int AddFontResourceA(
            [In] string lpszFileName);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int AddFontResourceW(
            [In, Const] IntPtr lpszFileName);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int AddFontResourceW(
            [In] string lpszFileName);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AddFontResourceExA(
            [In, Const] IntPtr lpszFilename,
            [In] uint fl,
            [In] IntPtr pdv);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int AddFontResourceExA(
            [In] string lpszFilename,
            [In] uint fl,
            [In] IntPtr pdv);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AddFontResourceExW(
            [In, Const] IntPtr lpszFilename,
            [In] uint fl,
            [In] IntPtr pdv);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int AddFontResourceExW(
            [In] string lpszFilename,
            [In] uint fl,
            [In] IntPtr pdv);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern IntPtr CreateFontA(
            [In] int nHeight,
            [In] int nWidth,
            [In] int nEscapement,
            [In] int nOrientation,
            [In] int fnWeight,
            [In] uint fdwItalic,
            [In] uint fdwUnderline,
            [In] uint fdwStrikeOut,
            [In] uint fdwCharSet,
            [In] uint fdwOutputPrecision,
            [In] uint fdwClipPrecision,
            [In] uint fdwQuality,
            [In] uint fdwPitchAndFamily,
            [Const, In] IntPtr lpszFace);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern IntPtr CreateFontA(
            [In] int nHeight,
            [In] int nWidth,
            [In] int nEscapement,
            [In] int nOrientation,
            [In] int fnWeight,
            [In] uint fdwItalic,
            [In] uint fdwUnderline,
            [In] uint fdwStrikeOut,
            [In] uint fdwCharSet,
            [In] uint fdwOutputPrecision,
            [In] uint fdwClipPrecision,
            [In] uint fdwQuality,
            [In] uint fdwPitchAndFamily,
            [In] string lpszFace);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern IntPtr CreateFontW(
            [In] int nHeight,
            [In] int nWidth,
            [In] int nEscapement,
            [In] int nOrientation,
            [In] int fnWeight,
            [In] uint fdwItalic,
            [In] uint fdwUnderline,
            [In] uint fdwStrikeOut,
            [In] uint fdwCharSet,
            [In] uint fdwOutputPrecision,
            [In] uint fdwClipPrecision,
            [In] uint fdwQuality,
            [In] uint fdwPitchAndFamily,
            [Const, In] IntPtr lpszFace);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern IntPtr CreateFontW(
            [In] int nHeight,
            [In] int nWidth,
            [In] int nEscapement,
            [In] int nOrientation,
            [In] int fnWeight,
            [In] uint fdwItalic,
            [In] uint fdwUnderline,
            [In] uint fdwStrikeOut,
            [In] uint fdwCharSet,
            [In] uint fdwOutputPrecision,
            [In] uint fdwClipPrecision,
            [In] uint fdwQuality,
            [In] uint fdwPitchAndFamily,
            [In] string lpszFace);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern IntPtr CreateFontIndirectA(
            [In, Const] IntPtr lplf);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi)]
        public static extern IntPtr CreateFontIndirectA(
            [In] ref LOGFONT lplf);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern IntPtr CreateFontIndirectW(
            [In, Const] IntPtr lplf);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr CreateFontIndirectW(
            [In] ref LOGFONT lplf);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern IntPtr CreateFontIndirectEx(
            [In] IntPtr penumlfex);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern IntPtr CreateFontIndirectEx(
            [In] ref ENUMLOGFONTEX penumlfex);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int CreateScalableFontResourceA(
            [In] uint fdwHidden,
            [Const, In] IntPtr lpszFontRes,
            [Const, In] IntPtr lpszFontFile,
            [Const, In] IntPtr lpszCurrentPath);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int CreateScalableFontResourceA(
            [In] uint fdwHidden,
            [In] string lpszFontRes,
            [In] string lpszFontFile,
            [In] string lpszCurrentPath);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int CreateScalableFontResourceW(
            [In] uint fdwHidden,
            [Const, In] IntPtr lpszFontRes,
            [Const, In] IntPtr lpszFontFile,
            [Const, In] IntPtr lpszCurrentPath);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int CreateScalableFontResourceW(
            [In] uint fdwHidden,
            [In] string lpszFontRes,
            [In] string lpszFontFile,
            [In] string lpszCurrentPath);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int DrawTextA(
            [In] IntPtr hDC,
            [Const, In] IntPtr lpString,
            [In] int nCount,
            [In, Out] IntPtr lpRect,
            [In] uint nFormat);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int DrawTextA(
            [In] IntPtr hDC,
            [In] string lpString,
            [In] int nCount,
            [In, Out] ref RECT lpRect,
            [In] uint nFormat);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int DrawTextW(
            [In] IntPtr hDC,
            [Const, In] IntPtr lpString,
            [In] int nCount,
            [In, Out] IntPtr lpRect,
            [In] uint nFormat);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int DrawTextW(
            [In] IntPtr hDC,
            [In] string lpString,
            [In] int nCount,
            [In, Out] ref RECT lpRect,
            [In] uint nFormat);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int DrawTextEXA(
            [In] IntPtr hdc,
            [In, Out] IntPtr lpchText,
            [In] int cchText,
            [In, Out] IntPtr lprc,
            [In] uint dwDTFormat,
            [In] IntPtr lpDTParams);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int DrawTextEXA(
            [In] IntPtr hdc,
            [In, Out] StringBuilder lpchText,
            [In] int cchText,
            [In, Out] ref RECT lprc,
            [In] uint dwDTFormat,
            [In] ref DRAWTEXTPARAMS lpDTParams);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int DrawTextEXW(
            [In] IntPtr hdc,
            [In, Out] IntPtr lpchText,
            [In] int cchText,
            [In, Out] IntPtr lprc,
            [In] uint dwDTFormat,
            [In] IntPtr lpDTParams);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int DrawTextEXW(
            [In] IntPtr hdc,
            [In, Out] StringBuilder lpchText,
            [In] int cchText,
            [In, Out] ref RECT lprc,
            [In] uint dwDTFormat,
            [In] ref DRAWTEXTPARAMS lpDTParams);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int EnableEUDC(
            [In] int fEnableEUDC);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int EnumFontFamiliesA(
            [In] IntPtr hdc,
            [Const, In] IntPtr lpszFamily,
            [In] IntPtr lpEnumFontFamProc,
            [In] IntPtr lParam);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int EnumFontFamiliesA(
            [In] IntPtr hdc,
            [In] string lpszFamily,
            [In] EnumFontFamProc lpEnumFontFamProc,
            [In] IntPtr lParam);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int EnumFontFamiliesW(
            [In] IntPtr hdc,
            [Const, In] IntPtr lpszFamily,
            [In] IntPtr lpEnumFontFamProc,
            [In] IntPtr lParam);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int EnumFontFamiliesW(
            [In] IntPtr hdc,
            [In] string lpszFamily,
            [In] EnumFontFamProc lpEnumFontFamProc,
            [In] IntPtr lParam);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int EnumFontFamiliesExA(
            [In] IntPtr hdc,
            [In] IntPtr lpLogfont,
            [In] IntPtr lpEnumFontFamExProc,
            [In] IntPtr lParam,
            uint dwFlags);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int EnumFontFamiliesExA(
            [In] IntPtr hdc,
            [In] ref LOGFONT lpLogfont,
            [In] EnumFontFamExProc lpEnumFontFamExProc,
            [In] IntPtr lParam,
            uint dwFlags);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int EnumFontFamiliesExW(
            [In] IntPtr hdc,
            [In] IntPtr lpLogfont,
            [In] IntPtr lpEnumFontFamExProc,
            [In] IntPtr lParam,
            uint dwFlags);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int EnumFontFamiliesExW(
            [In] IntPtr hdc,
            [In] ref LOGFONT lpLogfont,
            [In] EnumFontFamExProc lpEnumFontFamExProc,
            [In] IntPtr lParam,
            uint dwFlags);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int EnumFontsA(
            [In] IntPtr hdc,
            [In, Const] IntPtr lpFaceName,
            [In] IntPtr lpFontFunc,
            [In] IntPtr lParam);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int EnumFontsA(
            [In] IntPtr hdc,
            [In] string lpFaceName,
            [In] EnumFontsProc lpFontFunc,
            [In] IntPtr lParam);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int EnumFontsW(
            [In] IntPtr hdc,
            [In, Const] IntPtr lpFaceName,
            [In] IntPtr lpFontFunc,
            [In] IntPtr lParam);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int EnumFontsW(
            [In] IntPtr hdc,
            [In] string lpFaceName,
            [In] EnumFontsProc lpFontFunc,
            [In] IntPtr lParam);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int ExtTextOutA(
            [In] IntPtr hdc,
            [In] int X,
            [In] int Y,
            [In] uint fuOptions,
            [Const, In] IntPtr lprc,
            [Const, In] IntPtr lpString,
            [In] uint cbCount,
            [Const, In] IntPtr lpDx);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int ExtTextOutA(
            [In] IntPtr hdc,
            [In] int X,
            [In] int Y,
            [In] uint fuOptions,
            [In] ref RECT lprc,
            [In] string lpString,
            [In] uint cbCount,
            [In] int[] lpDx);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int ExtTextOutW(
            [In] IntPtr hdc,
            [In] int X,
            [In] int Y,
            [In] uint fuOptions,
            [Const, In] IntPtr lprc,
            [Const, In] IntPtr lpString,
            [In] uint cbCount,
            [Const, In] IntPtr lpDx);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int ExtTextOutW(
            [In] IntPtr hdc,
            [In] int X,
            [In] int Y,
            [In] uint fuOptions,
            [In] ref RECT lprc,
            [In] string lpString,
            [In] uint cbCount,
            [In] int[] lpDx);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GetAspectRatioFilterEx(
            [In] IntPtr hdc,
            [Out] IntPtr lpAspectRatio);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GetAspectRatioFilterEx(
            [In] IntPtr hdc,
            [Out] out SIZE lpAspectRatio);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetCharABCWidthsA(
            [In] IntPtr hdc,
            [In] uint uFirstChar,
            [In] uint uLastChar,
            [Out] IntPtr lpabc);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetCharABCWidthsA(
            [In] IntPtr hdc,
            [In] uint uFirstChar,
            [In] uint uLastChar,
            [Out] out ABC lpabc);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetCharABCWidthsW(
            [In] IntPtr hdc,
            [In] uint uFirstChar,
            [In] uint uLastChar,
            [Out] IntPtr lpabc);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetCharABCWidthsW(
            [In] IntPtr hdc,
            [In] uint uFirstChar,
            [In] uint uLastChar,
            [Out] out ABC lpabc);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetCharABCWidthsFloatA(
            [In] IntPtr hdc,
            [In] uint iFirstChar,
            [In] uint iLastChar,
            [Out] IntPtr lpABCF);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetCharABCWidthsFloatA(
            [In] IntPtr hdc,
            [In] uint iFirstChar,
            [In] uint iLastChar,
            [Out] out ABCFLOAT lpABCF);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetCharABCWidthsFloatW(
            [In] IntPtr hdc,
            [In] uint iFirstChar,
            [In] uint iLastChar,
            [Out] IntPtr lpABCF);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetCharABCWidthsFloatW(
            [In] IntPtr hdc,
            [In] uint iFirstChar,
            [In] uint iLastChar,
            [Out] out ABCFLOAT lpABCF);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetCharABCWidthsI(
            [In] IntPtr hdc,
            [In] uint giFrst,
            [In] uint cgi,
            [In] IntPtr pgi,
            [Out] IntPtr lpabc);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetCharABCWidthsI(
            [In] IntPtr hdc,
            [In] uint giFrst,
            [In] uint cgi,
            [In] ushort[] pgi,
            [Out] out ABC lpabc);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetCharacterPlacementA(
            [In] IntPtr hdc,
            [Const, In] IntPtr lpString,
            [In] int nCount,
            [In] int nMaxExtent,
            [In, Out] IntPtr lpResults,
            [In] uint dwFlags);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern uint GetCharacterPlacementA(
            [In] IntPtr hdc,
            [In] string lpString,
            [In] int nCount,
            [In] int nMaxExtent,
            [In, Out] ref GCP_RESULTS lpResults,
            [In] uint dwFlags);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetCharacterPlacementW(
            [In] IntPtr hdc,
            [Const, In] IntPtr lpString,
            [In] int nCount,
            [In] int nMaxExtent,
            [In, Out] IntPtr lpResults,
            [In] uint dwFlags);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern uint GetCharacterPlacementW(
            [In] IntPtr hdc,
            [In] string lpString,
            [In] int nCount,
            [In] int nMaxExtent,
            [In, Out] ref GCP_RESULTS lpResults,
            [In] uint dwFlags);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetCharWidthA(
            [In] IntPtr hdc,
            [In] uint iFirstChar,
            [In] uint iLastChar,
            [Out] IntPtr lpBuffer);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetCharWidthA(
            [In] IntPtr hdc,
            [In] uint iFirstChar,
            [In] uint iLastChar,
            [Out] out int lpBuffer);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetCharWidthW(
            [In] IntPtr hdc,
            [In] uint iFirstChar,
            [In] uint iLastChar,
            [Out] IntPtr lpBuffer);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetCharWidthW(
            [In] IntPtr hdc,
            [In] uint iFirstChar,
            [In] uint iLastChar,
            [Out] out int lpBuffer);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetCharWidth32A(
            [In] IntPtr hdc,
            [In] uint iFirstChar,
            [In] uint iLastChar,
            [Out] IntPtr lpBuffer);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetCharWidth32A(
            [In] IntPtr hdc,
            [In] uint iFirstChar,
            [In] uint iLastChar,
            [Out] out int lpBuffer);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetCharWidth32W(
            [In] IntPtr hdc,
            [In] uint iFirstChar,
            [In] uint iLastChar,
            [Out] IntPtr lpBuffer);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetCharWidth32W(
            [In] IntPtr hdc,
            [In] uint iFirstChar,
            [In] uint iLastChar,
            [Out] out int lpBuffer);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetCharWidthFloatA(
            [In] IntPtr hdc,
            [In] uint iFirstChar,
            [In] uint iLastChar,
            [Out] IntPtr pxBuffer);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetCharWidthFloatA(
            [In] IntPtr hdc,
            [In] uint iFirstChar,
            [In] uint iLastChar,
            [Out] out float pxBuffer);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetCharWidthFloatW(
            [In] IntPtr hdc,
            [In] uint iFirstChar,
            [In] uint iLastChar,
            [Out] IntPtr pxBuffer);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetCharWidthFloatW(
            [In] IntPtr hdc,
            [In] uint iFirstChar,
            [In] uint iLastChar,
            [Out] out float pxBuffer);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetCharWidthI(
            [In] IntPtr hdc,
            [In] uint giFirst,
            [In] uint cgi,
            [In] IntPtr pgi,
            [Out] IntPtr lpBuffer);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetCharWidthI(
            [In] IntPtr hdc,
            [In] uint giFirst,
            [In] uint cgi,
            [In] ushort[] pgi,
            [Out] out uint lpBuffer);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetFontData(
            [In] IntPtr hdc,
            [In] uint dwTable,
            [In] uint dwOffset,
            [Out] IntPtr lpvBuffer,
            [In] uint cbData);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetFontLanguageInfo(
            [In] IntPtr hdc);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetFontUnicodeRanges(
            [In] IntPtr hdc,
            [Out] IntPtr lpgs);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetFontUnicodeRanges(
            [In] IntPtr hdc,
            [Out] out GLYPHSET lpgs);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetGlyphIndiciesA(
            [In] IntPtr hdc,
            [Const, In] IntPtr lpstr,
            [In] int c,
            [Out] IntPtr pgi,
            [In] uint fl);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern uint GetGlyphIndiciesA(
            [In] IntPtr hdc,
            [In] string lpstr,
            [In] int c,
            [Out] out ushort pgi,
            [In] uint fl);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetGlyphIndiciesW(
            [In] IntPtr hdc,
            [Const, In] IntPtr lpstr,
            [In] int c,
            [Out] IntPtr pgi,
            [In] uint fl);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern uint GetGlyphIndiciesW(
            [In] IntPtr hdc,
            [In] string lpstr,
            [In] int c,
            [Out] out ushort pgi,
            [In] uint fl);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetGlyphOutlineA(
            [In] IntPtr hdc,
            [In] uint uChar,
            [In] uint uFormat,
            [Out] IntPtr lpgm,
            [In] uint cbBuffer,
            [Out] IntPtr lpvBuffer,
            [In, Const] IntPtr lpmat2);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetGlyphOutlineA(
            [In] IntPtr hdc,
            [In] uint uChar,
            [In] uint uFormat,
            [Out] out GLYPHMETRICS lpgm,
            [In] uint cbBuffer,
            [Out] IntPtr lpvBuffer,
            [In, Const] ref MAT2 lpmat2);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetGlyphOutlineW(
            [In] IntPtr hdc,
            [In] uint uChar,
            [In] uint uFormat,
            [Out] IntPtr lpgm,
            [In] uint cbBuffer,
            [Out] IntPtr lpvBuffer,
            [In, Const] IntPtr lpmat2);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetGlyphOutlineW(
            [In] IntPtr hdc,
            [In] uint uChar,
            [In] uint uFormat,
            [Out] out GLYPHMETRICS lpgm,
            [In] uint cbBuffer,
            [Out] IntPtr lpvBuffer,
            [In, Const] ref MAT2 lpmat2);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetKerningPairsA(
            [In] IntPtr hdc,
            [In] uint nNumPairs,
            [Out] IntPtr lpkrnpair);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetKerningPairsA(
            [In] IntPtr hdc,
            [In] uint nNumPairs,
            [Out] KERNINGPAIR[] lpkrnpair);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetKerningPairsW(
            [In] IntPtr hdc,
            [In] uint nNumPairs,
            [Out] IntPtr lpkrnpair);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetKerningPairsW(
            [In] IntPtr hdc,
            [In] uint nNumPairs,
            [Out] KERNINGPAIR[] lpkrnpair);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetOutlineTextMetricsA(
            [In] IntPtr hdc,
            [In] uint cbData,
            [Out] IntPtr lpOTM);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetOutlineTextMetricsA(
            [In] IntPtr hdc,
            [In] uint cbData,
            [Out] out OUTLINETEXTMETRICA lpOTM);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetOutlineTextMetricsW(
            [In] IntPtr hdc,
            [In] uint cbData,
            [Out] IntPtr lpOTM);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetOutlineTextMetricsW(
            [In] IntPtr hdc,
            [In] uint cbData,
            [Out] out OUTLINETEXTMETRICW lpOTM);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetRasterizerCaps(
            [Out] IntPtr lprs,
            [In] uint cb);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetRasterizerCaps(
            [Out] out RASTERIZER_STATUS lprs,
            [In] uint cb);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetTabbedTextExtentA(
            [In] IntPtr hDC,
            [In, Const] IntPtr lpString,
            [In] int nCount,
            [In] int nTabPositions,
            [Const, In] IntPtr lpnTabStopPositions);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern uint GetTabbedTextExtentA(
            [In] IntPtr hDC,
            [In] string lpString,
            [In] int nCount,
            [In] int nTabPositions,
            [Const, In] int[] lpnTabStopPositions);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetTabbedTextExtentW(
            [In] IntPtr hDC,
            [In, Const] IntPtr lpString,
            [In] int nCount,
            [In] int nTabPositions,
            [Const, In] IntPtr lpnTabStopPositions);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern uint GetTabbedTextExtentW(
            [In] IntPtr hDC,
            [In] string lpString,
            [In] int nCount,
            [In] int nTabPositions,
            [Const, In] int[] lpnTabStopPositions);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetTextAlign(
            [In] IntPtr hdc);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetTextCharacterExtra(
            [In] IntPtr hdc);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetTextColor(
            [In] IntPtr hdc);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetTextExtentExPointA(
            [In] IntPtr hdc,
            [In, Const] IntPtr lpszStr,
            [In] int cchString,
            [In] int nMaxExtent,
            [Out] IntPtr lpnFit,
            [Out] IntPtr alpDx,
            [Out] IntPtr lpSize);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int GetTextExtentExPointA(
            [In] IntPtr hdc,
            [In] string lpszStr,
            [In] int cchString,
            [In] int nMaxExtent,
            [Out] out int lpnFit,
            [Out] int[] alpDx,
            [Out] out SIZE lpSize);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetTextExtentExPointW(
            [In] IntPtr hdc,
            [In, Const] IntPtr lpszStr,
            [In] int cchString,
            [In] int nMaxExtent,
            [Out] IntPtr lpnFit,
            [Out] IntPtr alpDx,
            [Out] IntPtr lpSize);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int GetTextExtentExPointW(
            [In] IntPtr hdc,
            [In] string lpszStr,
            [In] int cchString,
            [In] int nMaxExtent,
            [Out] out int lpnFit,
            [Out] int[] alpDx,
            [Out] out SIZE lpSize);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetTextExtentExPointI(
            [In] IntPtr hdc,
            [In] IntPtr pgiIn,
            [In] int cgi,
            [In] int nMaxExtent,
            [Out] IntPtr lpnFit,
            [Out] IntPtr alpDx,
            [Out] IntPtr lpSize);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetTextExtentExPointI(
            [In] IntPtr hdc,
            [In] ushort[] pgiIn,
            [In] int cgi,
            [In] int nMaxExtent,
            [Out] out int lpnFit,
            [Out] int[] alpDx,
            [Out] out SIZE lpSize);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetTextExtentPointA(
            [In] IntPtr hdc,
            [In, Const] IntPtr lpString,
            [In] int cbString,
            [Out] IntPtr lpSize);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int GetTextExtentPointA(
            [In] IntPtr hdc,
            [In] string lpString,
            [In] int cbString,
            [Out] out SIZE lpSize);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetTextExtentPointW(
            [In] IntPtr hdc,
            [In, Const] IntPtr lpString,
            [In] int cbString,
            [Out] IntPtr lpSize);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int GetTextExtentPointW(
            [In] IntPtr hdc,
            [In] string lpString,
            [In] int cbString,
            [Out] out SIZE lpSize);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetTextExtentPoint32A(
            [In] IntPtr hdc,
            [In, Const] IntPtr lpString,
            [In] int cbString,
            [Out] IntPtr lpSize);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int GetTextExtentPoint32A(
            [In] IntPtr hdc,
            [In] string lpString,
            [In] int cbString,
            [Out] out SIZE lpSize);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetTextExtentPoint32W(
            [In] IntPtr hdc,
            [In, Const] IntPtr lpString,
            [In] int cbString,
            [Out] IntPtr lpSize);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int GetTextExtentPoint32W(
            [In] IntPtr hdc,
            [In] string lpString,
            [In] int cbString,
            [Out] out SIZE lpSize);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetTextExtentPointI(
            [In] IntPtr hdc,
            [In] IntPtr pgiIn,
            [In] int cgi,
            [Out] IntPtr lpSize);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetTextExtentPointI(
            [In] IntPtr hdc,
            [In] ushort[] pgiIn,
            [In] int cgi,
            [Out] out SIZE lpSize);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetTextFaceA(
            [In] IntPtr hdc,
            [In] int nCount,
            [Out] IntPtr lpFaceName);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int GetTextFaceA(
            [In] IntPtr hdc,
            [In] int nCount,
            [Out] StringBuilder lpFaceName);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetTextFaceW(
            [In] IntPtr hdc,
            [In] int nCount,
            [Out] IntPtr lpFaceName);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int GetTextFaceW(
            [In] IntPtr hdc,
            [In] int nCount,
            [Out] StringBuilder lpFaceName);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetTextMetricsA(
            [In] IntPtr hdc,
            [Out] IntPtr lptm);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetTextMetricsA(
            [In] IntPtr hdc,
            [Out] out TEXTMETRICA lptm);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetTextMetricsW(
            [In] IntPtr hdc,
            [Out] IntPtr lptm);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetTextMetricsW(
            [In] IntPtr hdc,
            [Out] out TEXTMETRICW lptm);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int PolyTextOutA(
            [In] IntPtr hdc,
            [Const, In] IntPtr pptxt,
            [In] int cStrings);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int PolyTextOutA(
            [In] IntPtr hdc,
            [Const, In] POLYTEXT[] pptxt,
            [In] int cStrings);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int PolyTextOutW(
            [In] IntPtr hdc,
            [Const, In] IntPtr pptxt,
            [In] int cStrings);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int PolyTextOutW(
            [In] IntPtr hdc,
            [Const, In] POLYTEXT[] pptxt,
            [In] int cStrings);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int RemoveFontMemResourceEx(
            [In] IntPtr fh);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int RemoveFontResourceA(
            [Const, In] IntPtr lpFileName);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi)]
        public static extern int RemoveFontResourceA(
            [In] string lpFileName);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int RemoveFontResourceW(
            [Const, In] IntPtr lpFileName);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int RemoveFontResourceW(
            [In] string lpFileName);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int RemoveFontResourceExA(
            [Const, In] IntPtr lpFileName,
            [In] uint fl,
            [In] IntPtr pdv);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int RemoveFontResourceExA(
            [In] string lpFileName,
            [In] uint fl,
            [In] IntPtr pdv);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int RemoveFontResourceExW(
            [Const, In] IntPtr lpFileName,
            [In] uint fl,
            [In] IntPtr pdv);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int RemoveFontResourceExW(
            [In] string lpFileName,
            [In] uint fl,
            [In] IntPtr pdv);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint SetMapperFlags(
            [In] IntPtr hdc,
            [In] uint dwFlags);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int SetTextCharacterExtra(
            [In] IntPtr hdc,
            [In] int nCharExtra);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint SetTextColor(
            [In] IntPtr hdc,
            [In] uint crColor);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int SetTextJustification(
            [In] IntPtr hdc,
            [In] int nBreakExtra,
            [In] int nBreakCount);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int TabbedTextOutA(
            [In] IntPtr hDC,
            [In] int X,
            [In] int Y,
            [In, Const] IntPtr lpString,
            [In] int nCount,
            [In] int nTabPositions,
            [Const, In] IntPtr lpnTabPositions,
            [In] int nTabOrigin);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi)]
        public static extern int TabbedTextOutA(
            [In] IntPtr hDC,
            [In] int X,
            [In] int Y,
            [In] string lpString,
            [In] int nCount,
            [In] int nTabPositions,
            [In] int[] lpnTabPositions,
            [In] int nTabOrigin);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int TabbedTextOutW(
            [In] IntPtr hDC,
            [In] int X,
            [In] int Y,
            [In, Const] IntPtr lpString,
            [In] int nCount,
            [In] int nTabPositions,
            [Const, In] IntPtr lpnTabPositions,
            [In] int nTabOrigin);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int TabbedTextOutW(
            [In] IntPtr hDC,
            [In] int X,
            [In] int Y,
            [In] string lpString,
            [In] int nCount,
            [In] int nTabPositions,
            [In] int[] lpnTabPositions,
            [In] int nTabOrigin);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int TextOutA(
            [In] IntPtr hdc,
            [In] int nXStart,
            [In] int nYStart,
            [In, Const] IntPtr lpString,
            [In] int cbString);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi)]
        public static extern int TextOutA(
            [In] IntPtr hdc,
            [In] int nXStart,
            [In] int nYStart,
            [In] string lpString,
            [In] int cbString);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int TextOutW(
            [In] IntPtr hdc,
            [In] int nXStart,
            [In] int nYStart,
            [In, Const] IntPtr lpString,
            [In] int cbString);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int TextOutW(
            [In] IntPtr hdc,
            [In] int nXStart,
            [In] int nYStart,
            [In] string lpString,
            [In] int cbString);
    }

    #endregion // Font and text functions

    #region Line and curve functions

    partial class gdi32
    {
        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AngleArc(
            [In] IntPtr hdc,
            [In] int X,
            [In] int Y,
            [In] uint dwRadius,
            [In] float eStartAngle,
            [In] float eSweepAngle);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int Arc(
            [In] IntPtr hdc,
            [In] int nLeftRect,
            [In] int nTopRect,
            [In] int nRightRect,
            [In] int nBottomRect,
            [In] int nXStartArc,
            [In] int nYStartArc,
            [In] int nXEndArc,
            [In] int nYEndArc);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int ArcTo(
            [In] IntPtr hdc,
            [In] int nLeftRect,
            [In] int nTopRect,
            [In] int nRightRect,
            [In] int nBottomRect,
            [In] int nXRadia11,
            [In] int nYRadia11,
            [In] int nXRadia12,
            [In] int nYRadia12);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GetArcDirection(
            [In] IntPtr hdc);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int LineDDA(
            [In] int nXStart,
            [In] int nYStart,
            [In] int nXEnd,
            [In] int nYEnd,
            [In] LineDDAProc lpLineFunc,
            [In] IntPtr lpData);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int LineTo(
            [In] IntPtr hdc,
            [In] int nXEnd,
            [In] int nYEnd);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int MoveToEx(
            [In] IntPtr hdc,
            [In] int X,
            [In] int Y,
            [Out] IntPtr lpPoint);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int MoveToEx(
            [In] IntPtr hdc,
            [In] int X,
            [In] int Y,
            [Out] out POINT lpPoint);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int PolyBezier(
            [In] IntPtr hdc,
            [Const, In] IntPtr lppt,
            [In] uint cPoints);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int PolyBezier(
            [In] IntPtr hdc,
            [In] POINT[] lppt,
            [In] uint cPoints);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int PolyBezierTo(
            [In] IntPtr hdc,
            [Const, In] IntPtr lppt,
            [In] uint cPoints);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int PolyBezierTo(
            [In] IntPtr hdc,
            [In] POINT[] lppt,
            [In] uint cPoints);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int PolyDraw(
            [In] IntPtr hdc,
            [Const, In] IntPtr lppt,
            [Const, In] IntPtr lpbTypes,
            [In] int cCount);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int PolyDraw(
            [In] IntPtr hdc,
            [In] POINT[] lppt,
            [In] byte[] lpbTypes,
            [In] int cCount);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int Polyline(
            [In] IntPtr hdc,
            [Const, In] IntPtr lppt,
            [In] uint cPoints);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int Polyline(
            [In] IntPtr hdc,
            [In] POINT[] lppt,
            [In] uint cPoints);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int PolylineTo(
            [In] IntPtr hdc,
            [Const, In] IntPtr lppt,
            [In] uint cPoints);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int PolylineTo(
            [In] IntPtr hdc,
            [In] POINT[] lppt,
            [In] uint cPoints);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int PolyPolyline(
            [In] IntPtr hdc,
            [Const, In] IntPtr lppt,
            [Const, In] IntPtr lpdwPolyPoints,
            [In] uint cCount);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int PolyPolyline(
            [In] IntPtr hdc,
            [In] POINT[] lppt,
            [In] uint[] lpdwPolyPoints,
            [In] uint cCount);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int SetArcDirection(
            [In] IntPtr hdc,
            [In] int ArcDirection);
    }

    #endregion // Line and curve functions

    #region Meta file functions

    partial class gdi32
    {
        [DllImport(ModuleName, SetLastError = true)]
        public static extern IntPtr CloseEnhMetaFile(
            [In] IntPtr hdc);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern IntPtr CopyEnhMetaFileA(
            [In] IntPtr hemfSrc,
            [In, Const] IntPtr lpszFile);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi)]
        public static extern IntPtr CopyEnhMetaFileA(
            [In] IntPtr hemfSrc,
            [In] string lpszFile);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern IntPtr CopyEnhMetaFileW(
            [In] IntPtr hemfSrc,
            [In, Const] IntPtr lpszFile);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr CopyEnhMetaFileW(
            [In] IntPtr hemfSrc,
            [In] string lpszFile);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern IntPtr CreateEnhMetaFileA(
            [In] IntPtr hdcRef,
            [In, Const] IntPtr lpFilename,
            [In, Const] IntPtr lpRect,
            [In, Const] IntPtr lpDescription);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi)]
        public static extern IntPtr CreateEnhMetaFileA(
            [In] IntPtr hdcRef,
            [In] string lpFilename,
            [In] ref RECT lpRect,
            [In] string lpDescription);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern IntPtr CreateEnhMetaFileW(
            [In] IntPtr hdcRef,
            [In, Const] IntPtr lpFilename,
            [In, Const] IntPtr lpRect,
            [In, Const] IntPtr lpDescription);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr CreateEnhMetaFileW(
            [In] IntPtr hdcRef,
            [In] string lpFilename,
            [In] ref RECT lpRect,
            [In] string lpDescription);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int DeleteEnhMetaFile(
            [In] IntPtr hemf);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int EnumEnhMetaFile(
            [In] IntPtr hdc,
            [In] IntPtr hemf,
            [In] IntPtr lpEnhMetaFunc,
            [In] IntPtr lpdata,
            [In, Const] IntPtr lpRect);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int EnumEnhMetaFile(
            [In] IntPtr hdc,
            [In] IntPtr hemf,
            [In] EnhMetaFileProc lpEnhMetaFunc,
            [In] IntPtr lpdata,
            [In] ref RECT lpRect);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GdiComment(
            [In] IntPtr hdc,
            [In] uint cbSize,
            [Const, In] IntPtr lpData);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GdiComment(
            [In] IntPtr hdc,
            [In] uint cbSize,
            [In] byte[] lpData);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern IntPtr GetEnhMetaFileA(
            [In, Const] IntPtr lpszMetaFile);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi)]
        public static extern IntPtr GetEnhMetaFileA(
            [In] string lpszMetaFile);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern IntPtr GetEnhMetaFileW(
            [In, Const] IntPtr lpszMetaFile);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr GetEnhMetaFileW(
            [In] string lpszMetaFile);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetEnhMetaFileBits(
            [In] IntPtr hemf,
            [In] uint cbBuffer,
            [Out] IntPtr lpbBuffer);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetEnhMetaFileBits(
            [In] IntPtr hemf,
            [In] uint cbBuffer,
            [Out] byte[] lpbBuffer);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetEnhMetaFileDescriptionA(
            [In] IntPtr hemf,
            [In] uint cchBuffer,
            [Out] IntPtr lpszDescription);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern uint GetEnhMetaFileDescriptionA(
            [In] IntPtr hemf,
            [In] uint cchBuffer,
            [Out] StringBuilder lpszDescription);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetEnhMetaFileDescriptionW(
            [In] IntPtr hemf,
            [In] uint cchBuffer,
            [Out] IntPtr lpszDescription);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern uint GetEnhMetaFileDescriptionW(
            [In] IntPtr hemf,
            [In] uint cchBuffer,
            [Out] StringBuilder lpszDescription);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetEnhMetaFileHeader(
            [In] IntPtr hemf,
            [In] uint cbBuffer,
            [Out] IntPtr lpemh);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetEnhMetaFileHeader(
            [In] IntPtr hemf,
            [In] uint cbBuffer,
            [Out] out ENHMETAHEADER lpemh);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetEnhMetaFilePaletteEntries(
            [In] IntPtr hemf,
            [In] uint cEntries,
            [Out] IntPtr lppe);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetEnhMetaFilePaletteEntries(
            [In] IntPtr hemf,
            [In] uint cEntries,
            [Out] PALETTEENTRY[] lppe);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetWinMetaFileBits(
            [In] IntPtr hemf,
            [In] uint cbBuffer,
            [Out] IntPtr lpbBuffer,
            [In] int fnMapMode,
            [In] IntPtr hdcRef);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetWinMetaFileBits(
            [In] IntPtr hemf,
            [In] uint cbBuffer,
            [Out] byte[] lpbBuffer,
            [In] int fnMapMode,
            [In] IntPtr hdcRef);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int PlayEnhMetaFile(
            [In] IntPtr hdc,
            [In] IntPtr hemf,
            [In, Const] IntPtr lpRect);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int PlayEnhMetaFile(
            [In] IntPtr hdc,
            [In] IntPtr hemf,
            [In, Const] ref RECT lpRect);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int PlayEnhMetaFileRecord(
            [In] IntPtr hdc,
            [In] IntPtr lpHandletable,
            [In, Const] IntPtr lpEnhMetaRecord,
            [In] uint nHandles);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int PlayEnhMetaFileRecord(
            [In] IntPtr hdc,
            [In] ref HANDLETABLE lpHandletable,
            [In, Const] ref ENHMETARECORD lpEnhMetaRecord,
            [In] uint nHandles);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern IntPtr SetEnhMetaFileBits(
            [In] uint cbBuffer,
            [In, Const] IntPtr lpData);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern IntPtr SetEnhMetaFileBits(
            [In] uint cbBuffer,
            [In, Const] byte[] lpData);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern IntPtr SetWinMetaFileBits(
            [In] uint cbBuffer,
            [In, Const] IntPtr lpbBuffer,
            [In] IntPtr hdcRef,
            [In, Const] IntPtr lpmfp);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern IntPtr SetWinMetaFileBits(
            [In] uint cbBuffer,
            [In, Const] byte[] lpbBuffer,
            [In] IntPtr hdcRef,
            [In, Const] ref METAFILEPICT lpmfp);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern IntPtr CloseMetaFile(
            [In] IntPtr hdc);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern IntPtr CopyMetaFileA(
            [In] IntPtr hmfSrc,
            [In, Const] IntPtr lpszFile);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi)]
        public static extern IntPtr CopyMetaFileA(
            [In] IntPtr hmfSrc,
            [In] string lpszFile);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern IntPtr CopyMetaFileW(
            [In] IntPtr hmfSrc,
            [In, Const] IntPtr lpszFile);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr CopyMetaFileW(
            [In] IntPtr hmfSrc,
            [In] string lpszFile);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern IntPtr CreateMetaFileA(
            [In, Const] IntPtr lpszFile);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi)]
        public static extern IntPtr CreateMetaFileA(
            [In] string lpszFile);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern IntPtr CreateMetaFileW(
            [In, Const] IntPtr lpszFile);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr CreateMetaFileW(
            [In] string lpszFile);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int DeleteMetaFile(
            [In] IntPtr hmf);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int EnumMetaFile(
            [In] IntPtr hdc,
            [In] IntPtr hmf,
            [In] IntPtr lpMetaFunc,
            [In] IntPtr lParam);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int EnumMetaFile(
            [In] IntPtr hdc,
            [In] IntPtr hmf,
            [In] EnumMetaFileProc lpMetaFunc,
            [In] IntPtr lParam);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetMetaFileBitsEx(
            [In] IntPtr hmf,
            [In] uint nSize,
            [Out] IntPtr lpvData);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int PlayMetaFile(
            [In] IntPtr hdc,
            [In] IntPtr hmf);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int PlayMetaFileRecord(
            [In] IntPtr hdc,
            [In] IntPtr lpHandletable,
            [In] IntPtr lpMetaRecord,
            [In] uint nHandles);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int PlayMetaFileRecord(
            [In] IntPtr hdc,
            [In] ref HANDLETABLE lpHandletable,
            [In] ref METARECORD lpMetaRecord,
            [In] uint nHandles);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern IntPtr SetMetaFileBitsEx(
            [In] uint nSize,
            [In, Const] IntPtr lpData);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern IntPtr SetMetaFileBitsEx(
            [In] uint nSize,
            [In, Const] byte[] lpData);
    }

    #endregion // Meta file functions

    #region Multiple display monitor functions

    partial class gdi32
    {
        [DllImport(ModuleName, SetLastError = true)]
        public static extern int EnumDisplayMonitors(
            [In] IntPtr hdc,
            [In, Const] IntPtr lprcClip,
            [In] IntPtr lpfnEnum,
            [In] IntPtr dwData);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int EnumDisplayMonitors(
            [In] IntPtr hdc,
            [In] ref RECT lprcClip,
            [In] MonitorEnumProc lpfnEnum,
            [In] IntPtr dwData);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GetMonitorInfoA(
            [In] IntPtr hMonitor,
            [Out] IntPtr lpmi);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int GetMonitorInfoA(
            [In] IntPtr hMonitor,
            [Out] out MONITORINFO lpmi);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int GetMonitorInfoA(
            [In] IntPtr hMonitor,
            [Out] out MONITORINFOEX lpmi);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GetMonitorInfoW(
            [In] IntPtr hMonitor,
            [Out] IntPtr lpmi);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int GetMonitorInfoW(
            [In] IntPtr hMonitor,
            [Out] out MONITORINFO lpmi);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int GetMonitorInfoW(
            [In] IntPtr hMonitor,
            [Out] out MONITORINFOEX lpmi);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern IntPtr MonitorFromPoint(
            [In] POINT pt,
            [In] uint dwFlags);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern IntPtr MonitorFromRect(
            [In, Const] IntPtr lprc,
            [In] uint dwFlags);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern IntPtr MonitorFromRect(
            [In] ref RECT lprc,
            [In] uint dwFlags);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern IntPtr MonitorFromWindow(
            [In] IntPtr hwnd,
            [In] uint dwFlags);
    }

    #endregion // Multiple display monitor functions

    #region Painting and drawing functions

    partial class gdi32
    {
        [DllImport(ModuleName, SetLastError = true)]
        public static extern IntPtr BeginPaint(
            [In] IntPtr hwnd,
            [Out] IntPtr lpPaint);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern IntPtr BeginPaint(
            [In] IntPtr hwnd,
            [Out] out PAINTSTRUCT lpPaint);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int DrawAnimatedRects(
            [In] IntPtr hwnd,
            [In] int idAni,
            [In, Const] IntPtr lprcFrom,
            [In, Const] IntPtr lprcTo);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int DrawAnimatedRects(
            [In] IntPtr hwnd,
            [In] int idAni,
            [In] ref RECT lprcFrom,
            [In] ref RECT lprcTo);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int DrawCaption(
            [In] IntPtr hwnd,
            [In] IntPtr hdc,
            [In, Const] IntPtr lprc,
            [In] uint uFlags);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int DrawCaption(
            [In] IntPtr hwnd,
            [In] IntPtr hdc,
            [In] ref RECT lprc,
            [In] uint uFlags);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int DrawEdge(
            [In] IntPtr hdc,
            [In, Out] IntPtr qrc,
            [In] uint edge,
            [In] uint grfFlags);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int DrawEdge(
            [In] IntPtr hdc,
            [In, Out] ref RECT qrc,
            [In] uint edge,
            [In] uint grfFlags);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int DrawFocusRect(
            [In] IntPtr hDC,
            [In, Const] IntPtr lprc);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int DrawFocusRect(
            [In] IntPtr hDC,
            [In] ref RECT lprc);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int DrawFrameControl(
            [In] IntPtr hdc,
            [In] IntPtr lprc,
            [In] uint uType,
            [In] uint uState);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int DrawFrameControl(
            [In] IntPtr hdc,
            [In] ref RECT lprc,
            [In] uint uType,
            [In] uint uState);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int DrawStateA(
            [In] IntPtr hdc,
            [In] IntPtr hbr,
            [In] IntPtr lpOutputFunc,
            [In] IntPtr lData,
            [In] IntPtr wData,
            [In] int x,
            [In] int y,
            [In] int cx,
            [In] int cy,
            [In] uint fuFlags);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int DrawStateA(
            [In] IntPtr hdc,
            [In] IntPtr hbr,
            [In] DrawStateProc lpOutputFunc,
            [In] IntPtr lData,
            [In] IntPtr wData,
            [In] int x,
            [In] int y,
            [In] int cx,
            [In] int cy,
            [In] uint fuFlags);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int DrawStateW(
            [In] IntPtr hdc,
            [In] IntPtr hbr,
            [In] IntPtr lpOutputFunc,
            [In] IntPtr lData,
            [In] IntPtr wData,
            [In] int x,
            [In] int y,
            [In] int cx,
            [In] int cy,
            [In] uint fuFlags);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int DrawStateW(
            [In] IntPtr hdc,
            [In] IntPtr hbr,
            [In] DrawStateProc lpOutputFunc,
            [In] IntPtr lData,
            [In] IntPtr wData,
            [In] int x,
            [In] int y,
            [In] int cx,
            [In] int cy,
            [In] uint fuFlags);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int EndPaint(
            [In] IntPtr hWnd,
            [In, Const] IntPtr lpPaint);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int EndPaint(
            [In] IntPtr hWnd,
            [In] ref PAINTSTRUCT lpPaint);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int ExcludeUpdateRgn(
            [In] IntPtr hDC,
            [In] IntPtr hWnd);

        [DllImport(ModuleName)]
        public static extern int GdiFlush();

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GdiGetBatchLimit();

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GdiSetBatchLimit(uint dwLimit);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern uint GetBkColor(
            [In] IntPtr hdc);

        [DllImport(ModuleName)]
        public static extern int GetBkMode(
            [In] IntPtr hdc);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern uint GetBoundsRect(
            [In] IntPtr hdc,
            [In] IntPtr lprcBounds,
            [In] uint flags);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern uint GetBoundsRect(
            [In] IntPtr hdc,
            [In] ref RECT lprcBounds,
            [In] uint flags);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GetROP2(
            [In] IntPtr hdc);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GetUpdateRect(
            [In] IntPtr hwnd,
            [Out] IntPtr lpRect,
            [In] int bErase);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GetUpdateRect(
            [In] IntPtr hwnd,
            [Out] out RECT lpRect,
            [In] int bErase);

        [DllImport(ModuleName)]
        public static extern int GetUpdateRgn(
            [In] IntPtr hWnd,
            [In] IntPtr hRgn,
            [In] int bErase);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern IntPtr GetWindowDC(
            [In] IntPtr hWnd);

        [DllImport(ModuleName)]
        public static extern int GetWindowRgn(
            [In] IntPtr hWnd,
            [In] IntPtr hRgn);

        [DllImport(ModuleName)]
        public static extern int GetWindowRgnBox(
            [In] IntPtr hWnd,
            [Out] IntPtr lprc);

        [DllImport(ModuleName)]
        public static extern int GetWindowRgnBox(
            [In] IntPtr hWnd,
            [Out] out RECT lprc);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GrayStringA(
            [In] IntPtr hDC,
            [In] IntPtr hBrush,
            [In] IntPtr lpOutputFunc,
            [In] IntPtr lpData,
            [In] int nCount,
            [In] int X,
            [In] int Y,
            [In] int nWidth,
            [In] int nHeight);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GrayStringA(
            [In] IntPtr hDC,
            [In] IntPtr hBrush,
            [In] OutputProc lpOutputFunc,
            [In] IntPtr lpData,
            [In] int nCount,
            [In] int X,
            [In] int Y,
            [In] int nWidth,
            [In] int nHeight);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GrayStringW(
            [In] IntPtr hDC,
            [In] IntPtr hBrush,
            [In] IntPtr lpOutputFunc,
            [In] IntPtr lpData,
            [In] int nCount,
            [In] int X,
            [In] int Y,
            [In] int nWidth,
            [In] int nHeight);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GrayStringW(
            [In] IntPtr hDC,
            [In] IntPtr hBrush,
            [In] OutputProc lpOutputFunc,
            [In] IntPtr lpData,
            [In] int nCount,
            [In] int X,
            [In] int Y,
            [In] int nWidth,
            [In] int nHeight);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int InvalidateRect(
            [In] IntPtr hWnd,
            [In, Const] IntPtr lpRect,
            [In] int bErase);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int InvalidateRect(
            [In] IntPtr hWnd,
            [In] ref RECT lpRect,
            [In] int bErase);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int InvalidateRgn(
            [In] IntPtr hWnd,
            [In] IntPtr hRgn,
            [In] int bErase);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int LockWindowUpdate(
            [In] IntPtr hWndLock);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int PaintDesktop(
            [In] IntPtr hdc);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int RedrawWindow(
            [In] IntPtr hWnd,
            [In, Const] IntPtr lprcUpdate,
            [In] IntPtr hrgnUpdate,
            [In] uint flags);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int RedrawWindow(
            [In] IntPtr hWnd,
            [In] ref RECT lprcUpdate,
            [In] IntPtr hrgnUpdate,
            [In] uint flags);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint SetBkColor(
            [In] IntPtr hdc,
            [In] uint crColor);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int SetBkMode(
            [In] IntPtr hdc,
            [In] int iBkMode);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint SetBoundsRect(
            [In] IntPtr hdc,
            [In, Const] IntPtr lprcBounds,
            [In] uint flags);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint SetBoundsRect(
            [In] IntPtr hdc,
            [In] ref RECT lprcBounds,
            [In] uint flags);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int SetROP2(
            [In] IntPtr hdc,
            [In] int fnDrawMode);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int SetWindowRgn(
            [In] IntPtr hWnd,
            [In] IntPtr hRgn,
            [In] int bRedraw);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int UpdateWindow(
            [In] IntPtr hWnd);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int ValidateRect(
            [In] IntPtr hWnd,
            [In, Const] IntPtr lpRect);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int ValidateRect(
            [In] IntPtr hWnd,
            [In] ref RECT lpRect);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int ValidateRgn(
            [In] IntPtr hWnd,
            [In] IntPtr hRgn);

        [DllImport(ModuleName)]
        public static extern IntPtr WindowFromDC(
            [In] IntPtr hDC);
    }

    #endregion // Painting and drawing functions

    #region Path functions

    partial class gdi32
    {
        [DllImport(ModuleName, SetLastError = true)]
        public static extern int AbortPath(
            [In] IntPtr hdc);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int BeginPath(
            [In] IntPtr hdc);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int CloseFigure(
            [In] IntPtr hdc);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int EndPath(
            [In] IntPtr hdc);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int FillPath(
            [In] IntPtr hdc);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int FlattenPath(
            [In] IntPtr hdc);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GetMiterLimit(
            [In] IntPtr hdc,
            [Out] IntPtr peLimit);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GetMiterLimit(
            [In] IntPtr hdc,
            [Out] out float peLimit);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GetPath(
            [In] IntPtr hdc,
            [Out] IntPtr lpPoints,
            [Out] IntPtr lpTypes,
            [In] int nSize);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GetPath(
            [In] IntPtr hdc,
            [Out] POINT[] lpPoints,
            [Out] byte[] lpTypes,
            [In] int nSize);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern IntPtr PathToRegion(
            [In] IntPtr hdc);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int SetMiterLimit(
            [In] IntPtr hdc,
            [In] float eNewLimit,
            [Out] IntPtr peOldLimit);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int SetMiterLimit(
            [In] IntPtr hdc,
            [In] float eNewLimit,
            [Out] out float peOldLimit);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int StrokeAndFillPath(
            [In] IntPtr hdc);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int StrokePath(
            [In] IntPtr hdc);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int WidenPath(
            [In] IntPtr hdc);
    }

    #endregion // Path functions

    #region Pen functions

    partial class gdi32
    {
        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern IntPtr CreatePen(
            [In] int fnPenStyle,
            [In] int nWidth,
            [In] uint crColor);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern IntPtr CreatePenDirect(
            [In, Const] IntPtr lplgpn);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern IntPtr CreatePenDirect(
            [In] ref LOGPEN lplgpn);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern IntPtr ExtCreatePen(
            [In] uint dwPenStyle,
            [In] uint dwWidth,
            [In, Const] IntPtr lplb,
            [In] uint dwStyleCount,
            [In, Const] IntPtr lpStyle);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern IntPtr ExtCreatePen(
            [In] uint dwPenStyle,
            [In] uint dwWidth,
            [In] ref LOGBRUSH lplb,
            [In] uint dwStyleCount,
            [In] ref uint[] lpStyle);
    }

    #endregion // Pen functions

    #region Rectangle functions

    partial class gdi32
    {
        [DllImport(ModuleName, SetLastError = true)]
        public static extern int CopyRect(
            [Out] IntPtr lprcDst,
            [In, Const] IntPtr lprcSrc);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int CopyRect(
            [Out] out RECT lprcDst,
            [In, Const] ref RECT lprcSrc);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int EqualRect(
            [In, Const] IntPtr lprc1,
            [In, Const] IntPtr lprc2);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int EqualRect(
            [In] ref RECT lprc1,
            [In] ref RECT lprc2);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int InflateRect(
            [In, Out] IntPtr lprc,
            [In] int dx,
            [In] int dy);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int InflateRect(
            [In, Out] ref RECT lprc,
            [In] int dx,
            [In] int dy);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int IsRectEmpty(
            [In, Const] IntPtr lprc);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int IsRectEmpty(
            [In] ref RECT lprc);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int OffsetRect(
            [In, Out] IntPtr lprc,
            [In] int dx,
            [In] int dy);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int OffsetRect(
            [In, Out] ref RECT lprc,
            [In] int dx,
            [In] int dy);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int PtInRect(
            [In, Const] IntPtr lprc,
            [In] POINT pt);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int PtInRect(
            [In] ref RECT lprc,
            [In] POINT pt);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int SetRect(
            [In] IntPtr lprc,
            [In] int xLeft,
            [In] int yTop,
            [In] int xRight,
            [In] int yBottom);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int SetRect(
            [In] ref RECT lprc,
            [In] int xLeft,
            [In] int yTop,
            [In] int xRight,
            [In] int yBottom);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int SetRectEmpty(
            [In] IntPtr lprc);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int SetRectEmpty(
            [In] ref RECT lprc);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int SubtractRect(
            [Out] IntPtr lprcDst,
            [In, Const] IntPtr lprcSrc1,
            [In, Const] IntPtr lprcSrc2);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int SubtractRect(
            [Out] out RECT lprcDst,
            [In, Const] ref RECT lprcSrc1,
            [In, Const] ref RECT lprcSrc2);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int UnionRect(
            [Out] IntPtr lprcDst,
            [In, Const] IntPtr lprcSrc1,
            [In, Const] IntPtr lprcSrc2);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int UnionRect(
            [Out] out RECT lprcDst,
            [In, Const] ref RECT lprcSrc1,
            [In, Const] ref RECT lprcSrc2);
    }

    #endregion // Rectangle functions

    #region Region functions

    partial class gdi32
    {
        [DllImport(ModuleName)]
        public static extern int CombineRgn(
            [In] IntPtr hrgnDest,
            [In] IntPtr hrgnSrc1,
            [In] IntPtr hrgnSrc2,
            [In] int fnCombineMode);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern IntPtr CreateEllipticRgn(
            [In] int nLeftRect,
            [In] int nTopRect,
            [In] int nRightRect,
            [In] int nBottomRect);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern IntPtr CreateEllipticRgnIndirect(
            [In, Const] IntPtr lprc);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern IntPtr CreateEllipticRgnIndirect(
            [In] ref RECT lprc);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern IntPtr CreatePolygonRgn(
            [In, Const] IntPtr lppt,
            [In] int cPoints,
            [In] int fnPolyFillMode);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern IntPtr CreatePolygonRgn(
            [In] POINT[] lppt,
            [In] int cPoints,
            [In] int fnPolyFillMode);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern IntPtr CreatePolyPolygonRgn(
            [In, Const] IntPtr lppt,
            [In, Const] IntPtr lpPolyCounts,
            [In] int nCount,
            [In] int fnPolyFillMode);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern IntPtr CreatePolyPolygonRgn(
            [In] POINT[] lppt,
            [In] int[] lpPolyCounts,
            [In] int nCount,
            [In] int fnPolyFillMode);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern IntPtr CreateRectRgn(
            [In] int nLeftRect,
            [In] int nTopRect,
            [In] int nRightRect,
            [In] int nBottomRect);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern IntPtr CreateRectRgnIndirect(
            [In, Const] IntPtr lprc);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern IntPtr CreateRectRgnIndirect(
            [In] ref RECT lprc);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern IntPtr CreateRoundRectRgn(
            [In] int nLeftRect,
            [In] int nTopRect,
            [In] int nRightRect,
            [In] int nBottomRect,
            [In] int nWidthEllipse,
            [In] int nHeightEllipse);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int EqualRgn(
            [In] IntPtr hSrcRgn1,
            [In] IntPtr hSrcRgn2);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern IntPtr ExtCreateRegion(
            [In, Const] IntPtr lpXform,
            [In] uint nCount,
            [In, Const] IntPtr lpRgnData);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern IntPtr ExtCreateRegion(
            [In, Const] ref XFORM lpXform,
            [In] uint nCount,
            [In, Const] ref RGNDATA lpRgnData);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int FillRgn(
            [In] IntPtr hdc,
            [In] IntPtr hrgn,
            [In] IntPtr hbr);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int FrameRgn(
            [In] IntPtr hdc,
            [In] IntPtr hrgn,
            [In] IntPtr hbr,
            [In] int nWidth,
            [In] int nHeight);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GetPolyFillMode(
            [In] IntPtr hdc);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetRegionData(
            [In] IntPtr hRgn,
            [In] uint dwCount,
            [Out] IntPtr lpRgnData);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetRegionData(
            [In] IntPtr hRgn,
            [In] uint dwCount,
            [Out] out RGNDATA lpRgnData);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GetRgnBox(
            [In] IntPtr hrgn,
            [Out] IntPtr lprc);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GetRgnBox(
            [In] IntPtr hrgn,
            [Out] out RECT lprc);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int InvertRgn(
            [In] IntPtr hdc,
            [In] IntPtr hrgn);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int OffsetRgn(
            [In] IntPtr hrgn,
            [In] int nXOffset,
            [In] int nYOffset);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int PaintRgn(
            [In] IntPtr hdc,
            [In] IntPtr hrgn);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int PtInRegion(
            [In] IntPtr hrgn,
            [In] int x,
            [In] int y);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int RectInRegion(
            [In] IntPtr hrgn,
            [In, Const] IntPtr lprc);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int RectInRegion(
            [In] IntPtr hrgn,
            [In] ref RECT lprc);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int SetPolyFillMode(
            [In] IntPtr hdc,
            [In] int iPolyFillMode);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int SetRectRgn(
            [In] IntPtr hrgn,
            [In] int nLeftRect,
            [In] int nTopRect,
            [In] int nRightRect,
            [In] int nBottomRect);
    }

    #endregion // Region functions

    #region Windows color system basic functions

    partial class gdi32
    {
        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int CheckColorsInGamut(
            [In] IntPtr hDC,
            [In] IntPtr lpRGBTriples,
            [In] IntPtr lpBuffer,
            [In] uint nCount);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int ColorCorrectPalette(
            [In] IntPtr hDC,
            [In] IntPtr hPalette,
            [In] uint dwFirstEntry,
            [In] uint dwNumOfEntries);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int ColorMatchToTarget(
            [In] IntPtr hDC,
            [In] IntPtr hdcTarget,
            [In] uint uiAction);

        [DllImport(ModuleName)]
        public static extern IntPtr CreateColorSpaceA(
            [In] IntPtr lpLogColorSpace);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr CreateColorSpaceA(
            [In] ref LOGCOLORSPACE lpLogColorSpace);

        [DllImport(ModuleName)]
        public static extern IntPtr CreateColorSpaceW(
            [In] IntPtr lpLogColorSpace);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr CreateColorSpaceW(
            [In] ref LOGCOLORSPACEW lpLogColorSpace);

        [DllImport(ModuleName)]
        public static extern int DeleteColorSpace(
            [In] IntPtr hColorSpace);

        [DllImport(ModuleName)]
        public static extern int EnumICMProfiles(
            [In] IntPtr hDC,
            [In] IntPtr lpEnumICMProfilesFunc,
            [In] IntPtr lParam);

        [DllImport(ModuleName)]
        public static extern int EnumICMProfiles(
            [In] IntPtr hDC,
            [In] EnumICMProfilesProcCallback lpEnumICMProfilesFunc,
            [In] IntPtr lParam);

        [DllImport(ModuleName)]
        public static extern IntPtr GetColorSpace(
            [In] IntPtr hDC);

        [DllImport(ModuleName)]
        public static extern int GetICMProfileA(
            [In] IntPtr hDC,
            [In] IntPtr lpcbName,
            [In] IntPtr lpszFilename);

        [DllImport(ModuleName, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int GetICMProfileA(
            [In] IntPtr hDC,
            [In] ref uint lpcbName,
            [In] StringBuilder lpszFilename);

        [DllImport(ModuleName)]
        public static extern int GetICMProfileW(
            [In] IntPtr hDC,
            [In] IntPtr lpcbName,
            [In] IntPtr lpszFilename);

        [DllImport(ModuleName, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int GetICMProfileW(
            [In] IntPtr hDC,
            [In] ref uint lpcbName,
            [In] StringBuilder lpszFilename);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetLogColorSpaceA(
            [In] IntPtr hColorSpace,
            [In] IntPtr lpBuffer,
            [In] uint nSize);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetLogColorSpaceA(
            [In] IntPtr hColorSpace,
            [Out] out LOGCOLORSPACE lpBuffer,
            [In] uint nSize);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetLogColorSpaceW(
            [In] IntPtr hColorSpace,
            [In] IntPtr lpBuffer,
            [In] uint nSize);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetLogColorSpaceW(
            [In] IntPtr hColorSpace,
            [Out] out LOGCOLORSPACEW lpBuffer,
            [In] uint nSize);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int SetColorSpace(
            [In] IntPtr hDC,
            [In] IntPtr hColorSpace);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int SetICMMode(
            [In] IntPtr hDC,
            [In] int iEnableICM);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int SetICMProfileA(
            [In] IntPtr hDC,
            [In] IntPtr lpFileName);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int SetICMProfileA(
            [In] IntPtr hDC,
            [In] string lpFileName);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int SetICMProfileW(
            [In] IntPtr hDC,
            [In] IntPtr lpFileName);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern int SetICMProfileW(
            [In] IntPtr hDC,
            [In] string lpFileName);
    }

    #endregion // Windows color system basic functions
}
