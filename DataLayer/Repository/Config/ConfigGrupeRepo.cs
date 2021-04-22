using ApiDisertatie.DataLayer.Models;
using System;
using System.Collections.Generic;

namespace ApiDisertatie.DataLayer.Repository
{
    public class ConfigGrupeRepo : GenericRepository<ConfigGrupe>
    {
        private readonly DatabaseContext dbContext;

        public ConfigGrupeRepo(DatabaseContext context) : base(context)
        {
            dbContext = context;
        }
    }
}
