using System;
using System.Collections.Generic;

namespace ApiDisertatie.DataLayer.Models
{
    public partial class CrmOferteDetalii
    {
        public int IdOfertaDetalii { get; set; }
        public int OfertaAntentId { get; set; }
        public int ArticolId { get; set; }
        public decimal Cantitate { get; set; }
        public decimal PretUnitar { get; set; }
        public decimal PretTotalNet { get; set; }
        public string InUserId { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUserId { get; set; }
        public DateTime? ModDate { get; set; }

        public virtual CrmOferteAntent OfertaAntent { get; set; }
    }
}
