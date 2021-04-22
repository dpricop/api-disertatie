using ApiDisertatie.DataLayer.Models;
using System;
using System.Collections.Generic;

namespace ApiDisertatie.DataLayer.Repository
{
    public partial class ConfigMotiveRepo : GenericRepository<ConfigMotive>
    {
        private readonly DatabaseContext dbContext;

        public ConfigMotiveRepo(DatabaseContext context) : base(context)
        {
            dbContext = context;
        }
    }
}
