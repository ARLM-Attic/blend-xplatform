using System;
using System.Data;
using System.Reflection;

namespace xPlatform
{
    public interface IModuleBase
    {
        Type BaseType { get; }
        Type CurrentType { get; }
        DataTable MethodList { get; }
        DataTable ArgumentList { get; }

        MethodInfo[] GatherMethodInfoList();
        DataTable GatherMethodList(MethodInfo[] methods);
        DataTable GatherArgumentList(MethodInfo[] methods);
    }
}
