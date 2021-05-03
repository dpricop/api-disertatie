using ApiDisertatie.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ApiDisertatie.DataLayer.Repository
{
    public class CrmOpportunityStatusRepo : GenericRepository<CrmOpportunityStatus>
    {
        private readonly DatabaseContext dbContext;

        public CrmOpportunityStatusRepo(DatabaseContext context) : base(context)
        {
            dbContext = context;
        }
        public virtual IQueryable<CrmOpportunityStatusDropDown> GetAllDropDown()
        {
            return this.GetAll().Select(s => new CrmOpportunityStatusDropDown() { IdOpportunityStatus = s.IdOpportunityStatus, StatusNume= s.StatusNume }).AsQueryable();
        }

        public virtual IQueryable<CrmOpportunityStatus> GetAllTable()
        {
            return this.GetAll().Select(s => new CrmOpportunityStatus() {
                IdOpportunityStatus = s.IdOpportunityStatus,
                StatusNume = s.StatusNume,
                InUserId = s.InUserId,
                InDate = s.InDate,
                ModUserId = s.ModUserId,
                ModDate = s.ModDate
            });
        }
    }
}
