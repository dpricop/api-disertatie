using System;
using System.Collections.Generic;

namespace ApiDisertatie.DataLayer.Models
{
    public partial class ConfigTari
    {
        public ConfigTari()
        {
            ConfigJudetes = new HashSet<ConfigJudete>();
            CrmParteneris = new HashSet<CrmParteneri>();
        }

        public int IdTara { get; set; }
        public string NumeTara { get; set; }
        public string CodTara { get; set; }
        public string InUserId { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUserId { get; set; }
        public DateTime? ModDate { get; set; }

        public virtual ICollection<ConfigJudete> ConfigJudetes { get; set; }
        public virtual ICollection<CrmParteneri> CrmParteneris { get; set; }
    }
}
