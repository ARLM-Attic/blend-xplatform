using System;
using System.Runtime.Serialization;

namespace xPlatform
{
    public interface ITypedPointer<T> : ISerializable, IPointer
        where T : struct
    {
        T this[int index] { get; set; }

        T GetData();
        T GetData(int index);

        void SetData(T value);
        void SetData(T value, int index);
    }
}
