using ApiDisertatie.DataLayer.Models;
using System;
using System.Collections.Generic;

namespace ApiDisertatie.DataLayer.Repository
{
    public class ConfigUmRepo : GenericRepository<ConfigUm>
    {
        private readonly DatabaseContext dbContext;

        public ConfigUmRepo(DatabaseContext context) : base(context)
        {
            dbContext = context;
        }
    }
}
