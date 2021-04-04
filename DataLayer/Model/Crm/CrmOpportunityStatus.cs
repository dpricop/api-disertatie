using System;
using System.Collections.Generic;

namespace ApiDisertatie.DataLayer.Models
{
    public partial class CrmOpportunityStatus
    {
        public CrmOpportunityStatus()
        {
            CrmOpportunities = new HashSet<CrmOpportunity>();
        }

        public int IdOpportunityStatus { get; set; }
        public string StatusNume { get; set; }
        public string InUserId { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUserId { get; set; }
        public DateTime? ModDate { get; set; }

        public virtual ICollection<CrmOpportunity> CrmOpportunities { get; set; }
    }
}
