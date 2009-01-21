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

    // http://msdn.microsoft.com/en-us/library/9h6ew5ts.aspx - _ismbbkprint
}
