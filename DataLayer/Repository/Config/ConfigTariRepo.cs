using ApiDisertatie.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ApiDisertatie.DataLayer.Repository
{
    public partial class ConfigTariRepo : GenericRepository<ConfigTari>
    {
        private readonly DatabaseContext dbContext;

        public ConfigTariRepo(DatabaseContext context) : base(context)
        {
            dbContext = context;
        }

        public virtual IQueryable<ConfigTariDropDown> GetAllDropDown()
        {
            return this.GetAll().Select(s => new ConfigTariDropDown() { IdTara = s.IdTara, NumeTara = s.NumeTara}).AsQueryable();
        }
        public virtual IQueryable<ConfigTariTable> GetAllTable()
        {
            return this.GetAll().Select(s => new ConfigTariTable() { 
                IdTara = s.IdTara, 
                NumeTara = s.NumeTara,
                CodTara = s.CodTara,
                InUserId = s.InUserId,
                InDate = s.InDate,
                ModUserId = s.ModUserId,
                ModDate = s.ModDate

            }).AsQueryable();
        }
    }
}
