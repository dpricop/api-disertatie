using System;
using System.Collections.Generic;

namespace ApiDisertatie.DataLayer.Models
{
    public partial class CrmOpportunityTable
    {
        public int IdOpportunity { get; set; }
        public string OppDescriere { get; set; }
        public double? Probabilitatea { get; set; }
        public double? Suma { get; set; }
        public bool? HotOrNot { get; set; }
        public string Competitori { get; set; }
        public int? PartenerId { get; set; }
        public int? PartenerContactId { get; set; }
        public int? StatusId { get; set; }
        public int? FazaId { get; set; }
        public int? MotivId { get; set; }
        public string InUserId { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUserId { get; set; }
        public DateTime? ModDate { get; set; }
        public string FazaNume { get; set; }
        public string  Motiv { get; set; }
        public string NumePartener { get; set; }
        public string  PartenerContact { get; set; }
        public string StatusNume { get; set; }
    }
}
