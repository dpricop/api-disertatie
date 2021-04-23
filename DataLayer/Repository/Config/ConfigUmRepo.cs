using ApiDisertatie.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ApiDisertatie.DataLayer.Repository
{
    public class ConfigUmRepo : GenericRepository<ConfigUm>
    {
        private readonly DatabaseContext dbContext;

        public ConfigUmRepo(DatabaseContext context) : base(context)
        {
            dbContext = context;
        }

        public virtual IQueryable<ConfigUmDropDown> GetAllDropDown()
        {
            return this.GetAll().Select(s => new ConfigUmDropDown() { IdUm = s.IdUm, Um = s.Um }).AsQueryable();
        }

        public IQueryable<ConfigUmTable> GetAllTable()
        {
            return this.GetAll().Select(s => new ConfigUmTable() { 
                IdUm = s.IdUm,
                Um = s.Um,
                InUserId = s.InUserId,
                InDate = s.InDate,
                ModUserId = s.ModUserId,
                ModDate = s.ModDate
            }).AsQueryable();
        }
    }
}