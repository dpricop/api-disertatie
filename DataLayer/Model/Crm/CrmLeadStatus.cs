using System;
using System.Collections.Generic;

namespace ApiDisertatie.DataLayer.Models
{
    public partial class CrmLeadStatus
    {
        public CrmLeadStatus()
        {
            CrmLeads = new HashSet<CrmLead>();
        }

        public int IdLeadStatus { get; set; }
        public string StatusNume { get; set; }
        public string InUserId { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUserId { get; set; }
        public DateTime? ModDate { get; set; }

        public virtual ICollection<CrmLead> CrmLeads { get; set; }
    }
}
