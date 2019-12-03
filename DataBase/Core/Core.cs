using Core.API;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public interface IStorage
    {
        Guid Write(IEntry entry);

        Guid Write(IList<IEntry> entries);

        IStorageData Read(Guid dataId);

        IStorageData Read(DatabaseQuery query);

        bool Update(Guid SessionId, IEntry data);

        bool Delete(DatabaseQuery query);

        bool Delete(Guid dataId);
    }

    public interface IStorageData
    {
        Guid Id { get; set; }

        IList<IEntry> Entries { get; set; } 
    }

    public interface IEntry
    { 
    
    }
}
