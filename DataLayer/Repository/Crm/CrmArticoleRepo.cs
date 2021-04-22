using ApiDisertatie.DataLayer.Models;
using System;
using System.Collections.Generic;

namespace ApiDisertatie.DataLayer.Repository
{
    public partial class CrmArticoleRepo : GenericRepository<CrmArticole>
    {
        private readonly DatabaseContext dbContext;

        public CrmArticoleRepo(DatabaseContext context) : base(context)
        {
            dbContext = context;
        }
    }
}
