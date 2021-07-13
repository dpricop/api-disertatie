using ApiDisertatie.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ApiDisertatie.DataLayer.Repository
{
    public partial class CrmTipActiuneRepo : GenericRepository<CrmTipActiune>
    {
        private readonly DatabaseContext dbContext;

        public CrmTipActiuneRepo(DatabaseContext context) : base(context)
        {
            dbContext = context;
        }

        public IQueryable<CrmTipActiune> GetAllTable() {

            return this.GetAll().OrderByDescending(c => c.IdTipActiune);
        
        }
    }
}