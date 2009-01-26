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
    public static extern int _ismbslead(string str, string current);

    [TestRequired]
    [DllImport(ModuleName, ExactSpelling = true, CharSet = CharSet.Ansi)]
    public static extern int _ismbstrail(string str, string current);

    [TestRequired]
    [DllImport(ModuleName, ExactSpelling = true, CharSet = CharSet.Ansi)]
    public static extern int _ismbslead_l(string str, string current, uint locale);

    [TestRequired]
    [DllImport(ModuleName, ExactSpelling = true, CharSet = CharSet.Ansi)]
    public static extern int _ismbstrail_l(string str, string current, uint locale);

    [DllImport(ModuleName)]
    public static extern int _mbbtype(uint c, int type);

    [TestRequired]
    [DllImport(ModuleName)]
    public static extern int _mbbtype_l(uint c, int type, uint locale);

    [TestRequired]
    [DllImport(ModuleName, ExactSpelling = true, CharSet = CharSet.Ansi)]
    public static extern int _mbsbtype(string mbstr, uint count);

    [TestRequired]
    [DllImport(ModuleName, ExactSpelling = true, CharSet = CharSet.Ansi)]
    public static extern int _mbsbtype_l(string mbstr, uint count, uint locale);

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

    [DllImport(ModuleNameDebug)]
    public static extern void _aligned_free_dbg(IntPtr memblock);

    [DllImport(ModuleName)]
    public static extern IntPtr _aligned_malloc(uint size, uint alignment);

    [DllImport(ModuleNameDebug, CharSet = CharSet.Ansi, ExactSpelling = true)]
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
}

#endregion // Data Conversion