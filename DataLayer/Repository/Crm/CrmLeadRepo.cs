using ApiDisertatie.DataLayer.Models;
using System;
using System.Collections.Generic;

namespace ApiDisertatie.DataLayer.Repository
{
    public partial class CrmLeadRepo : GenericRepository<CrmLead>
    {
        private readonly DatabaseContext dbContext;

        public CrmLeadRepo(DatabaseContext context) : base(context)
        {
            dbContext = context;
        }
    }
}
