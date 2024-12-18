using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OTools
{
    public class ConversionsLittleEndian : ConversionsBase
    {

        public override Int32 Int32FromBytes(byte[] buffer, int startIndex)
        {
            return BitConverter.ToInt32(buffer, startIndex);
        }
        public override UInt32 UInt32FromBytes(byte[] buffer, int startIndex)
        {
            return BitConverter.ToUInt32(buffer, startIndex);
        }
        public override byte[] UInt32ToBytes(uint value)
        {
            return BitConverter.GetBytes(value);
        }
        public override byte[] Int32ToBytes(int value)
        {
            return BitConverter.GetBytes(value);
        }
        public override ushort UshortFromBytes(byte[] buffer, int startIndex)
        {
            return BitConverter.ToUInt16(buffer, startIndex);
        }
        public override short ShortFromBytes(byte[] buffer, int startIndex)
        {
            return BitConverter.ToInt16(buffer, startIndex);
        }
        public override byte[] UShortToBytes(ushort value)
        {
            return BitConverter.GetBytes(value);
        }
        public override byte[] Short2Bytes(short value)
        {
            return BitConverter.GetBytes(value);
        }
        public override UInt64 ULongFromBytes(byte[] arr, int startIndex)
        {
            return BitConverter.ToUInt64(arr, startIndex);
        }
        public override Int64 LongFromBytes(byte[] arr, int startIndex)
        {
            return BitConverter.ToInt64(arr, startIndex);
        }
        public override byte[] ULong2Bytes(ulong value)
        {
            return BitConverter.GetBytes(value);
        }
        public override byte[] Long2Bytes(long value)
        {
            return BitConverter.GetBytes(value);
        }
        public override double DoubleFromBytes(byte[] arr, int startIndex)
        {
            return BitConverter.ToDouble(arr, startIndex);
        }
        public override byte[] Double2Bytes(double value)
        {
            return BitConverter.GetBytes(value);
        }
        public override float FloatFromBytes(byte[] arr, int startIndex)
        {
            return BitConverter.ToSingle(arr, startIndex);
        }
        public override byte[] FloatToBytes(float value)
        {
            return BitConverter.GetBytes(value);
        }
        public override char CharFromBytes(byte[] arr, int startIndex)
        {
            return BitConverter.ToChar(arr, startIndex);
        }
        public override ushort[] UshortsFromInt32(int value)
        {
            ushort[] retVal = new ushort[2];
            int utemp1, utemp2;

            utemp1 = (int)(value & 0xFFFF0000);//msb
            utemp1 = utemp1 >> 16;

            utemp2 = (int)(value & 0x0000FFFF);//lsb

            retVal[0] = (ushort)utemp2;
            retVal[1] = (ushort)utemp1;

            return retVal;
        }
        public override ushort[] UshortsFromUInt32(uint value)
        {
            ushort[] retVal = new ushort[2];
            uint utemp1, utemp2;

            utemp1 = (uint)(value & 0xFFFF0000);//msb
            utemp1 = utemp1 >> 16;

            utemp2 = (uint)(value & 0x0000FFFF);//lsb

            retVal[0] = (ushort)utemp2;
            retVal[1] = (ushort)utemp1;

            return retVal;
        }

        public override int UshortsToInt32(ushort[] buffer, int index)
        {
            int retVal;

            retVal = (int)(buffer[index] << 16) | buffer[index + 1];
            return retVal;
        }
    }
}
