using System;
using System.Collections.Generic;

namespace ApiDisertatie.DataLayer.Models
{
    public partial class CrmActiuni
    {
        public int IdActiune { get; set; }
        public string Descriere { get; set; }
        public DateTime? DataInceput { get; set; }
        public DateTime? DataSfarsit { get; set; }
        public bool? EFinalizata { get; set; }
        public int? TipActiuneId { get; set; }
        public int? LeadId { get; set; }
        public int? OpportunityId { get; set; }
        public string InUserId { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUserId { get; set; }
        public DateTime? ModDate { get; set; }
        public virtual CrmTipActiune TipActiune { get; set; }
        public virtual CrmLead Lead { get; set; }
        public virtual CrmOpportunity Opportunity { get; set; }
    }
}
