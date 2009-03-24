using System;

namespace xPlatform
{
    [Serializable]
    public abstract class ModuleBase<T>
        where T : ModuleBase<T>
    {
        [NonSerialized]
        public static readonly Type BaseType = typeof(ModuleBase<T>);

        [NonSerialized]
        public static readonly Type CurrentType = typeof(T);
    }
}
