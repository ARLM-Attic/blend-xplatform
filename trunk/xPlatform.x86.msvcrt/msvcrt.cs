using System;
using System.Text;
using xPlatform.Flags;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace xPlatform.x86.msvcrt
{
    [Serializable]
    public partial class msvcrt : ModuleBase
    {
        [NonSerialized]
        public const string ModuleName = "msvcrt.dll";
    }

    #region Buffer manipulation

    partial class msvcrt
    {
        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _memccpy(IntPtr dest, [Const] IntPtr src, int c, uint count);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr memchr(IntPtr buf, int c, size_t count);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int memcmp([Const] IntPtr buf1, [Const] IntPtr buf2, size_t count);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr memcpy(IntPtr dest, [Const] IntPtr src, size_t count);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _memicmp([Const] IntPtr buf1, [Const] IntPtr buf2, uint count);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr memmove(IntPtr dest, [Const] IntPtr src, size_t count);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr memset(IntPtr dest, int c, size_t count);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern void _swab(IntPtr src, IntPtr dest, int n);
    }

    #endregion // Buffer manipulation

    #region Byte classification

    partial class msvcrt
    {
        [DllImport(ModuleName)]
        public static extern int isleadbyte(int c);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _ismbbalnum(uint c);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _ismbbalpha(uint c);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _ismbbgraph(uint c);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _ismbbkalnum(uint c);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _ismbbkana(uint c);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _ismbbkprint(uint c);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _ismbbkpunct(uint c);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _ismbblead(uint c);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _ismbbprint(uint c);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _ismbbpunct(uint c);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _ismbbtrail(uint c);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _ismbslead([Const] IntPtr @string, [Const] IntPtr current);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _ismbstrail([Const] IntPtr @string, [Const] IntPtr current);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _mbbtype(byte c, int type);

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

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _set_se_translator(IntPtr se_trans_func);

        [DllImport(ModuleName)]
        public static extern terminate_function set_terminate(terminate_function term_func);

        [DllImport(ModuleName)]
        public static extern IntPtr set_terminate(IntPtr term_func);

        [DllImport(ModuleName)]
        public static extern unexpected_function set_unexpected(unexpected_function unexp_func);

        [DllImport(ModuleName)]
        public static extern IntPtr set_unexpected(IntPtr unexp_func);

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

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _fstat(int handle, IntPtr buffer);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _fstat(int handle, ref _stat buffer);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern long _fstati64(int handle, IntPtr buffer);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _isatty(int handle);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _locking(int handle, int mode, int nbytes);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _setmode(int handle, int mode);
    }

    #endregion // File handling routines with file handles

    #region File handling routines with path or filename

    partial class msvcrt
    {
        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _access([Const] IntPtr path, int mode);

        [DllImport(ModuleName, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int _access(string path, int mode);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _waccess([Const] IntPtr path, int mode);

        [DllImport(ModuleName, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int _waccess(string path, int mode);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _chmod([Const] IntPtr path, int pmode);

        [DllImport(ModuleName, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int _chmod(string path, int pmode);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _wchmod([Const] IntPtr path, int pmode);

        [DllImport(ModuleName, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int _wchmod(string path, int pmode);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _fullpath(IntPtr absPath, [Const] IntPtr relPath, size_t maxLength);

        [DllImport(ModuleName, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern IntPtr _fullpath(StringBuilder absPath, string relPath, size_t maxLength);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _wfullpath(IntPtr absPath, [Const] IntPtr relPath, size_t maxLength);

        [DllImport(ModuleName, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern IntPtr _wfullpath(StringBuilder absPath, string relPath, size_t maxLength);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _get_osfhandle(int filehandle);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern void _makepath(IntPtr path, [Const] IntPtr drive, [Const] IntPtr dir, [Const] IntPtr fname, [Const] IntPtr ext);

        [DllImport(ModuleName, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern void _makepath(StringBuilder path, string drive, string dir, string fname, string ext);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern void _wmakepath(IntPtr path, [Const] IntPtr drive, [Const] IntPtr dir, [Const] IntPtr fname, [Const] IntPtr ext);

        [DllImport(ModuleName, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern void _wmakepath(StringBuilder path, string drive, string dir, string fname, string ext);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _mktemp(IntPtr template);

        [DllImport(ModuleName, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern IntPtr _mktemp(string template);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _wmktemp(IntPtr template);

        [DllImport(ModuleName, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern IntPtr _wmktemp(string template);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _open_osfhandle(int osfhandle, int flags);

        [DllImport(ModuleName)]
        public static extern int remove([Const] IntPtr path);

        [DllImport(ModuleName, CharSet = CharSet.Ansi)]
        public static extern int remove(string path);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _wremove([Const] IntPtr path);

        [DllImport(ModuleName, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int _wremove(string path);

        [DllImport(ModuleName)]
        public static extern int rename([Const] IntPtr oldname, [Const] IntPtr newname);

        [DllImport(ModuleName, CharSet = CharSet.Ansi)]
        public static extern int rename(string oldname, string newname);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _wrename([Const] IntPtr oldname, [Const] IntPtr newname);

        [DllImport(ModuleName, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int _wrename(string oldname, string newname);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern void _splitpath([Const] IntPtr path, IntPtr drive, IntPtr dir, IntPtr fname, IntPtr ext);

        [DllImport(ModuleName, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern void _splitpath(string path, StringBuilder drive, StringBuilder dir, StringBuilder fname, StringBuilder ext);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern void _wsplitpath([Const] IntPtr path, IntPtr drive, IntPtr dir, IntPtr fname, IntPtr ext);

        [DllImport(ModuleName, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern void _wsplitpath(string path, StringBuilder drive, StringBuilder dir, StringBuilder fname, StringBuilder ext);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _unlink([Const] IntPtr path);

        [DllImport(ModuleName, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int _unlink(string path);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _wunlink([Const] IntPtr path);

        [DllImport(ModuleName, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int _wunlink(string path);
    }

    #endregion // File handling routines with path or filename

    #region Floating point support

    partial class msvcrt
    {
        [DllImport(ModuleName)]
        public static extern int abs(int n);

        [DllImport(ModuleName)]
        public static extern double acos(double x);

        [DllImport(ModuleName)]
        public static extern double asin(double x);

        [DllImport(ModuleName)]
        public static extern double atan(double x);

        [DllImport(ModuleName)]
        public static extern double atan2(double y, double x);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern double _j0(double x);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern double _j1(double x);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern double _jn(int n, double x);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern double _y0(double x);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern double _y1(double x);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern double _yn(int n, double x);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern double _cabs(_complex z);

        [DllImport(ModuleName)]
        public static extern double ceil(double x);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern double _chgsign(double x);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern uint _clear87();

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern uint _clearfp();

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern uint _control87(uint @new, uint mask);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern uint _controlfp(uint @new, uint mask);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern double _copysign(double x, double y);

        [DllImport(ModuleName)]
        public static extern double cos(double x);

        [DllImport(ModuleName)]
        public static extern double cosh(double x);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern _div_t div(int numer, int denom);

        [DllImport(ModuleName)]
        public static extern double exp(double x);

        [DllImport(ModuleName)]
        public static extern double fabs(double x);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _finite(double x);

        [DllImport(ModuleName)]
        public static extern double floor(double x);

        [DllImport(ModuleName)]
        public static extern double fmod(double x, double y);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _fpclass(double x);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _fpieee_flt(uint exc_code, IntPtr exc_info, _fpieee_flt_function handler);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern void _fpreset();

        [DllImport(ModuleName)]
        public static extern double frexp(double x, IntPtr expptr);

        [DllImport(ModuleName)]
        public static extern double frexp(double x, ref int expptr);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern double _hypot(double x, double y);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _isnan(double x);

        [DllImport(ModuleName)]
        public static extern double ldexp(double x, int exp);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern _ldiv_t ldiv(int number, int denom);

        [DllImport(ModuleName)]
        public static extern double log(double x);

        [DllImport(ModuleName)]
        public static extern double log10(double x);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern double _logb(double x);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern uint _lrotl(uint value, int shift);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern uint _lrotr(uint value, int shift);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _matherr(IntPtr except);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _matherr(ref _exception except);

        [CLSCompliant(false)]
        public static IComparable __max(IComparable a, IComparable b)
        {
            return a.CompareTo(b) > 0 ? a : b;
        }

        [CLSCompliant(false)]
        public static IComparable __min(IComparable a, IComparable b)
        {
            return a.CompareTo(b) < 0 ? a : b;
        }

        [DllImport(ModuleName)]
        public static extern double modf(double x, IntPtr intptr);

        [DllImport(ModuleName)]
        public static extern double modf(double x, ref double intptr);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern double _nextafter(double x, double y);

        [DllImport(ModuleName)]
        public static extern double pow(double x, double y);

        [DllImport(ModuleName)]
        public static extern int rand();

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern uint _rotl(uint value, int shift);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern uint _rotr(uint value, int shift);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern double _scalb(double x, int exp);

        [DllImport(ModuleName)]
        public static extern double sin(double x);

        [DllImport(ModuleName)]
        public static extern double sinh(double x);

        [DllImport(ModuleName)]
        public static extern double sqrt(double x);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern void srand(uint seed);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern uint _status87();

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern uint _statusfp();

        [DllImport(ModuleName)]
        public static extern double tan(double x);

        [DllImport(ModuleName)]
        public static extern double tanh(double x);
    }

    #endregion // Floating point support

    #region Stream input and output

    partial class msvcrt
    {
        [DllImport(ModuleName)]
        public static extern void clearerr(IntPtr stream);

        [DllImport(ModuleName)]
        public static extern int fclose(IntPtr stream);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _fcloseall();

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _fdopen(int handle, [Const] IntPtr mode);

        [DllImport(ModuleName, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern IntPtr _fdopen(int handle, string mode);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _wfdopen(int handle, [Const] IntPtr mode);
        
        [DllImport(ModuleName, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern IntPtr _wfdopen(int handle, string mode);

        [DllImport(ModuleName)]
        public static extern int feof(IntPtr stream);

        [DllImport(ModuleName)]
        public static extern int ferror(IntPtr stream);

        [DllImport(ModuleName)]
        public static extern int fflush(IntPtr stream);

        [DllImport(ModuleName)]
        public static extern int fgetc(IntPtr stream);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern wint_t fgetwc(IntPtr stream);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _fgetchar();

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern wint_t _fgetwchar();

        [DllImport(ModuleName)]
        public static extern int fgetpos(IntPtr stream, IntPtr pos);

        [DllImport(ModuleName)]
        public static extern int fgetpos(IntPtr stream, ref fpos_t pos);

        [DllImport(ModuleName)]
        public static extern IntPtr fgets(IntPtr @string, int n, IntPtr stream);

        [DllImport(ModuleName, CharSet = CharSet.Ansi)]
        public static extern IntPtr fgets(StringBuilder @string, int n, IntPtr stream);

        [DllImport(ModuleName)]
        public static extern IntPtr fgetws(IntPtr @string, int n, IntPtr stream);

        [DllImport(ModuleName, CharSet = CharSet.Unicode)]
        public static extern IntPtr fgetws(StringBuilder @string, int n, IntPtr stream);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _fileno(IntPtr stream);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _flushall();

        [DllImport(ModuleName)]
        public static extern IntPtr fopen([Const] IntPtr filename, [Const] IntPtr mode);

        [DllImport(ModuleName, CharSet = CharSet.Ansi)]
        public static extern IntPtr fopen(string filename, string mode);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _wfopen([Const] IntPtr filename, [Const] IntPtr mode);

        [DllImport(ModuleName, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern IntPtr _wfopen(string filename, string mode);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int fprintf(IntPtr stream, [Const] IntPtr format, __arglist);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int fprintf(IntPtr stream, string format, __arglist);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int fwprintf(IntPtr stream, [Const] IntPtr format, __arglist);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int fwprintf(IntPtr stream, string format, __arglist);

        [DllImport(ModuleName)]
        public static extern int fputc(int c, IntPtr stream);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern wint_t fputwc(wint_t c, IntPtr stream);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _fputchar(int c);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern wint_t _fputwchar(wint_t c);

        [DllImport(ModuleName)]
        public static extern int fputs([Const] IntPtr @string, IntPtr stream);

        [DllImport(ModuleName, CharSet = CharSet.Ansi)]
        public static extern int fputs(string @string, IntPtr stream);

        [DllImport(ModuleName)]
        public static extern int fputws([Const] IntPtr @string, IntPtr stream);

        [DllImport(ModuleName, CharSet = CharSet.Unicode)]
        public static extern int fputws(string @string, IntPtr stream);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern size_t fread(IntPtr buffer, size_t size, size_t count, IntPtr stream);

        [DllImport(ModuleName)]
        public static extern IntPtr freopen([Const] IntPtr filename, [Const] IntPtr mode, IntPtr stream);

        [DllImport(ModuleName, CharSet = CharSet.Ansi)]
        public static extern IntPtr freopen(string filename, string mode, IntPtr stream);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _wfreopen([Const] IntPtr filename, [Const] IntPtr mode, IntPtr stream);

        [DllImport(ModuleName, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern IntPtr _wfreopen(string filename, string mode, IntPtr stream);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int fscanf(IntPtr stream, [Const] IntPtr format, ref int arg0, ref int arg1, ref int arg2);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int fscanf(IntPtr stream, [Const] IntPtr format, ref int arg0, ref int arg1);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int fscanf(IntPtr stream, [Const] IntPtr format, ref int arg0);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int fscanf(IntPtr stream, [Const] IntPtr format, ref double arg0, ref double arg1, ref double arg2);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int fscanf(IntPtr stream, [Const] IntPtr format, ref double arg0, ref double arg1);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int fscanf(IntPtr stream, [Const] IntPtr format, ref double arg0);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int fscanf(IntPtr stream, [Const] IntPtr format, StringBuilder arg0, StringBuilder arg1, StringBuilder arg2);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int fscanf(IntPtr stream, [Const] IntPtr format, StringBuilder arg0, StringBuilder arg1);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int fscanf(IntPtr stream, [Const] IntPtr format, StringBuilder arg0);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int fscanf(IntPtr stream, [Const] IntPtr format, __arglist);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int fscanf(IntPtr stream, string format, ref int arg0, ref int arg1, ref int arg2);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int fscanf(IntPtr stream, string format, ref int arg0, ref int arg1);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int fscanf(IntPtr stream, string format, ref int arg0);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int fscanf(IntPtr stream, string format, ref double arg0, ref double arg1, ref double arg2);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int fscanf(IntPtr stream, string format, ref double arg0, ref double arg1);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int fscanf(IntPtr stream, string format, ref double arg0);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int fscanf(IntPtr stream, string format, StringBuilder arg0, StringBuilder arg1, StringBuilder arg2);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int fscanf(IntPtr stream, string format, StringBuilder arg0, StringBuilder arg1);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int fscanf(IntPtr stream, string format, StringBuilder arg0);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int fscanf(IntPtr stream, string format, __arglist);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern int fwscanf(IntPtr stream, [Const] IntPtr format, ref int arg0, ref int arg1, ref int arg2);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern int fwscanf(IntPtr stream, [Const] IntPtr format, ref int arg0, ref int arg1);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern int fwscanf(IntPtr stream, [Const] IntPtr format, ref int arg0);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern int fwscanf(IntPtr stream, [Const] IntPtr format, ref double arg0, ref double arg1, ref double arg2);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern int fwscanf(IntPtr stream, [Const] IntPtr format, ref double arg0, ref double arg1);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern int fwscanf(IntPtr stream, [Const] IntPtr format, ref double arg0);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern int fwscanf(IntPtr stream, [Const] IntPtr format, StringBuilder arg0, StringBuilder arg1, StringBuilder arg2);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern int fwscanf(IntPtr stream, [Const] IntPtr format, StringBuilder arg0, StringBuilder arg1);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern int fwscanf(IntPtr stream, [Const] IntPtr format, StringBuilder arg0);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int fwscanf(IntPtr stream, [Const] IntPtr format, __arglist);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern int fwscanf(IntPtr stream, string format, ref int arg0, ref int arg1, ref int arg2);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern int fwscanf(IntPtr stream, string format, ref int arg0, ref int arg1);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern int fwscanf(IntPtr stream, string format, ref int arg0);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern int fwscanf(IntPtr stream, string format, ref double arg0, ref double arg1, ref double arg2);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern int fwscanf(IntPtr stream, string format, ref double arg0, ref double arg1);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern int fwscanf(IntPtr stream, string format, ref double arg0);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern int fwscanf(IntPtr stream, string format, StringBuilder arg0, StringBuilder arg1, StringBuilder arg2);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern int fwscanf(IntPtr stream, string format, StringBuilder arg0, StringBuilder arg1);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern int fwscanf(IntPtr stream, string format, StringBuilder arg0);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int fwscanf(IntPtr stream, string format, __arglist);

        [DllImport(ModuleName)]
        public static extern int fseek(IntPtr stream, int offset, int origin);

        [DllImport(ModuleName)]
        public static extern int fsetpos(IntPtr stream, [Const] IntPtr pos);

        [DllImport(ModuleName)]
        public static extern int fsetpos(IntPtr stream, [Const] ref fpos_t pos);

        [DllImport(ModuleName)]
        public static extern IntPtr fsopen([Const] IntPtr filename, [Const] IntPtr mode, int shflag);

        [DllImport(ModuleName, CharSet = CharSet.Ansi)]
        public static extern IntPtr fsopen(string filename, string mode, int shflag);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _wfsopen([Const] IntPtr filename, [Const] IntPtr mode, int shflag);

        [DllImport(ModuleName, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern IntPtr _wfsopen(string filename, string mode, int shflag);

        [DllImport(ModuleName)]
        public static extern int ftell(IntPtr stream);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern size_t fwrite([Const] IntPtr buffer, size_t size, size_t count, IntPtr stream);

        [DllImport(ModuleName)]
        public static extern int getc(IntPtr stream);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern wint_t getwc(IntPtr stream);

        [DllImport(ModuleName)]
        public static extern int getchar();

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern wint_t getwchar();

        [DllImport(ModuleName)]
        public static extern IntPtr gets(IntPtr buffer);

        [DllImport(ModuleName, CharSet = CharSet.Ansi)]
        public static extern IntPtr gets(StringBuilder buffer);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _getws(IntPtr buffer);

        [DllImport(ModuleName, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern IntPtr _getws(StringBuilder buffer);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _getw(IntPtr stream);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int printf([Const] IntPtr format, __arglist);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int printf(string format, __arglist);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int printf([Const] IntPtr format, IntPtr arglist);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int printf(string format, IntPtr arglist);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int printf([Const] IntPtr format);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int printf(string format);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int wprintf([Const] IntPtr format, __arglist);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int wprintf(string format, __arglist);

        [DllImport(ModuleName)]
        public static extern int putc(int c, IntPtr stream);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern wint_t putwc(wint_t c, IntPtr stream);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _putchar(int c);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern wint_t _putwchar(wint_t c);

        [DllImport(ModuleName)]
        public static extern int puts([Const] IntPtr @string);

        [DllImport(ModuleName, CharSet = CharSet.Ansi)]
        public static extern int puts(string @string);

        [DllImport(ModuleName)]
        public static extern int putws([Const] IntPtr @string);

        [DllImport(ModuleName, CharSet = CharSet.Unicode)]
        public static extern int putws(string @string);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _puw(int binint, IntPtr stream);

        [DllImport(ModuleName)]
        public static extern void rewind(IntPtr stream);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _rmtmp();

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int scanf([Const] IntPtr format, ref int arg0, ref int arg1, ref int arg2);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int scanf([Const] IntPtr format, ref int arg0, ref int arg1);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int scanf([Const] IntPtr format, ref int arg0);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int scanf([Const] IntPtr format, ref double arg0, ref double arg1, ref double arg2);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int scanf([Const] IntPtr format, ref double arg0, ref double arg1);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int scanf([Const] IntPtr format, ref double arg0);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int scanf([Const] IntPtr format, StringBuilder arg0, StringBuilder arg1, StringBuilder arg2);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int scanf([Const] IntPtr format, StringBuilder arg0, StringBuilder arg1);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int scanf([Const] IntPtr format, StringBuilder arg0);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int scanf([Const] IntPtr format, __arglist);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int scanf(string format, ref int arg0, ref int arg1, ref int arg2);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int scanf(string format, ref int arg0, ref int arg1);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int scanf(string format, ref int arg0);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int scanf(string format, ref double arg0, ref double arg1, ref double arg2);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int scanf(string format, ref double arg0, ref double arg1);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int scanf(string format, ref double arg0);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int scanf(string format, StringBuilder arg0, StringBuilder arg1, StringBuilder arg2);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int scanf(string format, StringBuilder arg0, StringBuilder arg1);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int scanf(string format, StringBuilder arg0);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int scanf(string format, __arglist);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern int wscanf([Const] IntPtr format, ref int arg0, ref int arg1, ref int arg2);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern int wscanf([Const] IntPtr format, ref int arg0, ref int arg1);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern int wscanf([Const] IntPtr format, ref int arg0);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern int wscanf([Const] IntPtr format, ref double arg0, ref double arg1, ref double arg2);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern int wscanf([Const] IntPtr format, ref double arg0, ref double arg1);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern int wscanf([Const] IntPtr format, ref double arg0);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern int wscanf([Const] IntPtr format, StringBuilder arg0, StringBuilder arg1, StringBuilder arg2);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern int wscanf([Const] IntPtr format, StringBuilder arg0, StringBuilder arg1);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern int wscanf([Const] IntPtr format, StringBuilder arg0);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int wscanf([Const] IntPtr format, __arglist);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern int wscanf(string format, ref int arg0, ref int arg1, ref int arg2);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern int wscanf(string format, ref int arg0, ref int arg1);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern int wscanf(string format, ref int arg0);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern int wscanf(string format, ref double arg0, ref double arg1, ref double arg2);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern int wscanf(string format, ref double arg0, ref double arg1);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern int wscanf(string format, ref double arg0);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern int wscanf(string format, StringBuilder arg0, StringBuilder arg1, StringBuilder arg2);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern int wscanf(string format, StringBuilder arg0, StringBuilder arg1);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern int wscanf(string format, StringBuilder arg0);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int wscanf(string format, __arglist);

        [DllImport(ModuleName)]
        public static extern void setbuf(IntPtr stream, IntPtr buffer);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _setmaxstdio(int newmax);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int setvbuf(IntPtr stream, IntPtr buffer, int mode, size_t size);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int _snprintf(IntPtr buffer, size_t count, [Const] IntPtr format, __arglist);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int _snprintf(IntPtr buffer, size_t count, string format, __arglist);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int _snwprintf(IntPtr buffer, size_t count, [Const] IntPtr format, __arglist);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int _snwprintf(IntPtr buffer, size_t count, string format, __arglist);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int _snprintf(StringBuilder buffer, size_t count, [Const] IntPtr format, __arglist);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int _snprintf(StringBuilder buffer, size_t count, string format, __arglist);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int _snwprintf(StringBuilder buffer, size_t count, [Const] IntPtr format, __arglist);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int _snwprintf(StringBuilder buffer, size_t count, string format, __arglist);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int sprintf(IntPtr buffer, [Const] IntPtr format, __arglist);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int sprintf(IntPtr buffer, string format, __arglist);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int swprintf(IntPtr buffer, [Const] IntPtr format, __arglist);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int swprintf(IntPtr buffer, string format, __arglist);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int sprintf(StringBuilder buffer, [Const] IntPtr format, __arglist);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int sprintf(StringBuilder buffer, string format, __arglist);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int swprintf(StringBuilder buffer, [Const] IntPtr format, __arglist);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int swprintf(StringBuilder buffer, string format, __arglist);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int sscanf([Const] IntPtr buffer, [Const] IntPtr format, ref int arg0, ref int arg1, ref int arg2);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int sscanf([Const] IntPtr buffer, [Const] IntPtr format, ref int arg0, ref int arg1);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int sscanf([Const] IntPtr buffer, [Const] IntPtr format, ref int arg0);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int sscanf([Const] IntPtr buffer, [Const] IntPtr format, ref double arg0, ref double arg1, ref double arg2);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int sscanf([Const] IntPtr buffer, [Const] IntPtr format, ref double arg0, ref double arg1);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int sscanf([Const] IntPtr buffer, [Const] IntPtr format, ref double arg0);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int sscanf([Const] IntPtr buffer, [Const] IntPtr format, StringBuilder arg0, StringBuilder arg1, StringBuilder arg2);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int sscanf([Const] IntPtr buffer, [Const] IntPtr format, StringBuilder arg0, StringBuilder arg1);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int sscanf([Const] IntPtr buffer, [Const] IntPtr format, StringBuilder arg0);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int sscanf([Const] IntPtr buffer, [Const] IntPtr format, __arglist);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int sscanf([Const] IntPtr buffer, string format, ref int arg0, ref int arg1, ref int arg2);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int sscanf([Const] IntPtr buffer, string format, ref int arg0, ref int arg1);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int sscanf([Const] IntPtr buffer, string format, ref int arg0);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int sscanf([Const] IntPtr buffer, string format, ref double arg0, ref double arg1, ref double arg2);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int sscanf([Const] IntPtr buffer, string format, ref double arg0, ref double arg1);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int sscanf([Const] IntPtr buffer, string format, ref double arg0);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int sscanf([Const] IntPtr buffer, string format, StringBuilder arg0, StringBuilder arg1, StringBuilder arg2);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int sscanf([Const] IntPtr buffer, string format, StringBuilder arg0, StringBuilder arg1);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int sscanf([Const] IntPtr buffer, string format, StringBuilder arg0);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int sscanf([Const] IntPtr buffer, string format, __arglist);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern int swscanf([Const] IntPtr buffer, [Const] IntPtr format, ref int arg0, ref int arg1, ref int arg2);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern int swscanf([Const] IntPtr buffer, [Const] IntPtr format, ref int arg0, ref int arg1);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern int swscanf([Const] IntPtr buffer, [Const] IntPtr format, ref int arg0);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern int swscanf([Const] IntPtr buffer, [Const] IntPtr format, ref double arg0, ref double arg1, ref double arg2);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern int swscanf([Const] IntPtr buffer, [Const] IntPtr format, ref double arg0, ref double arg1);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern int swscanf([Const] IntPtr buffer, [Const] IntPtr format, ref double arg0);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern int swscanf([Const] IntPtr buffer, [Const] IntPtr format, StringBuilder arg0, StringBuilder arg1, StringBuilder arg2);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern int swscanf([Const] IntPtr buffer, [Const] IntPtr format, StringBuilder arg0, StringBuilder arg1);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern int swscanf([Const] IntPtr buffer, [Const] IntPtr format, StringBuilder arg0);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int swscanf([Const] IntPtr buffer, [Const] IntPtr format, __arglist);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern int swscanf([Const] IntPtr buffer, string format, ref int arg0, ref int arg1, ref int arg2);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern int swscanf([Const] IntPtr buffer, string format, ref int arg0, ref int arg1);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern int swscanf([Const] IntPtr buffer, string format, ref int arg0);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern int swscanf([Const] IntPtr buffer, string format, ref double arg0, ref double arg1, ref double arg2);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern int swscanf([Const] IntPtr buffer, string format, ref double arg0, ref double arg1);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern int swscanf([Const] IntPtr buffer, string format, ref double arg0);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern int swscanf([Const] IntPtr buffer, string format, StringBuilder arg0, StringBuilder arg1, StringBuilder arg2);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern int swscanf([Const] IntPtr buffer, string format, StringBuilder arg0, StringBuilder arg1);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern int swscanf([Const] IntPtr buffer, string format, StringBuilder arg0);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int swscanf([Const] IntPtr buffer, string format, __arglist);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int sscanf(string buffer, [Const] IntPtr format, ref int arg0, ref int arg1, ref int arg2);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int sscanf(string buffer, [Const] IntPtr format, ref int arg0, ref int arg1);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int sscanf(string buffer, [Const] IntPtr format, ref int arg0);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int sscanf(string buffer, [Const] IntPtr format, ref double arg0, ref double arg1, ref double arg2);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int sscanf(string buffer, [Const] IntPtr format, ref double arg0, ref double arg1);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int sscanf(string buffer, [Const] IntPtr format, ref double arg0);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int sscanf(string buffer, [Const] IntPtr format, StringBuilder arg0, StringBuilder arg1, StringBuilder arg2);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int sscanf(string buffer, [Const] IntPtr format, StringBuilder arg0, StringBuilder arg1);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int sscanf(string buffer, [Const] IntPtr format, StringBuilder arg0);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int sscanf(string buffer, [Const] IntPtr format, __arglist);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int sscanf(string buffer, string format, ref int arg0, ref int arg1, ref int arg2);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int sscanf(string buffer, string format, ref int arg0, ref int arg1);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int sscanf(string buffer, string format, ref int arg0);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int sscanf(string buffer, string format, ref double arg0, ref double arg1, ref double arg2);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int sscanf(string buffer, string format, ref double arg0, ref double arg1);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int sscanf(string buffer, string format, ref double arg0);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int sscanf(string buffer, string format, StringBuilder arg0, StringBuilder arg1, StringBuilder arg2);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int sscanf(string buffer, string format, StringBuilder arg0, StringBuilder arg1);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int sscanf(string buffer, string format, StringBuilder arg0);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int sscanf(string buffer, string format, __arglist);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern int swscanf(string buffer, [Const] IntPtr format, ref int arg0, ref int arg1, ref int arg2);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern int swscanf(string buffer, [Const] IntPtr format, ref int arg0, ref int arg1);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern int swscanf(string buffer, [Const] IntPtr format, ref int arg0);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern int swscanf(string buffer, [Const] IntPtr format, ref double arg0, ref double arg1, ref double arg2);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern int swscanf(string buffer, [Const] IntPtr format, ref double arg0, ref double arg1);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern int swscanf(string buffer, [Const] IntPtr format, ref double arg0);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern int swscanf(string buffer, [Const] IntPtr format, StringBuilder arg0, StringBuilder arg1, StringBuilder arg2);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern int swscanf(string buffer, [Const] IntPtr format, StringBuilder arg0, StringBuilder arg1);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern int swscanf(string buffer, [Const] IntPtr format, StringBuilder arg0);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int swscanf(string buffer, [Const] IntPtr format, __arglist);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern int swscanf(string buffer, string format, ref int arg0, ref int arg1, ref int arg2);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern int swscanf(string buffer, string format, ref int arg0, ref int arg1);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern int swscanf(string buffer, string format, ref int arg0);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern int swscanf(string buffer, string format, ref double arg0, ref double arg1, ref double arg2);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern int swscanf(string buffer, string format, ref double arg0, ref double arg1);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern int swscanf(string buffer, string format, ref double arg0);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern int swscanf(string buffer, string format, StringBuilder arg0, StringBuilder arg1, StringBuilder arg2);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern int swscanf(string buffer, string format, StringBuilder arg0, StringBuilder arg1);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern int swscanf(string buffer, string format, StringBuilder arg0);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int swscanf(string buffer, string format, __arglist);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _tempnam(IntPtr dir, IntPtr prefix);

        [DllImport(ModuleName, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern IntPtr _tempnam(StringBuilder dir, StringBuilder prefix);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _wtempnam(IntPtr dir, IntPtr prefix);

        [DllImport(ModuleName, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern IntPtr _wtempnam(StringBuilder dir, StringBuilder prefix);

        [DllImport(ModuleName)]
        public static extern IntPtr tmpnam(IntPtr @string);

        [DllImport(ModuleName, CharSet = CharSet.Ansi)]
        public static extern IntPtr tmpnam(StringBuilder @string);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _wtmpnam(IntPtr @string);

        [DllImport(ModuleName, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern IntPtr _wtmpnam(StringBuilder @string);

        [DllImport(ModuleName)]
        public static extern IntPtr tmpfile();

        [DllImport(ModuleName)]
        public static extern int ungetc(int c, IntPtr stream);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern wint_t ungetwc(wint_t c, IntPtr stream);

        [DllImport(ModuleName)]
        public static extern int vfprintf(IntPtr stream, [Const] IntPtr format, IntPtr argptr);

        [DllImport(ModuleName, CharSet = CharSet.Ansi)]
        public static extern int vfprintf(IntPtr stream, string format, IntPtr argptr);

        [DllImport(ModuleName)]
        public static extern int vfwprintf(IntPtr stream, [Const] IntPtr format, IntPtr argptr);

        [DllImport(ModuleName, CharSet = CharSet.Unicode)]
        public static extern int vfwprintf(IntPtr stream, string format, IntPtr argptr);

        [DllImport(ModuleName)]
        public static extern int vprintf([Const] IntPtr format, IntPtr argptr);

        [DllImport(ModuleName, CharSet = CharSet.Ansi)]
        public static extern int vprintf(string format, IntPtr argptr);

        [DllImport(ModuleName)]
        public static extern int vwprintf([Const] IntPtr format, IntPtr argptr);

        [DllImport(ModuleName, CharSet = CharSet.Unicode)]
        public static extern int vwprintf(string format, IntPtr argptr);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _vsnprintf(IntPtr buffer, size_t count, [Const] IntPtr format, IntPtr argptr);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _vsnprintf(IntPtr buffer, size_t count, string format, IntPtr argptr);

        [DllImport(ModuleName, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int _vsnprintf(StringBuilder buffer, size_t count, [Const] IntPtr format, IntPtr argptr);

        [DllImport(ModuleName, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int _vsnprintf(StringBuilder buffer, size_t count, string format, IntPtr argptr);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _vsnwprintf(IntPtr buffer, size_t count, [Const] IntPtr format, IntPtr argptr);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _vsnwprintf(IntPtr buffer, size_t count, string format, IntPtr argptr);

        [DllImport(ModuleName, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int _vsnwprintf(StringBuilder buffer, size_t count, [Const] IntPtr format, IntPtr argptr);

        [DllImport(ModuleName, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int _vsnwprintf(StringBuilder buffer, size_t count, string format, IntPtr argptr);

        [DllImport(ModuleName)]
        public static extern int vsprintf(IntPtr buffer, [Const] IntPtr format, IntPtr argptr);

        [DllImport(ModuleName)]
        public static extern int vsprintf(IntPtr buffer, string format, IntPtr argptr);

        [DllImport(ModuleName, CharSet = CharSet.Ansi)]
        public static extern int vsprintf(StringBuilder buffer, [Const] IntPtr format, IntPtr argptr);

        [DllImport(ModuleName, CharSet = CharSet.Ansi)]
        public static extern int vsprintf(StringBuilder buffer, string format, IntPtr argptr);

        [DllImport(ModuleName)]
        public static extern int vswprintf(IntPtr buffer, [Const] IntPtr format, IntPtr argptr);

        [DllImport(ModuleName)]
        public static extern int vswprintf(IntPtr buffer, string format, IntPtr argptr);

        [DllImport(ModuleName, CharSet = CharSet.Unicode)]
        public static extern int vswprintf(StringBuilder buffer, [Const] IntPtr format, IntPtr argptr);

        [DllImport(ModuleName, CharSet = CharSet.Unicode)]
        public static extern int vswprintf(StringBuilder buffer, string format, IntPtr argptr);
    }

    #endregion // Stream input and output

    #region Low level input and output

    partial class msvcrt
    {
        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _close(int handle);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _commit(int handle);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _creat([Const] IntPtr filename, int pmode);

        [DllImport(ModuleName, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int _creat(string filename, int pmode);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _wcreat([Const] IntPtr filename, int pmode);

        [DllImport(ModuleName, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int _wcreat(string filename, int pmode);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _dup(int handle);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _dup2(int handle1, int handle2);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _eof(int handle);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _lseek(int handle, int offset, int origin);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern long _lseeki64(int handle, long offset, int origin);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _open([Const] IntPtr filename, int oflag, int pmode);

        [DllImport(ModuleName, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int _open(string filename, int oflag, int pmode);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _open([Const] IntPtr filename, int oflag);

        [DllImport(ModuleName, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int _open(string filename, int oflag);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _wopen([Const] IntPtr filename, int oflag, int pmode);

        [DllImport(ModuleName, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int _wopen(string filename, int oflag, int pmode);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _wopen([Const] IntPtr filename, int oflag);

        [DllImport(ModuleName, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int _wopen(string filename, int oflag);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _read(int handle, IntPtr buffer, uint count);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _sopen([Const] IntPtr filename, int oflag, int shflag, int pmode);

        [DllImport(ModuleName, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int _sopen(string filename, int oflag, int shflag, int pmode);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _sopen([Const] IntPtr filename, int oflag, int shflag);

        [DllImport(ModuleName, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int _sopen(string filename, int oflag, int shflag);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _wsopen([Const] IntPtr filename, int oflag, int shflag, int pmode);

        [DllImport(ModuleName, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int _wsopen(string filename, int oflag, int shflag, int pmode);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _wsopen([Const] IntPtr filename, int oflag, int shflag);

        [DllImport(ModuleName, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int _wsopen(string filename, int oflag, int shflag);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _tell(int handle);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern long _telli64(int handle);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _umask(int pmode);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _write(int handle, [Const] IntPtr buffer, uint count);
    }

    #endregion // Low level input and output

    #region Console and port input and output routines

    partial class msvcrt
    {
        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _cgets(IntPtr buffer);

        [DllImport(ModuleName, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern IntPtr _cgets(StringBuilder buffer);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int _cprintf([Const] IntPtr format, __arglist);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int _cprintf(string format, __arglist);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _cputs([Const] IntPtr @string);

        [DllImport(ModuleName, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int _cputs(string @string);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int _cscanf([Const] IntPtr format, ref int arg0, ref int arg1, ref int arg2);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int _cscanf([Const] IntPtr format, ref int arg0, ref int arg1);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int _cscanf([Const] IntPtr format, ref int arg0);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int _cscanf([Const] IntPtr format, ref double arg0, ref double arg1, ref double arg2);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int _cscanf([Const] IntPtr format, ref double arg0, ref double arg1);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int _cscanf([Const] IntPtr format, ref double arg0);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int _cscanf([Const] IntPtr format, StringBuilder arg0, StringBuilder arg1, StringBuilder arg2);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int _cscanf([Const] IntPtr format, StringBuilder arg0, StringBuilder arg1);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int _cscanf([Const] IntPtr format, StringBuilder arg0);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int _cscanf([Const] IntPtr format, __arglist);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int _cscanf(string format, ref int arg0, ref int arg1, ref int arg2);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int _cscanf(string format, ref int arg0, ref int arg1);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int _cscanf(string format, ref int arg0);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int _cscanf(string format, ref double arg0, ref double arg1, ref double arg2);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int _cscanf(string format, ref double arg0, ref double arg1);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int _cscanf(string format, ref double arg0);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int _cscanf(string format, StringBuilder arg0, StringBuilder arg1, StringBuilder arg2);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int _cscanf(string format, StringBuilder arg0, StringBuilder arg1);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int _cscanf(string format, StringBuilder arg0);

        [DllImport(ModuleName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int _cscanf(string format, __arglist);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _getch();

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _getche();

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _inp(ushort port);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern ushort _inpw(ushort port);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern uint _inpd(ushort port);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _kbhit();

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _outp(ushort port, int databyte);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern ushort _outpw(ushort port, ushort dataword);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern uint _outpd(ushort port, uint dataword);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _putch(int c);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _ungetch(int c);
    }

    #endregion // Console and port input and output routines

    #region Locale dependent routines

    partial class msvcrt
    {
        [DllImport(ModuleName)]
        public static extern IntPtr localeconv();

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern void _mbccpy(IntPtr dest, [Const] IntPtr src);

        [DllImport(ModuleName)]
        public static extern IntPtr setlocale(int category, [Const] IntPtr locale);

        [DllImport(ModuleName, CharSet = CharSet.Ansi)]
        public static extern IntPtr setlocale(int category, string locale);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _wsetlocale(int category, [Const] IntPtr locale);

        [DllImport(ModuleName, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern IntPtr _wsetlocale(int category, string locale);
    }

    #endregion // Locale dependent routines

    #region Memory allocation routines

    partial class msvcrt
    {
        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _alloca(size_t size);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr calloc(size_t num, size_t size);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _expand(IntPtr memblock, size_t size);

        [DllImport(ModuleName)]
        public static extern void free(IntPtr memblock);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern size_t _get_sbh_threshold();

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _heapadd(IntPtr memblock, size_t size);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _heapchk();

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _heapmin();

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _heapset(uint fill);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _heapwalk(IntPtr entryinfo);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _heapwalk(ref _HEAPINFO entryinfo);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr malloc(size_t size);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern size_t _msize(IntPtr memblock);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern _PNH _query_new_handler();

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _query_new_mode();

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr realloc(IntPtr memblock, size_t size);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern _PNH _set_new_handler(_PNH pNewHandler);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _set_new_mode(int newhandlermode);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _set_sbh_threshold(size_t size);
    }

    #endregion // Memory allocation routines

    #region Process and environment control

    partial class msvcrt
    {
        [DllImport(ModuleName)]
        public static extern void abort();

        public static void assert(int expression)
        {
            Debug.Assert(expression.Equals(0));
        }

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int atexit(_onexit_t func);

        [DllImport(ModuleName)]
        public static extern int atexit(IntPtr func);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern uint _beginthread(_beginthread_function start_address, uint stack_size, IntPtr arglist);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern uint _beginthreadex(IntPtr security, uint stack_size, _beginthreadex_function start_address, IntPtr arglist, uint initflag, IntPtr thrdaddr);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern void _cexit();

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern void _c_exit();

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _cwait(IntPtr termstat, int procHandle, int action);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _cwait(ref int termstat, int procHandle, int action);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern void _endthread();

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern void _endthreadex(uint retval);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _execl([Const] IntPtr cmdname, [Const] IntPtr arg0, [Const] IntPtr arg1, [Const] IntPtr arg2, [Const] IntPtr arg3, [Const] IntPtr arg4, [Const] IntPtr arg5, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _execl([Const] IntPtr cmdname, [Const] IntPtr arg0, [Const] IntPtr arg1, [Const] IntPtr arg2, [Const] IntPtr arg3, [Const] IntPtr arg4, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _execl([Const] IntPtr cmdname, [Const] IntPtr arg0, [Const] IntPtr arg1, [Const] IntPtr arg2, [Const] IntPtr arg3, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _execl([Const] IntPtr cmdname, [Const] IntPtr arg0, [Const] IntPtr arg1, [Const] IntPtr arg2, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _execl([Const] IntPtr cmdname, [Const] IntPtr arg0, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _execl([Const] IntPtr cmdname, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _execl([Const] IntPtr cmdname, __arglist);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _execl(string cmdname, string arg0, string arg1, string arg2, string arg3, string arg4, string arg5, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _execl(string cmdname, string arg0, string arg1, string arg2, string arg3, string arg4, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _execl(string cmdname, string arg0, string arg1, string arg2, string arg3, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _execl(string cmdname, string arg0, string arg1, string arg2, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _execl(string cmdname, string arg0, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _execl(string cmdname, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _execl(string cmdname, __arglist);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wexecl([Const] IntPtr cmdname, [Const] IntPtr arg0, [Const] IntPtr arg1, [Const] IntPtr arg2, [Const] IntPtr arg3, [Const] IntPtr arg4, [Const] IntPtr arg5, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wexecl([Const] IntPtr cmdname, [Const] IntPtr arg0, [Const] IntPtr arg1, [Const] IntPtr arg2, [Const] IntPtr arg3, [Const] IntPtr arg4, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wexecl([Const] IntPtr cmdname, [Const] IntPtr arg0, [Const] IntPtr arg1, [Const] IntPtr arg2, [Const] IntPtr arg3, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wexecl([Const] IntPtr cmdname, [Const] IntPtr arg0, [Const] IntPtr arg1, [Const] IntPtr arg2, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wexecl([Const] IntPtr cmdname, [Const] IntPtr arg0, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wexecl([Const] IntPtr cmdname, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wexecl([Const] IntPtr cmdname, __arglist);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wexecl(string cmdname, string arg0, string arg1, string arg2, string arg3, string arg4, string arg5, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wexecl(string cmdname, string arg0, string arg1, string arg2, string arg3, string arg4, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wexecl(string cmdname, string arg0, string arg1, string arg2, string arg3, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wexecl(string cmdname, string arg0, string arg1, string arg2, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wexecl(string cmdname, string arg0, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wexecl(string cmdname, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wexecl(string cmdname, __arglist);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _execle([Const] IntPtr cmdname, [Const] IntPtr arg0, [Const] IntPtr arg1, [Const] IntPtr arg2, [Const] IntPtr arg3, [Const] IntPtr arg4, [Const] IntPtr arg5, [Const] IntPtr pleasePassNullHere, [Const, Readonly] IntPtr envp);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _execle([Const] IntPtr cmdname, [Const] IntPtr arg0, [Const] IntPtr arg1, [Const] IntPtr arg2, [Const] IntPtr arg3, [Const] IntPtr arg4, [Const] IntPtr pleasePassNullHere, [Const, Readonly] IntPtr envp);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _execle([Const] IntPtr cmdname, [Const] IntPtr arg0, [Const] IntPtr arg1, [Const] IntPtr arg2, [Const] IntPtr arg3, [Const] IntPtr pleasePassNullHere, [Const, Readonly] IntPtr envp);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _execle([Const] IntPtr cmdname, [Const] IntPtr arg0, [Const] IntPtr arg1, [Const] IntPtr arg2, [Const] IntPtr pleasePassNullHere, [Const, Readonly] IntPtr envp);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _execle([Const] IntPtr cmdname, [Const] IntPtr arg0, [Const] IntPtr pleasePassNullHere, [Const, Readonly] IntPtr envp);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _execle([Const] IntPtr cmdname, [Const] IntPtr pleasePassNullHere, [Const, Readonly] IntPtr envp);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _execle([Const] IntPtr cmdname, __arglist);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _execle(string cmdname, string arg0, string arg1, string arg2, string arg3, string arg4, string arg5, [Const] IntPtr pleasePassNullHere, string envp);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _execle(string cmdname, string arg0, string arg1, string arg2, string arg3, string arg4, [Const] IntPtr pleasePassNullHere, string envp);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _execle(string cmdname, string arg0, string arg1, string arg2, string arg3, [Const] IntPtr pleasePassNullHere, string envp);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _execle(string cmdname, string arg0, string arg1, string arg2, [Const] IntPtr pleasePassNullHere, string envp);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _execle(string cmdname, string arg0, [Const] IntPtr pleasePassNullHere, string envp);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _execle(string cmdname, [Const] IntPtr pleasePassNullHere, string envp);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _execle(string cmdname, __arglist);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wexecle([Const] IntPtr cmdname, [Const] IntPtr arg0, [Const] IntPtr arg1, [Const] IntPtr arg2, [Const] IntPtr arg3, [Const] IntPtr arg4, [Const] IntPtr arg5, [Const] IntPtr pleasePassNullHere, [Const, Readonly] IntPtr envp);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wexecle([Const] IntPtr cmdname, [Const] IntPtr arg0, [Const] IntPtr arg1, [Const] IntPtr arg2, [Const] IntPtr arg3, [Const] IntPtr arg4, [Const] IntPtr pleasePassNullHere, [Const, Readonly] IntPtr envp);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wexecle([Const] IntPtr cmdname, [Const] IntPtr arg0, [Const] IntPtr arg1, [Const] IntPtr arg2, [Const] IntPtr arg3, [Const] IntPtr pleasePassNullHere, [Const, Readonly] IntPtr envp);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wexecle([Const] IntPtr cmdname, [Const] IntPtr arg0, [Const] IntPtr arg1, [Const] IntPtr arg2, [Const] IntPtr pleasePassNullHere, [Const, Readonly] IntPtr envp);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wexecle([Const] IntPtr cmdname, [Const] IntPtr arg0, [Const] IntPtr pleasePassNullHere, [Const, Readonly] IntPtr envp);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wexecle([Const] IntPtr cmdname, [Const] IntPtr pleasePassNullHere, [Const, Readonly] IntPtr envp);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wexecle([Const] IntPtr cmdname, __arglist);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wexecle(string cmdname, string arg0, string arg1, string arg2, string arg3, string arg4, string arg5, [Const] IntPtr pleasePassNullHere, string envp);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wexecle(string cmdname, string arg0, string arg1, string arg2, string arg3, string arg4, [Const] IntPtr pleasePassNullHere, string envp);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wexecle(string cmdname, string arg0, string arg1, string arg2, string arg3, [Const] IntPtr pleasePassNullHere, string envp);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wexecle(string cmdname, string arg0, string arg1, string arg2, [Const] IntPtr pleasePassNullHere, string envp);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wexecle(string cmdname, string arg0, [Const] IntPtr pleasePassNullHere, string envp);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wexecle(string cmdname, [Const] IntPtr pleasePassNullHere, string envp);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wexecle(string cmdname, __arglist);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _execlp([Const] IntPtr cmdname, [Const] IntPtr arg0, [Const] IntPtr arg1, [Const] IntPtr arg2, [Const] IntPtr arg3, [Const] IntPtr arg4, [Const] IntPtr arg5, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _execlp([Const] IntPtr cmdname, [Const] IntPtr arg0, [Const] IntPtr arg1, [Const] IntPtr arg2, [Const] IntPtr arg3, [Const] IntPtr arg4, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _execlp([Const] IntPtr cmdname, [Const] IntPtr arg0, [Const] IntPtr arg1, [Const] IntPtr arg2, [Const] IntPtr arg3, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _execlp([Const] IntPtr cmdname, [Const] IntPtr arg0, [Const] IntPtr arg1, [Const] IntPtr arg2, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _execlp([Const] IntPtr cmdname, [Const] IntPtr arg0, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _execlp([Const] IntPtr cmdname, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _execlp([Const] IntPtr cmdname, __arglist);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _execlp(string cmdname, string arg0, string arg1, string arg2, string arg3, string arg4, string arg5, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _execlp(string cmdname, string arg0, string arg1, string arg2, string arg3, string arg4, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _execlp(string cmdname, string arg0, string arg1, string arg2, string arg3, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _execlp(string cmdname, string arg0, string arg1, string arg2, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _execlp(string cmdname, string arg0, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _execlp(string cmdname, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _execlp(string cmdname, __arglist);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wexeclp([Const] IntPtr cmdname, [Const] IntPtr arg0, [Const] IntPtr arg1, [Const] IntPtr arg2, [Const] IntPtr arg3, [Const] IntPtr arg4, [Const] IntPtr arg5, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wexeclp([Const] IntPtr cmdname, [Const] IntPtr arg0, [Const] IntPtr arg1, [Const] IntPtr arg2, [Const] IntPtr arg3, [Const] IntPtr arg4, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wexeclp([Const] IntPtr cmdname, [Const] IntPtr arg0, [Const] IntPtr arg1, [Const] IntPtr arg2, [Const] IntPtr arg3, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wexeclp([Const] IntPtr cmdname, [Const] IntPtr arg0, [Const] IntPtr arg1, [Const] IntPtr arg2, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wexeclp([Const] IntPtr cmdname, [Const] IntPtr arg0, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wexeclp([Const] IntPtr cmdname, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wexeclp([Const] IntPtr cmdname, __arglist);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wexeclp(string cmdname, string arg0, string arg1, string arg2, string arg3, string arg4, string arg5, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wexeclp(string cmdname, string arg0, string arg1, string arg2, string arg3, string arg4, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wexeclp(string cmdname, string arg0, string arg1, string arg2, string arg3, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wexeclp(string cmdname, string arg0, string arg1, string arg2, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wexeclp(string cmdname, string arg0, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wexeclp(string cmdname, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wexeclp(string cmdname, __arglist);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _execlpe([Const] IntPtr cmdname, [Const] IntPtr arg0, [Const] IntPtr arg1, [Const] IntPtr arg2, [Const] IntPtr arg3, [Const] IntPtr arg4, [Const] IntPtr arg5, [Const] IntPtr pleasePassNullHere, [Const, Readonly] IntPtr envp);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _execlpe([Const] IntPtr cmdname, [Const] IntPtr arg0, [Const] IntPtr arg1, [Const] IntPtr arg2, [Const] IntPtr arg3, [Const] IntPtr arg4, [Const] IntPtr pleasePassNullHere, [Const, Readonly] IntPtr envp);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _execlpe([Const] IntPtr cmdname, [Const] IntPtr arg0, [Const] IntPtr arg1, [Const] IntPtr arg2, [Const] IntPtr arg3, [Const] IntPtr pleasePassNullHere, [Const, Readonly] IntPtr envp);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _execlpe([Const] IntPtr cmdname, [Const] IntPtr arg0, [Const] IntPtr arg1, [Const] IntPtr arg2, [Const] IntPtr pleasePassNullHere, [Const, Readonly] IntPtr envp);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _execlpe([Const] IntPtr cmdname, [Const] IntPtr arg0, [Const] IntPtr pleasePassNullHere, [Const, Readonly] IntPtr envp);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _execlpe([Const] IntPtr cmdname, [Const] IntPtr pleasePassNullHere, [Const, Readonly] IntPtr envp);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _execlpe([Const] IntPtr cmdname, __arglist);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _execlpe(string cmdname, string arg0, string arg1, string arg2, string arg3, string arg4, string arg5, [Const] IntPtr pleasePassNullHere, string envp);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _execlpe(string cmdname, string arg0, string arg1, string arg2, string arg3, string arg4, [Const] IntPtr pleasePassNullHere, string envp);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _execlpe(string cmdname, string arg0, string arg1, string arg2, string arg3, [Const] IntPtr pleasePassNullHere, string envp);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _execlpe(string cmdname, string arg0, string arg1, string arg2, [Const] IntPtr pleasePassNullHere, string envp);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _execlpe(string cmdname, string arg0, [Const] IntPtr pleasePassNullHere, string envp);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _execlpe(string cmdname, [Const] IntPtr pleasePassNullHere, string envp);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _execlpe(string cmdname, __arglist);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wexeclpe([Const] IntPtr cmdname, [Const] IntPtr arg0, [Const] IntPtr arg1, [Const] IntPtr arg2, [Const] IntPtr arg3, [Const] IntPtr arg4, [Const] IntPtr arg5, [Const] IntPtr pleasePassNullHere, [Const, Readonly] IntPtr envp);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wexeclpe([Const] IntPtr cmdname, [Const] IntPtr arg0, [Const] IntPtr arg1, [Const] IntPtr arg2, [Const] IntPtr arg3, [Const] IntPtr arg4, [Const] IntPtr pleasePassNullHere, [Const, Readonly] IntPtr envp);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wexeclpe([Const] IntPtr cmdname, [Const] IntPtr arg0, [Const] IntPtr arg1, [Const] IntPtr arg2, [Const] IntPtr arg3, [Const] IntPtr pleasePassNullHere, [Const, Readonly] IntPtr envp);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wexeclpe([Const] IntPtr cmdname, [Const] IntPtr arg0, [Const] IntPtr arg1, [Const] IntPtr arg2, [Const] IntPtr pleasePassNullHere, [Const, Readonly] IntPtr envp);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wexeclpe([Const] IntPtr cmdname, [Const] IntPtr arg0, [Const] IntPtr pleasePassNullHere, [Const, Readonly] IntPtr envp);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wexeclpe([Const] IntPtr cmdname, [Const] IntPtr pleasePassNullHere, [Const, Readonly] IntPtr envp);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wexeclpe([Const] IntPtr cmdname, __arglist);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wexeclpe(string cmdname, string arg0, string arg1, string arg2, string arg3, string arg4, string arg5, [Const] IntPtr pleasePassNullHere, string envp);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wexeclpe(string cmdname, string arg0, string arg1, string arg2, string arg3, string arg4, [Const] IntPtr pleasePassNullHere, string envp);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wexeclpe(string cmdname, string arg0, string arg1, string arg2, string arg3, [Const] IntPtr pleasePassNullHere, string envp);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wexeclpe(string cmdname, string arg0, string arg1, string arg2, [Const] IntPtr pleasePassNullHere, string envp);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wexeclpe(string cmdname, string arg0, [Const] IntPtr pleasePassNullHere, string envp);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wexeclpe(string cmdname, [Const] IntPtr pleasePassNullHere, string envp);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wexeclpe(string cmdname, __arglist);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _execv([Const] IntPtr cmdname, [Const] IntPtr argv);

        [DllImport(ModuleName, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int _execv(string cmdname, string argv);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _wexecv([Const] IntPtr cmdname, [Const] IntPtr argv);

        [DllImport(ModuleName, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int _wexecv(string cmdname, string argv);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _execve([Const] IntPtr cmdname, [Const] IntPtr argv, [Const, Readonly] IntPtr envp);

        [DllImport(ModuleName, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int _execve(string cmdname, string argv, string envp);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _wexecve([Const] IntPtr cmdname, [Const] IntPtr argv, [Const, Readonly] IntPtr envp);

        [DllImport(ModuleName, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int _wexecve(string cmdname, string argv, string envp);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _execvp([Const] IntPtr cmdname, [Const] IntPtr argv);

        [DllImport(ModuleName, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int _execvp(string cmdname, string argv);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _wexecvp([Const] IntPtr cmdname, [Const] IntPtr argv);

        [DllImport(ModuleName, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int _wexecvp(string cmdname, string argv);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _execvpe([Const] IntPtr cmdname, [Const] IntPtr argv, [Const, Readonly] IntPtr envp);

        [DllImport(ModuleName, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int _execvpe(string cmdname, string argv, string envp);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _wexecvpe([Const] IntPtr cmdname, [Const] IntPtr argv, [Const, Readonly] IntPtr envp);

        [DllImport(ModuleName, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int _wexecvpe(string cmdname, string argv, string envp);

        [DllImport(ModuleName)]
        public static extern void exit(int status);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern void _exit(int status);

        [DllImport(ModuleName)]
        public static extern IntPtr getenv([Const] IntPtr varname);

        [DllImport(ModuleName, CharSet = CharSet.Ansi)]
        public static extern IntPtr getenv(string varname);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _wgetenv([Const] IntPtr varname);

        [DllImport(ModuleName, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern IntPtr _wgetenv(string varname);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _getpid();

        [DllImport(ModuleName)]
        public static extern void longjmp(jmp_buf env, int value);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern _onexit_t _onexit(_onexit_t func);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _onexit(IntPtr func);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _pclose(IntPtr stream);

        [DllImport(ModuleName)]
        public static extern void perror([Const] IntPtr @string);

        [DllImport(ModuleName, CharSet = CharSet.Ansi)]
        public static extern void perror(string @string);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern void _wperror([Const] IntPtr @string);

        [DllImport(ModuleName, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern void _wperror(string @string);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _pipe(IntPtr phandles, uint psize, int textmode);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _pipe(int[] phandles, uint psize, int textmode);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _popen([Const] IntPtr command, [Const] IntPtr mode);

        [DllImport(ModuleName, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern IntPtr _popen(string command, string mode);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _wpopen([Const] IntPtr command, [Const] IntPtr mode);

        [DllImport(ModuleName, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern IntPtr _wpopen(string command, string mode);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _putenv([Const] IntPtr envstring);

        [DllImport(ModuleName, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int _putenv(string envstring);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _wputenv([Const] IntPtr envstring);

        [DllImport(ModuleName, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int _wputenv(string envstring);

        [DllImport(ModuleName)]
        public static extern int raise(int sig);

        [DllImport(ModuleName)]
        public static extern int setjmp(jmp_buf env);

        [DllImport(ModuleName), Todo("Translation not completed.")]
        public static extern void signal(int sig, IntPtr func);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _spawnl(int mode, [Const] IntPtr cmdname, [Const] IntPtr arg0, [Const] IntPtr arg1, [Const] IntPtr arg2, [Const] IntPtr arg3, [Const] IntPtr arg4, [Const] IntPtr arg5, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _spawnl(int mode, [Const] IntPtr cmdname, [Const] IntPtr arg0, [Const] IntPtr arg1, [Const] IntPtr arg2, [Const] IntPtr arg3, [Const] IntPtr arg4, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _spawnl(int mode, [Const] IntPtr cmdname, [Const] IntPtr arg0, [Const] IntPtr arg1, [Const] IntPtr arg2, [Const] IntPtr arg3, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _spawnl(int mode, [Const] IntPtr cmdname, [Const] IntPtr arg0, [Const] IntPtr arg1, [Const] IntPtr arg2, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _spawnl(int mode, [Const] IntPtr cmdname, [Const] IntPtr arg0, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _spawnl(int mode, [Const] IntPtr cmdname, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _spawnl(int mode, [Const] IntPtr cmdname, __arglist);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _spawnl(int mode, string cmdname, string arg0, string arg1, string arg2, string arg3, string arg4, string arg5, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _spawnl(int mode, string cmdname, string arg0, string arg1, string arg2, string arg3, string arg4, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _spawnl(int mode, string cmdname, string arg0, string arg1, string arg2, string arg3, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _spawnl(int mode, string cmdname, string arg0, string arg1, string arg2, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _spawnl(int mode, string cmdname, string arg0, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _spawnl(int mode, string cmdname, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _spawnl(int mode, string cmdname, __arglist);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wspawnl(int mode, [Const] IntPtr cmdname, [Const] IntPtr arg0, [Const] IntPtr arg1, [Const] IntPtr arg2, [Const] IntPtr arg3, [Const] IntPtr arg4, [Const] IntPtr arg5, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wspawnl(int mode, [Const] IntPtr cmdname, [Const] IntPtr arg0, [Const] IntPtr arg1, [Const] IntPtr arg2, [Const] IntPtr arg3, [Const] IntPtr arg4, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wspawnl(int mode, [Const] IntPtr cmdname, [Const] IntPtr arg0, [Const] IntPtr arg1, [Const] IntPtr arg2, [Const] IntPtr arg3, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wspawnl(int mode, [Const] IntPtr cmdname, [Const] IntPtr arg0, [Const] IntPtr arg1, [Const] IntPtr arg2, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wspawnl(int mode, [Const] IntPtr cmdname, [Const] IntPtr arg0, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wspawnl(int mode, [Const] IntPtr cmdname, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wspawnl(int mode, [Const] IntPtr cmdname, __arglist);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wspawnl(int mode, string cmdname, string arg0, string arg1, string arg2, string arg3, string arg4, string arg5, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wspawnl(int mode, string cmdname, string arg0, string arg1, string arg2, string arg3, string arg4, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wspawnl(int mode, string cmdname, string arg0, string arg1, string arg2, string arg3, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wspawnl(int mode, string cmdname, string arg0, string arg1, string arg2, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wspawnl(int mode, string cmdname, string arg0, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wspawnl(int mode, string cmdname, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wspawnl(int mode, string cmdname, __arglist);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _spawnle(int mode, [Const] IntPtr cmdname, [Const] IntPtr arg0, [Const] IntPtr arg1, [Const] IntPtr arg2, [Const] IntPtr arg3, [Const] IntPtr arg4, [Const] IntPtr arg5, [Const] IntPtr pleasePassNullHere, [Const, Readonly] IntPtr envp);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _spawnle(int mode, [Const] IntPtr cmdname, [Const] IntPtr arg0, [Const] IntPtr arg1, [Const] IntPtr arg2, [Const] IntPtr arg3, [Const] IntPtr arg4, [Const] IntPtr pleasePassNullHere, [Const, Readonly] IntPtr envp);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _spawnle(int mode, [Const] IntPtr cmdname, [Const] IntPtr arg0, [Const] IntPtr arg1, [Const] IntPtr arg2, [Const] IntPtr arg3, [Const] IntPtr pleasePassNullHere, [Const, Readonly] IntPtr envp);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _spawnle(int mode, [Const] IntPtr cmdname, [Const] IntPtr arg0, [Const] IntPtr arg1, [Const] IntPtr arg2, [Const] IntPtr pleasePassNullHere, [Const, Readonly] IntPtr envp);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _spawnle(int mode, [Const] IntPtr cmdname, [Const] IntPtr arg0, [Const] IntPtr pleasePassNullHere, [Const, Readonly] IntPtr envp);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _spawnle(int mode, [Const] IntPtr cmdname, [Const] IntPtr pleasePassNullHere, [Const, Readonly] IntPtr envp);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _spawnle(int mode, [Const] IntPtr cmdname, __arglist);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _spawnle(int mode, string cmdname, string arg0, string arg1, string arg2, string arg3, string arg4, string arg5, [Const] IntPtr pleasePassNullHere, string envp);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _spawnle(int mode, string cmdname, string arg0, string arg1, string arg2, string arg3, string arg4, [Const] IntPtr pleasePassNullHere, string envp);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _spawnle(int mode, string cmdname, string arg0, string arg1, string arg2, string arg3, [Const] IntPtr pleasePassNullHere, string envp);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _spawnle(int mode, string cmdname, string arg0, string arg1, string arg2, [Const] IntPtr pleasePassNullHere, string envp);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _spawnle(int mode, string cmdname, string arg0, [Const] IntPtr pleasePassNullHere, string envp);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _spawnle(int mode, string cmdname, [Const] IntPtr pleasePassNullHere, string envp);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _spawnle(int mode, string cmdname, __arglist);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wspawnle(int mode, [Const] IntPtr cmdname, [Const] IntPtr arg0, [Const] IntPtr arg1, [Const] IntPtr arg2, [Const] IntPtr arg3, [Const] IntPtr arg4, [Const] IntPtr arg5, [Const] IntPtr pleasePassNullHere, [Const, Readonly] IntPtr envp);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wspawnle(int mode, [Const] IntPtr cmdname, [Const] IntPtr arg0, [Const] IntPtr arg1, [Const] IntPtr arg2, [Const] IntPtr arg3, [Const] IntPtr arg4, [Const] IntPtr pleasePassNullHere, [Const, Readonly] IntPtr envp);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wspawnle(int mode, [Const] IntPtr cmdname, [Const] IntPtr arg0, [Const] IntPtr arg1, [Const] IntPtr arg2, [Const] IntPtr arg3, [Const] IntPtr pleasePassNullHere, [Const, Readonly] IntPtr envp);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wspawnle(int mode, [Const] IntPtr cmdname, [Const] IntPtr arg0, [Const] IntPtr arg1, [Const] IntPtr arg2, [Const] IntPtr pleasePassNullHere, [Const, Readonly] IntPtr envp);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wspawnle(int mode, [Const] IntPtr cmdname, [Const] IntPtr arg0, [Const] IntPtr pleasePassNullHere, [Const, Readonly] IntPtr envp);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wspawnle(int mode, [Const] IntPtr cmdname, [Const] IntPtr pleasePassNullHere, [Const, Readonly] IntPtr envp);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wspawnle(int mode, [Const] IntPtr cmdname, __arglist);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wspawnle(int mode, string cmdname, string arg0, string arg1, string arg2, string arg3, string arg4, string arg5, [Const] IntPtr pleasePassNullHere, string envp);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wspawnle(int mode, string cmdname, string arg0, string arg1, string arg2, string arg3, string arg4, [Const] IntPtr pleasePassNullHere, string envp);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wspawnle(int mode, string cmdname, string arg0, string arg1, string arg2, string arg3, [Const] IntPtr pleasePassNullHere, string envp);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wspawnle(int mode, string cmdname, string arg0, string arg1, string arg2, [Const] IntPtr pleasePassNullHere, string envp);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wspawnle(int mode, string cmdname, string arg0, [Const] IntPtr pleasePassNullHere, string envp);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wspawnle(int mode, string cmdname, [Const] IntPtr pleasePassNullHere, string envp);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wspawnle(int mode, string cmdname, __arglist);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _spawnlp(int mode, [Const] IntPtr cmdname, [Const] IntPtr arg0, [Const] IntPtr arg1, [Const] IntPtr arg2, [Const] IntPtr arg3, [Const] IntPtr arg4, [Const] IntPtr arg5, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _spawnlp(int mode, [Const] IntPtr cmdname, [Const] IntPtr arg0, [Const] IntPtr arg1, [Const] IntPtr arg2, [Const] IntPtr arg3, [Const] IntPtr arg4, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _spawnlp(int mode, [Const] IntPtr cmdname, [Const] IntPtr arg0, [Const] IntPtr arg1, [Const] IntPtr arg2, [Const] IntPtr arg3, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _spawnlp(int mode, [Const] IntPtr cmdname, [Const] IntPtr arg0, [Const] IntPtr arg1, [Const] IntPtr arg2, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _spawnlp(int mode, [Const] IntPtr cmdname, [Const] IntPtr arg0, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _spawnlp(int mode, [Const] IntPtr cmdname, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _spawnlp(int mode, [Const] IntPtr cmdname, __arglist);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _spawnlp(int mode, string cmdname, string arg0, string arg1, string arg2, string arg3, string arg4, string arg5, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _spawnlp(int mode, string cmdname, string arg0, string arg1, string arg2, string arg3, string arg4, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _spawnlp(int mode, string cmdname, string arg0, string arg1, string arg2, string arg3, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _spawnlp(int mode, string cmdname, string arg0, string arg1, string arg2, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _spawnlp(int mode, string cmdname, string arg0, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _spawnlp(int mode, string cmdname, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _spawnlp(int mode, string cmdname, __arglist);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wspawnlp(int mode, [Const] IntPtr cmdname, [Const] IntPtr arg0, [Const] IntPtr arg1, [Const] IntPtr arg2, [Const] IntPtr arg3, [Const] IntPtr arg4, [Const] IntPtr arg5, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wspawnlp(int mode, [Const] IntPtr cmdname, [Const] IntPtr arg0, [Const] IntPtr arg1, [Const] IntPtr arg2, [Const] IntPtr arg3, [Const] IntPtr arg4, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wspawnlp(int mode, [Const] IntPtr cmdname, [Const] IntPtr arg0, [Const] IntPtr arg1, [Const] IntPtr arg2, [Const] IntPtr arg3, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wspawnlp(int mode, [Const] IntPtr cmdname, [Const] IntPtr arg0, [Const] IntPtr arg1, [Const] IntPtr arg2, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wspawnlp(int mode, [Const] IntPtr cmdname, [Const] IntPtr arg0, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wspawnlp(int mode, [Const] IntPtr cmdname, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wspawnlp(int mode, [Const] IntPtr cmdname, __arglist);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wspawnlp(int mode, string cmdname, string arg0, string arg1, string arg2, string arg3, string arg4, string arg5, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wspawnlp(int mode, string cmdname, string arg0, string arg1, string arg2, string arg3, string arg4, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wspawnlp(int mode, string cmdname, string arg0, string arg1, string arg2, string arg3, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wspawnlp(int mode, string cmdname, string arg0, string arg1, string arg2, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wspawnlp(int mode, string cmdname, string arg0, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wspawnlp(int mode, string cmdname, [Const] IntPtr pleasePassNullHere);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wspawnlp(int mode, string cmdname, __arglist);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _spawnlpe(int mode, [Const] IntPtr cmdname, [Const] IntPtr arg0, [Const] IntPtr arg1, [Const] IntPtr arg2, [Const] IntPtr arg3, [Const] IntPtr arg4, [Const] IntPtr arg5, [Const] IntPtr pleasePassNullHere, [Const, Readonly] IntPtr envp);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _spawnlpe(int mode, [Const] IntPtr cmdname, [Const] IntPtr arg0, [Const] IntPtr arg1, [Const] IntPtr arg2, [Const] IntPtr arg3, [Const] IntPtr arg4, [Const] IntPtr pleasePassNullHere, [Const, Readonly] IntPtr envp);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _spawnlpe(int mode, [Const] IntPtr cmdname, [Const] IntPtr arg0, [Const] IntPtr arg1, [Const] IntPtr arg2, [Const] IntPtr arg3, [Const] IntPtr pleasePassNullHere, [Const, Readonly] IntPtr envp);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _spawnlpe(int mode, [Const] IntPtr cmdname, [Const] IntPtr arg0, [Const] IntPtr arg1, [Const] IntPtr arg2, [Const] IntPtr pleasePassNullHere, [Const, Readonly] IntPtr envp);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _spawnlpe(int mode, [Const] IntPtr cmdname, [Const] IntPtr arg0, [Const] IntPtr pleasePassNullHere, [Const, Readonly] IntPtr envp);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _spawnlpe(int mode, [Const] IntPtr cmdname, [Const] IntPtr pleasePassNullHere, [Const, Readonly] IntPtr envp);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _spawnlpe(int mode, [Const] IntPtr cmdname, __arglist);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _spawnlpe(int mode, string cmdname, string arg0, string arg1, string arg2, string arg3, string arg4, string arg5, [Const] IntPtr pleasePassNullHere, string envp);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _spawnlpe(int mode, string cmdname, string arg0, string arg1, string arg2, string arg3, string arg4, [Const] IntPtr pleasePassNullHere, string envp);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _spawnlpe(int mode, string cmdname, string arg0, string arg1, string arg2, string arg3, [Const] IntPtr pleasePassNullHere, string envp);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _spawnlpe(int mode, string cmdname, string arg0, string arg1, string arg2, [Const] IntPtr pleasePassNullHere, string envp);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _spawnlpe(int mode, string cmdname, string arg0, [Const] IntPtr pleasePassNullHere, string envp);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _spawnlpe(int mode, string cmdname, [Const] IntPtr pleasePassNullHere, string envp);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _spawnlpe(int mode, string cmdname, __arglist);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wspawnlpe(int mode, [Const] IntPtr cmdname, [Const] IntPtr arg0, [Const] IntPtr arg1, [Const] IntPtr arg2, [Const] IntPtr arg3, [Const] IntPtr arg4, [Const] IntPtr arg5, [Const] IntPtr pleasePassNullHere, [Const, Readonly] IntPtr envp);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wspawnlpe(int mode, [Const] IntPtr cmdname, [Const] IntPtr arg0, [Const] IntPtr arg1, [Const] IntPtr arg2, [Const] IntPtr arg3, [Const] IntPtr arg4, [Const] IntPtr pleasePassNullHere, [Const, Readonly] IntPtr envp);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wspawnlpe(int mode, [Const] IntPtr cmdname, [Const] IntPtr arg0, [Const] IntPtr arg1, [Const] IntPtr arg2, [Const] IntPtr arg3, [Const] IntPtr pleasePassNullHere, [Const, Readonly] IntPtr envp);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wspawnlpe(int mode, [Const] IntPtr cmdname, [Const] IntPtr arg0, [Const] IntPtr arg1, [Const] IntPtr arg2, [Const] IntPtr pleasePassNullHere, [Const, Readonly] IntPtr envp);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wspawnlpe(int mode, [Const] IntPtr cmdname, [Const] IntPtr arg0, [Const] IntPtr pleasePassNullHere, [Const, Readonly] IntPtr envp);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wspawnlpe(int mode, [Const] IntPtr cmdname, [Const] IntPtr pleasePassNullHere, [Const, Readonly] IntPtr envp);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wspawnlpe(int mode, [Const] IntPtr cmdname, __arglist);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wspawnlpe(int mode, string cmdname, string arg0, string arg1, string arg2, string arg3, string arg4, string arg5, [Const] IntPtr pleasePassNullHere, string envp);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wspawnlpe(int mode, string cmdname, string arg0, string arg1, string arg2, string arg3, string arg4, [Const] IntPtr pleasePassNullHere, string envp);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wspawnlpe(int mode, string cmdname, string arg0, string arg1, string arg2, string arg3, [Const] IntPtr pleasePassNullHere, string envp);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wspawnlpe(int mode, string cmdname, string arg0, string arg1, string arg2, [Const] IntPtr pleasePassNullHere, string envp);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wspawnlpe(int mode, string cmdname, string arg0, [Const] IntPtr pleasePassNullHere, string envp);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wspawnlpe(int mode, string cmdname, [Const] IntPtr pleasePassNullHere, string envp);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), CLSCompliant(false)]
        public static extern int _wspawnlpe(int mode, string cmdname, __arglist);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _spawnv(int mode, [Const] IntPtr cmdname, [Const] IntPtr argv);

        [DllImport(ModuleName, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int _spawnv(int mode, string cmdname, string argv);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _wspawnv(int mode, [Const] IntPtr cmdname, [Const] IntPtr argv);

        [DllImport(ModuleName, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int _wspawnv(int mode, string cmdname, string argv);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _spawnve(int mode, [Const] IntPtr cmdname, [Const] IntPtr argv, [Const, Readonly] IntPtr envp);

        [DllImport(ModuleName, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int _spawnve(int mode, string cmdname, string argv, string envp);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _wspawnve(int mode, [Const] IntPtr cmdname, [Const] IntPtr argv, [Const, Readonly] IntPtr envp);

        [DllImport(ModuleName, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int _wspawnve(int mode, string cmdname, string argv, string envp);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _spawnvp([Const] IntPtr cmdname, [Const] IntPtr argv);

        [DllImport(ModuleName, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int _spawnvp(string cmdname, string argv);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _wspawnvp([Const] IntPtr cmdname, [Const] IntPtr argv);

        [DllImport(ModuleName, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int _wspawnvp(string cmdname, string argv);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _spawnvpe(int mode, [Const] IntPtr cmdname, [Const] IntPtr argv, [Const, Readonly] IntPtr envp);

        [DllImport(ModuleName, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int _spawnvpe(int mode, string cmdname, string argv, string envp);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _wspawnvpe(int mode, [Const] IntPtr cmdname, [Const] IntPtr argv, [Const, Readonly] IntPtr envp);

        [DllImport(ModuleName, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int _wspawnvpe(int mode, string cmdname, string argv, string envp);

        [DllImport(ModuleName)]
        public static extern int system([Const] IntPtr command);

        [DllImport(ModuleName, CharSet = CharSet.Ansi)]
        public static extern int system(string command);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _wsystem([Const] IntPtr command);

        [DllImport(ModuleName, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int _wsystem(string command);
    }

    #endregion // Process and environment control

    #region Searching and sorting

    partial class msvcrt
    {
        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr bsearch([Const] IntPtr key, [Const] IntPtr @base, size_t num, size_t width, compare_function compare);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _lfind([Const] IntPtr key, [Const] IntPtr @base, IntPtr num, uint width, compare_function compare);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _lsearch([Const] IntPtr key, IntPtr @base, IntPtr num, uint width, compare_function compare);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern void qsort(IntPtr @base, size_t num, size_t width, compare_function compare);
    }

    #endregion // Searching and sorting

    #region String manipulation

    partial class msvcrt
    {
        [DllImport(ModuleName)]
        public static extern int strcoll([Const] IntPtr string1, [Const] IntPtr string2);

        [DllImport(ModuleName, CharSet = CharSet.Ansi)]
        public static extern int strcoll(string string1, string string2);

        [DllImport(ModuleName)]
        public static extern int wcscoll([Const] IntPtr string1, [Const] IntPtr string2);

        [DllImport(ModuleName, CharSet = CharSet.Unicode)]
        public static extern int wcscoll(string string1, string string2);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _mbscoll([Const] IntPtr string1, [Const] IntPtr string2);

        [DllImport(ModuleName, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int _mbscoll(string string1, string string2);

        [DllImport(ModuleName)]
        public static extern int stricoll([Const] IntPtr string1, [Const] IntPtr string2);

        [DllImport(ModuleName, CharSet = CharSet.Ansi)]
        public static extern int stricoll(string string1, string string2);

        [DllImport(ModuleName)]
        public static extern int wcsicoll([Const] IntPtr string1, [Const] IntPtr string2);

        [DllImport(ModuleName, CharSet = CharSet.Unicode)]
        public static extern int wcsicoll(string string1, string string2);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _mbsicoll([Const] IntPtr string1, [Const] IntPtr string2);

        [DllImport(ModuleName, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int _mbsicoll(string string1, string string2);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int strncoll([Const] IntPtr string1, [Const] IntPtr string2, size_t count);

        [DllImport(ModuleName, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int strncoll(string string1, string string2, size_t count);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int wcsncoll([Const] IntPtr string1, [Const] IntPtr string2, size_t count);

        [DllImport(ModuleName, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int wcsncoll(string string1, string string2, size_t count);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _mbsncoll([Const] IntPtr string1, [Const] IntPtr string2, size_t count);

        [DllImport(ModuleName, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int _mbsncoll(string string1, string string2, size_t count);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int strnicoll([Const] IntPtr string1, [Const] IntPtr string2, size_t count);

        [DllImport(ModuleName, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int strnicoll(string string1, string string2, size_t count);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int wcsnicoll([Const] IntPtr string1, [Const] IntPtr string2, size_t count);

        [DllImport(ModuleName, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int wcsnicoll(string string1, string string2, size_t count);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _mbsnicoll([Const] IntPtr string1, [Const] IntPtr string2, size_t count);

        [DllImport(ModuleName, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int _mbsnicoll(string string1, string string2, size_t count);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _mbsdec([Const] IntPtr start, [Const] IntPtr current);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _strdec([Const] IntPtr start, [Const] IntPtr current);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _wcsdec([Const] IntPtr start, [Const] IntPtr current);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _mbsinc([Const] IntPtr start, [Const] IntPtr current);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _strinc([Const] IntPtr start, [Const] IntPtr current);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _wcsinc([Const] IntPtr start, [Const] IntPtr current);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern size_t strlen([Const] IntPtr @string);

        [DllImport(ModuleName, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern size_t strlen(string @string);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern size_t wcslen([Const] IntPtr @string);

        [DllImport(ModuleName, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern size_t wcslen(string @string);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern size_t _mbslen([Const] IntPtr @string);

        [DllImport(ModuleName, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern size_t _mbslen(string @string);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern size_t _mbstrlen([Const] IntPtr @string);

        [DllImport(ModuleName, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern size_t _mbstrlen(string @string);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _strlwr([Const] IntPtr @string);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _wcslwr([Const] IntPtr @string);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _mbslwr([Const] IntPtr @string);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _mbsnbcat(IntPtr dest, [Const] IntPtr src, size_t count);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _mbsnbcmp([Const] IntPtr string1, [Const] IntPtr string2, size_t count);

        [DllImport(ModuleName, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int _mbsnbcmp(string string1, string string2, size_t count);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern size_t _mbsnbcnt([Const] IntPtr @string, size_t number);

        [DllImport(ModuleName, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern size_t _mbsnbcnt(string @string, size_t number);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern size_t _mbsnccnt([Const] IntPtr @string, size_t number);

        [DllImport(ModuleName, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern size_t _mbsnccnt(string @string, size_t number);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern size_t _strncnt([Const] IntPtr @string, size_t number);

        [DllImport(ModuleName, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern size_t _strncnt(string @string, size_t number);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern size_t _wcsncnt([Const] IntPtr @string, size_t number);

        [DllImport(ModuleName, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern size_t _wcsncnt(string @string, size_t number);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _mbsnbcpy(IntPtr dest, [Const] IntPtr src, size_t count);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _mbsnbicmp([Const] IntPtr string1, [Const] IntPtr string2, size_t count);

        [DllImport(ModuleName, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int _mbsnbicmp(string string1, string string2, size_t count);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _mbsnbset(IntPtr @string, uint c, size_t count);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern uint _mbsnextc([Const] IntPtr @string);

        [DllImport(ModuleName, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern uint _mbsnextc(string @string);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern uint _strnextc([Const] IntPtr @string);

        [DllImport(ModuleName, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern uint _strnextc(string @string);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern uint _wcsnextc([Const] IntPtr @string);

        [DllImport(ModuleName, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern uint _wcsnextc(string @string);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _mbsninc([Const] IntPtr @string, size_t count);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _strninc([Const] IntPtr @string, size_t count);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _wcsninc([Const] IntPtr @string, size_t count);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _mbsspnp([Const] IntPtr string1, [Const] IntPtr string2);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _strspnp([Const] IntPtr string1, [Const] IntPtr string2);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _wcsspnp([Const] IntPtr string1, [Const] IntPtr string2);

        [DllImport(ModuleName)]
        public static extern IntPtr strcat(IntPtr strDestination, [Const] IntPtr strSource);

        [DllImport(ModuleName)]
        public static extern IntPtr wcscat(IntPtr strDestination, [Const] IntPtr strSource);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _mbscat(IntPtr strDestination, [Const] IntPtr strSource);

        [DllImport(ModuleName)]
        public static extern IntPtr strchr([Const] IntPtr @string, int c);

        [DllImport(ModuleName)]
        public static extern IntPtr wcschr([Const] IntPtr @string, int c);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _mbschr([Const] IntPtr @string, int c);

        [DllImport(ModuleName)]
        public static extern int strcmp([Const] IntPtr string1, [Const] IntPtr string2);

        [DllImport(ModuleName, CharSet = CharSet.Ansi)]
        public static extern int strcmp(string string1, string string2);

        [DllImport(ModuleName)]
        public static extern int wcscmp([Const] IntPtr string1, [Const] IntPtr string2);

        [DllImport(ModuleName, CharSet = CharSet.Unicode)]
        public static extern int wcscmp(string string1, string string2);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _mbscmp([Const] IntPtr string1, [Const] IntPtr string2);

        [DllImport(ModuleName, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int _mbscmp(string string1, string string2);

        [DllImport(ModuleName)]
        public static extern IntPtr strcpy(IntPtr strDestination, [Const] IntPtr strSource);

        [DllImport(ModuleName)]
        public static extern IntPtr wcscpy(IntPtr strDestination, [Const] IntPtr strSource);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _mbscpy(IntPtr strDestination, [Const] IntPtr strSource);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern size_t strcspn([Const] IntPtr strDestination, [Const] IntPtr strCharSet);

        [DllImport(ModuleName, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern size_t strcspn(string strDestination, string strCharSet);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern size_t wcscspn([Const] IntPtr strDestination, [Const] IntPtr strCharSet);

        [DllImport(ModuleName, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern size_t wcscspn(string strDestination, string strCharSet);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern size_t _mbscspn([Const] IntPtr strDestination, [Const] IntPtr strCharSet);

        [DllImport(ModuleName, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern size_t _mbscspn(string strDestination, string strCharSet);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _strdup([Const] IntPtr strSource);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _wcsdup([Const] IntPtr strSource);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _mbsdup([Const] IntPtr strSource);

        [DllImport(ModuleName)]
        public static extern IntPtr strerror(int errnum);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _strerror([Const] IntPtr strErrMsg);

        [DllImport(ModuleName, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern IntPtr _strerror(string strErrMsg);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _stricmp([Const] IntPtr string1, [Const] IntPtr string2);

        [DllImport(ModuleName, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int _stricmp(string string1, string string2);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _wcsicmp([Const] IntPtr string1, [Const] IntPtr string2);

        [DllImport(ModuleName, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int _wcsicmp(string string1, string string2);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _mbsicmp([Const] IntPtr string1, [Const] IntPtr string2);

        [DllImport(ModuleName, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int _mbsicmp(string string1, string string2);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr strncat(IntPtr strDestination, [Const] IntPtr strSource, size_t count);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr wcsncat(IntPtr strDestination, [Const] IntPtr strSource, size_t count);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _mbsncat(IntPtr strDestination, [Const] IntPtr strSource, size_t count);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int strncmp([Const] IntPtr string1, [Const] IntPtr string2, size_t count);

        [DllImport(ModuleName, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int strncmp(string string1, string string2, size_t count);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int wcsncmp([Const] IntPtr string1, [Const] IntPtr string2, size_t count);

        [DllImport(ModuleName, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int wcsncmp(string string1, string string2, size_t count);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _mbsncmp([Const] IntPtr string1, [Const] IntPtr string2, size_t count);

        [DllImport(ModuleName, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int _mbsncmp(string string1, string string2, size_t count);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr strncpy(IntPtr strDestination, [Const] IntPtr strSource, size_t count);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr wcsncpy(IntPtr strDestination, [Const] IntPtr strSource, size_t count);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _mbsncpy(IntPtr strDestination, [Const] IntPtr strSource, size_t count);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _strnicmp([Const] IntPtr string1, [Const] IntPtr string2, size_t count);

        [DllImport(ModuleName, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int _strnicmp(string string1, string string2, size_t count);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _wcsnicmp([Const] IntPtr string1, [Const] IntPtr string2, size_t count);

        [DllImport(ModuleName, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int _wcsnicmp(string string1, string string2, size_t count);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _mbsnicmp([Const] IntPtr string1, [Const] IntPtr string2, size_t count);

        [DllImport(ModuleName, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int _mbsnicmp(string string1, string string2, size_t count);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _strnset(IntPtr @string, int c, size_t count);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _wcsnset(IntPtr @string, wchar_t c, size_t count);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _mbsnset(IntPtr @string, uint c, size_t count);

        [DllImport(ModuleName)]
        public static extern IntPtr strpbrk([Const] IntPtr @string, [Const] IntPtr strCharSet);

        [DllImport(ModuleName)]
        public static extern IntPtr wcspbrk([Const] IntPtr @string, [Const] IntPtr strCharSet);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _mbspbrk([Const] IntPtr @string, [Const] IntPtr strCharSet);

        [DllImport(ModuleName)]
        public static extern IntPtr strrchr([Const] IntPtr @string, int c);

        [DllImport(ModuleName)]
        public static extern IntPtr wcsrchr([Const] IntPtr @string, int c);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _mbsrchr([Const] IntPtr @string, int c);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _strrev(IntPtr @string);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _wcsrev(IntPtr @string);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _mbsrev(IntPtr @string);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _strset(IntPtr @string, int c);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _wcsset(IntPtr @string, wchar_t c);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _mbsset(IntPtr @string, uint c);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern size_t strspn([Const] IntPtr string1, [Const] IntPtr string2);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern size_t wcsspn([Const] IntPtr string1, [Const] IntPtr string2);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern size_t _mbsspn([Const] IntPtr string1, [Const] IntPtr string2);

        [DllImport(ModuleName)]
        public static extern IntPtr strstr([Const] IntPtr @string, [Const] IntPtr strCharSet);

        [DllImport(ModuleName)]
        public static extern IntPtr wcsstr([Const] IntPtr @string, [Const] IntPtr strCharSet);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _mbsstr([Const] IntPtr @string, [Const] IntPtr strCharSet);

        [DllImport(ModuleName)]
        public static extern IntPtr strtok(IntPtr strToken, [Const] IntPtr strDelimit);

        [DllImport(ModuleName)]
        public static extern IntPtr wcstok(IntPtr strToken, [Const] IntPtr strDelimit);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _mbstok(IntPtr strToken, [Const] IntPtr strDelimit);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _strupr([Const] IntPtr @string);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _wcsupr([Const] IntPtr @string);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _mbsupr([Const] IntPtr @string);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern size_t strxfrm(IntPtr strDest, [Const] IntPtr strSource, size_t count);

        [DllImport(ModuleName, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern size_t strxfrm(StringBuilder strDest, string strSource, size_t count);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern size_t wcsxfrm(IntPtr strDest, [Const] IntPtr strSource, size_t count);

        [DllImport(ModuleName, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern size_t wcsxfrm(StringBuilder strDest, string strSource, size_t count);
    }

    #endregion // String manipulation

    #region System calls

    partial class msvcrt
    {
        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _findclose(int handle);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _findfirst(IntPtr filespec, IntPtr fileinfo);

        [DllImport(ModuleName, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int _findfirst(string filespec, ref _finddata_t fileinfo);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern long _findfirsti64(IntPtr filespec, IntPtr fileinfo);

        [DllImport(ModuleName, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern long _findfirsti64(string filespec, ref _finddata_t fileinfo);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _wfindfirst(IntPtr filespec, IntPtr fileinfo);

        [DllImport(ModuleName, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int _wfindfirst(string filespec, ref _wfinddata_t fileinfo);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern long _wfindfirsti64(IntPtr filespec, IntPtr fileinfo);

        [DllImport(ModuleName, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern long _wfindfirsti64(string filespec, ref _wfinddata_t fileinfo);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _findnext(int handle, IntPtr fileinfo);

        [DllImport(ModuleName, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int _findnext(int handle, ref _finddata_t fileinfo);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern long _findnexti64(int handle, IntPtr fileinfo);

        [DllImport(ModuleName, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern long _findnexti64(int handle, ref _finddata_t fileinfo);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _wfindnext(int handle, IntPtr fileinfo);

        [DllImport(ModuleName, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int _wfindnext(int handle, ref _wfinddata_t fileinfo);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern long _wfindnexti64(int handle, IntPtr fileinfo);

        [DllImport(ModuleName, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern long _wfindnexti64(int handle, ref _wfinddata_t fileinfo);
    }

    #endregion // System calls

    #region Time management

    partial class msvcrt
    {
        [DllImport(ModuleName)]
        public static extern IntPtr asctime([Const] IntPtr timeptr);

        [DllImport(ModuleName)]
        public static extern IntPtr asctime(ref tm timeptr);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _wasctime([Const] IntPtr timeptr);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _wasctime(ref tm timeptr);

        [DllImport(ModuleName)]
        public static extern clock_t clock();

        [DllImport(ModuleName)]
        public static extern IntPtr ctime([Const] IntPtr timeptr);

        [DllImport(ModuleName)]
        public static extern IntPtr ctime(ref time_t timer);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _wctime([Const] IntPtr timeptr);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _wctime(ref time_t timer);

        [DllImport(ModuleName)]
        public static extern double difftime(time_t timer1, time_t timer0);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern void _ftime(IntPtr timeptr);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern void _ftime(ref _timeb timeptr);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _futime(int handle, IntPtr filetime);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _futime(int handle, ref _utimbuf filetime);

        [DllImport(ModuleName)]
        public static extern IntPtr gmtime([Const] IntPtr timer);

        [DllImport(ModuleName)]
        public static extern IntPtr gmtime(ref time_t timer);

        [DllImport(ModuleName)]
        public static extern IntPtr localtime([Const] IntPtr timer);

        [DllImport(ModuleName)]
        public static extern IntPtr localtime(ref time_t timer);

        [DllImport(ModuleName)]
        public static extern time_t mktime(IntPtr timeptr);

        [DllImport(ModuleName)]
        public static extern time_t mktime(ref tm timeptr);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _strdate(IntPtr datestr);

        [DllImport(ModuleName, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern IntPtr _strdate(StringBuilder datestr);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _wstrdate(IntPtr datestr);

        [DllImport(ModuleName, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern IntPtr _wstrdate(StringBuilder datestr);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern size_t strftime(IntPtr strDest, size_t maxsize, [Const] IntPtr format, [Const] IntPtr timeptr);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern size_t wcsftime(IntPtr strDest, size_t maxsize, [Const] IntPtr format, [Const] IntPtr timeptr);

        [DllImport(ModuleName, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern size_t strftime(StringBuilder strDest, size_t maxsize, string format, ref tm timeptr);

        [DllImport(ModuleName, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern size_t wcsftime(StringBuilder strDest, size_t maxsize, string format, ref tm timeptr);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _strtime(IntPtr datestr);

        [DllImport(ModuleName, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern IntPtr _strtime(StringBuilder datestr);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr _wstrtime(IntPtr datestr);

        [DllImport(ModuleName, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern IntPtr _wstrtime(StringBuilder datestr);

        [DllImport(ModuleName)]
        public static extern time_t time(IntPtr timer);

        [DllImport(ModuleName)]
        public static extern time_t time(ref time_t timer);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern void _tzset();

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _utime(IntPtr filename, IntPtr times);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int _wutime(IntPtr filename, IntPtr times);
    }

    #endregion // Time management
}
