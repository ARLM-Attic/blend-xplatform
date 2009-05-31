using System;
using System.Runtime.Serialization;

namespace xPlatform.NonStandard
{
    [CLSCompliant(false)]
    public interface IUnsafePointer : ISerializable, IPointer
    {
        unsafe void* ToPointer();
    }
}
