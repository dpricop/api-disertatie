using System;
using System.Collections.Generic;


namespace ApiDisertatie.DataLayer.Models
{
    public partial class ConfigMonede
    {
        public ConfigMonede()
        {
            CrmArticoles = new HashSet<CrmArticole>();
        }

        public int IdMoneda { get; set; }
        public string Moneda { get; set; }
        public double? CursValutar { get; set; }
        public DateTime? DataCurs { get; set; }
        public bool? IsActivm { get; set; }
        public double? Multiplicator { get; set; }
        public bool? IsDefault { get; set; }
        public string Symbol { get; set; }
        public string InUserId { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUserId { get; set; }
        public DateTime? ModDate { get; set; }

        public virtual ICollection<CrmArticole> CrmArticoles { get; set; }
    }
}
