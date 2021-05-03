using ApiDisertatie.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ApiDisertatie.DataLayer.Repository
{
    public partial class CrmArticoleRepo : GenericRepository<CrmArticole>
    {
        private readonly DatabaseContext dbContext;

        public CrmArticoleRepo(DatabaseContext context) : base(context)
        {
            dbContext = context;
        }

        public virtual IQueryable<CrmArticoleDropDown> GetAllDropDown()
        {
            return this.GetAll().Select(s => new CrmArticoleDropDown() { IdArticol  = s.IdArticol, Denumire = s.Denumire}).AsQueryable();
        }

        public virtual IQueryable<CrmArticole> GetAllTable()
        {
            return this.GetAll();
        }
    }
}
