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
        [DllImport(ModuleName, SetLastError = true)]
        public static extern void DrawInsert(
            [In] IntPtr handParent,
            [In] IntPtr hLB,
            [In] int nItem);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int LBItemFromPt(
            [In] IntPtr hLB,
            [In] POINT pt,
            [In] int bAutoScroll);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int MakeDragList(
            [In] IntPtr hLB);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int FlatSB_EnableScrollBar(
            [In] IntPtr hwnd,
            [In] int wSBflags,
            [In] uint wArrows);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int FlatSB_GetScrollInfo(
            [In] IntPtr hwnd,
            [In] int fnBar,
            [Out] IntPtr lpsi);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int FlatSB_GetScrollInfo(
            [In] IntPtr hwnd,
            [In] int fnBar,
            [Out] out SCROLLINFO lpsi);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int FlatSB_GetScrollPos(
            [In] IntPtr hwnd,
            [In] int code);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int FlatSB_GetScrollProp(
            [In] IntPtr hwnd,
            [In] uint index,
            [Out] IntPtr pValue);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int FlatSB_GetScrollProp(
            [In] IntPtr hwnd,
            [In] uint index,
            [Out] out int pValue);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int FlatSB_GetScrollPropPtr(
            [In] IntPtr hwnd,
            [In] uint index,
            [Out] IntPtr pValue);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int FlatSB_GetScrollPropPtr(
            [In] IntPtr hwnd,
            [In] uint index,
            [Out] out int pValue);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int FlatSB_GetScrollRange(
            [In] IntPtr hwnd,
            [In] int code,
            [Out] IntPtr lpMinPos,
            [Out] IntPtr lpMaxPos);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int FlatSB_GetScrollRange(
            [In] IntPtr hwnd,
            [In] int code,
            [Out] out int lpMinPos,
            [Out] out int lpMaxPos);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int FlatSB_SetScrollInfo(
            [In] IntPtr hwnd,
            [In] int fnBar,
            [In] IntPtr lpsi,
            [In] int fRedraw);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int FlatSB_SetScrollInfo(
            [In] IntPtr hwnd,
            [In] int fnBar,
            [In] ref SCROLLINFO lpsi,
            [In] int fRedraw);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int FlatSB_SetScrollPos(
            [In] IntPtr hwnd,
            [In] int code,
            [In] int nPos,
            [In] int fRedraw);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int FlatSB_SetScrollProp(
            [In] IntPtr hwnd,
            [In] uint index,
            [In] int newValue,
            [In] int fRedraw);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int FlatSB_SetScrollRange(
            [In] IntPtr hwnd,
            [In] int code,
            [In] int nMinPos,
            [In] int nMaxPos,
            [In] int fRedraw);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int FlatSB_ShowScrollBar(
            [In] IntPtr hwnd,
            [In] int code,
            [In] int fShow);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int InitializeFlatSB(
            [In] IntPtr hwnd);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int UninitializeFlatSB(
            [In] IntPtr hwnd);
    }

    #endregion // Common control functions
}
