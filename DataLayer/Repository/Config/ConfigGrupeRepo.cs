using ApiDisertatie.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ApiDisertatie.DataLayer.Repository
{
    public class ConfigGrupeRepo : GenericRepository<ConfigGrupe>
    {
        private readonly DatabaseContext dbContext;

        public ConfigGrupeRepo(DatabaseContext context) : base(context)
        {
            dbContext = context;
        }

        public virtual IQueryable<ConfigGrupeDropDown> GetAllDropDown()
        {
            return this.GetAll().Select(s => new ConfigGrupeDropDown() {IdGrupa = s.IdGrupa, Grupa = s.Grupa }).AsQueryable();
        }

        public virtual IQueryable<ConfigGrupeTable> GetAllTable()
        {
            return this.GetAll().Select(s => new ConfigGrupeTable() {
                IdGrupa = s.IdGrupa,
                Grupa = s.Grupa,
                InUserId = s.InUserId,
                InDate = s.InDate,
                ModUserId = s.ModUserId,
                ModDate = s.ModDate

            }).AsQueryable();
        }
    }
}
