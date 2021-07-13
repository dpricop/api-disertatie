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

        public IQueryable<CrmOferteDetaliiTable> GetAllTable()
        {
            return this.GetAll().Select(c => new CrmOferteDetaliiTable()
            {
                IdOfertaDetalii = c.IdOfertaDetalii,
                OfertaAntentId  = c.OfertaAntentId,
                ArticolId  = c.ArticolId,
                Articole = new CrmArticole() { 
                    IdArticol = c.Articole.IdArticol,
                    Denumire = c.Articole.Denumire,
                    Cod = c.Articole.Cod,
                    CodEan = c.Articole.CodEan,
                    IsInactiva = c.Articole.IsInactiva,
                    Pretlista = c.Articole.Pretlista,
                    Pretaman = c.Articole.Pretlista,
                    Adaosmin = c.Articole.Adaosmin,
                    UmId = c.Articole.UmId,
                    GrupaId = c.Articole.GrupaId,
                    MonedaId = c.Articole.MonedaId,
                    Um = new ConfigUm() { 
                        IdUm = c.Articole.Um.IdUm, 
                        Um = c.Articole.Um.Um,
                    },
                    Grupa =  new ConfigGrupe() { 
                        IdGrupa = c.Articole.Grupa.IdGrupa,
                        Grupa = c.Articole.Grupa.Grupa,
                    },
                    Moneda =  new ConfigMonede() { 
                        IdMoneda = c.Articole.Moneda.IdMoneda,
                        Moneda = c.Articole.Moneda.Moneda,
                    }
                },
                Cantitate = c.Cantitate,
                PretUnitar = c.PretUnitar,
                PretTotalNet  = c.PretTotalNet,
                InUserId  = c.InUserId,
                InDate = c.InDate,
                ModUserId  = c.ModUserId,
                ModDate  = c.ModDate,
            });
        }
    }
}
