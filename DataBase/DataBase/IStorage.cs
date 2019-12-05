using System;
using System.Collections.Generic;
using System.Text;

namespace Database
{
    public interface IStorage
    {
        uint Crate(byte[] data);

        uint Crate(uint id);

        void Delete(uint id);
    }
}
