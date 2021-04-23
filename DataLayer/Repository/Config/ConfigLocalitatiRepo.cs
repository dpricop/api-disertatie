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

        public IQueryable<ConfigLocalitatiTable> GetAllTable()
        {
            return this.GetAll().Select(s => new ConfigLocalitatiTable() { 
                IdLocalitate = s.IdLocalitate,
                NumeLocalitate = s.NumeLocalitate,
                JudetId = s.JudetId,
                InUserId = s.InUserId,
                InDate = s.InDate,
                ModUserId = s.ModUserId,
                ModDate = s.ModDate
            }).AsQueryable();
        }
    }
}
