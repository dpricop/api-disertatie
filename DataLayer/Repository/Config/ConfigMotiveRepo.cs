using ApiDisertatie.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ApiDisertatie.DataLayer.Repository
{
    public partial class ConfigMotiveRepo : GenericRepository<ConfigMotive>
    {
        private readonly DatabaseContext dbContext;

        public ConfigMotiveRepo(DatabaseContext context) : base(context)
        {
            dbContext = context;
        }

        public IQueryable<ConfigMotiveDropDown> GetAllDropDown()
        {
            return this.GetAll().Select(s => new ConfigMotiveDropDown() { IdMotiv = s.IdMotiv, Motiv = s.Motiv}).AsQueryable();
        }
    }
}
