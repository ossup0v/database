using System;
using System.Collections.Generic;
using System.Text;

namespace Storage.API
{
    public interface IStorage
    {
        void Update(Guid recordId, byte[] data);

        int[] Find(Guid recordId);

        /// <summary>
        /// Creating empty block
        /// </summary>
        Guid Create();
        Guid Create(byte[] date);
        
        Guid Create(Func<uint, byte[]> dataGenerator);
        /// <summary>
        /// Deleting record by id
        /// </summary>
        /// <param name="recordId"></param>
        void Delete(Guid recordId);

    }
}
