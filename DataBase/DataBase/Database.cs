using System;
using Database.API;
using Database.Core;

namespace Database
{
    public class Database : IDatabase
    {
        private Storage _storage;

        public Guid Create(byte[] data)
        {
            var uintG = Interpreter.ToByte(_storage.Create(data));
            return new Guid(uintG);
        }

        public Guid Create(Func<uint, byte[]> dataGenerator)
        {
            var bytes = Interpreter.ToByte(dataGenerator);
            var uintG = Interpreter.ToByte(_storage.Create(bytes));
            return new Guid(uintG);
        }

        public void Delete(Guid id)
        {
            var storageId = Interpreter.ToUint(id);
            _storage.Delete(storageId);
        }

        public IData Find(Guid id)
        {
            var storageId = Interpreter.ToUint(id);
            var storageData = _storage.Find(storageId);
            return Interpreter.ToIData(storageData);
        }
    }
}
