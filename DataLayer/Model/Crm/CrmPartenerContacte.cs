using System;
using System.Collections.Generic;

namespace ApiDisertatie.DataLayer.Models
{
    public partial class CrmPartenerContacte
    {
        public CrmPartenerContacte()
        {
            CrmOpportunities = new HashSet<CrmOpportunity>();
        }

        public int IdPartenerContact { get; set; }
        public int? PartenerId { get; set; }
        public string NumeContact { get; set; }
        public string PrenumeContact { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string Functia { get; set; }
        public string Note { get; set; }
        public string InUserId { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUserId { get; set; }
        public DateTime? ModDate { get; set; }

        public virtual CrmParteneri Partener { get; set; }
        public virtual ICollection<CrmOpportunity> CrmOpportunities { get; set; }
    }
}
