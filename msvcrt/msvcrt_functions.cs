using System;
using System.Runtime.InteropServices;

#region Buffer Manipulation

partial class msvcrt
{
    [DllImport(ModuleName)]
    public static extern IntPtr _memccpy(IntPtr dest, IntPtr src, int c, uint count);

    [DllImport(ModuleName)]
    public static extern IntPtr memchr(IntPtr buf, int c, uint count);

    [DllImport(ModuleName)]
    public static extern IntPtr wmemchr(IntPtr buf, ushort c, uint count);

    [DllImport(ModuleName)]
    public static extern int memcmp(IntPtr buf1, IntPtr buf2, uint count);

    [DllImport(ModuleName)]
    public static extern int wmemcmp(IntPtr buf1, IntPtr buf2, uint count);

    [DllImport(ModuleName)]
    public static extern IntPtr memcpy(IntPtr dest, IntPtr src, uint count);

    [DllImport(ModuleName)]
    public static extern IntPtr wmemcpy(IntPtr dest, IntPtr src, uint count);
    
    [DllImport(ModuleName)]
    public static extern int _memicmp(IntPtr buf1, IntPtr buf2, uint count);

    [DllImport(ModuleName)]
    public static extern int _memicmp_l(IntPtr buf1, IntPtr buf2, uint count, uint locale);

    [DllImport(ModuleName)]
    public static extern IntPtr memmove(IntPtr dest, IntPtr src, uint count);

    [DllImport(ModuleName)]
    public static extern IntPtr wmemmove(IntPtr dest, IntPtr src, uint count);

    [DllImport(ModuleName)]
    public static extern IntPtr memset(IntPtr dest, int c, uint count);

    [DllImport(ModuleName)]
    public static extern IntPtr wmemset(IntPtr dest, ushort c, uint count);

    [DllImport(ModuleName)]
    public static extern void _swab(IntPtr src, IntPtr dest, int n);
}

#endregion // Buffer Manipulation

#region Byte Classification

partial class msvcrt
{
    [DllImport(ModuleName)]
    public static extern int isleadbyte(int c);

    [DllImport(ModuleName)]
    public static extern int _isleadbyte_l(int c);

    [DllImport(ModuleName)]
    public static extern int _ismbbalnum(uint c);

    [DllImport(ModuleName)]
    public static extern int _ismbbalnum_l(uint c);

    [DllImport(ModuleName)]
    public static extern int _ismbbalpha(uint c);

    [DllImport(ModuleName)]
    public static extern int _ismbbalpha_l(uint c);

    [DllImport(ModuleName)]
    public static extern int _ismbbgraph(uint c);

    [TestRequired]
    [DllImport(ModuleName)]
    public static extern int _ismbbgraph_l(uint c, uint locale);

    [DllImport(ModuleName)]
    public static extern int _ismbbkalnum(uint c);

    [TestRequired]
    [DllImport(ModuleName)]
    public static extern int _ismbbkalnum_l(uint c, uint locale);

    [DllImport(ModuleName)]
    public static extern int _ismbbkana(uint c);

    [TestRequired]
    [DllImport(ModuleName)]
    public static extern int _ismbbkana_l(uint c, uint locale);

    [DllImport(ModuleName)]
    public static extern int _ismbbkprint(uint c);

    [TestRequired]
    [DllImport(ModuleName)]
    public static extern int _ismbbkprint_l(uint c, uint locale);

    [DllImport(ModuleName)]
    public static extern int _ismbbkpunct(uint c);

    [TestRequired]
    [DllImport(ModuleName)]
    public static extern int _ismbbkpunct_l(uint c, uint locale);

    [DllImport(ModuleName)]
    public static extern int _ismbblead(uint c);

    [TestRequired]
    [DllImport(ModuleName)]
    public static extern int _ismbblead_l(uint c, uint locale);

    [DllImport(ModuleName)]
    public static extern int _ismbbprint(uint c);

    [TestRequired]
    [DllImport(ModuleName)]
    public static extern int _ismbbprint_l(uint c, uint locale);

    [DllImport(ModuleName)]
    public static extern int _ismbbpunct(uint c);

    [TestRequired]
    [DllImport(ModuleName)]
    public static extern int _ismbbpunct_l(uint c, uint locale);

    [DllImport(ModuleName)]
    public static extern int _ismbbtrail(uint c);

    [TestRequired]
    [DllImport(ModuleName)]
    public static extern int _ismbbtrail_l(uint c, uint locale);

    [TestRequired]
    [DllImport(ModuleName, ExactSpelling = true, CharSet = CharSet.Ansi)]
    public static extern int _ismbslead(IntPtr str, IntPtr current);

    [TestRequired]
    [DllImport(ModuleName, ExactSpelling = true, CharSet = CharSet.Ansi)]
    public static extern int _ismbstrail(IntPtr str, IntPtr current);

    [TestRequired]
    [DllImport(ModuleName, ExactSpelling = true, CharSet = CharSet.Ansi)]
    public static extern int _ismbslead_l(IntPtr str, IntPtr current, uint locale);

