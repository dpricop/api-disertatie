using ApiDisertatie.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ApiDisertatie.DataLayer.Repository
{
    public class CrmParteneriRepo : GenericRepository<CrmParteneri>
    {
        private readonly DatabaseContext dbContext;

        public CrmParteneriRepo(DatabaseContext context) : base(context)
        {
            dbContext = context;
        }
        public virtual IQueryable<CrmParteneriDropDown> GetAllDropDown()
        {
            return this.GetAll().Select(s => new CrmParteneriDropDown(){ IdPartener = s.IdPartener, NumePartener = s.NumePartener }).AsQueryable();
        }

        public virtual IQueryable<CrmParteneri> GetAllTable()
        {
            return this.GetAll();
        }
    }

}
