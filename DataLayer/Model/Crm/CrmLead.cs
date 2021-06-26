using System;
using System.Collections.Generic;

namespace ApiDisertatie.DataLayer.Models
{
    public partial class CrmLead
    {
        public int IdLead { get; set; }
        public string LeadNume { get; set; }
        public string LeadDescriere { get; set; }
        public bool? PersoanaFizica { get; set; }
        public string CodFiscal { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public bool? HotOrNot { get; set; }
        public string NoteSursa { get; set; }
        public string ContactNume{ get; set; }
        public string ContactPrenume { get; set; }
        public int? LeadStatusId { get; set; }
        public int? PartenerId { get; set; }
        public bool? ECalificat { get; set; }
        public bool? EInactiv { get; set; }
        public bool? EConvertit { get; set; }
        public int? MotivId { get; set; }
        public string InUserId { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUserId { get; set; }
        public DateTime? ModDate { get; set; }

        public virtual CrmLeadStatus LeadStatus { get; set; }
        public virtual ConfigMotive Motiv { get; set; }
        public virtual CrmParteneri Partener { get; set; }
    }
}
