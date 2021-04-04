﻿using System;
using System.Collections.Generic;

namespace ApiDisertatie.DataLayer.Models
{
    public partial class CrmOpportunityFaza
    {
        public CrmOpportunityFaza()
        {
            CrmOpportunities = new HashSet<CrmOpportunity>();
        }

        public int IdOpportunityFaza { get; set; }
        public string FazaNume { get; set; }
        public string InUserId { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUserId { get; set; }
        public DateTime? ModDate { get; set; }

        public virtual ICollection<CrmOpportunity> CrmOpportunities { get; set; }
    }
}
