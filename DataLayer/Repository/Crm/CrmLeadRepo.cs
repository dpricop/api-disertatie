using ApiDisertatie.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ApiDisertatie.DataLayer.Repository
{
    public partial class CrmLeadRepo : GenericRepository<CrmLead>
    {
        private readonly DatabaseContext dbContext;

        public CrmLeadRepo(DatabaseContext context) : base(context)
        {
            dbContext = context;
        }
        public virtual IQueryable<CrmLeadDropDown> GetAllDropDown()
        {
            return this.GetAll().Select(s => new CrmLeadDropDown() { IdLead = s.IdLead, LeadNume = s.LeadNume}).AsQueryable();
        }

        public virtual IQueryable<CrmLead> GetAllTable()
        {
            return this.GetAll().Select(s => new CrmLead()
            {

                IdLead = s.IdLead,
                LeadNume = s.LeadNume,
                LeadDescriere = s.LeadDescriere,
                PersoanaFizica = s.PersoanaFizica,
                CodFiscal = s.CodFiscal,
                Email = s.Email,
                Telefon = s.Telefon,
                HotOrNot = s.HotOrNot,
                NoteSursa = s.NoteSursa,
                ContactNume = s.ContactNume,
                ContactPrenume = s.ContactPrenume,
                LeadStatusId = s.LeadStatusId,
                PartenerId = s.PartenerId,
                ECalificat = s.ECalificat,
                EInactiv = s.EInactiv,
                EConvertit = s.EConvertit,
                MotivId = s.MotivId,
                InUserId = s.InUserId,
                InDate = s.InDate,
                ModUserId = s.ModUserId,
                ModDate = s.ModDate
            }).AsQueryable();
        }
    }
}
