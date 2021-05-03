using ApiDisertatie.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ApiDisertatie.DataLayer.Repository
{
    public partial class CrmOpportunityFazaRepo : GenericRepository<CrmOpportunityFaza>
    {
        private readonly DatabaseContext dbContext;

        public CrmOpportunityFazaRepo(DatabaseContext context) : base(context)
        {
            dbContext = context;
        }

        public virtual IQueryable<CrmOpportunityFazaDropDown> GetAllDropDown()
        {
            return this.GetAll().Select(s => new CrmOpportunityFazaDropDown() { IdOpportunityFaza = s.IdOpportunityFaza, FazaNume = s.FazaNume }).AsQueryable();
        }

        public virtual IQueryable<CrmOpportunityFaza> GetAllTable()
        {
            return this.GetAll().Select(s => new CrmOpportunityFaza() {

                IdOpportunityFaza = s.IdOpportunityFaza,
                FazaNume  = s.FazaNume,
                InUserId = s.InUserId,
                InDate = s.InDate,
                ModUserId = s.ModUserId,
                ModDate = s.ModDate
            });
        }
    }
}
