using ApiDisertatie.DataLayer.Models;
using System;
using System.Collections.Generic;

namespace ApiDisertatie.DataLayer.Repository
{
    public class ConfigJudeteRepo : GenericRepository<ConfigJudete>
    {
        private readonly DatabaseContext dbContext;

        public ConfigJudeteRepo(DatabaseContext context) : base(context)
        {
            dbContext = context;
        }
    }
}
