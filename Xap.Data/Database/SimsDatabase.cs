using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xap.Data.Entities;

namespace Xap.Data.Database
{
    public class SimsDatabase : ISimsDatabase
    {
        public SimsDatabase()
        {

        }
        readonly SQLiteAsyncConnection _database;

        public SimsDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<LogBook>().Wait();
        }

        public Task<List<LogBook>> GetItemsAsync()
        {
            return _database.Table<LogBook>().ToListAsync();
        }

        public Task<LogBook> GetItemAsync(int id)
        {
            return _database.Table<LogBook>()
                            .Where(i => i.LogBoookId == id)
                            .FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(LogBook logBook)
        {
            if (logBook.LogBoookId != 0)
            {
                return _database.UpdateAsync(logBook);
            }
            else
            {
                return _database.InsertAsync(logBook);
            }
        }

        public Task<int> DeleteItemAsync(LogBook logBook)
        {
            return _database.DeleteAsync(logBook);
        }
    }
}
