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

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi)]
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

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int EnumFontFamiliesW(
            [In] IntPtr hdc,
            [In] string lpszFamily,
            [In] EnumFontFamProc lpEnumFontFamProc,
            [In] IntPtr lParam);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int EnumFontFamiliesExA(
            [In] IntPtr hdc,
            [In] IntPtr lpLogfont,
            [In] IntPtr lpEnumFontFamExProc,
            [In] IntPtr lParam,
            uint dwFlags);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi)]
        public static extern int EnumFontFamiliesExA(
            [In] IntPtr hdc,
            [In] ref LOGFONT lpLogfont,
            [In] EnumFontFamExProc lpEnumFontFamExProc,
            [In] IntPtr lParam,
            uint dwFlags);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int EnumFontFamiliesExW(
            [In] IntPtr hdc,
            [In] IntPtr lpLogfont,
            [In] IntPtr lpEnumFontFamExProc,
            [In] IntPtr lParam,
            uint dwFlags);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode)]
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

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi)]
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

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode)]
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
    }

    #endregion // Font and text functions
}
