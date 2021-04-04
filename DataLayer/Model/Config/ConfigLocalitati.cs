using System;
using System.Collections.Generic;

namespace ApiDisertatie.DataLayer.Models
{
    public partial class ConfigLocalitati
    {
        public ConfigLocalitati()
        {
            CrmParteneris = new HashSet<CrmParteneri>();
        }

        public int IdLocalitate { get; set; }
        public string NumeLocalitate { get; set; }
        public int? JudetId { get; set; }
        public string InUserId { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUserId { get; set; }
        public DateTime? ModDate { get; set; }

        public virtual ConfigJudete Judet { get; set; }
        public virtual ICollection<CrmParteneri> CrmParteneris { get; set; }
    }
}
