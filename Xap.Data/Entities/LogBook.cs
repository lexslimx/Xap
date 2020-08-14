using SQLite;
using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace Xap.Data.Entities
{
    public class LogBook
    {
        public LogBook()
        {

        }

        [PrimaryKey, AutoIncrement]
        public int LogBoookId { get; set; }
        public DateTime? CheckInTime { get; set; }
        public DateTime? CheckOutTime { get; set; }
        public string EntityNo { get; set; }
        public bool? Synced { get; set; }
    }
}
