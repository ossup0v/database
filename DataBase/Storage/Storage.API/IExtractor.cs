using System;
using System.Collections.Generic;
using System.Text;

namespace Storage.API
{
    public interface IExtractor
    {
        byte[] GetBytes(int value);

        byte[] GetBytes(long value);

        byte[] GetBytes(uint value);

        byte[] GetBytes(double value);

        double GetDouble(byte[] bytes);

        uint GetUInt32(byte[] bytes);

        long GetInt64(byte[] bytes);

        int GetInt32(byte[] bytes);

        uint GetInt32(byte[] bytes, int offset, int count);
    }
}
