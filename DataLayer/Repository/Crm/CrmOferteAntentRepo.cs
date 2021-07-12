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

        public IQueryable<CrmOferteAntentTable> GetAllTable() {


            return this.GetAll().Select(c => new CrmOferteAntentTable()
            {

                IdOfertaAntent = c.IdOfertaAntent,
                FurnizorNume = c.FurnizorNume,
                FurnizorCif = c.FurnizorCif,
                FurnizorNrRegCom = c.FurnizorNrRegCom,
                FurnizorCont = c.FurnizorCont,
                FurnizorBanca = c.FurnizorBanca,
                PartenerId = c.PartenerId,
                NumePartener = c.Partener.NumePartener,
                OpportunityId = c.OpportunityId,
                DataEmiterii = c.DataEmiterii,
                DataExpirarii = c.DataExpirarii,
                OfertaAcceptata = c.OfertaAcceptata,
                OfertaRespinsa = c.OfertaRespinsa,
                InUserId = c.InUserId,
                InDate = c.InDate,
                ModUserId = c.ModUserId,
                ModDate = c.ModDate,

    });
        }
    }
}
