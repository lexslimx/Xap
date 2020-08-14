using System.Collections.Generic;
using System.Threading.Tasks;
using Xap.Data.Entities;

namespace Xap.Data.Database
{
    public interface ISimsDatabase
    {
        Task<int> DeleteItemAsync(LogBook logBook);
        Task<LogBook> GetItemAsync(int id);
        Task<List<LogBook>> GetItemsAsync();
        Task<int> SaveItemAsync(LogBook logBook);
    }
}