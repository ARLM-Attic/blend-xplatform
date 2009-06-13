using System;
using System.Text;
using xPlatform.Flags;
using xPlatform.x86.gdi32;
using xPlatform.x86.user32;
using System.Runtime.InteropServices;

namespace xPlatform.x86.comctl32
{
    [Serializable]
    public partial class comctl32 : ModuleBase<comctl32>
    {
        [NonSerialized]
        public const string ModuleName = "comctl32.dll";
    }

    #region Common control functions

    partial class comctl32
    {
        [DllImport(ModuleName)]
        public static extern void DrawInsert(
            [In] IntPtr handParent,
            [In] IntPtr hLB,
            [In] int nItem);

        [DllImport(ModuleName)]
        public static extern int LBItemFromPt(
            [In] IntPtr hLB,
            [In] POINT pt,
            [In] int bAutoScroll);

        [DllImport(ModuleName)]
        public static extern int MakeDragList(
            [In] IntPtr hLB);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int FlatSB_EnableScrollBar(
            [In] IntPtr hwnd,
            [In] int wSBflags,
            [In] uint wArrows);

        [DllImport(ModuleName)]
        public static extern int FlatSB_GetScrollInfo(
            [In] IntPtr hwnd,
            [In] int fnBar,
            [Out] IntPtr lpsi);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int FlatSB_GetScrollInfo(
            [In] IntPtr hwnd,
            [In] int fnBar,
            [Out] out SCROLLINFO lpsi);

        [DllImport(ModuleName)]
        public static extern int FlatSB_GetScrollPos(
            [In] IntPtr hwnd,
            [In] int code);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int FlatSB_GetScrollProp(
            [In] IntPtr hwnd,
            [In] uint index,
            [Out] IntPtr pValue);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int FlatSB_GetScrollProp(
            [In] IntPtr hwnd,
            [In] uint index,
            [Out] out int pValue);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int FlatSB_GetScrollPropPtr(
            [In] IntPtr hwnd,
            [In] uint index,
            [Out] IntPtr pValue);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int FlatSB_GetScrollPropPtr(
            [In] IntPtr hwnd,
            [In] uint index,
            [Out] out int pValue);

        [DllImport(ModuleName)]
        public static extern int FlatSB_GetScrollRange(
            [In] IntPtr hwnd,
            [In] int code,
            [Out] IntPtr lpMinPos,
            [Out] IntPtr lpMaxPos);

        [DllImport(ModuleName)]
        public static extern int FlatSB_GetScrollRange(
            [In] IntPtr hwnd,
            [In] int code,
            [Out] out int lpMinPos,
            [Out] out int lpMaxPos);

        [DllImport(ModuleName)]
        public static extern int FlatSB_SetScrollInfo(
            [In] IntPtr hwnd,
            [In] int fnBar,
            [In] IntPtr lpsi,
            [In] int fRedraw);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int FlatSB_SetScrollInfo(
            [In] IntPtr hwnd,
            [In] int fnBar,
            [In] ref SCROLLINFO lpsi,
            [In] int fRedraw);

        [DllImport(ModuleName)]
        public static extern int FlatSB_SetScrollPos(
            [In] IntPtr hwnd,
            [In] int code,
            [In] int nPos,
            [In] int fRedraw);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int FlatSB_SetScrollProp(
            [In] IntPtr hwnd,
            [In] uint index,
            [In] int newValue,
            [In] int fRedraw);

        [DllImport(ModuleName)]
        public static extern int FlatSB_SetScrollRange(
            [In] IntPtr hwnd,
            [In] int code,
            [In] int nMinPos,
            [In] int nMaxPos,
            [In] int fRedraw);

        [DllImport(ModuleName)]
        public static extern int FlatSB_ShowScrollBar(
            [In] IntPtr hwnd,
            [In] int code,
            [In] int fShow);

        [DllImport(ModuleName)]
        public static extern int InitializeFlatSB(
            [In] IntPtr hwnd);

