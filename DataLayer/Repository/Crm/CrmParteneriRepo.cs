using ApiDisertatie.DataLayer.Models;
using System;
using System.Collections.Generic;

namespace ApiDisertatie.DataLayer.Repository
{
    public class CrmParteneriRepo : GenericRepository<CrmParteneri>
    {
        private readonly DatabaseContext dbContext;

        public CrmParteneriRepo(DatabaseContext context) : base(context)
        {
            dbContext = context;
        }
    }

}
