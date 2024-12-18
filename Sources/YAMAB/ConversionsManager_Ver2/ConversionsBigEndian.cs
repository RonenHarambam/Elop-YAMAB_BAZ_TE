using System;
using System.Collections.Generic;
using System.Text;

namespace OTools
{

    /// <summary>
    /// Big endian - Should inherit from ConversionsBase and override all its functions
    /// </summary>
    class ConversionsBigEndian : ConversionsBase
    {
        //public string FormatBuffer2HexString(ushort[] buffer)
        //{
        //    string retVal = null;

        //    for (int i = 0; i < buffer.Length; i++)
        //    {
        //        retVal += buffer[i].ToString("X4") + " ";
        //    }
        //    return retVal;
        //}
        public string Buffer2String(byte[] buffer)
        {
            string retVal = null;

            for (int i = 0; i < buffer.Length; i++)
            {
                if (i > 0)
                {
                    if ((i % 64) == 0)
                    {
                        retVal = retVal + Environment.NewLine;
                    }
                }
                retVal = retVal + buffer[i].ToString("X2") + " ";
            }
            return retVal;
        }



        public override byte[] UShortToBytes(ushort value)
        {
            byte[] retVal = new byte[2];
            int lsb;
            int msb;

            lsb = value & 255; //LSB
            msb = value & 0xFF00;
            msb = msb >> 8;
            retVal[0] = (byte)msb;
            retVal[1] = (byte)lsb;
            return retVal;
        }

        /// <summary>
        /// the first item in the array stores the msb
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public override byte[] UInt32ToBytes(uint value)
        {
            byte[] retVal = new byte[4];
            uint lsb;
            uint msb1;
            uint msb2;
            uint msb3;

            lsb = value & 255;           //LSB
            msb1 = value & 0x0000FF00;  //MSB1
            msb1 = msb1 >> 8;
            msb2 = value & 0x00FF0000;  //MSB1
            msb2 = msb2 >> 16;
            msb3 = value & 0xFF000000;  //MSB1
            msb3 = msb3 >> 24;
            retVal[0] = (byte)msb3;
            retVal[1] = (byte)msb2;
            retVal[2] = (byte)msb1;
            retVal[3] = (byte)lsb;
            return retVal;
        }

        public override short ShortFromBytes(byte[] buffer, int startIndex)
        {
            short retVal;
            byte[] buffer2Convert = new byte[buffer.Length];

            if (BitConverter.IsLittleEndian)
            {
                buffer2Convert[startIndex] = buffer[startIndex + 1];
                buffer2Convert[startIndex + 1] = buffer[startIndex];
                retVal = BitConverter.ToInt16(buffer2Convert, startIndex);
            }
            else
            {
                retVal = BitConverter.ToInt16(buffer, startIndex);
            }
            return retVal;
        }



        public override ushort UshortFromBytes(byte[] buffer, int startIndex)
        {
            ushort retVal;
            byte[] buffer2Convert = new byte[buffer.Length];

            if (BitConverter.IsLittleEndian)
            {
                buffer2Convert[startIndex] = buffer[startIndex + 1];
                buffer2Convert[startIndex + 1] = buffer[startIndex];
                retVal = BitConverter.ToUInt16(buffer2Convert, startIndex);
            }
            else
            {
                retVal = BitConverter.ToUInt16(buffer, startIndex);
            }
            return retVal;
        }

        public override UInt32 UInt32FromBytes(byte[] buffer, int startIndex)
        {
            UInt32 retVal;
            byte[] buffer2Convert = new byte[buffer.Length];

            if (BitConverter.IsLittleEndian)
            {
                buffer2Convert[startIndex] = buffer[startIndex + 3];
                buffer2Convert[startIndex + 1] = buffer[startIndex + 2];
                buffer2Convert[startIndex + 2] = buffer[startIndex + 1];
                buffer2Convert[startIndex + 3] = buffer[startIndex];
                retVal = BitConverter.ToUInt32(buffer2Convert, startIndex);
            }
            else
            {
                retVal = BitConverter.ToUInt32(buffer, startIndex);
            }
            return retVal;
        }

