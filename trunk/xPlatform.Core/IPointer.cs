using System;
using System.Runtime.Serialization;

namespace xPlatform
{
    public interface IPointer : ISerializable
    {
        int ToInt32();
        long ToInt64();
        IntPtr ToIntPtr();
    }
}
