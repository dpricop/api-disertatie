using ApiDisertatie.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ApiDisertatie.DataLayer.Repository
{
    public partial class CrmOferteAntentRepo : GenericRepository<CrmOferteAntent>
    {
        private readonly DatabaseContext dbContext;

        public CrmOferteAntentRepo(DatabaseContext context) : base(context)
        {
            dbContext = context;
        }
    }
}
