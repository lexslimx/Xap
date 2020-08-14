using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xap.Models;

namespace Xap.Interfaces
{
    public interface ILogBookService
    {
        void AddItem(string EntityNo);
        Task<List<LogBookDto>> GetItemsAsync();
        Task<LogBookDto> GetItemAsync(int logBookId);
    }
}
