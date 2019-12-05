using Database.API;
using System;

namespace Database
{
    public static class Interpreter
    {
        public static Guid ToGuid(Func<uint, byte[]> data)
        {
            throw new NotImplementedException();
        }
        public static uint ToUint(Guid id)
        {
            throw new NotImplementedException();
        }
        public static byte[] ToByte(Func<uint, byte[]> data)
        {
            throw new NotImplementedException();
        }
        public static byte[] ToByte(uint data)
        {
            throw new NotImplementedException();
        }
        public static IData ToIData(byte[] data)
        {
            throw new NotImplementedException();
        }
    }
}
