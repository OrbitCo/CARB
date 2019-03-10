using System;
using System.Collections.Generic;

namespace CAQM.Models.19FEB
{
    public partial class SystemEventLog1
    {
        public long SystemEventLogId { get; set; }
        public DateTime EventDateTime { get; set; }
        public int EventNumber { get; set; }
        public string EventType { get; set; }
        public string Username { get; set; }
        public string ServerName { get; set; }
        public string EventMessage { get; set; }
    }
}