    [TestRequired]
    [DllImport(ModuleName, ExactSpelling = true, CharSet = CharSet.Ansi)]
    public static extern int _ismbstrail_l(IntPtr str, IntPtr current, uint locale);

    [DllImport(ModuleName)]
    public static extern int _mbbtype(uint c, int type);

    [TestRequired]
    [DllImport(ModuleName)]
    public static extern int _mbbtype_l(uint c, int type, uint locale);

    [TestRequired]
    [DllImport(ModuleName, ExactSpelling = true, CharSet = CharSet.Ansi)]
    public static extern int _mbsbtype(IntPtr mbstr, uint count);

    [TestRequired]
    [DllImport(ModuleName, ExactSpelling = true, CharSet = CharSet.Ansi)]
    public static extern int _mbsbtype_l(IntPtr mbstr, uint count, uint locale);

    [Todo]
    [TestRequired]
    [DllImport(ModuleName)]
    public static extern int mbsinit(IntPtr ps);

    // http://msdn.microsoft.com/en-us/library/9h6ew5ts.aspx - _ismbbkprint
}

#endregion // Byte Classification

#region Character Classification

partial class msvcrt
{
    [DllImport(ModuleName)]
    public static extern int isalnum(int c);

    [DllImport(ModuleName)]
    public static extern int iswalnum(ushort c);

    [DllImport(ModuleName)]
    public static extern int _isalnum_l(int c, uint locale);

    [DllImport(ModuleName)]
    public static extern int _iswalnum_l(ushort c, uint locale);

    [DllImport(ModuleName)]
    public static extern int _ismbcalnum(uint c);

    [DllImport(ModuleName)]
    public static extern int _ismbcalnum_l(uint c, uint locale);

    [DllImport(ModuleName)]
    public static extern int _ismbcalpha(uint c);

    [DllImport(ModuleName)]
    public static extern int _ismbcalpha_l(uint c, uint locale);

    [DllImport(ModuleName)]
    public static extern int _ismbcdigit(uint c);

    [DllImport(ModuleName)]
    public static extern int _ismbcdigit_l(uint c, uint locale);

    [DllImport(ModuleName)]
    public static extern int isalpha(int c);

    [DllImport(ModuleName)]
    public static extern int iswalpha(ushort c);

    [DllImport(ModuleName)]
    public static extern int _isalpha_l(int c, uint locale);

    [DllImport(ModuleName)]
    public static extern int _iswalpha_l(ushort c, uint locale);

    [DllImport(ModuleName)]
    public static extern int __isascii(int c);

    [DllImport(ModuleName)]
    public static extern int iswascii(ushort c);

    [DllImport(ModuleName)]
    public static extern int iscntrl(int c);

    [DllImport(ModuleName)]
    public static extern int iswcntrl(ushort c);

    [DllImport(ModuleName)]
    public static extern int _iscntrl_l(int c, uint locale);

    [DllImport(ModuleName)]
    public static extern int _iswcntrl_l(ushort c, uint locale);

    [DllImport(ModuleName)]
    public static extern int __iscsym(int c);

    [DllImport(ModuleName)]
    public static extern int __iswcsym(ushort c);

    [DllImport(ModuleName)]
    public static extern int __iscsymf(int c);

    [DllImport(ModuleName)]
    public static extern int __iswcsymf(ushort c);

    [DllImport(ModuleName)]
    public static extern int _iscsym_l(int c, uint locale);

    [DllImport(ModuleName)]
    public static extern int _iswcsym_l(ushort c, uint locale);

    [DllImport(ModuleName)]
    public static extern int _iscsymf_l(int c, uint locale);

    [DllImport(ModuleName)]
    public static extern int _iswcsymf_l(ushort c, uint locale);

    [DllImport(ModuleName)]
    public static extern int isdigit(int c);

    [DllImport(ModuleName)]
    public static extern int iswdigit(ushort c);

    [DllImport(ModuleName)]
    public static extern int _isdigit_l(int c, uint locale);

    [DllImport(ModuleName)]
    public static extern int _iswdigit_l(ushort c, uint locale);

    [DllImport(ModuleName)]
    public static extern int isgraph(int c);

    [DllImport(ModuleName)]
    public static extern int iswgraph(ushort c);

    [DllImport(ModuleName)]
    public static extern int _isgraph_l(int c, uint locale);

    [DllImport(ModuleName)]
    public static extern int _iswgraph_l(ushort c, uint locale);

    [DllImport(ModuleName)]
    public static extern int _ismbcgraph(uint c);

    [DllImport(ModuleName)]
    public static extern int _ismbcgraph_l(uint c, uint locale);

    [DllImport(ModuleName)]
    public static extern int _ismbcprint(uint c);

    [DllImport(ModuleName)]
    public static extern int _ismbcprint_l(uint c, uint locale);

    [DllImport(ModuleName)]
    public static extern int _ismbcpunct(uint c);

    [DllImport(ModuleName)]
    public static extern int _ismbcpunct_l(uint c, uint locale);

    [DllImport(ModuleName)]
    public static extern int _ismbcspace(uint c);

