using System;
using System.Runtime.InteropServices;

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
