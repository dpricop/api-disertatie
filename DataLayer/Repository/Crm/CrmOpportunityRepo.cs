using ApiDisertatie.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ApiDisertatie.DataLayer.Repository
{
    public partial class CrmOpportunityRepo : GenericRepository<CrmOpportunity>
    {
        private readonly DatabaseContext dbContext;

        public CrmOpportunityRepo(DatabaseContext context) : base(context)
        {
            dbContext = context;
        }

        public virtual IQueryable<CrmOpportunityDropDown> GetAllDropDown()
        {
            return this.GetAll().Select(s => new CrmOpportunityDropDown() { IdOpportunity = s.IdOpportunity,OppDescriere = s.OppDescriere }).AsQueryable();
        }

        public virtual IQueryable<CrmOpportunityTable> GetAllTable()
        {
            return this.GetAll().Select(c => new CrmOpportunityTable()
            {
                IdOpportunity = c.IdOpportunity,
                OppDescriere = c.OppDescriere,
                Probabilitatea = c.Probabilitatea,
                Suma = c.Suma,
                HotOrNot = c.HotOrNot,
                Competitori = c.Competitori,
                PartenerId = c.PartenerId,
                NumePartener = c.Partener.NumePartener,
                PartenerContactId = c.PartenerContactId,
                PartenerContact = $"{c.PartenerContact.NumeContact} {c.PartenerContact.PrenumeContact}",
                StatusId = c.StatusId,
                StatusNume = c.Status.StatusNume,
                FazaId = c.FazaId,
                FazaNume = c.Faza.FazaNume,
                MotivId = c.MotivId,
                Motiv = c.Motiv.Motiv,
                InUserId = c.InUserId,
                InDate = c.InDate,
                ModUserId = c.ModUserId,
                ModDate = c.ModDate,
            });
        }
    }
}
