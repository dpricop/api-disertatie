using System;
using System.Collections.Generic;

namespace ApiDisertatie.DataLayer.Models
{
    public partial class CrmOferteAntent
    {
        public CrmOferteAntent()
        {
            CrmOferteDetaliis = new HashSet<CrmOferteDetalii>();
        }

        public int IdOfertaAntent { get; set; }
        public string FurnizorNume { get; set; }
        public string FurnizorCif { get; set; }
        public string FurnizorNrRegCom { get; set; }
        public string FurnizorCont { get; set; }
        public string FurnizorBanca { get; set; }
        public int PartenerId { get; set; }
        public int? OpportunityId { get; set; }
        public DateTime? DataEmiterii { get; set; }
        public DateTime? DataExpirarii { get; set; }
        public bool? OfertaAcceptata { get; set; }
        public bool? OfertaRespinsa { get; set; }
        public string InUserId { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUserId { get; set; }
        public DateTime? ModDate { get; set; }
        public virtual CrmParteneri Partener { get; set; }
        public virtual ICollection<CrmOferteDetalii> CrmOferteDetaliis { get; set; }
    }
}
