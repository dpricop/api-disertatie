using ApiDisertatie.DataLayer.Models;
using System;
using System.Collections.Generic;

namespace ApiDisertatie.DataLayer.Repository
{
    public partial class CrmOpportunityFazaRepo : GenericRepository<CrmOpportunityFaza>
    {
        private readonly DatabaseContext dbContext;

        public CrmOpportunityFazaRepo(DatabaseContext context) : base(context)
        {
            dbContext = context;
        }
    }
}