        [DllImport(ModuleName)]
        public static extern int UninitializeFlatSB(
            [In] IntPtr hwnd);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern uint HIMAGELIST_QueryInterface(
            [In] IntPtr himl,
            [In] IntPtr riid,
            [Out] IntPtr ppv);

        [DllImport(ModuleName)]
        public static extern int ImageList_Add(
            [In] IntPtr himl,
            [In] IntPtr hbmImage,
            [In] IntPtr hbmMask);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int ImageList_AddMasked(
            [In] IntPtr himl,
            [In] IntPtr hbmImage,
            [In] uint crMask);

        [DllImport(ModuleName)]
        public static extern int ImageList_BeginDrag(
            [In] IntPtr himlTrack,
            [In] int iTrack,
            [In] int dxHotspot,
            [In] int dyHotspot);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern uint ImageList_CoCreateInstance(
            [In] IntPtr rclsid,
            [In, Const] IntPtr punkOuter,
            [In] IntPtr riid,
            [Out] IntPtr ppv);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int ImageList_Copy(
            [In] IntPtr himlDst,
            [In] IntPtr himlSrc,
            [In] int iDst,
            [In] int iSrc,
            [In] uint uFlags);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr ImageList_Create(
            [In] int cx,
            [In] int cy,
            [In] uint flags,
            [In] int cInitial,
            [In] int cGrow);

        [DllImport(ModuleName)]
        public static extern int ImageList_Destroy(
            [In] IntPtr himl);

        [DllImport(ModuleName)]
        public static extern int ImageList_DragEnter(
            [In] IntPtr hwndLock,
            [In] int x,
            [In] int y);

        [DllImport(ModuleName)]
        public static extern int ImageList_DragLeave(
            [In] IntPtr hwndLock);

        [DllImport(ModuleName)]
        public static extern int ImageList_DragMove(
            [In] int x,
            [In] int y);

        [DllImport(ModuleName)]
        public static extern int ImageList_DragShowNolock(
            [In] int fShow);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int ImageList_Draw(
            [In] IntPtr himl,
            [In] int i,
            [In] IntPtr hdcDst,
            [In] int x,
            [In] int y,
            [In] uint fStyle);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int ImageList_DrawEx(
            [In] IntPtr himl,
            [In] int i,
            [In] IntPtr hdcDst,
            [In] int x,
            [In] int y,
            [In] int dx,
            [In] int dy,
            [In] uint rgbBk,
            [In] uint rgbFg,
            [In] uint fStyle);

        [DllImport(ModuleName)]
        public static extern int ImageList_DrawIndirect(
            [In] IntPtr pimldp);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int ImageList_DrawIndirect(
            [In] ref IMAGELISTDRAWPARAMS pimldp);

        [DllImport(ModuleName)]
        public static extern IntPtr ImageList_Duplicate(
            [In] IntPtr himl);

        [DllImport(ModuleName)]
        public static extern void ImageList_EndDrag();

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern uint ImageList_GetBkColor(
            [In] IntPtr himl);

        [DllImport(ModuleName)]
        public static extern IntPtr ImageList_GetDragImages(
            [Out] IntPtr ppt,
            [Out] IntPtr pptHotspot);

        [DllImport(ModuleName)]
        public static extern IntPtr ImageList_GetDragImages(
            [Out] out POINT ppt,
            [Out] out POINT pptHotspot);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr ImageList_GetIcon(
            [In] IntPtr himl,
            [In] int i,
            [In] uint flags);

        [DllImport(ModuleName)]
        public static extern int ImageList_GetIconSize(
            [In] IntPtr himl,
            [Out] IntPtr cx,
            [Out] IntPtr cy);

        [DllImport(ModuleName)]
        public static extern int ImageList_GetIconSize(
            [In] IntPtr himl,
            [Out] out int cx,
            [Out] out int cy);

        [DllImport(ModuleName)]
        public static extern int ImageList_GetImageCount(
            [In] IntPtr himl);

