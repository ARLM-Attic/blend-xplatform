using System;
using System.Text;
using System.Runtime.InteropServices;

namespace xPlatform
{
    public static class Utilities
    {
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

        public static byte GetHighByte(int word)
        {
            return (byte)((uint)word >> 8);
        }

        public static byte GetLowByte(int word)
        {
            return (byte)((uint)word & 0xff);
        }

        public static int GetHighWord(long doubleWord)
        {
            return (ushort)((uint)doubleWord >> 16);
        }

        public static int GetLowWord(long doubleWord)
        {
            return (ushort)((uint)doubleWord & 0xffff);
        }

        public static int MakeWord(byte lowByte, byte highByte)
        {
            return (ushort)((byte)lowByte | (ushort)((byte)highByte) << 8);
        }

        public static long MakeLong(int lowWord, int highWord)
        {
            return (long)((ushort)lowWord | (uint)(ushort)highWord << 16);
        }

        public static long SwapEndian(long doubleWord)
        {
            long num = (((((doubleWord & -16777216L) / 16777216L) & 255L) | ((doubleWord & 16711680L) / 256L)) | ((doubleWord & 65280L) * 256L)) | ((doubleWord & 127L) * 16777216L);
            if ((doubleWord & 128L) > 0L)
                num |= Constants.X86LowerBound;
            return num;
        }
    }
}