    [DllImport(ModuleName)]
    public static extern int _ismbcspace_l(uint c, uint locale);

    [DllImport(ModuleName)]
    public static extern int islower(int c);

    [DllImport(ModuleName)]
    public static extern int iswlower(ushort c);

    [DllImport(ModuleName)]
    public static extern int islower_l(int c, uint locale);

    [DllImport(ModuleName)]
    public static extern int _iswlower_l(ushort c, uint locale);

    [DllImport(ModuleName)]
    public static extern int _ismbclower(uint c);

    [DllImport(ModuleName)]
    public static extern int _ismbclower_l(uint c, uint locale);

    [DllImport(ModuleName)]
    public static extern int _ismbcupper(uint c);

    [DllImport(ModuleName)]
    public static extern int _ismbcupper_l(uint c, uint locale);

    [DllImport(ModuleName)]
    public static extern int _ismbchira(uint c);

    [DllImport(ModuleName)]
    public static extern int _ismbchira_l(uint c, uint locale);

    [DllImport(ModuleName)]
    public static extern int _ismbckata(uint c);

    [DllImport(ModuleName)]
    public static extern int _ismbckata_l(uint c, uint locale);

    [DllImport(ModuleName)]
    public static extern int _ismbclegal(uint c);

    [DllImport(ModuleName)]
    public static extern int _ismbclegal_l(uint c, uint locale);

    [DllImport(ModuleName)]
    public static extern int _ismbcsymbol(uint c);

    [DllImport(ModuleName)]
    public static extern int _ismbcsymbol_l(uint c, uint locale);

    [DllImport(ModuleName)]
    public static extern int _ismbcl0(uint c);

    [DllImport(ModuleName)]
    public static extern int _ismbcl0_l(uint c, uint locale);

    [DllImport(ModuleName)]
    public static extern int _ismbcl1(uint c);

    [DllImport(ModuleName)]
    public static extern int _ismbcl1_l(uint c, uint locale);

    [DllImport(ModuleName)]
    public static extern int _ismbcl2(uint c);

    [DllImport(ModuleName)]
    public static extern int _ismbcl2_l(uint c, uint locale);

    [DllImport(ModuleName)]
    public static extern int isprint(int c);

    [DllImport(ModuleName)]
    public static extern int iswprint(ushort c);

    [DllImport(ModuleName)]
    public static extern int _isprint_l(int c, uint locale);

    [DllImport(ModuleName)]
    public static extern int _iswprint_l(ushort c, uint locale);

    [DllImport(ModuleName)]
    public static extern int ispunct(int c);

    [DllImport(ModuleName)]
    public static extern int iswpunct(ushort c);

    [DllImport(ModuleName)]
    public static extern int _ispunct_l(int c, uint locale);

    [DllImport(ModuleName)]
    public static extern int _iswpunct_l(ushort c, uint locale);

    [DllImport(ModuleName)]
    public static extern int isspace(int c);

    [DllImport(ModuleName)]
    public static extern int iswspace(ushort c);

    [DllImport(ModuleName)]
    public static extern int _isspace_l(int c, uint locale);

    [DllImport(ModuleName)]
    public static extern int _iswspace_l(ushort c, uint locale);

    [DllImport(ModuleName)]
    public static extern int isupper(int c);

    [DllImport(ModuleName)]
    public static extern int _isupper_l(int c, uint locale);

    [DllImport(ModuleName)]
    public static extern int iswupper(ushort c);

    [DllImport(ModuleName)]
    public static extern int _iswsupper_l(ushort c, uint locale);

    [DllImport(ModuleName)]
    public static extern int _isctype(int c, uint desc);

    [DllImport(ModuleName)]
    public static extern int _isctype_l(int c, uint desc, uint locale);

    [DllImport(ModuleName)]
    public static extern int iswctype(ushort c, ushort desc);

    [DllImport(ModuleName)]
    public static extern int _iswctype_l(ushort c, ushort desc, uint locale);

    [DllImport(ModuleName)]
    public static extern int isxdigit(int c);

    [DllImport(ModuleName)]
    public static extern int iswxdigit(ushort c);

    [DllImport(ModuleName)]
    public static extern int _isxdigit_l(int c, uint locale);

    [DllImport(ModuleName)]
    public static extern int _iswxdigit_l(ushort c, uint locale);

    [DllImport(ModuleName)]
    public static extern uint _mbclen(IntPtr c);

    [DllImport(ModuleName)]
    public static extern int mblen(IntPtr mbstr, uint count);

    [DllImport(ModuleName)]
    public static extern int _mblen_l(IntPtr mbstr, uint count, uint locale);
}

#endregion // Character Classification

#region Data Alignment

partial class msvcrt
{
    [DllImport(ModuleName)]
    public static extern void _aligned_free(IntPtr memblock);

    [DllImport(ModuleName)]
    public static extern void _aligned_free_dbg(IntPtr memblock);

    [DllImport(ModuleName)]
    public static extern IntPtr _aligned_malloc(uint size, uint alignment);

