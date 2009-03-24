using System;
using xPlatform.Flags;
using System.Runtime.InteropServices;

namespace xPlatform.x86.msvcrt
{
    [Serializable]
    public partial class msvcrt : ModuleBase<msvcrt>
    {
        [NonSerialized]
        public const string ModuleName = "msvcrt.dll";
    }

    partial class msvcrt
    {
        /// <summary>
        /// Copies characters from a buffer.
        /// </summary>
        /// <remarks>
        /// The _memccpy function copies 0 or more bytes of src to dest, halting when the character c has been copied or when count bytes have been copied, whichever comes first.
        /// </remarks>
        /// <param name="dest">Pointer to destination</param>
        /// <param name="src">Pointer to source</param>
        /// <param name="c">Last character to copy</param>
        /// <param name="count">Number of characters</param>
        /// <returns>If the character c is copied, _memccpy returns a pointer to the byte in dest that immediately follows the character. If c is not copied, it returns NULL.</returns>
        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _memccpy(IntPtr dest, [Const] IntPtr src, int c, uint count);

        /// <summary>
        /// Finds characters in a buffer.
        /// </summary>
        /// <remarks>
        /// The memchr function looks for the first occurrence of c in the first count bytes of buf. It stops when it finds c or when it has checked the first count bytes.
        /// </remarks>
        /// <param name="buf">Pointer to buffer</param>
        /// <param name="c">Character to look for</param>
        /// <param name="count">Number of characters to check</param>
        /// <returns>If successful, memchr returns a pointer to the first location of c in buf. Otherwise it returns NULL.</returns>
        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr memchr(IntPtr buf, int c, size_t count);

        /// <summary>
        /// Compare characters in two buffers.
        /// </summary>
        /// <remarks>
        /// The memcmp function compares the first count bytes of buf1 and buf2 and returns a value indicating their relationship.
        /// </remarks>
        /// <param name="buf1">First buffer</param>
        /// <param name="buf2">Second buffer</param>
        /// <param name="count">Number of characters</param>
        /// <returns>
        /// The return value indicates the relationship between the buffers.
        /// &quot;&lt;0&quot; buf1 less than buf2
        /// &quot;0&quot; buf1 identical to buf2
        /// &quot;&gt;0&quot; buf1 greater than buf2
        /// </returns>
        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int memcmp([Const] IntPtr buf1, [Const] IntPtr buf2, size_t count);

        /// <summary>
        /// Copies characters between buffers.
        /// </summary>
        /// <remarks>
        /// The memcpy function copies count bytes of src to dest. If the source and destination overlap, this function does not ensure that the original source bytes in the overlapping region are copied before being overwritten. Use memmove to handle overlapping regions.
        /// </remarks>
        /// <param name="dest">New buffer</param>
        /// <param name="src">Buffer to copy from</param>
        /// <param name="count">Number of characters to copy</param>
        /// <returns>memcpy returns the value of dest.</returns>
        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr memcpy(IntPtr dest, [Const] IntPtr src, size_t count);

        /// <summary>
        /// Compares characters in two buffers (case-insensitive).
        /// </summary>
        /// <remarks>
        /// The _memicmp function compares the first count characters of the two buffers buf1 and buf2 byte by byte. The comparison is not case sensitive.
        /// </remarks>
        /// <param name="buf1">First buffer</param>
        /// <param name="buf2">Second buffer</param>
        /// <param name="count">Number of characters</param>
        /// <returns>
        /// The return value indicates the relationship between the buffers.
        /// &quot;&lt;0&quot; buf1 less than buf2
        /// &quot;0&quot; buf1 identical to buf2
        /// &quot;&gt;0&quot; buf1 greater than buf2
        /// </returns>
        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _memicmp([Const] IntPtr buf1, [Const] IntPtr buf2, uint count);

        /// <summary>
        /// Moves one buffer to another.
        /// </summary>
        /// <remarks>The memmove function copies count bytes of characters from src to dest. If some regions of the source area and the destination overlap, memmove ensures that the original source bytes in the overlapping region are copied before being overwritten.</remarks>
        /// <param name="dest">Destination object</param>
        /// <param name="src">Source object</param>
        /// <param name="count">Number of bytes of characters to copy</param>
        /// <returns>memmove returns the value of dest.</returns>
        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr memmove(IntPtr dest, [Const] IntPtr src, size_t count);

        /// <summary>
        /// Sets buffers to a specified character.
        /// </summary>
        /// <remarks>The memset function sets the first count bytes of dest to the character c.</remarks>
        /// <param name="dest">Pointer to destination</param>
        /// <param name="c">Character to set</param>
        /// <param name="count">Number of characters</param>
        /// <returns>memset returns the value of dest.</returns>
        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr memset(IntPtr dest, int c, size_t count);

        /// <summary>
        /// Swaps bytes.
        /// </summary>
        /// <remarks>The _swab function copies n bytes from src, swaps each pair of adjacent bytes, and stores the result at dest. The integer n should be an even number to allow for swapping. _swab is typically used to prepare binary data for transfer to a machine that uses a different byte order.</remarks>
        /// <param name="src">Data to be copied and swapped</param>
        /// <param name="dest">Storage location for swapped data</param>
        /// <param name="n">Number of bytes to be copied and swapped</param>
        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern void _swab(IntPtr src, IntPtr dest, int n);
    }
}
