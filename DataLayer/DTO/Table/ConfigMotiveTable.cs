using System;
using System.Collections.Generic;

namespace ApiDisertatie.DataLayer.Models
{
    public partial class ConfigMotiveTable
    {
        public int IdMotiv { get; set; }
        public string Motiv { get; set; }
        public bool? EMotivLead { get; set; }
        public bool? EMotivOpportunity { get; set; }
        public string InUserId { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUserId { get; set; }
        public DateTime? ModDate { get; set; }
    }
}
