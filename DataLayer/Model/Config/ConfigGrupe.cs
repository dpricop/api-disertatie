using System;
using System.Collections.Generic;

namespace ApiDisertatie.DataLayer.Models
{
    public partial class ConfigGrupe
    {
        public ConfigGrupe()
        {
            CrmArticoles = new HashSet<CrmArticole>();
        }

        public int IdGrupa { get; set; }
        public string Grupa { get; set; }
        public string InUserId { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUserId { get; set; }
        public DateTime? ModDate { get; set; }

        public virtual ICollection<CrmArticole> CrmArticoles { get; set; }
    }
}
