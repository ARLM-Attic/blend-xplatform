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
    }

    #endregion // Device context functions
}
