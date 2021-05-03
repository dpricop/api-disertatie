using ApiDisertatie.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ApiDisertatie.DataLayer.Repository
{
    public partial class CrmLeadStatusRepo : GenericRepository<CrmLeadStatus>
    {
        private readonly DatabaseContext dbContext;

        public CrmLeadStatusRepo(DatabaseContext context) : base(context)
        {
            dbContext = context;
        }

        public virtual IQueryable<CrmLeadStatusDropDown> GetAllDropDown()
        {
            return this.GetAll().Select(s => new CrmLeadStatusDropDown() { IdLeadStatus = s.IdLeadStatus, StatusNume = s.StatusNume }).AsQueryable();
        }

        public virtual IQueryable<CrmLeadStatus> GetAllTable()
        {
            return this.GetAll();
        }
    }
}