    [DllImport(ModuleName, CharSet = CharSet.Ansi, ExactSpelling = true)]
    public static extern IntPtr _aligned_malloc_dbg(uint size, uint alignment, string filename, int linenumber);

    [DllImport(ModuleName)]
    public static extern uint _aligned_msize(IntPtr memblock, uint alignment, uint offset);

    [DllImport(ModuleName)]
    public static extern uint _aligned_msize_dbg(IntPtr memblock, uint alignment, uint offset);

    [DllImport(ModuleName)]
    public static extern IntPtr _aligned_offset_malloc(uint size, uint alignment, uint offset);

    [DllImport(ModuleName, CharSet = CharSet.Ansi, ExactSpelling = true)]
    public static extern IntPtr _aligned_offset_malloc_dbg(uint size, uint alignment, uint offset, string filename, int linenumber);

    [DllImport(ModuleName)]
    public static extern IntPtr _aligned_offset_realloc(IntPtr memblock, uint size, uint alignment, uint offset);

    [DllImport(ModuleName, CharSet = CharSet.Ansi, ExactSpelling = true)]
    public static extern IntPtr _aligned_offset_realloc_dbg(IntPtr memblock, uint size, uint alignment, uint offset, string filename, int linenumber);

    [DllImport(ModuleName)]
    public static extern IntPtr _aligned_offset_recalloc(IntPtr memblock, uint num, uint size, uint alignment, uint offset);

    [DllImport(ModuleName, CharSet = CharSet.Ansi, ExactSpelling = true)]
    public static extern IntPtr _aligned_offset_recalloc_dbg(IntPtr memblock, uint num, uint size, uint alignment, uint offset, string filename, int linenumber);

    [DllImport(ModuleName)]
    public static extern IntPtr _aligned_realloc(IntPtr memblock, uint size, uint alignment);

    [DllImport(ModuleName)]
    public static extern IntPtr _aligned_realloc_dbg(IntPtr memblock, uint size, uint alignment, string filename, int linenumber);

    [DllImport(ModuleName)]
    public static extern IntPtr _aligned_recalloc(IntPtr memblock, uint num, uint size, uint alignment);

    [DllImport(ModuleName, CharSet = CharSet.Ansi, ExactSpelling = true)]
    public static extern IntPtr _aligned_recalloc_dbg(IntPtr memblock, uint num, uint size, uint alignment, string filename, int linenumber);
}

#endregion // Data Alignment

#region Data Conversion

partial class msvcrt
{
    [DllImport(ModuleName)]
    public static extern int abs(int n);

    [DllImport(ModuleName)]
    public static extern long abs64(long n);

    [DllImport(ModuleName, ExactSpelling = true, CharSet = CharSet.Ansi)]
    public static extern double atof(string str);

    [DllImport(ModuleName, ExactSpelling = true, CharSet = CharSet.Unicode)]
    public static extern double _wtof(string str);

    [DllImport(ModuleName, ExactSpelling = true, CharSet = CharSet.Ansi)]
    public static extern double _atof_l(string str, uint locale);

    [DllImport(ModuleName, ExactSpelling = true, CharSet = CharSet.Unicode)]
    public static extern double _wtof_l(string str, uint locale);

    [DllImport(ModuleName, ExactSpelling = true, CharSet = CharSet.Ansi)]
    public static extern int atoi(string str);

    [DllImport(ModuleName, ExactSpelling = true, CharSet = CharSet.Unicode)]
    public static extern int _wtoi(string str);

    [DllImport(ModuleName, ExactSpelling = true, CharSet = CharSet.Ansi)]
    public static extern int _atoi_l(string str, uint locale);

    [DllImport(ModuleName, ExactSpelling = true, CharSet = CharSet.Unicode)]
    public static extern int _wtoi_l(string str, uint locale);

    [DllImport(ModuleName, ExactSpelling = true, CharSet = CharSet.Ansi)]
    public static extern long _atoi64(string str);

    [DllImport(ModuleName, ExactSpelling = true, CharSet = CharSet.Unicode)]
    public static extern long _wtoi64(string str);

    [DllImport(ModuleName, ExactSpelling = true, CharSet = CharSet.Ansi)]
    public static extern long _atoi64_l(string str, uint locale);

    [DllImport(ModuleName, ExactSpelling = true, CharSet = CharSet.Unicode)]
    public static extern long _wtoi64_l(string str, uint locale);

    [DllImport(ModuleName, ExactSpelling = true, CharSet = CharSet.Ansi)]
    public static extern int atol(string str);

    [DllImport(ModuleName, ExactSpelling = true, CharSet = CharSet.Ansi)]
    public static extern int _atol_l(string str, uint locale);

    [DllImport(ModuleName, ExactSpelling = true, CharSet = CharSet.Unicode)]
    public static extern int _wtol(string str);

    [DllImport(ModuleName, ExactSpelling = true, CharSet = CharSet.Unicode)]
    public static extern int _wtol_l(string str, uint locale);

    [DllImport(ModuleName)]
    public static extern IntPtr _ecvt(double value, int count, IntPtr dec, IntPtr sign);

