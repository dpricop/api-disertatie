using System;
using System.Collections.Generic;

namespace ApiDisertatie.DataLayer.Models
{
    public partial class ConfigJudete
    {
        public ConfigJudete()
        {
            ConfigLocalitatis = new HashSet<ConfigLocalitati>();
            CrmParteneris = new HashSet<CrmParteneri>();
        }

        public int IdJudet { get; set; }
        public string NumeJudet { get; set; }
        public string CodJudet { get; set; }
        public int? TaraId { get; set; }
        public string InUserId { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUserId { get; set; }
        public DateTime? ModDate { get; set; }

        public virtual ConfigTari Tara { get; set; }
        public virtual ICollection<ConfigLocalitati> ConfigLocalitatis { get; set; }
        public virtual ICollection<CrmParteneri> CrmParteneris { get; set; }
    }
}
