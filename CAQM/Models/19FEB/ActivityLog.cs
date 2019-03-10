﻿using System;
using System.Collections.Generic;

namespace CAQM.Models.19FEB
{
    public partial class ActivityLog
    {
        public int ActivityLogId { get; set; }
        public int UserId { get; set; }
        public string ActionType { get; set; }
        public string DataType { get; set; }
        public string IdNumber { get; set; }
        public bool IsWrongSigninAttempt { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public User User { get; set; }
    }
}