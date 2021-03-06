﻿using System;
using System.Collections.Generic;

namespace CAQM.Models.26FebDB
{
    public partial class SystemEventLog
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
