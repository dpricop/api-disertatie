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

        public virtual IQueryable<CrmParteneriTable> GetAllTable()
        {

            return this.GetAll().Select(s => new CrmParteneriTable() { 
                IdPartener = s.IdPartener,
                NumePartener = s.NumePartener,
                PersoanaFizica = s.PersoanaFizica,
                CodFiscal = s.CodFiscal,
                Cnp = s.Cnp,
                SerieBi = s.SerieBi,
                PaginaWeb = s.PaginaWeb,
                NrAngajati = s.NrAngajati,
                CifraDeAfacere = s.CifraDeAfacere,
                TaraId = s.TaraId,
                NumeTara = s.Tara.NumeTara,
                JudetId = s.JudetId,
                NumeJudet = s.Judet.NumeJudet,
                LocalitateId = s.LocalitateId,
                NumeLocalitate = s.Localitate.NumeLocalitate,
                Adresa = s.Adresa,
                CodPostal = s.CodPostal,
                Platitortva = s.Platitortva,
                Dataplatitortva = s.Dataplatitortva,
                Dataverif = s.Dataverif,
                TvaIncasare = s.TvaIncasare,
                DataTvaincasare = s.DataTvaincasare,
                DataverifTvainc = s.DataverifTvainc,
                ValidatVs = s.ValidatVs,
                DataVerifVs = s.DataVerifVs,
                InUserId = s.InUserId,
                InDate = s.InDate,
                ModUserId = s.ModUserId,
                ModDate = s.ModDate

    }).AsQueryable();
        }
    }

}
