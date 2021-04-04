using System;
using System.Collections.Generic;


namespace ApiDisertatie.DataLayer.Models
{
    public partial class CrmListaNotite
    {
        public int IdNotita { get; set; }
        public string NotitaDesc { get; set; }
        public bool? EFinalizata { get; set; }
        public string InUserId { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUserId { get; set; }
        public DateTime? ModDate { get; set; }
    }
}
