﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseManager.Domain.Entities
{
    public class Finance
    {
        public int Id { get; set; }
        public int DatabaseID { get; set; }
        public DateTime? PeriodStart { get; set; }
        public DateTime? PeriodEnd { get; set; }
        public double? MonthlyRate { get; set; }
        public double? LogSize { get; set; }
        public double? DbSize { get; set; }
        public double? WebSize { get; set; }
        public double? TotalSpaceUsage { get; set; }
        public int? InvoiceNumber { get; set; }
        public string Invoice { get; set; }
        public string Notes { get; set; }
    }
}