    [DllImport(ModuleName)]
    public static extern IntPtr _fcvt(double value, int count, IntPtr dec, IntPtr sign);

    [DllImport(ModuleName)]
    public static extern IntPtr _gcvt(double value, int digits, IntPtr buffer);

    [DllImport(ModuleName)]
    public static extern IntPtr _itoa(int value, IntPtr str, int radix);

    [DllImport(ModuleName)]
    public static extern IntPtr _i64toa(long value, IntPtr str, int radix);

    [DllImport(ModuleName)]
    public static extern IntPtr _ui64toa(ulong value, IntPtr str, int radix);

    [DllImport(ModuleName)]
    public static extern IntPtr _itow(int value, IntPtr str, int radix);

    [DllImport(ModuleName)]
    public static extern IntPtr _i64tow(long value, IntPtr str, int radix);

    [DllImport(ModuleName)]
    public static extern IntPtr _ui64tow(ulong value, IntPtr str, int radix);

    [DllImport(ModuleName)]
    public static extern int labs(int n);

    [DllImport(ModuleName)]
    public static extern IntPtr _ltoa(int value, IntPtr str, int radix);

    [DllImport(ModuleName)]
    public static extern IntPtr _ltow(int value, IntPtr str, int radix);

    [DllImport(ModuleName)]
    public static extern uint _mbbtombc(uint c);

    [DllImport(ModuleName)]
    public static extern uint _mbbtombc_l(uint c, uint locale);

    [DllImport(ModuleName)]
    public static extern uint _mbcjistojms(uint c);

    [DllImport(ModuleName)]
    public static extern uint _mbcjistojms_l(uint c, uint locale);

    [DllImport(ModuleName)]
    public static extern uint _mbcjmstojis(uint c);

    [DllImport(ModuleName)]
    public static extern uint _mbcjmstojis_l(uint c, uint locale);

    [DllImport(ModuleName)]
    public static extern uint _mbctohira(uint c);

    [DllImport(ModuleName)]
    public static extern uint _mbctohira_l(uint c, uint locale);

    [DllImport(ModuleName)]
    public static extern uint _mbctokata(uint c);

    [DllImport(ModuleName)]
    public static extern uint _mbctokata_l(uint c, uint locale);

    [DllImport(ModuleName)]
    public static extern uint _mbctombb(uint c);

    [DllImport(ModuleName)]
    public static extern uint _mbctombb_l(uint c, uint locale);

    [DllImport(ModuleName)]
    public static extern uint mbstowcs(IntPtr wcstr, IntPtr mbstr, uint count);

    [DllImport(ModuleName)]
    public static extern uint _mbstowcs_l(IntPtr wcstr, IntPtr mbstr, uint count, uint locale);

    [DllImport(ModuleName)]
    public static extern int mbtowc(IntPtr wchar, IntPtr mbchar, uint count);

    [DllImport(ModuleName)]
    public static extern int _mbtowc_l(IntPtr wchar, IntPtr mbchar, uint count, uint locale);

    [DllImport(ModuleName)]
    public static extern double strtod(IntPtr nptr, IntPtr endptr);

    [DllImport(ModuleName)]
    public static extern double _strtod_l(IntPtr nptr, IntPtr endptr, uint locale);

    [DllImport(ModuleName)]
    public static extern double wcstod(IntPtr nptr, IntPtr endptr);

    [DllImport(ModuleName)]
    public static extern double wcstod_l(IntPtr nptr, IntPtr endptr, uint locale);

    [DllImport(ModuleName)]
    public static extern int strtol(IntPtr nptr, IntPtr endptr, int @base);

    [DllImport(ModuleName)]
    public static extern int wcstol(IntPtr nptr, IntPtr endptr, int @base);

    [DllImport(ModuleName)]
    public static extern int _strtol_l(IntPtr nptr, IntPtr endptr, int @base, uint locale);

    [DllImport(ModuleName)]
    public static extern int _wcstol_l(IntPtr nptr, IntPtr endptr, int @base, uint locale);

    [DllImport(ModuleName)]
    public static extern uint strtoul(IntPtr nptr, IntPtr endptr, int @base);

    [DllImport(ModuleName)]
    public static extern uint _strtoul_l(IntPtr nptr, IntPtr endptr, int @base, uint locale);

    [DllImport(ModuleName)]
    public static extern uint wcstoul(IntPtr nptr, IntPtr endptr, int @base);

    [DllImport(ModuleName)]
    public static extern uint _wcstoul_l(IntPtr nptr, IntPtr endptr, int @base, uint locale);

    [DllImport(ModuleName)]
    public static extern uint strxfrm(IntPtr strDest, IntPtr strSource, uint count);

    [DllImport(ModuleName)]
    public static extern uint wcsxfrm(IntPtr strDest, IntPtr strSource, uint count);

    [DllImport(ModuleName)]
    public static extern uint _strxfrm_l(IntPtr strDest, IntPtr strSource, uint count, uint locale);

    [DllImport(ModuleName)]
    public static extern uint _wcsxfrm_l(IntPtr strDest, IntPtr strSource, uint count, uint locale);

