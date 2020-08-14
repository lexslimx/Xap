using System;
using System.Collections.Generic;
using System.Text;

namespace Xap.Models
{
    public class LogBookDto
    {
        public int LogBoookId { get; set; }
        public DateTime? CheckInTime { get; set; }
        public DateTime? CheckOutTime { get; set; }
        public string EntityNo { get; set; }
        public bool? Synced { get; set; }
    }
}
