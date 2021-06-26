using System;
using System.Collections.Generic;

namespace ApiDisertatie.DataLayer.Models
{
    public partial class CrmParteneriTable
    {
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
        public string NumeTara { get; set; }
        public int? JudetId { get; set; }
        public string NumeJudet { get; set; }
        public int? LocalitateId { get; set; }
         public string NumeLocalitate { get; set; }
        public string Adresa { get; set; }
        public string CodPostal { get; set; }
        public bool? Platitortva { get; set; }
        public bool? TvaIncasare { get; set; }
        public string InUserId { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUserId { get; set; }
        public DateTime? ModDate { get; set; }
    }
}
