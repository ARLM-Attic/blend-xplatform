using System;

namespace xPlatform
{
    [Serializable]
    public abstract class ModuleBase : IModuleBase
    {
        public virtual Type BaseType
        {
            get { return null; }
        }

        public virtual Type CurrentType
        {
            get { return this.GetType(); }
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
