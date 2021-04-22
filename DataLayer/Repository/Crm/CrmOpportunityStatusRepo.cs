using ApiDisertatie.DataLayer.Models;
using System;
using System.Collections.Generic;

namespace ApiDisertatie.DataLayer.Repository
{
    public class CrmOpportunityStatusRepo : GenericRepository<CrmOpportunityStatus>
    {
        private readonly DatabaseContext dbContext;

        public CrmOpportunityStatusRepo(DatabaseContext context) : base(context)
        {
            dbContext = context;
        }
    }
}
