using System;
using System.Runtime.Serialization;

namespace xPlatform.NonStandard
{
    [CLSCompliant(false)]
    public interface IUnsignedPointer : ISerializable, IPointer
    {
        [CLSCompliant(false)]
        uint ToUInt32();

        [CLSCompliant(false)]
        ulong ToUInt64();

        [CLSCompliant(false)]
        UIntPtr ToUIntPtr();
    }
}
