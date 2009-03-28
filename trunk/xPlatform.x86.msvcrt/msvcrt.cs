using System;
using System.Text;
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

    #region Buffer manipulation

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

    #endregion // Buffer manipulation

    #region Byte classification

    partial class msvcrt
    {
        /// <summary>
        /// Lead byte; test result depends on LC_CTYPE category setting of current locale
        /// </summary>
        /// <remarks>
        /// The isleadbyte macro returns a nonzero value if its argument is the first byte of a multibyte character. isleadbyte produces a meaningful result for any integer argument from –1 (EOF) to UCHAR_MAX (0xFF), inclusive. The result of the test depends upon the LC_CTYPE category setting of the current locale; see setlocale for more information.
        /// The expected argument type of isleadbyte is int; if a signed character is passed, the compiler may convert it to an integer by sign extension, yielding unpredictable results.
        /// </remarks>
        /// <param name="c">Integer to test</param>
        /// <returns>isleadbyte returns a nonzero value if the argument satisfies the test condition or 0 if it does not. In the “C” locale and in single-byte – character set (SBCS) locales, isleadbyte always returns 0.</returns>
        [DllImport(ModuleName)]
        public static extern int isleadbyte(int c);

        /// <summary>
        /// isalnum || _ismbbkalnum
        /// </summary>
        /// <param name="c">Integer to be tested</param>
        /// <returns>
        /// _ismbbalnum returns a nonzero value if the expression 
        /// isalnum || _ismbbkalnum
        /// is true of c, or 0 if it is not.
        /// </returns>
        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _ismbbalnum(uint c);

        /// <summary>
        /// isalpha || _ismbbkalnum
        /// </summary>
        /// <param name="c">Integer to be tested</param>
        /// <returns>
        /// _ismbbalpha returns a nonzero value if the expression 
        /// isalpha || _ismbbkalnum
        /// is true of c, or 0 if it is not.
        /// </returns>
        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _ismbbalpha(uint c);

        /// <summary>
        /// Same as _ismbbprint, but _ismbbgraph does not include the space character (0x20) 
        /// </summary>
        /// <param name="c">Integer to be tested</param>
        /// <returns>
        /// _ismbbgraph returns a nonzero value if the expression 
        /// ( _PUNCT | _UPPER | _LOWER | _DIGIT ) || _ismbbkprint
        /// is true of c, or 0 if it is not.
        /// </returns>
        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _ismbbgraph(uint c);

        /// <summary>
        /// Non-ASCII text symbol other than punctuation. For example, in code page 932 only, _ismbbkalnum tests for katakana alphanumeric
        /// </summary>
        /// <param name="c">Integer to be tested</param>
        /// <returns>_ismbbkalnum returns a nonzero value if the integer c is a non-ASCII text symbol other than punctuation, or 0 if it is not.</returns>
        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _ismbbkalnum(uint c);

        /// <summary>_ismbbkana tests for a katakana symbol and is specific to code page 932.</summary>
        /// <remarks>Katakana (0xA1 – 0xDF), code page 932 only</remarks>
        /// <param name="c">Integer to be tested</param>
        /// <returns>_ismbbkana returns a nonzero value if the integer c is a katakana symbol, or 0 if it is not.</returns>
        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _ismbbkana(uint c);

        /// <summary>
        /// Non-ASCII text or non-ASCII punctuation symbol. For example, in code page 932 only, _ismbbkprint tests for katakana alphanumeric or katakana punctuation (range: 0xA1 – 0xDF).
        /// </summary>
        /// <param name="c">Integer to be tested</param>
        /// <returns>_ismbbkprint returns a nonzero value if the integer c is a non-ASCII text or non-ASCII punctuation symbol, or 0 if it is not. For example, in code page 932 only, _ismbbkprint tests for katakana alphanumeric or katakana punctuation (range: 0xA1 – 0xDF).</returns>
        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _ismbbkprint(uint c);

        /// <summary>
        /// Non-ASCII punctuation. For example, in code page 932 only, _ismbbkpunct tests for katakana punctuation.
        /// </summary>
        /// <param name="c">Integer to be tested</param>
        /// <returns>_ismbbkpunct returns a nonzero value if the integer c is a non-ASCII punctuation symbol, or 0 if it is not. For example, in code page 932 only, _ismbbkpunct tests for katakana punctuation.</returns>
        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _ismbbkpunct(uint c);

        /// <summary>
        /// First byte of multibyte character. For example, in code page 932 only, valid ranges are 0x81 – 0x9F, 0xE0 – 0xFC.
        /// </summary>
        /// <param name="c">Integer to be tested</param>
        /// <returns>_ismbblead returns a nonzero value if the integer c is the first byte of a multibyte character. For example, in code page 932 only, valid ranges are 0x81 – 0x9F and 0xE0 – 0xFC.</returns>
        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _ismbblead(uint c);

        /// <summary>
        /// isprint || _ismbbkprint. ismbbprint includes the space character (0x20)
        /// </summary>
        /// <param name="c">Integer to be tested</param>
        /// <returns>
        /// _ismbbprint returns a nonzero value if the expression 
        /// isprint || _ismbbkprint
        /// is true of c, or 0 if it is not.
        /// </returns>
        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _ismbbprint(uint c);

        /// <summary>
        /// ispunct || _ismbbkpunct
        /// </summary>
        /// <param name="c">_ismbbpunct returns a nonzero value if the integer c is a non-ASCII punctuation symbol.</param>
        /// <returns>Integer to be tested</returns>
        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _ismbbpunct(uint c);

        /// <summary>
        /// Second byte of multibyte character. For example, in code page 932 only, valid ranges are 0x40 – 0x7E, 0x80 – 0xEC.
        /// </summary>
        /// <param name="c">Integer to be tested</param>
        /// <returns>_ismbbtrail returns a nonzero value if the integer c is the second byte of a multibyte character. For example, in code page 932 only, valid ranges are 0x40 – 0x7E and 0x80 – 0xEC.</returns>
        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _ismbbtrail(uint c);

        /// <summary>
        /// Lead byte (in string context)
        /// </summary>
        /// <remarks>The _ismbslead and _ismbstrail routines perform context-sensitive tests for multibyte-character string lead and trail bytes; they determine whether a given substring pointer points to a lead byte or a trail byte. _ismbslead and _ismbstrail are slower than their _ismbblead and _ismbbtrail counterparts because they take the string context into account.</remarks>
        /// <param name="string">Pointer to start of string or previous known lead byte</param>
        /// <param name="current">Pointer to position in string to be tested</param>
        /// <returns>_ismbslead return –1 if the character is a lead byte, respectively. Otherwise they return zero.</returns>
        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _ismbslead([Const] IntPtr @string, [Const] IntPtr current);

        /// <summary>
        /// Trail byte (in string context)
        /// </summary>
        /// <remarks>The _ismbslead and _ismbstrail routines perform context-sensitive tests for multibyte-character string lead and trail bytes; they determine whether a given substring pointer points to a lead byte or a trail byte. _ismbslead and _ismbstrail are slower than their _ismbblead and _ismbbtrail counterparts because they take the string context into account.</remarks>
        /// <param name="string">Pointer to start of string or previous known lead byte</param>
        /// <param name="current">Pointer to position in string to be tested</param>
        /// <returns>_ismbstrail return –1 if the character is a trail byte, respectively. Otherwise they return zero.</returns>
        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _ismbstrail([Const] IntPtr @string, [Const] IntPtr current);

        /// <summary>
        /// Return byte type based on previous byte
        /// </summary>
        /// <remarks>The _mbbtype function determines the type of a byte in a multibyte character. If the value of type is any value except 1, _mbbtype tests for a valid single-byte or lead byte of a multibyte character. If the value of type is 1, _mbbtype tests for a valid trail byte of a multibyte character. In earlier versions, _mbbtype was called chkctype. For new code, _mbbtype use instead.</remarks>
        /// <param name="c">Character to test</param>
        /// <param name="type">Type of byte to test for</param>
        /// <returns>_mbbtype returns the type of byte within a string. This decision is context-sensitive as specified by the value of type, which provides the control test condition. type is the type of the previous byte in the string.</returns>
        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _mbbtype(byte c, int type);

        /// <summary>
        /// Return type of byte within string
        /// </summary>
        /// <remarks>The _mbsbtype function determines the type of a byte in a multibyte character string. The function examines only the byte at offset count in mbstr, ignoring invalid characters before the specified byte. </remarks>
        /// <param name="mbstr">Address of a sequence of multibyte characters</param>
        /// <param name="count">Byte offset from head of string</param>
        /// <returns>_mbsbtype returns an integer value indicating the result of the test on the specified byte.</returns>
        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _mbsbtype([Const] IntPtr mbstr, size_t count);
    }

    #endregion // Byte classification

    #region Character classification

    partial class msvcrt
    {
        [DllImport(ModuleName)]
        public static extern int isalnum(int c);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int iswalnum(wint_t c);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _ismbcalnum(uint c);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _ismbcalpha(uint c);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _ismbcdigit(uint c);

        [DllImport(ModuleName)]
        public static extern int isalpha(int c);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int iswalpha(wint_t c);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int __isascii(int c);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int iswascii(wint_t c);

        [DllImport(ModuleName)]
        public static extern int iscntrl(int c);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int iswcntrl(wint_t c);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int __iscsym(int c);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int __iscsymf(int c);

        [DllImport(ModuleName)]
        public static extern int isdigit(int c);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int iswdigit(wint_t c);

        [DllImport(ModuleName)]
        public static extern int isgraph(int c);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int iswgraph(wint_t c);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _ismbcgraph(uint c);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _ismbcprint(uint c);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _ismbcpunct(uint c);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _ismbcspace(uint c);

        [DllImport(ModuleName)]
        public static extern int islower(int c);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int iswlower(wint_t c);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _ismbclower(uint c);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _ismbcupper(uint c);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _ismbchira(uint c);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _ismbckata(uint c);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _ismbclegal(uint c);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _ismbcsymbol(uint c);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _ismbcl0(uint c);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _ismbcl1(uint c);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _ismbcl2(uint c);

        [DllImport(ModuleName)]
        public static extern int isprint(int c);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int iswprint(wint_t c);

        [DllImport(ModuleName)]
        public static extern int ispunct(int c);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int iswpunct(wint_t c);

        [DllImport(ModuleName)]
        public static extern int isspace(int c);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int iswspace(wint_t c);

        [DllImport(ModuleName)]
        public static extern int isupper(int c);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int iswupper(wint_t c);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int iswctype(wint_t c, wctype_t desc);

        [DllImport(ModuleName)]
        public static extern int isxdigit(int c);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int iswxdigit(wint_t c);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern size_t _mbclen([Const] IntPtr c);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int mblen([Const] IntPtr mbstr, size_t count);
    }

    #endregion // Character classification

    #region Data conversion

    partial class msvcrt
    {
        [DllImport(ModuleName)]
        public static extern int abs(int n);

        [DllImport(ModuleName)]
        public static extern double atof([Const] IntPtr @string);

        [DllImport(ModuleName, CharSet = CharSet.Ansi)]
        public static extern double atof(string @string);

        [DllImport(ModuleName)]
        public static extern int atoi([Const] IntPtr @string);

        [DllImport(ModuleName, CharSet = CharSet.Ansi)]
        public static extern int atoi(string @string);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern long _atoi64([Const] IntPtr @string);

        [DllImport(ModuleName, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern long _atoi64(string @string);

        [DllImport(ModuleName)]
        public static extern int atol([Const] IntPtr @string);

        [DllImport(ModuleName, CharSet = CharSet.Ansi)]
        public static extern int atol(string @string);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _ecvt(double value, int count, IntPtr dec, IntPtr sign);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _ecvt(double value, int count, out int dec, out int sign);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _fcvt(double value, int count, IntPtr dec, IntPtr sign);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _fcvt(double value, int count, out int dec, out int sign);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _gcvt(double value, int digits, IntPtr buffer);

        [DllImport(ModuleName, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern IntPtr _gcvt(double value, int digits, StringBuilder buffer);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _itoa(int value, IntPtr @string, int radix);

        [DllImport(ModuleName, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern IntPtr _itoa(int vlaue, StringBuilder @string, int radix);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _i64toa(long value, IntPtr @string, int radix);

        [DllImport(ModuleName, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern IntPtr _i64toa(long value, StringBuilder @string, int radix);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _ui64toa(ulong value, IntPtr @string, int radix);

        [DllImport(ModuleName, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern IntPtr _ui64toa(ulong value, StringBuilder @string, int radix);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _itow(int value, IntPtr @string, int radix);

        [DllImport(ModuleName, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern IntPtr _itow(int value, StringBuilder @string, int radix);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _i64tow(long value, IntPtr @string, int radix);

        [DllImport(ModuleName, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern IntPtr _i64tow(long value, StringBuilder @string, int radix);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _ui64tow(ulong value, IntPtr @string, int radix);

        [DllImport(ModuleName, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern IntPtr _ui64tow(ulong value, StringBuilder @string, int radix);

        [DllImport(ModuleName)]
        public static extern int labs(int n);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _ltoa(int value, IntPtr @string, int radix);

        [DllImport(ModuleName, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern IntPtr _ltoa(int value, StringBuilder @string, int radix);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _ltow(int value, IntPtr @string, int radix);

        [DllImport(ModuleName, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern IntPtr _ltow(int value, StringBuilder @string, int radix);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern ushort _mbbtombc(ushort c);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern uint _mbcjistojms(uint c);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern uint _mbcjmstojis(uint c);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern uint _mbctohira(uint c);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern uint _mbctokata(uint c);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern uint _mbctombb(uint c);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern size_t mbstowcs(IntPtr wcstr, [Const] IntPtr mbstr, size_t count);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int mbtowc(IntPtr wchar, [Const] IntPtr mbchar, size_t count);

        [DllImport(ModuleName)]
        public static extern double strtod([Const] IntPtr nptr, IntPtr endptr);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern double strtod([Const] IntPtr nptr, out IntPtr endptr);

        [DllImport(ModuleName, CharSet = CharSet.Ansi)]
        public static extern double strtod(string nptr, IntPtr endptr);

        [DllImport(ModuleName, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern double strtod(string nptr, out IntPtr endptr);

        [DllImport(ModuleName)]
        public static extern double wcstod([Const] IntPtr nptr, IntPtr endptr);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern double wcstod([Const] IntPtr nptr, out IntPtr endptr);

        [DllImport(ModuleName, CharSet = CharSet.Unicode)]
        public static extern double wcstod(string nptr, IntPtr endptr);

        [DllImport(ModuleName, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern double wcstod(string nptr, out IntPtr endptr);

        [DllImport(ModuleName)]
        public static extern int strtol([Const] IntPtr nptr, IntPtr endptr, int @base);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int strtol([Const] IntPtr nptr, out IntPtr endptr, int @base);

        [DllImport(ModuleName, CharSet = CharSet.Ansi)]
        public static extern int strtol(string nptr, IntPtr endptr, int @base);

        [DllImport(ModuleName, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int strtol(string nptr, out IntPtr endptr, int @base);

        [DllImport(ModuleName)]
        public static extern int wcstol([Const] IntPtr nptr, IntPtr endptr, int @base);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int wcstol([Const] IntPtr nptr, out IntPtr endptr, int @base);

        [DllImport(ModuleName, CharSet = CharSet.Unicode)]
        public static extern int wcstol(string nptr, IntPtr endptr, int @base);

        [DllImport(ModuleName, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int wcstol(string nptr, out IntPtr endptr, int @base);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern uint strtoul([Const] IntPtr nptr, IntPtr endptr, int @base);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern uint strtoul([Const] IntPtr nptr, out IntPtr endptr, int @base);

        [DllImport(ModuleName, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern uint strtoul(string nptr, IntPtr endptr, int @base);

        [DllImport(ModuleName, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern uint strtoul(string nptr, out IntPtr endptr, int @base);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern uint wcstoul([Const] IntPtr nptr, IntPtr endptr, int @base);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern uint wcstoul([Const] IntPtr nptr, out IntPtr endptr, int @base);

        [DllImport(ModuleName, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern uint wcstoul(string nptr, IntPtr endptr, int @base);

        [DllImport(ModuleName, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern uint wcstoul(string nptr, out IntPtr endptr, int @base);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern size_t strxfrm(IntPtr strDest, [Const] IntPtr strSource, size_t count);

        [DllImport(ModuleName, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern size_t strxfrm(StringBuilder strDest, string strSource, size_t count);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern size_t wcsxfrm(IntPtr strDest, [Const] IntPtr strSource, size_t count);

        [DllImport(ModuleName, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern size_t wcsxfrm(StringBuilder strDest, string strSource, size_t count);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int __toascii(int c);

        [DllImport(ModuleName)]
        public static extern int tolower(int c);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _tolower(int c);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int towlower(wint_t c);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern uint _mbctolower(uint c);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern uint _mbctoupper(uint c);

        [DllImport(ModuleName)]
        public static extern int toupper(int c);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _toupper(int c);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int towupper(wint_t c);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _ultoa(uint value, IntPtr @string, int radix);

        [DllImport(ModuleName, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern IntPtr _ultoa(uint value, StringBuilder @string, int radix);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _ultow(uint value, IntPtr @string, int radix);

        [DllImport(ModuleName, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern IntPtr _ultow(uint value, StringBuilder @string, int radix);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern size_t wcstombs(IntPtr mbstr, [Const] IntPtr wcstr, size_t count);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int wctomb(IntPtr mbchar, wchar_t wchar);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _wtoi([Const] IntPtr @string);

        [DllImport(ModuleName, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int _wtoi(string @string);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern long _wtoi64([Const] IntPtr @string);

        [DllImport(ModuleName, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern long _wtoi64(string @string);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _wtol([Const] IntPtr @string);

        [DllImport(ModuleName, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int _wtol(string @string);
    }

    #endregion // Data conversion

    #region Directory control

    partial class msvcrt
    {
        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _chdir([Const] IntPtr dirname);

        [DllImport(ModuleName, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int _chdir(string dirname);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _wchdir([Const] IntPtr dirname);

        [DllImport(ModuleName, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int _wchdir(string dirname);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _chdrive(int drive);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _getcwd(IntPtr buffer, int maxlen);

        [DllImport(ModuleName, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern IntPtr _getcwd(StringBuilder buffer, int maxlen);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _wgetcwd(IntPtr buffer, int maxlen);

        [DllImport(ModuleName, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern IntPtr _wgetcwd(StringBuilder buffer, int maxlen);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _getdcwd(int drive, IntPtr buffer, int maxlen);

        [DllImport(ModuleName, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern IntPtr _getdcwd(int drive, StringBuilder buffer, int maxlen);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _wgetdcwd(int drive, IntPtr buffer, int maxlen);

        [DllImport(ModuleName, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern IntPtr _wgetdcwd(int drive, StringBuilder buffer, int maxlen);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _getdrive();

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _mkdir([Const] IntPtr dirname);

        [DllImport(ModuleName, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int _mkdir(string dirname);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _wmkdir([Const] IntPtr dirname);

        [DllImport(ModuleName, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int _wmkdir(string dirname);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _rmdir([Const] IntPtr dirname);

        [DllImport(ModuleName, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int _rmdir(string dirname);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _wrmdir([Const] IntPtr dirname);

        [DllImport(ModuleName, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int _wrmdir(string dirname);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern void _searchenv([Const] IntPtr filename, [Const] IntPtr varname, IntPtr pathname);

        [DllImport(ModuleName, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern void _searchenv(string filename, string varname, StringBuilder pathname);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern void _wsearchenv([Const] IntPtr filename, [Const] IntPtr varname, IntPtr pathname);

        [DllImport(ModuleName, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern void _wsearchenv(string filename, string varname, StringBuilder pathname);
    }

    #endregion // Directory control

    #region Exception handling routines

    partial class msvcrt
    {
        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern _se_translator_function _set_se_translator(_se_translator_function se_trans_func);

        [DllImport(ModuleName)]
        public static extern terminate_function set_terminate(terminate_function term_func);

        [DllImport(ModuleName)]
        public static extern unexpected_function set_unexpected(unexpected_function unexp_func);

        [DllImport(ModuleName)]
        public static extern void terminate();

        [DllImport(ModuleName)]
        public static extern void unexpected();
    }

    #endregion // Exception handling routines

    #region File handling routines with file handles

    partial class msvcrt
    {
        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _chsize(int handle, int size);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _filelength(int handle);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern long _filelengthi64(int handle);
    }

    #endregion // File handling routines with file handles
}
