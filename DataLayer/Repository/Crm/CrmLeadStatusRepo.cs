using ApiDisertatie.DataLayer.Models;
using System;
using System.Collections.Generic;

namespace ApiDisertatie.DataLayer.Repository
{
    public partial class CrmLeadStatusRepo : GenericRepository<CrmLeadStatus>
    {
        private readonly DatabaseContext dbContext;

        public CrmLeadStatusRepo(DatabaseContext context) : base(context)
        {
            dbContext = context;
        }
    }
}
