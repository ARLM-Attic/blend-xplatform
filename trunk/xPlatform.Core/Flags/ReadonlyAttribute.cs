using System;

namespace xPlatform.Flags
{
    [Serializable]
    [AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
    public class ReadonlyAttribute : Attribute { }
}
