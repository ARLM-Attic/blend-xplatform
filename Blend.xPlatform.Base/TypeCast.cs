using System;

namespace Blend.xPlatform.Base
{
    [Serializable]
    public sealed class TypeCast
    {
        private TypeCast(Enum value)
            : base()
        {
            this.value = value;
        }

        private Enum value;

        public static implicit operator TypeCast(Enum value)
        {
            return new TypeCast(value);
        }

        public static implicit operator Enum(TypeCast op)
        {
            return op.value;
        }

        public static implicit operator byte(TypeCast op)
        {
            return (byte)Convert.ChangeType(op.value, typeof(byte));
        }

        public static implicit operator sbyte(TypeCast op)
        {
            return (sbyte)Convert.ChangeType(op.value, typeof(sbyte));
        }

        public static implicit operator short(TypeCast op)
        {
            return (short)Convert.ChangeType(op.value, typeof(short));
        }

        public static implicit operator ushort(TypeCast op)
        {
            return (ushort)Convert.ChangeType(op.value, typeof(ushort));
        }

        public static implicit operator int(TypeCast op)
        {
            return (int)Convert.ChangeType(op.value, typeof(int));
        }

        public static implicit operator uint(TypeCast op)
        {
            return (uint)Convert.ChangeType(op.value, typeof(uint));
        }

        public static implicit operator long(TypeCast op)
        {
            return (long)Convert.ChangeType(op.value, typeof(long));
        }

        public static implicit operator ulong(TypeCast op)
        {
            return (ulong)Convert.ChangeType(op.value, typeof(ulong));
        }
    }
}