    [DllImport(ModuleName)]
    public static extern int __toascii(int c);

    [DllImport(ModuleName)]
    public static extern int tolower(int c);

    [DllImport(ModuleName)]
    public static extern int _tolower(int c);

    [DllImport(ModuleName)]
    public static extern int towloer(ushort c);

    [DllImport(ModuleName)]
    public static extern int _tolower_l(int c, uint locale);

    [DllImport(ModuleName)]
    public static extern int _towlower_l(ushort c, uint locale);

    [DllImport(ModuleName)]
    public static extern uint _mbctolower(uint c);

    [DllImport(ModuleName)]
    public static extern uint _mbctolower_l(uint c, uint locale);

    [DllImport(ModuleName)]
    public static extern uint _mbctoupper(uint c);

    [DllImport(ModuleName)]
    public static extern uint _mbctoupper_l(uint c, uint locale);

    [DllImport(ModuleName)]
    public static extern int toupper(int c);

    [DllImport(ModuleName)]
    public static extern int _toupper(int c);

    [DllImport(ModuleName)]
    public static extern int towupper(ushort c);
    
    [DllImport(ModuleName)]
    public static extern int _toupper_l(int c, uint locale);

    [DllImport(ModuleName)]
    public static extern int _towupper_l(ushort c, uint locale);

    [DllImport(ModuleName)]
    public static extern IntPtr _ultoa(uint value, IntPtr str, int radix);

    [DllImport(ModuleName)]
    public static extern IntPtr _ultow(uint value, IntPtr str, int radix);

    [DllImport(ModuleName)]
    public static extern uint wcstombs(IntPtr mbstr, IntPtr wcstr, uint count);

    [DllImport(ModuleName)]
    public static extern uint _wcstombs_l(IntPtr mbstr, IntPtr wcstr, uint count, uint locale);

    [DllImport(ModuleName)]
    public static extern uint wctomb(IntPtr mbstr, IntPtr wcstr);

    [DllImport(ModuleName)]
    public static extern uint _wctomb_l(IntPtr mbstr, IntPtr wcstr, uint locale);
}

#endregion // Data Conversion

#region POSIX CRT Functions - TODO

partial class msvcrt
{
}

#endregion // POSIX CRT Functions

#region Directory Control Functions

partial class msvcrt
{
    [DllImport(ModuleName, ExactSpelling = true, CharSet = CharSet.Ansi)]
    public static extern int _chdir(string dirname);

    [DllImport(ModuleName, ExactSpelling = true, CharSet = CharSet.Ansi)]
    public static extern int _wchdir(string dirname);

    [DllImport(ModuleName, ExactSpelling = true, CharSet = CharSet.Ansi)]
    public static extern int _chdrive(int drive);

    [DllImport(ModuleName)]
    public static extern IntPtr _getcwd(IntPtr buffer, int maxlen);

    [DllImport(ModuleName)]
    public static extern IntPtr _wgetcwd(IntPtr buffer, int maxlen);

    [DllImport(ModuleName)]
    public static extern IntPtr _getdcwd(int drive, IntPtr buffer, int maxlen);

    [DllImport(ModuleName)]
    public static extern IntPtr _wgetdcwd(int drive, IntPtr buffer, int maxlen);

    [DllImport(ModuleName)]
    public static extern uint _getdiskfree(uint drive, IntPtr driveinfo);

    [DllImport(ModuleName)]
    public static extern int _getdrive();

    [DllImport(ModuleName)]
    public static extern uint _getdrives();

    [DllImport(ModuleName, ExactSpelling = true, CharSet = CharSet.Ansi)]
    public static extern int _mkdir(string dirname);

    [DllImport(ModuleName, ExactSpelling = true, CharSet = CharSet.Unicode)]
    public static extern int _wmkdir(string dirname);

    [DllImport(ModuleName, ExactSpelling = true, CharSet = CharSet.Ansi)]
    public static extern int _rmdir(string dirname);

    [DllImport(ModuleName, ExactSpelling = true, CharSet = CharSet.Ansi)]
    public static extern int _wrmdir(string dirname);

    [DllImport(ModuleName, ExactSpelling = true, CharSet = CharSet.Ansi)]
    public static extern void _searchenv(IntPtr filename, IntPtr varname, IntPtr pathname);

    [DllImport(ModuleName, ExactSpelling = true, CharSet = CharSet.Unicode)]
    public static extern void _wsearchenv(IntPtr filename, IntPtr varname, IntPtr pathname);
}

#endregion // Directory Control Functions

#region Error Handling

partial class msvcrt
{
    [DllImport(ModuleName)]
    public static extern void clearerr(IntPtr stream);

    [DllImport(ModuleName)]
    public static extern int _eof(int fd);

    [DllImport(ModuleName)]
    public static extern int feof(IntPtr stream);

    [DllImport(ModuleName)]
    public static extern int ferror(IntPtr stream);

    [DllImport(ModuleName)]
    public static extern int _set_error_mode(int modeval);
}

#endregion // Error Handling

