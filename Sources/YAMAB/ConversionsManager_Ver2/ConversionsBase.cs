using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace OTools
{
   public abstract class ConversionsBase
    {
        protected Dictionary<int, int> m_bitToMask = null;
        public ConversionsBase()
        {

        }
        public string FormatBuffer2HexString(int startIndex, byte[] buffer)
        {
            string retVal = null;

            for (int i = startIndex; i < buffer.Length; i++)
            {
                retVal += buffer[i].ToString("X2") + " ";
            }
            return retVal;
        }
        public abstract Int32 Int32FromBytes(byte[] buffer, int startIndex);
        public abstract UInt32 UInt32FromBytes(byte[] buffer, int startIndex);
        public abstract ushort UshortFromBytes(byte[] buffer, int startIndex);
        public abstract short ShortFromBytes(byte[] buffer, int startIndex);
        public abstract byte[] UShortToBytes(ushort value);
        public abstract byte[] Short2Bytes(short value);
        public abstract byte[] FloatToBytes(float value);
        public abstract byte[] UInt32ToBytes(uint value);
        public abstract byte[] Int32ToBytes(int value);
        public abstract UInt64 ULongFromBytes(byte[] arr, int startIndex);
        public abstract Int64 LongFromBytes(byte[] arr, int startIndex);
        public abstract double DoubleFromBytes(byte[] arr, int startIndex);
        public abstract float FloatFromBytes(byte[] arr, int startIndex);

        public abstract char CharFromBytes(byte[] arr, int startIndex);

        public abstract byte[] ULong2Bytes(ulong value);
        public abstract byte[] Long2Bytes(long value);
        public abstract byte[] Double2Bytes(double value);
        public abstract ushort[] UshortsFromUInt32(uint value);
        public abstract ushort[] UshortsFromInt32(int value);


        public ushort ReverseBits(ushort value)
        {
            int retVal = 0;
            int bitValue;
            int mask;

            for (int bitIndex = 0; bitIndex < 16; bitIndex++)
            {
                mask = 1 << bitIndex;
                bitValue = value & mask;
                bitValue = bitValue >> bitIndex;

                if (bitValue > 0)
                {
                    mask = 1 << (15 - bitIndex);

                    //Now, set the bit in its new position
                    retVal = retVal | mask;
                }
            }
            return (ushort)retVal;
        }



        public abstract int UshortsToInt32(ushort[] buffer, int index);

        public string FormatBuffer2HexString(ushort[] buffer)
        {
            string retVal = null;

            for (int i = 0; i < buffer.Length; i++)
            {
                retVal += buffer[i].ToString("X4") + " ";
            }
            return retVal;
        }

        public byte SetBits(byte value, byte bitsValue, int index)
        {
            int retVal;

            retVal = value | (bitsValue << index);
            return (byte)retVal;
        }
        public ushort SetBits(ushort value, byte bitsValue, int index)
        {
            int retVal;

            retVal = value | (bitsValue << index);
            return (ushort)retVal;
        }


        public ushort[] ReverseBitsInArray(ushort[] bitsArray)
        {
            for (int i = 0; i < bitsArray.Length; i++)
            {
                bitsArray[i] = ReverseBits(bitsArray[i]);
            }
            return bitsArray;
        }

        public byte ExtractValue(byte value, bool bit0, bool bit1, bool bit2, bool bit3, bool bit4, bool bit5, bool bit6, bool bit7)
        {
            bool[] maskList = { bit0, bit1, bit2, bit3, bit4, bit5, bit6, bit7 };
            int mask = 0;
            int shiftRightValue = -1;
            int retVal;

            if (m_bitToMask == null)
            {
                m_bitToMask = new Dictionary<int, int>();//0 -1 To 7 bit

                for (int i = 0; i <= 7; i++)
                {
                    m_bitToMask.Add(i, (int)Math.Pow(2, i));
                }
            }

            for (int i = 0; i < maskList.Length; i++)
            {
                if (maskList[i] == true)
                {
                    mask = mask | m_bitToMask[i];
                    if (shiftRightValue == -1)
                    {
                        shiftRightValue = i;
                    }
                }
            }
            retVal = value & mask;
            if (shiftRightValue > 0)
            {
                retVal = retVal >> shiftRightValue;
            }
            return (byte)retVal;
        }

        public byte GetBit(byte data, int index)
        {
            return GetBits(data, index, index);
        }

        public bool GetBitBool(byte data, int index)
        {
            bool retVal;
            retVal = GetBits(data, index, index) == 1 ? true : false;
            return retVal;
        }

        public byte GetBits(byte data, int indexStart, int indexEnd)
        {
            byte[] arr = { 1, 2, 4, 8, 16, 32, 64, 128 };
            byte mask = 0;
            byte ret;

            //Produce the mask
            for (int i = indexStart; i <= indexEnd; i++)
            {
                mask = (byte)(mask | arr[i]);
            }
            ret = (byte)(data & mask);
            if (indexStart != 0)
                ret = (byte)(ret >> indexStart);
            return ret;
        }


        public ushort GetBits(ushort data, int indexStart, int indexEnd)
        {
            ushort[] arr = { 1, 2, 4, 8, 16, 32, 64, 128, 256, 512, 1024, 2048, 4096, 8192, 16384, 32768 };
            ushort mask = 0;
            ushort ret;

            //Produce the mask
            for (int i = indexStart; i <= indexEnd; i++)
            {
                mask = (ushort)(mask | arr[i]);
            }
            ret = (ushort)(data & mask);
            if (indexStart != 0)
                ret = (ushort)(ret >> indexStart);
            return ret;
        }

        public byte GetBit(ushort data, int index)
        {
            return Convert.ToByte(GetBits(data, index, index));
        }




        public string StringFromBytes(byte[] arr, int startIndex, int length = -1)
        {
            if (length > -1)
            {
                return ASCIIEncoding.ASCII.GetString(arr, startIndex, length);
                //return BitConverter.ToString(arr, startIndex, length);
            }
            else
            {
                return null;
                //return ASCIIEncoding.ASCII.GetString(arr, startIndex,);
            }

            
        }


        public byte[] GetBytesFromString(string s)
        {

            if (s!=null && s.Length > 0)
            {
                return ASCIIEncoding.ASCII.GetBytes(s);
              
            }
            else
            {
                return null;
               
            }
        }


        /// <summary>
        /// Copying the data to the buffer count bytes from indexStart assuming buffer has the correct size
        /// </summary>
        /// <param name="buffer">The buffer to be filled</param>
        /// <param name="data">The data that will be copied from</param>
        /// <param name="indexStart">The index we start to copy from data</param>
        /// <param name="count">Number of bytes to be copied, if left unassigned then the default is actually the srcBuffer length</param>
        /// <param name="indexStartDst">The index we start to fill the data in dstBuffer</param>
        public void CopyBuffer(byte[] srcBuffer, byte[] dstBuffer, int srcIndexStart, int count = 0, int dstIndexStart = 0)
        {
            if (count == 0)
                count = dstBuffer.Length;
            for (int i = dstIndexStart; i < count + dstIndexStart; i++)
            {
                dstBuffer[i] = srcBuffer[srcIndexStart + i - dstIndexStart];
            }
        }

        public sbyte Byte2SByte(byte value)
        {
            return (sbyte)(value);
        }

        //private static byte[] ConvertLittleEndianToBigEndian(byte[] buffer)
        //{
        //    byte[] retVal = new byte[buffer.Length];

        //    int bufferMaxIndex = retVal.Length - 1;
        //    for (int i = 0; i < buffer.Length; i++)
        //    {
        //        retVal[i] = buffer[bufferMaxIndex - i];
        //    }
        //    return retVal;
        //}

        public byte GetBit(int data, int index)
        {
            return Convert.ToByte(new BitArray(new int[] { data })[index]);
        }

        protected byte[] SubArray(byte[] data, int index, LengthDataType length)
        {
            byte[] result = new byte[(byte)length];
            Array.Copy(data, index, result, 0, (byte)length);
            return result;
        }

        protected enum LengthDataType: byte
        {
            Double = 8,
            Float = 4,
            Long = 8,
            Ulong = 8,
        }
    }
}
