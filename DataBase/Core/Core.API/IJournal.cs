using System;
using System.Collections.Generic;
using System.Text;

namespace Core.API
{
    public interface IJournal
    {
        Guid Create();

        void Write(Guid id, IJournalData data);

        IJournalData Read(Guid id);

        void Delete(Guid id);
    }

    public interface IJournalStorage : IJournal
    {
        
    }

    public interface IJournalData
    {
        Guid Id { get; set; }

        UserInfo Creator { get; set; }   
        
        UserInfo LastModified { get; set; }    

        IList<IEntry> Entries { get; set; }
    }

    public interface IEntry
    {

    }

    public class UserInfo
    { 
    
    }
}