#region Exception Handling

partial class msvcrt
{
    [DllImport(ModuleName)]
    public static extern _se_translator_function _set_se_translator(_se_translator_function seTransFunction);

    [DllImport(ModuleName)]
    public static extern terminate_function set_terminate(terminate_function termFunction);
    
    [DllImport(ModuleName)]
    public static extern unexpected_function set_unexpected(unexpected_function unexpFunction);

    [DllImport(ModuleName)]
    public static extern void terminate();

    [DllImport(ModuleName)]
    public static extern void unexpected();
}

#endregion // Exception Handling

#region File Handling - Test Required

partial class msvcrt
{
    [DllImport(ModuleName)]
    public static extern int _chsize(int fd, int size);

    [DllImport(ModuleName)]
    public static extern int _filelength(int fd);

    [DllImport(ModuleName)]
    public static extern long _filelengthi64(int fd);

    [DllImport(ModuleName)]
    public static extern int _fstat(int fd, IntPtr buffer);

    [DllImport(ModuleName)]
    public static extern int _fstat32(int fd, IntPtr buffer);

    [DllImport(ModuleName)]
    public static extern int _fstat64(int fd, IntPtr buffer);

    [DllImport(ModuleName)]
    public static extern int _fstati64(int fd, IntPtr buffer);

    [DllImport(ModuleName)]
    public static extern int _fstat32i64(int fd, IntPtr buffer);

    [DllImport(ModuleName)]
    public static extern int _fstat64i32(int fd, IntPtr buffer);

    [DllImport(ModuleName)]
    public static extern int _get_osfhandle(int fd);

    [DllImport(ModuleName)]
    public static extern int _isatty(int fd);

    [DllImport(ModuleName)]
    public static extern int _locking(int fd, int mode, int nbytes);

    [DllImport(ModuleName)]
    public static extern int _open_osfhandle(int osfhandle, int flags);

    [DllImport(ModuleName)]
    public static extern int _setmode(int fd, int mode);

    [DllImport(ModuleName, ExactSpelling = true, CharSet = CharSet.Ansi)]
    public static extern int _access(string path, int mode);

    [DllImport(ModuleName, ExactSpelling = true, CharSet = CharSet.Unicode)]
    public static extern int _waccess(string path, int mode);

    [DllImport(ModuleName, ExactSpelling = true, CharSet = CharSet.Ansi)]
    public static extern int _chmod(string filename, int pmode);

    [DllImport(ModuleName, ExactSpelling = true, CharSet = CharSet.Unicode)]
    public static extern int _wchmod(string filename, int pmode);

    [DllImport(ModuleName, ExactSpelling = true, CharSet = CharSet.Ansi)]
    public static extern IntPtr _fullpath(IntPtr absPath, IntPtr relPath, uint maxLength);

    [DllImport(ModuleName, ExactSpelling = true, CharSet = CharSet.Unicode)]
    public static extern IntPtr _wfullpath(IntPtr absPath, IntPtr relPath, uint maxLength);

    [DllImport(ModuleName, ExactSpelling = true, CharSet = CharSet.Ansi)]
    public static extern void _makepath(IntPtr path, IntPtr drive, IntPtr dir, IntPtr fname, IntPtr ext);

    [DllImport(ModuleName, ExactSpelling = true, CharSet = CharSet.Unicode)]
    public static extern void _wmakepath(IntPtr path, IntPtr drive, IntPtr dir, IntPtr fname, IntPtr ext);

    [DllImport(ModuleName, ExactSpelling = true, CharSet = CharSet.Ansi)]
    public static extern IntPtr _mktemp(IntPtr template);

    [DllImport(ModuleName, ExactSpelling = true, CharSet = CharSet.Unicode)]
    public static extern IntPtr _wmktemp(IntPtr template);

    [DllImport(ModuleName, ExactSpelling = true, CharSet = CharSet.Ansi)]
    public static extern int remove(string path);

    [DllImport(ModuleName, ExactSpelling = true, CharSet = CharSet.Unicode)]
    public static extern int _wremove(string path);

    [DllImport(ModuleName, ExactSpelling = true, CharSet = CharSet.Ansi)]
    public static extern int rename(string oldname, string newname);

    [DllImport(ModuleName, ExactSpelling = true, CharSet = CharSet.Unicode)]
    public static extern int _wrename(string oldname, string newname);

    [Todo]
    [DllImport(ModuleName, ExactSpelling = true, CharSet = CharSet.Ansi)]
    public static extern void _splitpath(string path, ref string drive, ref string dir,
        ref string fname, ref string ext);

    [Todo]
    [DllImport(ModuleName, ExactSpelling = true, CharSet = CharSet.Unicode)]
    public static extern void _wsplitpath(string path, ref string drive, ref string dir,
        ref string fname, ref string ext);

    [DllImport(ModuleName, ExactSpelling = true, CharSet = CharSet.Ansi)]
    public static extern int _stat(string path, IntPtr buffer);

    [DllImport(ModuleName, ExactSpelling = true, CharSet = CharSet.Ansi)]
    public static extern int _stat32(string path, IntPtr buffer);

