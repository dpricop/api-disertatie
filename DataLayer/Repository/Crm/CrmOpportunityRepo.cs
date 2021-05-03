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

        public virtual IQueryable<CrmOpportunity> GetAllTable()
        {
            return this.GetAll();
        }
    }
}
