using System;
using System.Collections.Generic;
using System.Text;

namespace Database.Core
{
    public class Extractor
    {
        public byte[] GetBytes(int value)
        {
            var bytes = BitConverter.GetBytes(value);

            if (false == BitConverter.IsLittleEndian)
            {
                Array.Reverse(bytes);
            }

            return bytes;
        }

        public byte[] GetBytes(long value)
        {
            var bytes = BitConverter.GetBytes(value);

            if (false == BitConverter.IsLittleEndian)
            {
                Array.Reverse(bytes);
            }

            return bytes;
        }

        public byte[] GetBytes(uint value)
        {
            var bytes = BitConverter.GetBytes(value);

            if (false == BitConverter.IsLittleEndian)
            {
                Array.Reverse(bytes);
            }

            return bytes;
        }

        public byte[] GetBytes(double value)
        {
            var bytes = BitConverter.GetBytes(value);

            if (false == BitConverter.IsLittleEndian)
            {
                Array.Reverse(bytes);
            }

            return bytes;
        }

        public double GetDouble(byte[] bytes)
        {
            if (false == BitConverter.IsLittleEndian)
            {
                var bytesClone = new byte[bytes.Length];
                bytes.CopyTo(bytesClone, 0);
                Array.Reverse(bytesClone);
                return BitConverter.ToDouble(bytesClone, 0);
            }
            else
            {
                return BitConverter.ToDouble(bytes, 0);
            }
        }

        public int GetInt32(byte[] bytes)
        {
            if (false == BitConverter.IsLittleEndian)
            {
                var bytesClone = new byte[bytes.Length];
                bytes.CopyTo(bytesClone, 0);
                Array.Reverse(bytesClone);
                return BitConverter.ToInt32(bytesClone, 0);
            }
            else
            {
                return BitConverter.ToInt32(bytes, 0);
            }
        }

        public uint GetInt32(byte[] bytes, int offset, int count)
        {
            if (false == BitConverter.IsLittleEndian)
            {
                var bytesClone = new byte[bytes.Length];
                bytes.CopyTo(bytesClone, 0);
                Array.Reverse(bytesClone);
                return BitConverter.ToUInt32(bytesClone, 0);
            }
            else
            {
                return BitConverter.ToUInt32(bytes, 0);
            }
        }

        public long GetInt64(byte[] bytes)
        {
            if (false == BitConverter.IsLittleEndian)
            {
                var bytesClone = new byte[bytes.Length];
                bytes.CopyTo(bytesClone, 0);
                Array.Reverse(bytesClone);
                return BitConverter.ToInt64(bytesClone, 0);
            }
            else
            {
                return BitConverter.ToInt64(bytes, 0);
            }
        }

        public uint GetUInt32(byte[] bytes)
        {
            if (false == BitConverter.IsLittleEndian)
            {
                var bytesClone = new byte[bytes.Length];
                bytes.CopyTo(bytesClone, 0);
                Array.Reverse(bytesClone);
                return BitConverter.ToUInt32(bytesClone, 0);
            }
            else
            {
                return BitConverter.ToUInt32(bytes, 0);
            }
        }
    }
}
