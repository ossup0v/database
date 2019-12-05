using Core.API;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class JournalStorage : IJournalStorage
    {
        private IDatabase _storage;

        public Guid Create()
        {
            return _storage.Create();
        }

        public void Delete(Guid id)
        {
            _storage.Delete(id);
        }

        public IJournalData Read(Guid id)
        {
            _storage.Find(id);
            throw new NotImplementedException();
        }

        public void Write(Guid id, IJournalData data)
        {
            //ToDo IJournal to byte array
            _storage.Update(id, new byte[16]);
            throw new NotImplementedException();
        }
    }
}
