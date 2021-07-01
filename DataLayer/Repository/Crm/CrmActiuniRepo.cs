using ApiDisertatie.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ApiDisertatie.DataLayer.Repository
{
    public partial class CrmActiuniRepo : GenericRepository<CrmActiuni>
    {
        private readonly DatabaseContext dbContext;

        public CrmActiuniRepo(DatabaseContext context) : base(context)
        {
            dbContext = context;
        }

        public virtual  IQueryable<CrmActiuniTable> GetAllTable()
        {
            return this.GetAll().Select(s => new CrmActiuniTable()
            {
                IdActiune = s.IdActiune,
                Descriere = s.Descriere,
                DataInceput = s.DataInceput,
                DataSfarsit = s.DataSfarsit,
                EFinalizata = s.EFinalizata,
                TipActiuneId = s.TipActiuneId,
                TipActiune = s.TipActiune.TipActiune,
                LeadId = s.LeadId,
                LeadNume = s.Lead.LeadNume,
                OpportunityId = s.OpportunityId,
                OppDescriere = s.Opportunity.OppDescriere,
                InUserId = s.InUserId,
                InDate = s.InDate,
                ModUserId = s.ModUserId,
                ModDate = s.ModDate
            }).AsQueryable();
        }


    }

}