        public override Int32 Int32FromBytes(byte[] buffer, int startIndex)
        {
            Int32 retVal;
            byte[] buffer2Convert = new byte[buffer.Length];

            if (BitConverter.IsLittleEndian)
            {
                buffer2Convert[startIndex] = buffer[startIndex + 3];
                buffer2Convert[startIndex + 1] = buffer[startIndex + 2];
                buffer2Convert[startIndex + 2] = buffer[startIndex + 1];
                buffer2Convert[startIndex + 3] = buffer[startIndex];
                retVal = BitConverter.ToInt32(buffer2Convert, startIndex);
            }
            else
            {
                retVal = BitConverter.ToInt32(buffer, startIndex);
            }
            return retVal;
        }


        public override char CharFromBytes(byte[] arr, int startIndex)
        {

            throw new NotImplementedException();
        }

        public override byte[] Double2Bytes(double value)
        {
            byte[] buffer;

            buffer = BitConverter.GetBytes(value);
            Array.Reverse(buffer);
            return buffer;
        }

        public override double DoubleFromBytes(byte[] arr, int startIndex)
        {
            double retVal;
            if (BitConverter.IsLittleEndian)
            {
                byte[] subArray = SubArray(arr, startIndex, LengthDataType.Double);

                Array.Reverse(subArray);
                retVal = BitConverter.ToDouble(subArray, startIndex);
            }
            else
            {
                retVal = BitConverter.ToDouble(arr, startIndex);
            }
            return retVal;
        }

        public override float FloatFromBytes(byte[] arr, int startIndex)
        {
            float retVal;

            if (BitConverter.IsLittleEndian)
            {
                byte[] subArray = SubArray(arr, startIndex, LengthDataType.Float);

                Array.Reverse(subArray);
                retVal = BitConverter.ToSingle(subArray, 0);
            }
            else
            {
                retVal = BitConverter.ToSingle(arr, startIndex);
            }
            return retVal;
        }

        public override byte[] FloatToBytes(float value)
        {
            byte[] buffer;

            buffer = BitConverter.GetBytes(value);
            Array.Reverse(buffer);
            return buffer;
        }

        public override byte[] Int32ToBytes(int value)
        {
            byte[] buffer;

            buffer = BitConverter.GetBytes(value);
            Array.Reverse(buffer);
            return buffer;
        }

        public override byte[] Long2Bytes(long value)
        {
            byte[] buffer;

            buffer = BitConverter.GetBytes(value);
            Array.Reverse(buffer);
            return buffer;
        }

        public override long LongFromBytes(byte[] arr, int startIndex)
        {
            long retVal;

            if (BitConverter.IsLittleEndian)
            {
                byte[] subArray = SubArray(arr, startIndex, LengthDataType.Long);

                Array.Reverse(subArray);
                retVal = BitConverter.ToInt64(subArray, 0);
            }
            else
            {
                retVal = BitConverter.ToInt64(arr, startIndex);
            }
            return retVal;
        }

        public override byte[] Short2Bytes(short value)
        {
            byte[] buffer;

            buffer = BitConverter.GetBytes(value);
            Array.Reverse(buffer);
            return buffer;
        }

        public override byte[] ULong2Bytes(ulong value)
        {
            byte[] buffer;

            buffer = BitConverter.GetBytes(value);
            Array.Reverse(buffer);
            return buffer;
        }

        public override ulong ULongFromBytes(byte[] arr, int startIndex)
        {
            ulong retVal;

            if (BitConverter.IsLittleEndian)
            {
                byte[] subArray = SubArray(arr, startIndex, LengthDataType.Ulong);

                Array.Reverse(subArray);
                retVal = BitConverter.ToUInt64(subArray, startIndex);
            }
            else
            {
                retVal = BitConverter.ToUInt64(arr, startIndex);
            }
            return retVal;
        }

        public override ushort[] UshortsFromInt32(int value)
        {
            ushort[] retVal=new ushort[2];
            int utemp1, utemp2;

            utemp1 = (int)(value & 0xFFFF0000);//msb
            utemp1 = utemp1 >> 16;

            utemp2 = (int)(value & 0x0000FFFF);//lsb

            retVal[0] =(ushort) utemp1;
            retVal[1] = (ushort)utemp2;

            return retVal;
        }

        public override ushort[] UshortsFromUInt32(uint value)
        {
            ushort[] retVal = new ushort[2];
            uint utemp1, utemp2;

            utemp1 = (uint)(value & 0xFFFF0000);//msb
            utemp1 = utemp1 >> 16;

            utemp2 = (uint)(value & 0x0000FFFF);//lsb

            retVal[0] = (ushort)utemp1;
            retVal[1] = (ushort)utemp2;

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
