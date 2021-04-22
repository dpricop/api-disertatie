using ApiDisertatie.DataLayer.Models;
using System;
using System.Collections.Generic;


namespace ApiDisertatie.DataLayer.Repository
{
    public partial class CrmOpportunityRepo : GenericRepository<CrmOpportunity>
    {
        private readonly DatabaseContext dbContext;

        public CrmOpportunityRepo(DatabaseContext context) : base(context)
        {
            dbContext = context;
        }
    }
}
