using ApiDisertatie.DataLayer.Models;
using System;
using System.Collections.Generic;

namespace ApiDisertatie.DataLayer.Repository
{
    public partial class ConfigLocalitatiRepo : GenericRepository<ConfigLocalitati>
    {
        private readonly DatabaseContext dbContext;

        public ConfigLocalitatiRepo(DatabaseContext context) : base(context)
        {
            dbContext = context;
        }
    }
}
