using ApiDisertatie.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ApiDisertatie.DataLayer.Repository
{
    public partial class ConfigLocalitatiRepo : GenericRepository<ConfigLocalitati>
    {
        private readonly DatabaseContext dbContext;

        public ConfigLocalitatiRepo(DatabaseContext context) : base(context)
        {
            dbContext = context;
        }
        public IQueryable<ConfigLocalitatiDropDown> GetAllDropDown()
        {
            return this.GetAll().Select(s => new ConfigLocalitatiDropDown() { IdLocalitate = s.IdLocalitate, NumeLocalitate = s.NumeLocalitate }).AsQueryable();
        }
    }
}
