using System;
using System.Collections.Generic;
using System.Text;

namespace Storage.Storage.API
{
    public interface IRecordStorage
    {
        void Update(uint recordId, byte[] data);

        int[] Find(uint recordId);

        /// <summary>
        /// Creating empty block
        /// </summary>
        int[] Create();

        int[] Create(byte[] date);

        uint Create(Func<uint, byte[]> dataGenerator);
        /// <summary>
        /// Deleting record by id
        /// </summary>
        /// <param name="recordId"></param>
        void Delete(uint recordId);

    }
}
