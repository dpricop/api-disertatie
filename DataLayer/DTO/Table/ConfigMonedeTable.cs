using System;
using System.Collections.Generic;


namespace ApiDisertatie.DataLayer.Models
{
    public partial class ConfigMonedeTable
    {
        public int IdMoneda { get; set; }
        public string Moneda { get; set; }
        public string InUserId { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUserId { get; set; }
        public DateTime? ModDate { get; set; }
    }
}