        [DllImport(ModuleName)]
        public static extern int ImageList_GetImageInfo(
            [In] IntPtr himl,
            [In] int i,
            [Out] IntPtr pImageInfo);

        [DllImport(ModuleName)]
        public static extern int ImageList_GetImageInfo(
            [In] IntPtr himl,
            [In] int i,
            [Out] out IMAGEINFO pImageInfo);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr ImageList_LoadImageA(
            [In] IntPtr hi,
            [In, Const] IntPtr lpbmp,
            [In] int cx,
            [In] int cGrow,
            [In] uint crMask,
            [In] uint uType,
            [In] uint uFlags);

        [DllImport(ModuleName, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern IntPtr ImageList_LoadImageA(
            [In] IntPtr hi,
            [In] string lpbmp,
            [In] int cx,
            [In] int cGrow,
            [In] uint crMask,
            [In] uint uType,
            [In] uint uFlags);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr ImageList_LoadImageW(
            [In] IntPtr hi,
            [In, Const] IntPtr lpbmp,
            [In] int cx,
            [In] int cGrow,
            [In] uint crMask,
            [In] uint uType,
            [In] uint uFlags);

        [DllImport(ModuleName, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern IntPtr ImageList_LoadImageW(
            [In] IntPtr hi,
            [In] string lpbmp,
            [In] int cx,
            [In] int cGrow,
            [In] uint crMask,
            [In] uint uType,
            [In] uint uFlags);

        [DllImport(ModuleName)]
        public static extern IntPtr ImageList_Merge(
            [In] IntPtr himl1,
            [In] int i1,
            [In] IntPtr himl2,
            [In] int i2,
            [In] int dx,
            [In] int dy);

        [DllImport(ModuleName)]
        public static extern IntPtr ImageList_Read(
            [In] IntPtr pstm);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern uint ImageList_ReadEx(
            [In] uint dwFlags,
            [In] IntPtr pstm,
            [In] IntPtr riid,
            [Out] IntPtr ppv);

        [DllImport(ModuleName)]
        public static extern int ImageList_Remove(
            [In] IntPtr himl,
            [In] int i);

        [DllImport(ModuleName)]
        public static extern int ImageList_Replace(
            [In] IntPtr himl,
            [In] int i,
            [In] IntPtr hbmImage,
            [In] IntPtr hbmMask);

        [DllImport(ModuleName)]
        public static extern int ImageList_ReplaceIcon(
            [In] IntPtr himl,
            [In] int i,
            [In] IntPtr hicon);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern uint ImageList_SetBkColor(
            [In] IntPtr himl,
            [In] uint clrBk);

        [DllImport(ModuleName)]
        public static extern int ImageList_SetColorTable(
            [In] IntPtr himl,
            [In] int start,
            [In] int len,
            [In] IntPtr prgb);

        [DllImport(ModuleName)]
        public static extern int ImageList_SetColorTable(
            [In] IntPtr himl,
            [In] int start,
            [In] int len,
            [In] RGBQUAD[] prgb);

        [DllImport(ModuleName)]
        public static extern int ImageList_SetDragCursorImage(
            [In] IntPtr himlDrag,
            [In] int iDrag,
            [In] int dxHotspot,
            [In] int dyHotspot);

        [DllImport(ModuleName)]
        public static extern int ImageList_SetIconSize(
            [In] IntPtr himl,
            [In] int cx,
            [In] int cy);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int ImageList_SetImageCount(
            [In] IntPtr himl,
            [In] uint uNewCount);

        [DllImport(ModuleName)]
        public static extern int ImageList_SetOverlayImage(
            [In] IntPtr himl,
            [In] int iImage,
            [In] int iOverlay);

        [DllImport(ModuleName)]
        public static extern int ImageList_Write(
            [In] IntPtr himl,
            [In] IntPtr pstm);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int ImageList_WriteEx(
            [In] IntPtr himl,
            [In] uint dwFlags,
            [In] IntPtr pstm);
    }

    #endregion // Common control functions
}
