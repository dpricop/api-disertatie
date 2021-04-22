using ApiDisertatie.DataLayer.Models;
using System;
using System.Collections.Generic;


namespace ApiDisertatie.DataLayer.Repository
{
    public partial class ConfigMonedeRepo : GenericRepository<ConfigMonede>
    {
        private readonly DatabaseContext dbContext;
        public ConfigMonedeRepo(DatabaseContext context) : base(context)
        {
            dbContext = context;
        }
    }
}
