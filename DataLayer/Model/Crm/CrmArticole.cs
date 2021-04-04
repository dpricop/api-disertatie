using System;
using System.Collections.Generic;

namespace ApiDisertatie.DataLayer.Models
{
    public partial class CrmArticole
    {
        public int IdArticol { get; set; }
        public string Denumire { get; set; }
        public string Cod { get; set; }
        public string CodEan { get; set; }
        public bool? IsInactiva { get; set; }
        public decimal? Pretlista { get; set; }
        public decimal? Pretaman { get; set; }
        public decimal? Adaosmin { get; set; }
        public int? UmId { get; set; }
        public int? GrupaId { get; set; }
        public int? MonedaId { get; set; }
        public string InUserId { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUserId { get; set; }
        public DateTime? ModDate { get; set; }

        public virtual ConfigGrupe Grupa { get; set; }
        public virtual ConfigMonede Moneda { get; set; }
        public virtual ConfigUm Um { get; set; }
    }
}