    [DllImport(ModuleName, ExactSpelling = true, CharSet = CharSet.Ansi)]
    public static extern int _stat64(string path, IntPtr buffer);

    [DllImport(ModuleName, ExactSpelling = true, CharSet = CharSet.Ansi)]
    public static extern int _stati64(string path, IntPtr buffer);

    [DllImport(ModuleName, ExactSpelling = true, CharSet = CharSet.Ansi)]
    public static extern int _stat32i64(string path, IntPtr buffer);

    [DllImport(ModuleName, ExactSpelling = true, CharSet = CharSet.Ansi)]
    public static extern int _stat64i32(string path, IntPtr buffer);

    [DllImport(ModuleName, ExactSpelling = true, CharSet = CharSet.Unicode)]
    public static extern int _wstat(string path, IntPtr buffer);

    [DllImport(ModuleName, ExactSpelling = true, CharSet = CharSet.Unicode)]
    public static extern int _wstat32(string path, IntPtr buffer);

    [DllImport(ModuleName, ExactSpelling = true, CharSet = CharSet.Unicode)]
    public static extern int _wstat64(string path, IntPtr buffer);

    [DllImport(ModuleName, ExactSpelling = true, CharSet = CharSet.Unicode)]
    public static extern int _wstati64(string path, IntPtr buffer);

    [DllImport(ModuleName, ExactSpelling = true, CharSet = CharSet.Unicode)]
    public static extern int _wstat32i64(string path, IntPtr buffer);

    [DllImport(ModuleName, ExactSpelling = true, CharSet = CharSet.Unicode)]
    public static extern int _wstat64i32(string path, IntPtr buffer);

    [DllImport(ModuleName)]
    public static extern int _umask(int pmode);

    [DllImport(ModuleName, ExactSpelling = true, CharSet = CharSet.Ansi)]
    public static extern int _unlink(string filename);

    [DllImport(ModuleName, ExactSpelling = true, CharSet = CharSet.Unicode)]
    public static extern int _wunlink(string filename);

    [DllImport(ModuleName, ExactSpelling = true, CharSet = CharSet.Ansi)]
    public static extern IntPtr fopen(string filename, string mode);

    [DllImport(ModuleName, ExactSpelling = true, CharSet = CharSet.Unicode)]
    public static extern IntPtr _wfopen(string filename, string mode);

    [DllImport(ModuleName, ExactSpelling = true, CharSet = CharSet.Ansi)]
    public static extern IntPtr _fsopen(string filename, string mode, int shflag);

    [DllImport(ModuleName, ExactSpelling = true, CharSet = CharSet.Unicode)]
    public static extern IntPtr _wfsopen(string filename, string mode, int shflag);

    [DllImport(ModuleName, ExactSpelling = true, CharSet = CharSet.Ansi)]
    public static extern int _open(string filename, int oflag);

    [DllImport(ModuleName, ExactSpelling = true, CharSet = CharSet.Ansi)]
    public static extern int _open(string filename, int oflag, int pmode);

    [DllImport(ModuleName, ExactSpelling = true, CharSet = CharSet.Unicode)]
    public static extern int _wopen(string filename, int oflag);

    [DllImport(ModuleName, ExactSpelling = true, CharSet = CharSet.Unicode)]
    public static extern int _wopen(string filename, int oflag, int pmode);

    [DllImport(ModuleName, ExactSpelling = true, CharSet = CharSet.Ansi)]
    public static extern int _sopen(string filename, int oflag, int shflag);

    [DllImport(ModuleName, ExactSpelling = true, CharSet = CharSet.Ansi)]
    public static extern int _sopen(string filename, int oflag, int shflag, int pmode);

    [DllImport(ModuleName, ExactSpelling = true, CharSet = CharSet.Unicode)]
    public static extern int _wsopen(string filename, int oflag, int shflag);

    [DllImport(ModuleName, ExactSpelling = true, CharSet = CharSet.Unicode)]
    public static extern int _wsopen(string filename, int oflag, int shflag, int pmode);

    [DllImport(ModuleName)]
    public static extern int _pipe(IntPtr pfds, uint psize, int textmode);

    [DllImport(ModuleName, ExactSpelling = true, CharSet = CharSet.Ansi)]
    public static extern IntPtr freopen(string path, string mode, IntPtr stream);

    [DllImport(ModuleName, ExactSpelling = true, CharSet = CharSet.Unicode)]
    public static extern IntPtr _wfreopen(string path, string mode, IntPtr stream);

    [DllImport(ModuleName, ExactSpelling = true, CharSet = CharSet.Ansi)]
    public static extern IntPtr _fdopen(int fd, string mode);

    [DllImport(ModuleName, ExactSpelling = true, CharSet = CharSet.Unicode)]
    public static extern IntPtr _wfdopen(int fd, string mode);

    [DllImport(ModuleName)]
    public static extern int _fileno(IntPtr stream);
}

#endregion // File Handling

#region Floating-Point Support

partial class msvcrt
{
}

#endregion // Floating-Point Support
