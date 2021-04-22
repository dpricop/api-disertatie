using ApiDisertatie.DataLayer.Models;
using System;
using System.Collections.Generic;

namespace ApiDisertatie.DataLayer.Repository
{
    public class CrmPartenerContacteRepo : GenericRepository<CrmPartenerContacte>
    {
        private readonly DatabaseContext dbContext;

        public CrmPartenerContacteRepo(DatabaseContext context) : base(context)
        {
            dbContext = context;
        }
    }
}
