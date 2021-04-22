using ApiDisertatie.DataLayer.Models;
using System;
using System.Collections.Generic;

namespace ApiDisertatie.DataLayer.Repository
{
    public class AppUtilizatoriRepo : GenericRepository<AppUtilizatori>
    {
        private readonly DatabaseContext dbContext;

        public AppUtilizatoriRepo(DatabaseContext context) : base(context)
        {
            dbContext = context;
        }
    }
}
