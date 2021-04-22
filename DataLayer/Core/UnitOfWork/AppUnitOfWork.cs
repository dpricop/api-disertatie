using ApiDisertatie.DataLayer.Repository;
using System.Threading.Tasks;

namespace ApiDisertatie.DataLayer.UnitOfWork
{
	public class AppUnitOfWork : IUnitOfWork
	{
		#region - Declarations
		private readonly DatabaseContext dbContext;
		public AppUtilizatoriRepo appUtilizatoriRepo { get; set; }
		public ConfigGrupeRepo configGrupeRepo { get; set; }
		public ConfigJudeteRepo configJudeteRepo { get; set; }
		public ConfigLocalitatiRepo configLocalitatiRepo { get; set; }
		public ConfigMonedeRepo configMonedeRepo { get; set; }
		public ConfigMotiveRepo configMotiveRepo { get; set; }
		public ConfigTariRepo configTariRepo { get; set; }
		public ConfigUmRepo configUmRepo { get; set; }
		public CrmArticoleRepo crmArticoleRepo { get; set; }
		public CrmLeadRepo crmLeadRepo { get; set; }
		public CrmLeadStatusRepo crmLeadStatusRepo { get; set; }
		public CrmListaNotiteRepo crmListaNotiteRepo { get; set; }
		public CrmOpportunityFazaRepo crmOpportunityFazaRepo { get; set; }
		public CrmOpportunityRepo crmOpportunityRepo { get; set; }
		public CrmOpportunityStatusRepo crmOpportunityStatusRepo { get; set; }
		public CrmPartenerContacteRepo crmPartenerContacteRepo { get; set; }
		public CrmParteneriRepo crmParteneriRepo { get; set; }
		#endregion

		#region - Constructor
		public AppUnitOfWork(DatabaseContext DbContext)
		{
			dbContext = DbContext;
			appUtilizatoriRepo = new AppUtilizatoriRepo(dbContext);
			configGrupeRepo = new ConfigGrupeRepo(dbContext);
			configJudeteRepo = new ConfigJudeteRepo(dbContext);
			configLocalitatiRepo = new ConfigLocalitatiRepo(dbContext);
			configMonedeRepo = new ConfigMonedeRepo(dbContext);
			configMotiveRepo = new ConfigMotiveRepo(dbContext);
			configTariRepo = new ConfigTariRepo(dbContext);
			configUmRepo = new ConfigUmRepo(dbContext);
			crmArticoleRepo = new CrmArticoleRepo(dbContext);
			crmLeadRepo = new CrmLeadRepo(dbContext);
			crmLeadStatusRepo = new CrmLeadStatusRepo(dbContext);
			crmListaNotiteRepo = new CrmListaNotiteRepo(dbContext);
			crmOpportunityFazaRepo = new CrmOpportunityFazaRepo(dbContext);
			crmOpportunityRepo = new CrmOpportunityRepo(dbContext);
			crmOpportunityStatusRepo = new CrmOpportunityStatusRepo(dbContext);
			crmPartenerContacteRepo = new CrmPartenerContacteRepo(dbContext);
			crmParteneriRepo = new CrmParteneriRepo(dbContext);
		}

		#endregion

		public int SaveChanges()
		{
			return dbContext.SaveChanges();
		}

		public void Dispose()
		{
			if (dbContext != null)			
				dbContext.Dispose();
		}
	}
}