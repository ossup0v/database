using System;
using System.Collections.Generic;
using System.Text;
using Storage.API;

namespace Storage.Helpers
{
    public class Extractor : IExtractor
    {
        public byte[] GetBytes(int value)
        {
            throw new NotImplementedException();
        }

        public byte[] GetBytes(long value)
        {
            throw new NotImplementedException();
        }

        public byte[] GetBytes(uint value)
        {
            throw new NotImplementedException();
        }

        public byte[] GetBytes(double value)
        {
            throw new NotImplementedException();
        }

        public double GetDouble(byte[] bytes)
        {
            throw new NotImplementedException();
        }

        public int GetInt32(byte[] bytes)
        {
            throw new NotImplementedException();
        }

        public uint Getint32(byte[] bytes, int offset, int count)
        {
            throw new NotImplementedException();
        }

        public long GetInt64(byte[] bytes)
        {
            throw new NotImplementedException();
        }

        public uint GetUint32(byte[] bytes)
        {
            throw new NotImplementedException();
        }
    }
}
