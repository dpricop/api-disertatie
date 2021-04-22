using ApiDisertatie.DataLayer.Models;
using System;
using System.Collections.Generic;

namespace ApiDisertatie.DataLayer.Repository
{
    public partial class ConfigTariRepo : GenericRepository<ConfigTari>
    {
        private readonly DatabaseContext dbContext;

        public ConfigTariRepo(DatabaseContext context) : base(context)
        {
            dbContext = context;
        }
    }
}
