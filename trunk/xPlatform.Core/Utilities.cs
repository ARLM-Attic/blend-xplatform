using System;
using System.Text;
using System.Runtime.InteropServices;

namespace xPlatform
{
    public static class Utilities
    {
        public static string CreateWhitespaceString(int length)
        {
            if (length < 1)
                return String.Empty;

            StringBuilder buffer = new StringBuilder(length);

            for (int i = 0; i < length; i++)
                buffer.Append(' ');

            return buffer.ToString();
        }

        public static unsafe int NativeSizeOf(Type targetType)
        {
            if (targetType == null)
                throw new ArgumentNullException("targetType");

            string targetTypeName = targetType.FullName;

            switch (targetTypeName)
            {
                case "System.Char":
                    return sizeof(char);
                case "System.Boolean":
                    return sizeof(bool);
                case "System.Byte":
                    return sizeof(byte);
                case "System.DateTime":
                    return sizeof(DateTime);
                case "System.Decimal":
                    return sizeof(decimal);
                case "System.Double":
                    return sizeof(double);
                case "System.Guid":
                    return sizeof(Guid);
                case "System.Int16":
                    return sizeof(short);
                case "System.Int32":
                    return sizeof(int);
                case "System.Int64":
                    return sizeof(long);
                case "System.IntPtr":
                    return sizeof(IntPtr);
                case "System.SByte":
                    return sizeof(sbyte);
                case "System.Single":
                    return sizeof(float);
                case "System.TimeSpan":
                    return sizeof(TimeSpan);
                case "System.UInt16":
                    return sizeof(ushort);
                case "System.UInt32":
                    return sizeof(uint);
                case "System.UInt64":
                    return sizeof(ulong);
                case "System.UIntPtr":
                    return sizeof(UIntPtr);
                default:
                    return Marshal.SizeOf(targetType);
            }
        }
    }
}
