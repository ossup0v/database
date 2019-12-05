using System;
using System.Collections.Generic;
using System.Text;

namespace Database.API
{
    public interface IDatabase
    {
        IData Find(Guid id);

        Guid Create(byte[] data);
        
        Guid Create(Func<uint, byte[]> dataGenerator);

        /// <summary>
        /// Deleting record by id
        /// </summary>
        /// <param name="id"></param>
        void Delete(Guid id);
    }
}
