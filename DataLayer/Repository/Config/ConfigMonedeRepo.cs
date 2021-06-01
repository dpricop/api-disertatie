using ApiDisertatie.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ApiDisertatie.DataLayer.Repository
{
    public partial class ConfigMonedeRepo : GenericRepository<ConfigMonede>
    {
        private readonly DatabaseContext dbContext;
        public ConfigMonedeRepo(DatabaseContext context) : base(context)
        {
            dbContext = context;
        }

        public IQueryable<ConfigMonedeDropDown> GetAllDropDown()
        {
            return this.GetAll().Select(s => new ConfigMonedeDropDown() { IdMoneda = s.IdMoneda, Moneda = s.Moneda}).AsQueryable();
        }
        public IQueryable<ConfigMonedeTable> GetAllTable()
        {
            return this.GetAll().Select(s => new ConfigMonedeTable() {
                IdMoneda = s.IdMoneda,
                Moneda = s.Moneda,
                InUserId = s.InUserId,
                InDate = s.InDate,
                ModUserId = s.ModUserId,
                ModDate = s.ModDate
            }).AsQueryable();
        }
    }
}
