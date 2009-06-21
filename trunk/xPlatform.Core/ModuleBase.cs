using System;
using System.Data;
using System.Reflection;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace xPlatform
{
    [Serializable]
    public abstract class ModuleBase : IModuleBase
    {
        public ModuleBase()
        {
            this.methodInfoList = this.GatherMethodInfoList();
            this.methodList = this.GatherMethodList(this.methodInfoList);
            this.argumentList = this.GatherArgumentList(this.methodInfoList);
        }

        private MethodInfo[] methodInfoList = null;
        private DataTable methodList = null;
        private DataTable argumentList = null;

        public virtual Type BaseType
        {
            get { return null; }
        }

        public virtual Type CurrentType
        {
            get { return this.GetType(); }
        }

        public DataTable MethodList
        {
            get { return this.methodList; }
        }

        public DataTable ArgumentList
        {
            get { return this.argumentList; }
        }

        protected virtual MethodInfo[] GatherMethodInfoList()
        {
            List<MethodInfo> list = new List<MethodInfo>();

            foreach (MethodInfo eachInfo in this.CurrentType.GetMethods(
                BindingFlags.Public | BindingFlags.Static))
            {
                if (eachInfo.GetCustomAttributes(typeof(DllImportAttribute), false)
                    .Length < 1)
                    continue;

                list.Add(eachInfo);
            }

            return list.ToArray();
        }

        protected virtual DataTable GatherMethodList(MethodInfo[] methods)
        {
            DataTable table = new DataTable(String.Concat(this.CurrentType.Name, "_methods"));

            // Table Setup
            table.Columns.AddRange(new DataColumn[] {
                new DataColumn("MethodIdentity", typeof(int)),
                new DataColumn("MethodIndex", typeof(int)),
                new DataColumn("MethodSignature", typeof(string)),
                new DataColumn("MethodName", typeof(string)),
                new DataColumn("MethodReturnType", typeof(string)),
                new DataColumn("MethodArgsCount", typeof(int)),
                new DataColumn("MethodCallingConvention", typeof(string)),
                new DataColumn("MethodIsCLSCompliant", typeof(bool)),
                new DataColumn("MethodInfo", typeof(MethodInfo)),
            });
            table.PrimaryKey = new DataColumn[] { table.Columns[0], table.Columns[1] };

            int i = 0;

            foreach (MethodInfo eachMethod in methods)
            {
                table.Rows.Add(new object[] {
                    eachMethod.ToString().GetHashCode(),
                    ++i,
                    eachMethod.ToString(),
                    eachMethod.Name,
                    eachMethod.ReturnType.ToString(),
                    eachMethod.GetParameters().Length,
                    eachMethod.CallingConvention.ToString(),
                    new Predicate<MethodInfo>(delegate(MethodInfo method)
                    {
                        object[] result = method.GetCustomAttributes(typeof(CLSCompliantAttribute), false);

                        if (result == null || result.Length < 1)
                            return false;

                        CLSCompliantAttribute attribute = result[0] as CLSCompliantAttribute;

                        if (attribute == null)
                            return false;

                        return attribute.IsCompliant;
                    })(eachMethod),
                    eachMethod,
                });
            }

            return table;
        }

        protected virtual DataTable GatherArgumentList(MethodInfo[] methods)
        {
            DataTable table = new DataTable(String.Concat(this.CurrentType.Name, "_arguments"));

            // Table setup
            table.Columns.AddRange(new DataColumn[] {
                new DataColumn("ArgumentIndex", typeof(int)),
                new DataColumn("PositionIndex", typeof(int)),
                new DataColumn("MethodIdentity", typeof(int)),
                new DataColumn("ArgumentType", typeof(string)),
                new DataColumn("ArgumentName", typeof(string)),
                new DataColumn("IsInputArgument", typeof(bool)),
                new DataColumn("IsOutputArgument", typeof(bool)),
                new DataColumn("IsReturnValue", typeof(bool)),
                new DataColumn("IsLocaleID", typeof(bool)),
                new DataColumn("IsOptionalArgument", typeof(bool)),
                new DataColumn("ParameterInfo", typeof(ParameterInfo)),
            });
            table.PrimaryKey = new DataColumn[] { table.Columns[0], table.Columns[1] };

            int i = 0;

            foreach (MethodInfo eachMethod in methods)
            {
                foreach (ParameterInfo eachParameter in eachMethod.GetParameters())
                {
                    table.Rows.Add(new object[] {
                        ++i,
                        eachParameter.Position,
                        eachMethod.ToString().GetHashCode(),
                        eachParameter.ParameterType.ToString(),
                        eachParameter.Name,
                        eachParameter.IsIn,
                        eachParameter.IsOut,
                        eachParameter.IsRetval,
                        eachParameter.IsLcid,
                        eachParameter.IsOptional,
                    });
                }
            }

            return table;
        }
    }

    [Serializable]
    public abstract class ModuleBase<T> : ModuleBase
        where T : ModuleBase
    {
        [NonSerialized]
        public static readonly Type ModuleBaseType = typeof(ModuleBase<T>);

        [NonSerialized]
        public static readonly Type ModuleCurrentType = typeof(T);

        public override Type BaseType
        {
            get { return ModuleBaseType; }
        }

        public override Type CurrentType
        {
            get { return ModuleCurrentType; }
        }
    }
}
