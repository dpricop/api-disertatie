using System;
using System.Collections.Generic;

namespace ApiDisertatie.DataLayer.Models
{
    public partial class AppUtilizatori
    {
        public int IdUtilizator { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Email { get; set; }
        public string Parola { get; set; }
        public string DbNume { get; set; }
        public string DbParola { get; set; }
        public bool? EInactiv { get; set; }
        public string CodRecuperareParola { get; set; }
        public string InUserId { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUserId { get; set; }
        public DateTime? ModDate { get; set; }
    }
}
