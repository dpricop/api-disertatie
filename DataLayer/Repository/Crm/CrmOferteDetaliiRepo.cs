using ApiDisertatie.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ApiDisertatie.DataLayer.Repository
{
    public partial class CrmOferteDetaliiRepo : GenericRepository<CrmOferteDetalii>
    {
        private readonly DatabaseContext dbContext;

        public CrmOferteDetaliiRepo(DatabaseContext context) : base(context)
        {
            dbContext = context;
        }
    }
}
