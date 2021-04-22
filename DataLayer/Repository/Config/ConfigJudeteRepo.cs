using ApiDisertatie.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ApiDisertatie.DataLayer.Repository
{
    public class ConfigJudeteRepo : GenericRepository<ConfigJudete>
    {
        private readonly DatabaseContext dbContext;

        public ConfigJudeteRepo(DatabaseContext context) : base(context)
        {
            dbContext = context;
        }

        public IQueryable<ConfigJudeteDropDown> GetAllDropDown()
        {
            return this.GetAll().Select(s => new ConfigJudeteDropDown() { IdJudet = s.IdJudet, NumeJudet = s.NumeJudet}).AsQueryable();
        }
    }
}
