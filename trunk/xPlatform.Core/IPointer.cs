using System;
using System.Runtime.Serialization;

namespace xPlatform
{
    public interface IPointer : ISerializable
    {
        int ToInt32();
        long ToInt64();
    }

    public interface IPointer<T> : IPointer
        where T : struct
    {
        T this[int index] { get; set; }

        T GetData();
        T GetData(int index);

        void SetData(T value);
        void SetData(T value, int index);
    }
}
