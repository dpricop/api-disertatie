using ApiDisertatie.DataLayer.Models;
using System;
using System.Collections.Generic;


namespace ApiDisertatie.DataLayer.Repository
{
    public partial class CrmListaNotiteRepo : GenericRepository<CrmOpportunityFaza>
    {
        private readonly DatabaseContext dbContext;

        public CrmListaNotiteRepo(DatabaseContext context) : base(context)
        {
            dbContext = context;
        }
    }
}
