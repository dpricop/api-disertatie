using System;
using System.Collections.Generic;

namespace ApiDisertatie.DataLayer.Models
{
    public partial class CrmParteneri
    {
        public CrmParteneri()
        {
            CrmLeads = new HashSet<CrmLead>();
            CrmOpportunities = new HashSet<CrmOpportunity>();
            CrmPartenerContactes = new HashSet<CrmPartenerContacte>();
        }

        public int IdPartener { get; set; }
        public string NumePartener { get; set; }
        public bool? PersoanaFizica { get; set; }
        public string CodFiscal { get; set; }
        public string Cnp { get; set; }
        public string SerieBi { get; set; }
        public string PaginaWeb { get; set; }
        public int? NrAngajati { get; set; }
        public double? CifraDeAfacere { get; set; }
        public int? TaraId { get; set; }
        public int? JudetId { get; set; }
        public int? LocalitateId { get; set; }
        public string Adresa { get; set; }
        public string CodPostal { get; set; }
        public bool? Platitortva { get; set; }
        public bool? TvaIncasare { get; set; }
        public string InUserId { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUserId { get; set; }
        public DateTime? ModDate { get; set; }

        public virtual ConfigJudete Judet { get; set; }
        public virtual ConfigLocalitati Localitate { get; set; }
        public virtual ConfigTari Tara { get; set; }
        public virtual ICollection<CrmLead> CrmLeads { get; set; }
        public virtual ICollection<CrmOpportunity> CrmOpportunities { get; set; }
        public virtual ICollection<CrmPartenerContacte> CrmPartenerContactes { get; set; }
    }
}
