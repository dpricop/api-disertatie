using ApiDisertatie.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ApiDisertatie.DataLayer.Repository
{
    public class CrmPartenerContacteRepo : GenericRepository<CrmPartenerContacte>
    {
        private readonly DatabaseContext dbContext;

        public CrmPartenerContacteRepo(DatabaseContext context) : base(context)
        {
            dbContext = context;
        }

        public virtual IQueryable<CrmPartenerContacteDropDown> GetAllDropDown()
        {
            return this.GetAll().Select(s => new CrmPartenerContacteDropDown() { 
                IdPartenerContact = s.IdPartenerContact, 
                NumeContact = s.NumeContact,
                PrenumeContact = s.PrenumeContact
            }).AsQueryable();
        }

        public virtual IQueryable<CrmPartenerContacteTable> GetAllTable()
        {
            return this.GetAll().Select(s => new CrmPartenerContacteTable() {
                IdPartenerContact = s.IdPartenerContact,
                PartenerId = s.PartenerId,
                NumePartener = s.Partener.NumePartener,
                NumeContact = s.NumeContact,
                PrenumeContact = s.PrenumeContact,
                Telefon = s.Telefon,
                Email = s.Email,
                Functia = s.Functia,
                Note = s.Note,
                InUserId = s.InUserId,
                InDate = s.InDate,
                ModUserId = s.ModUserId,
                ModDate = s.ModDate,
            });
        }
    }
}
