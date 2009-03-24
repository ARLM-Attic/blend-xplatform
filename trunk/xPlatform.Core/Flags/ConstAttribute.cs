using System;

namespace xPlatform.Flags
{
    [Serializable]
    [AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
    public class ConstAttribute : Attribute { }
}
