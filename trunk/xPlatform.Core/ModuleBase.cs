using System;
using System.Data;
using System.Reflection;
using System.Runtime.InteropServices;

namespace xPlatform
{
    [Serializable]
    public abstract class ModuleBase : IModuleBase
    {
        public ModuleBase()
        {
            this.methodList = this.GatherMethodList();
        }

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

        protected virtual DataTable GatherMethodList()
        {
            DataTable table = new DataTable(this.CurrentType.FullName);
            MethodInfo[] methods = this.CurrentType.GetMethods(BindingFlags.Public | BindingFlags.Static);

            // Table Setup
            table.Columns.AddRange(new DataColumn[] {
                new DataColumn("MethodIdentity", typeof(int)),
                new DataColumn("MethodSignature", typeof(string)),
                new DataColumn("MethodName", typeof(string)),
                new DataColumn("MethodReturnType", typeof(string)),
                new DataColumn("MethodArgsCount", typeof(int)),
                new DataColumn("MethodCallingConvention", typeof(string)),
                new DataColumn("MethodIsCLSCompliant", typeof(bool)),
            });
            table.PrimaryKey = new DataColumn[] { table.Columns[0] };

            foreach (MethodInfo eachMethod in methods)
            {
                if (eachMethod.GetCustomAttributes(
                    typeof(DllImportAttribute),
                    false).Length < 1)
                    continue;

                table.Rows.Add(new object[] {
                    eachMethod.ToString().GetHashCode(),
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
                });
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
