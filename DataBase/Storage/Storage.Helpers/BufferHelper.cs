using System;
using System.Collections.Generic;
using System.Text;
using Storage.API;

namespace Storage.Helpers
{
    public class BufferHelper
    {
        private IExtractor _extractor;

        public BufferHelper(IExtractor extractor)
        {
            _extractor = extractor;
        }

        public Guid ReadBufferGuid(byte[] buffer, int bufferOffset)
        {
            var guidBuffer = new byte[16];
            Buffer.BlockCopy(buffer, bufferOffset, guidBuffer, 0, 16);
            return new Guid(guidBuffer);
        }

        public uint ReadBufferUInt32(byte[] buffer, int bufferOffset)
        {
            var uintBuffer = new byte[4];
            Buffer.BlockCopy(buffer, bufferOffset, uintBuffer, 0, 4);
            return _extractor.GetUInt32(uintBuffer);
        }

        public int ReadBufferInt32(byte[] buffer, int bufferOffset)
        {
            var intBuffer = new byte[4];
            Buffer.BlockCopy(buffer, bufferOffset, intBuffer, 0, 4);
            return _extractor.GetInt32(intBuffer);
        }

        public long ReadBufferInt64(byte[] buffer, int bufferOffset)
        {
            var longBuffer = new byte[8];
            Buffer.BlockCopy(buffer, bufferOffset, longBuffer, 0, 8);
            return _extractor.GetInt64(longBuffer);
        }

        public double ReadBufferDouble(byte[] buffer, int bufferOffset)
        {
            var doubleBuffer = new byte[8];
            Buffer.BlockCopy(buffer, bufferOffset, doubleBuffer, 0, 8);
            return _extractor.GetDouble(doubleBuffer);
        }

        public void WriteBuffer(double value, byte[] buffer, int bufferOffset)
        {
            Buffer.BlockCopy(_extractor.GetBytes(value), 0, buffer, bufferOffset, 8);
        }

        public void WriteBuffer(uint value, byte[] buffer, int bufferOffset)
        {
            Buffer.BlockCopy(_extractor.GetBytes(value), 0, buffer, bufferOffset, 4);
        }

        public void WriteBuffer(long value, byte[] buffer, int bufferOffset)
        {
            Buffer.BlockCopy(_extractor.GetBytes(value), 0, buffer, bufferOffset, 8);
        }

        public void WriteBuffer(int value, byte[] buffer, int bufferOffset)
        {
            Buffer.BlockCopy(_extractor.GetBytes((int)value), 0, buffer, bufferOffset, 4);
        }

        public void WriteBuffer(Guid value, byte[] buffer, int bufferOffset)
        {
            Buffer.BlockCopy(value.ToByteArray(), 0, buffer, bufferOffset, 16);
        }
    }
}
