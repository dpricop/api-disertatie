using System;
using System.Collections.Generic;

namespace ApiDisertatie.DataLayer.Models
{
    public partial class ConfigUm
    {
        public ConfigUm()
        {
            CrmArticoles = new HashSet<CrmArticole>();
        }

        public int IdUm { get; set; }
        public string Um { get; set; }
        public string InUserId { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUserId { get; set; }
        public DateTime? ModDate { get; set; }

        public virtual ICollection<CrmArticole> CrmArticoles { get; set; }
    }
}
