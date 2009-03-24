using System;

namespace xPlatform.Flags
{
    [Serializable]
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    public class TodoAttribute : Attribute { }
}
