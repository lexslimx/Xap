using System;
using System.Collections.Generic;
using System.Text;
using Xap.Data.Entities;
using Xap.Interfaces;
using Xap.Models;
using System.Threading.Tasks;
using Xap.Data.Database;
using System.Data;

namespace Xap.Services
{
    public class LogBookService : ILogBookService
    {
        private ISimsDatabase _database;
        public LogBookService(ISimsDatabase database)
        {
            _database = database;
        }
        public void AddItem(string entityNo)
        {
            var logBook = new LogBook
            {
                CheckInTime = DateTime.Now,
                Synced = false,
                EntityNo = entityNo
            };
            _database.SaveItemAsync(logBook);
        }

        public async Task<LogBookDto> GetItemAsync(int logBookId)
        {
            var logBook = await _database.GetItemAsync(logBookId);
            if (logBook == null) return null;
            var logBookDto = GetLogBoookDto(logBook);
            return logBookDto;
        }

        public async Task<List<LogBookDto>> GetItemsAsync()
        {
            var logBooks = await _database.GetItemsAsync();
            var result = new List<LogBookDto>();
            foreach (var logBook in logBooks)
            {
                result.Add(GetLogBoookDto(logBook));
            }
            return result;
        }

        private static LogBookDto GetLogBoookDto(LogBook logBook)
        {
            return new LogBookDto
            {
                CheckInTime = logBook.CheckInTime,
                CheckOutTime = logBook.CheckOutTime,
                EntityNo = logBook.EntityNo,
                LogBoookId = logBook.LogBoookId,
                Synced = logBook.Synced
            };
        }
    }
}
