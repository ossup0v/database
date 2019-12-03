using System;
using System.Collections.Generic;
using System.Text;
using Storage.API;

namespace Storage.Helpers
{
    public class BufferHelper
    {
        private static IExtractor _extractor;
        public BufferHelper(IExtractor extractor)
        {
            _extractor = extractor;
        }

        public Guid ReadBufferGuid(byte[] buffer, int bufferOffset)
        {
            byte[] bufferGuid = new byte[16];
            Buffer.BlockCopy(buffer, bufferOffset, bufferGuid, 0, buffer.Length);
            return new Guid(bufferGuid);
        }

        public uint ReadBufferUint32(byte[] buffer, int bufferOffset)
        {
            byte[] bufferUint = new byte[4];
            Buffer.BlockCopy(buffer, bufferOffset, bufferUint, 0, buffer.Length);
            return _extractor.GetUint32(bufferUint);
        }
    }
}
