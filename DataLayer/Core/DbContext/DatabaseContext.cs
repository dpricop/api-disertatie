using ApiDisertatie.DataLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiDisertatie.DataLayer
{
    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {

        }
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) 
        {

        }

        public virtual DbSet<AppUtilizatori> AppUtilizatori { get; set; }
        public virtual DbSet<ConfigGrupe> ConfigGrupe { get; set; }
        public virtual DbSet<ConfigJudete> ConfigJudete { get; set; }
        public virtual DbSet<ConfigLocalitati> ConfigLocalitati { get; set; }
        public virtual DbSet<ConfigMonede> ConfigMonede { get; set; }
        public virtual DbSet<ConfigMotive> ConfigMotive { get; set; }
        public virtual DbSet<ConfigTari> ConfigTari { get; set; }
        public virtual DbSet<ConfigUm> ConfigUm { get; set; }
        public virtual DbSet<CrmArticole> CrmArticole { get; set; }
        public virtual DbSet<CrmLead> CrmLead { get; set; }
        public virtual DbSet<CrmLeadStatus> CrmLeadStatus { get; set; }
        public virtual DbSet<CrmListaNotite> CrmListaNotite { get; set; }
        public virtual DbSet<CrmOpportunity> CrmOpportunity { get; set; }
        public virtual DbSet<CrmOpportunityFaza> CrmOpportunityFaza { get; set; }
        public virtual DbSet<CrmOpportunityStatus> CrmOpportunityStatus { get; set; }
        public virtual DbSet<CrmPartenerContacte> CrmPartenerContacte { get; set; }
        public virtual DbSet<CrmParteneri> CrmParteneri { get; set; }
        public virtual DbSet<CrmActiuni> CrmActiuni { get; set; }
        public virtual DbSet<CrmOferteAntent> CrmOferteAntent { get; set; }
        public virtual DbSet<CrmOferteDetalii> CrmOferteDetalii { get; set; }
        public virtual DbSet<CrmTipActiune> crmTipActiune { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "en_US.UTF-8");

            modelBuilder.Entity<AppUtilizatori>(entity =>
            {
                entity.HasKey(e => e.IdUtilizator)
                    .HasName("pk_ds_app_utilizatori");

                entity.ToTable("app_utilizatori");

                entity.HasIndex(e => e.Email, "uk_ds_app_utilizatori_email")
                    .IsUnique();

                entity.Property(e => e.IdUtilizator).HasColumnName("id_utilizator");

                entity.Property(e => e.CodRecuperareParola)
                    .HasMaxLength(100)
                    .HasColumnName("cod_recuperare_parola");

                entity.Property(e => e.DbNume)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("db_nume");

                entity.Property(e => e.DbParola)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("db_parola");

                entity.Property(e => e.EInactiv)
                    .HasColumnName("e_inactiv")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("email");

                entity.Property(e => e.InDate)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("in_date")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.InUserId)
                    .HasMaxLength(150)
                    .HasColumnName("in_user_id")
                    .HasDefaultValueSql("\"current_user\"()");

                entity.Property(e => e.ModDate)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("mod_date");

                entity.Property(e => e.ModUserId)
                    .HasMaxLength(150)
                    .HasColumnName("mod_user_id");

                entity.Property(e => e.Nume)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("nume");

                entity.Property(e => e.Parola)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("parola");

                entity.Property(e => e.Prenume)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("prenume");
            });

            modelBuilder.Entity<ConfigGrupe>(entity =>
            {
                entity.HasKey(e => e.IdGrupa)
                    .HasName("pk_ds_config_grupe");

                entity.ToTable("config_grupe");

                entity.HasIndex(e => e.Grupa, "uk_ds_config_grupe")
                    .IsUnique();

                entity.Property(e => e.IdGrupa).HasColumnName("id_grupa");

                entity.Property(e => e.Grupa)
                    .HasMaxLength(255)
                    .HasColumnName("grupa");

                entity.Property(e => e.InDate)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("in_date")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.InUserId)
                    .HasMaxLength(150)
                    .HasColumnName("in_user_id")
                    .HasDefaultValueSql("\"current_user\"()");

                entity.Property(e => e.ModDate)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("mod_date");

                entity.Property(e => e.ModUserId)
                    .HasMaxLength(150)
                    .HasColumnName("mod_user_id");
            });

            modelBuilder.Entity<ConfigJudete>(entity =>
            {
                entity.HasKey(e => e.IdJudet)
                    .HasName("pk_ds_config_judete");

                entity.ToTable("config_judete");

                entity.HasIndex(e => e.NumeJudet, "uk_ds_config_judete")
                    .IsUnique();

                entity.Property(e => e.IdJudet).HasColumnName("id_judet");

                entity.Property(e => e.InDate)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("in_date")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.InUserId)
                    .HasMaxLength(150)
                    .HasColumnName("in_user_id")
                    .HasDefaultValueSql("\"current_user\"()");

                entity.Property(e => e.ModDate)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("mod_date");

                entity.Property(e => e.ModUserId)
                    .HasMaxLength(150)
                    .HasColumnName("mod_user_id");

                entity.Property(e => e.NumeJudet)
                    .HasMaxLength(255)
                    .HasColumnName("nume_judet");

                entity.Property(e => e.TaraId).HasColumnName("tara_id");

                entity.HasOne(d => d.Tara)
                    .WithMany(p => p.ConfigJudetes)
                    .HasForeignKey(d => d.TaraId)
                    .HasConstraintName("fk_ds_config_judete_tara_id");
            });

            modelBuilder.Entity<ConfigLocalitati>(entity =>
            {
                entity.HasKey(e => e.IdLocalitate)
                    .HasName("pk_ds_config_localitati");

                entity.ToTable("config_localitati");

                entity.Property(e => e.IdLocalitate).HasColumnName("id_localitate");

                entity.Property(e => e.InDate)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("in_date")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.InUserId)
                    .HasMaxLength(150)
                    .HasColumnName("in_user_id")
                    .HasDefaultValueSql("\"current_user\"()");

                entity.Property(e => e.JudetId).HasColumnName("judet_id");

                entity.Property(e => e.ModDate)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("mod_date");

                entity.Property(e => e.ModUserId)
                    .HasMaxLength(150)
                    .HasColumnName("mod_user_id");

                entity.Property(e => e.NumeLocalitate)
                    .HasMaxLength(255)
                    .HasColumnName("nume_localitate");

                entity.HasOne(d => d.Judet)
                    .WithMany(p => p.ConfigLocalitatis)
                    .HasForeignKey(d => d.JudetId)
                    .HasConstraintName("fk_ds_config_localitati_judet_id");
            });

            modelBuilder.Entity<ConfigMonede>(entity =>
            {
                entity.HasKey(e => e.IdMoneda)
                    .HasName("pk_ds_config_monede");

                entity.ToTable("config_monede");

                entity.HasIndex(e => e.Moneda, "uk_ds_config_monede")
                    .IsUnique();

                entity.Property(e => e.IdMoneda).HasColumnName("id_moneda");

                entity.Property(e => e.InDate)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("in_date")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.InUserId)
                    .HasMaxLength(150)
                    .HasColumnName("in_user_id")
                    .HasDefaultValueSql("\"current_user\"()");

                entity.Property(e => e.ModDate)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("mod_date");

                entity.Property(e => e.ModUserId)
                    .HasMaxLength(150)
                    .HasColumnName("mod_user_id");

                entity.Property(e => e.Moneda)
                    .HasMaxLength(5)
                    .HasColumnName("moneda");
            });

            modelBuilder.Entity<ConfigMotive>(entity =>
            {
                entity.HasKey(e => e.IdMotiv)
                    .HasName("pk_ds_config_motive");

                entity.ToTable("config_motive");

                entity.HasIndex(e => e.Motiv, "uk_ds_config_motive")
                    .IsUnique();

                entity.Property(e => e.IdMotiv).HasColumnName("id_motiv");

                entity.Property(e => e.EMotivLead)
                    .HasColumnName("e_motiv_lead")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.EMotivOpportunity)
                    .HasColumnName("e_motiv_opportunity")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.InDate)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("in_date")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.InUserId)
                    .HasMaxLength(150)
                    .HasColumnName("in_user_id")
                    .HasDefaultValueSql("\"current_user\"()");

                entity.Property(e => e.ModDate)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("mod_date");

                entity.Property(e => e.ModUserId)
                    .HasMaxLength(150)
                    .HasColumnName("mod_user_id");

                entity.Property(e => e.Motiv)
                    .HasMaxLength(255)
                    .HasColumnName("motiv");
            });

            modelBuilder.Entity<ConfigTari>(entity =>
            {
                entity.HasKey(e => e.IdTara)
                    .HasName("pk_ds_config_tari");

                entity.ToTable("config_tari");

                entity.HasIndex(e => e.NumeTara, "uk_ds_config_tari")
                    .IsUnique();

                entity.Property(e => e.IdTara).HasColumnName("id_tara");

                entity.Property(e => e.CodTara)
                    .HasMaxLength(10)
                    .HasColumnName("cod_tara");

                entity.Property(e => e.InDate)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("in_date")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.InUserId)
                    .HasMaxLength(150)
                    .HasColumnName("in_user_id")
                    .HasDefaultValueSql("\"current_user\"()");

                entity.Property(e => e.ModDate)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("mod_date");

                entity.Property(e => e.ModUserId)
                    .HasMaxLength(150)
                    .HasColumnName("mod_user_id");

                entity.Property(e => e.NumeTara)
                    .HasMaxLength(255)
                    .HasColumnName("nume_tara");
            });

            modelBuilder.Entity<ConfigUm>(entity =>
            {
                entity.HasKey(e => e.IdUm)
                    .HasName("pk_ds_config_um");

                entity.ToTable("config_um");

                entity.HasIndex(e => e.Um, "uk_ds_config_um")
                    .IsUnique();

                entity.Property(e => e.IdUm).HasColumnName("id_um");

                entity.Property(e => e.InDate)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("in_date")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.InUserId)
                    .HasMaxLength(150)
                    .HasColumnName("in_user_id")
                    .HasDefaultValueSql("\"current_user\"()");

                entity.Property(e => e.ModDate)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("mod_date");

                entity.Property(e => e.ModUserId)
                    .HasMaxLength(150)
                    .HasColumnName("mod_user_id");

                entity.Property(e => e.Um)
                    .HasMaxLength(255)
                    .HasColumnName("um");
            });

            modelBuilder.Entity<CrmArticole>(entity =>
            {
                entity.HasKey(e => e.IdArticol)
                    .HasName("pk_ds_crm_articole");

                entity.ToTable("crm_articole");

                entity.Property(e => e.IdArticol).HasColumnName("id_articol");

                entity.Property(e => e.Adaosmin)
                    .HasColumnName("adaosmin")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Cod)
                    .HasMaxLength(150)
                    .HasColumnName("cod");

                entity.Property(e => e.CodEan)
                    .HasMaxLength(25)
                    .HasColumnName("cod_ean");

                entity.Property(e => e.Denumire)
                    .HasMaxLength(255)
                    .HasColumnName("denumire");

                entity.Property(e => e.GrupaId).HasColumnName("grupa_id");

                entity.Property(e => e.InDate)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("in_date")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.InUserId)
                    .HasMaxLength(150)
                    .HasColumnName("in_user_id")
                    .HasDefaultValueSql("\"current_user\"()");

                entity.Property(e => e.IsInactiva)
                    .HasColumnName("is_inactiva")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.ModDate)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("mod_date");

                entity.Property(e => e.ModUserId)
                    .HasMaxLength(150)
                    .HasColumnName("mod_user_id");

                entity.Property(e => e.MonedaId).HasColumnName("moneda_id");

                entity.Property(e => e.Pretaman)
                    .HasColumnName("pretaman")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Pretlista)
                    .HasColumnName("pretlista")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UmId).HasColumnName("um_id");

                entity.HasOne(d => d.Grupa)
                    .WithMany(p => p.CrmArticoles)
                    .HasForeignKey(d => d.GrupaId)
                    .HasConstraintName("fk_ds_crm_articol_grupa");

                entity.HasOne(d => d.Moneda)
                    .WithMany(p => p.CrmArticoles)
                    .HasForeignKey(d => d.MonedaId)
                    .HasConstraintName("fk_ds_crm_articol_moneda");

                entity.HasOne(d => d.Um)
                    .WithMany(p => p.CrmArticoles)
                    .HasForeignKey(d => d.UmId)
                    .HasConstraintName("fk_ds_crm_articol_um");
            });

            modelBuilder.Entity<CrmLead>(entity =>
            {
                entity.HasKey(e => e.IdLead)
                    .HasName("pk_ds_crm_leads");

                entity.ToTable("crm_leads");

                entity.Property(e => e.IdLead).HasColumnName("id_lead");

                entity.Property(e => e.CodFiscal)
                    .HasMaxLength(25)
                    .HasColumnName("cod_fiscal");

                entity.Property(e => e.ContactNume).HasColumnName("contact_nume");

                entity.Property(e => e.ContactPrenume).HasColumnName("contact_prenume");

                entity.Property(e => e.ECalificat)
                    .HasColumnName("e_calificat")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.EConvertit)
                    .HasColumnName("e_convertit")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.EInactiv)
                    .HasColumnName("e_inactiv")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .HasColumnName("email");

                entity.Property(e => e.HotOrNot)
                    .HasColumnName("hot_or_not")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.InDate)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("in_date")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.InUserId)
                    .HasMaxLength(150)
                    .HasColumnName("in_user_id")
                    .HasDefaultValueSql("\"current_user\"()");

                entity.Property(e => e.LeadDescriere)
                    .HasMaxLength(255)
                    .HasColumnName("lead_descriere");

                entity.Property(e => e.LeadNume)
                    .HasMaxLength(255)
                    .HasColumnName("lead_nume");

                entity.Property(e => e.LeadStatusId).HasColumnName("lead_status_id");

                entity.Property(e => e.ModDate)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("mod_date");

                entity.Property(e => e.ModUserId)
                    .HasMaxLength(150)
                    .HasColumnName("mod_user_id");

                entity.Property(e => e.MotivId).HasColumnName("motiv_id");

                entity.Property(e => e.NoteSursa).HasColumnName("note_sursa");

                entity.Property(e => e.PartenerId)
                    .HasColumnName("partener_id")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PersoanaFizica)
                    .HasColumnName("persoana_fizica")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Telefon)
                    .HasMaxLength(25)
                    .HasColumnName("telefon");

                entity.HasOne(d => d.LeadStatus)
                    .WithMany(p => p.CrmLeads)
                    .HasForeignKey(d => d.LeadStatusId)
                    .HasConstraintName("fk_ds_crm_leads_lead_status_id");

                entity.HasOne(d => d.Motiv)
                    .WithMany(p => p.CrmLeads)
                    .HasForeignKey(d => d.MotivId)
                    .HasConstraintName("fk_crm_opportunities_config_motive");

                entity.HasOne(d => d.Partener)
                    .WithMany(p => p.CrmLeads)
                    .HasForeignKey(d => d.PartenerId)
                    .HasConstraintName("fk_ds_crm_lead_partener_id");
            });

            modelBuilder.Entity<CrmLeadStatus>(entity =>
            {
                entity.HasKey(e => e.IdLeadStatus)
                    .HasName("pk_ds_crm_lead_status");

                entity.ToTable("crm_lead_status");

                entity.Property(e => e.IdLeadStatus).HasColumnName("id_lead_status");

                entity.Property(e => e.InDate)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("in_date")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.InUserId)
                    .HasMaxLength(150)
                    .HasColumnName("in_user_id")
                    .HasDefaultValueSql("\"current_user\"()");

                entity.Property(e => e.ModDate)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("mod_date");

                entity.Property(e => e.ModUserId)
                    .HasMaxLength(150)
                    .HasColumnName("mod_user_id");

                entity.Property(e => e.StatusNume)
                    .HasMaxLength(100)
                    .HasColumnName("status_nume");
            });

            modelBuilder.Entity<CrmListaNotite>(entity =>
            {
                entity.HasKey(e => e.IdNotita)
                    .HasName("pk_ds_crm_lista_notite");

                entity.ToTable("crm_lista_notite");

                entity.Property(e => e.IdNotita).HasColumnName("id_notita");

                entity.Property(e => e.EFinalizata)
                    .HasColumnName("e_finalizata")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.InDate)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("in_date")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.InUserId)
                    .HasMaxLength(150)
                    .HasColumnName("in_user_id")
                    .HasDefaultValueSql("\"current_user\"()");

                entity.Property(e => e.ModDate)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("mod_date");

                entity.Property(e => e.ModUserId)
                    .HasMaxLength(150)
                    .HasColumnName("mod_user_id");

                entity.Property(e => e.NotitaDesc)
                    .HasMaxLength(250)
                    .HasColumnName("notita_desc");
            });

            modelBuilder.Entity<CrmOpportunity>(entity =>
            {
                entity.HasKey(e => e.IdOpportunity)
                    .HasName("pk_opportunities");

                entity.ToTable("crm_opportunities");

                entity.Property(e => e.IdOpportunity).HasColumnName("id_opportunity");

                entity.Property(e => e.Competitori).HasColumnName("competitori");

                entity.Property(e => e.FazaId).HasColumnName("faza_id");

                entity.Property(e => e.HotOrNot)
                    .HasColumnName("hot_or_not")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.InDate)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("in_date")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.InUserId)
                    .HasMaxLength(150)
                    .HasColumnName("in_user_id")
                    .HasDefaultValueSql("\"current_user\"()");

                entity.Property(e => e.ModDate)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("mod_date");

                entity.Property(e => e.ModUserId)
                    .HasMaxLength(150)
                    .HasColumnName("mod_user_id");

                entity.Property(e => e.MotivId).HasColumnName("motiv_id");

                entity.Property(e => e.OppDescriere).HasColumnName("opp_descriere");

                entity.Property(e => e.PartenerContactId).HasColumnName("partener_contact_id");

                entity.Property(e => e.PartenerId).HasColumnName("partener_id");

                entity.Property(e => e.Probabilitatea)
                    .HasColumnName("probabilitatea")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.Suma)
                    .HasColumnName("suma")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.Faza)
                    .WithMany(p => p.CrmOpportunities)
                    .HasForeignKey(d => d.FazaId)
                    .HasConstraintName("fk_ds_crm_opportunities_crm_opportunity_faza");

                entity.HasOne(d => d.Motiv)
                    .WithMany(p => p.CrmOpportunities)
                    .HasForeignKey(d => d.MotivId)
                    .HasConstraintName("fk_crm_opportunities_config_motive");

                entity.HasOne(d => d.PartenerContact)
                    .WithMany(p => p.CrmOpportunities)
                    .HasForeignKey(d => d.PartenerContactId)
                    .HasConstraintName("fk_crm_opportunities_crm_partener_contacte");

                entity.HasOne(d => d.Partener)
                    .WithMany(p => p.CrmOpportunities)
                    .HasForeignKey(d => d.PartenerId)
                    .HasConstraintName("fk_crm_opportunities_crm_parteneri");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.CrmOpportunities)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("fk_ds_crm_opportunities_crm_opportunity_status");
            });

            modelBuilder.Entity<CrmOpportunityFaza>(entity =>
            {
                entity.HasKey(e => e.IdOpportunityFaza)
                    .HasName("pk_ds_crm_opportunity_faza");

                entity.ToTable("crm_opportunity_faza");

                entity.Property(e => e.IdOpportunityFaza).HasColumnName("id_opportunity_faza");

                entity.Property(e => e.FazaNume)
                    .HasMaxLength(100)
                    .HasColumnName("faza_nume");

                entity.Property(e => e.InDate)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("in_date")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.InUserId)
                    .HasMaxLength(150)
                    .HasColumnName("in_user_id")
                    .HasDefaultValueSql("\"current_user\"()");

                entity.Property(e => e.ModDate)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("mod_date");

                entity.Property(e => e.ModUserId)
                    .HasMaxLength(150)
                    .HasColumnName("mod_user_id");
            });

            modelBuilder.Entity<CrmOpportunityStatus>(entity =>
            {
                entity.HasKey(e => e.IdOpportunityStatus)
                    .HasName("pk_ds_crm_opportunity_status");

                entity.ToTable("crm_opportunity_status");

                entity.Property(e => e.IdOpportunityStatus).HasColumnName("id_opportunity_status");

                entity.Property(e => e.InDate)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("in_date")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.InUserId)
                    .HasMaxLength(150)
                    .HasColumnName("in_user_id")
                    .HasDefaultValueSql("\"current_user\"()");

                entity.Property(e => e.ModDate)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("mod_date");

                entity.Property(e => e.ModUserId)
                    .HasMaxLength(150)
                    .HasColumnName("mod_user_id");

                entity.Property(e => e.StatusNume)
                    .HasMaxLength(100)
                    .HasColumnName("status_nume");
            });

            modelBuilder.Entity<CrmPartenerContacte>(entity =>
            {
                entity.HasKey(e => e.IdPartenerContact)
                    .HasName("pk_ds_crm_partener_contacte");

                entity.ToTable("crm_partener_contacte");

                entity.Property(e => e.IdPartenerContact).HasColumnName("id_partener_contact");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .HasColumnName("email");

                entity.Property(e => e.Functia)
                    .HasMaxLength(255)
                    .HasColumnName("functia");

                entity.Property(e => e.InDate)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("in_date")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.InUserId)
                    .HasMaxLength(150)
                    .HasColumnName("in_user_id")
                    .HasDefaultValueSql("\"current_user\"()");

                entity.Property(e => e.ModDate)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("mod_date");

                entity.Property(e => e.ModUserId)
                    .HasMaxLength(150)
                    .HasColumnName("mod_user_id");

                entity.Property(e => e.Note).HasColumnName("note");

                entity.Property(e => e.NumeContact)
                    .HasMaxLength(250)
                    .HasColumnName("nume_contact");

                entity.Property(e => e.PartenerId).HasColumnName("partener_id");

                entity.Property(e => e.PrenumeContact)
                    .HasMaxLength(250)
                    .HasColumnName("prenume_contact");

                entity.Property(e => e.Telefon)
                    .HasMaxLength(30)
                    .HasColumnName("telefon");

                entity.HasOne(d => d.Partener)
                    .WithMany(p => p.CrmPartenerContactes)
                    .HasForeignKey(d => d.PartenerId)
                    .HasConstraintName("fk_ds_crm_partener_contacte_crm_parteneri");
            });

            modelBuilder.Entity<CrmParteneri>(entity =>
            {
                entity.HasKey(e => e.IdPartener)
                    .HasName("pk_gen_partners");

                entity.ToTable("crm_parteneri");

                entity.HasIndex(e => e.CodFiscal, "uk_gen_parteneri")
                    .IsUnique();

                entity.HasIndex(e => e.Cnp, "uk_gen_parteneri_cnp")
                    .IsUnique();

                entity.Property(e => e.IdPartener).HasColumnName("id_partener");

                entity.Property(e => e.Adresa)
                    .HasMaxLength(200)
                    .HasColumnName("adresa");

                entity.Property(e => e.CifraDeAfacere)
                    .HasColumnName("cifra_de_afacere")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Cnp)
                    .HasMaxLength(15)
                    .HasColumnName("cnp");

                entity.Property(e => e.CodFiscal)
                    .HasMaxLength(50)
                    .HasColumnName("cod_fiscal");

                entity.Property(e => e.CodPostal)
                    .HasMaxLength(50)
                    .HasColumnName("cod_postal");

                entity.Property(e => e.InDate)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("in_date")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.InUserId)
                    .HasMaxLength(150)
                    .HasColumnName("in_user_id")
                    .HasDefaultValueSql("\"current_user\"()");

                entity.Property(e => e.JudetId).HasColumnName("judet_id");

                entity.Property(e => e.LocalitateId).HasColumnName("localitate_id");

                entity.Property(e => e.ModDate)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("mod_date");

                entity.Property(e => e.ModUserId)
                    .HasMaxLength(150)
                    .HasColumnName("mod_user_id");

                entity.Property(e => e.NrAngajati).HasColumnName("nr_angajati");

                entity.Property(e => e.NumePartener).HasColumnName("nume_partener");

                entity.Property(e => e.PaginaWeb)
                    .HasMaxLength(100)
                    .HasColumnName("pagina_web");

                entity.Property(e => e.PersoanaFizica)
                    .HasColumnName("persoana_fizica")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Platitortva)
                    .HasColumnName("platitortva")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.SerieBi)
                    .HasMaxLength(15)
                    .HasColumnName("serie_bi");

                entity.Property(e => e.TaraId).HasColumnName("tara_id");

                entity.Property(e => e.TvaIncasare)
                    .HasColumnName("tva_incasare")
                    .HasDefaultValueSql("false");

                entity.HasOne(d => d.Judet)
                    .WithMany(p => p.CrmParteneris)
                    .HasForeignKey(d => d.JudetId)
                    .HasConstraintName("fk_ds_crm_parteneri_judet_id");

                entity.HasOne(d => d.Localitate)
                    .WithMany(p => p.CrmParteneris)
                    .HasForeignKey(d => d.LocalitateId)
                    .HasConstraintName("fk_ds_crm_parteneri_localitate_id");

                entity.HasOne(d => d.Tara)
                    .WithMany(p => p.CrmParteneris)
                    .HasForeignKey(d => d.TaraId)
                    .HasConstraintName("fk_ds_crm_parteneri_tara_id");
            });

            modelBuilder.Entity<CrmActiuni>(entity =>
            {
                entity.HasKey(e => e.IdActiune)
                    .HasName("pk_crm_actiuni");

                entity.ToTable("crm_actiuni");

                entity.Property(e => e.IdActiune).HasColumnName("id_actiune");

                entity.Property(e => e.DataInceput).HasColumnName("data_inceput");

                entity.Property(e => e.DataSfarsit).HasColumnName("data_sfarsit");

                entity.Property(e => e.Descriere).HasColumnName("descriere");

                entity.Property(e => e.EFinalizata)
                    .HasColumnName("e_finalizata")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.InDate)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("in_date")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.InUserId)
                    .HasMaxLength(150)
                    .HasColumnName("in_user_id")
                    .HasDefaultValueSql("\"current_user\"()");

                entity.Property(e => e.LeadId).HasColumnName("lead_id");

                entity.Property(e => e.ModDate)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("mod_date");

                entity.Property(e => e.ModUserId)
                    .HasMaxLength(150)
                    .HasColumnName("mod_user_id");

                entity.Property(e => e.OpportunityId).HasColumnName("opportunity_id");

                entity.Property(e => e.TipActiuneId).HasColumnName("tip_actiune_id");

                entity.HasOne(d => d.TipActiune)
                .WithMany()
                .HasForeignKey(d => d.TipActiuneId)
                .HasConstraintName("fk_crm_actiuni_crm_tip_actiuni");

                entity.HasOne(d => d.Lead)
                .WithMany()
                .HasForeignKey(d => d.LeadId)
                .HasConstraintName("fk_crm_actiuni_leads");

                entity.HasOne(d => d.Opportunity)
                    .WithMany()
                    .HasForeignKey(d => d.OpportunityId)
                    .HasConstraintName("fk_crm_actiuni_opportunities");
            });

            modelBuilder.Entity<CrmTipActiune>(entity =>
            {
                entity.HasKey(e => e.IdTipActiune)
                    .HasName("pk_crm_tip_actiune");

                entity.ToTable("crm_tip_actiune");

                entity.HasIndex(e => e.TipActiune, "uk_crm_tip_actiune_tip_actiune")
                    .IsUnique();

                entity.Property(e => e.IdTipActiune).HasColumnName("id_tip_actiune");

                entity.Property(e => e.InDate)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("in_date")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.InUserId)
                    .HasMaxLength(150)
                    .HasColumnName("in_user_id")
                    .HasDefaultValueSql("\"current_user\"()");

                entity.Property(e => e.ModDate)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("mod_date");

                entity.Property(e => e.ModUserId)
                    .HasMaxLength(150)
                    .HasColumnName("mod_user_id");

                entity.Property(e => e.TipActiune)
                    .HasMaxLength(255)
                    .HasColumnName("tip_actiune");
            });

            modelBuilder.Entity<CrmOferteAntent>(entity =>
            {
                entity.HasKey(e => e.IdOfertaAntent)
                    .HasName("pk_crm_oferte_antent");

                entity.ToTable("crm_oferte_antent");

                entity.Property(e => e.IdOfertaAntent).HasColumnName("id_oferta_antent");

                entity.Property(e => e.DataEmiterii)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("data_emiterii")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.DataExpirarii)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("data_expirarii")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.FurnizorBanca)
                    .HasMaxLength(255)
                    .HasColumnName("furnizor_banca");

                entity.Property(e => e.FurnizorCif)
                    .HasMaxLength(255)
                    .HasColumnName("furnizor_cif");

                entity.Property(e => e.FurnizorCont)
                    .HasMaxLength(255)
                    .HasColumnName("furnizor_cont");

                entity.Property(e => e.FurnizorNrRegCom)
                    .HasMaxLength(255)
                    .HasColumnName("furnizor_nr_reg_com");

                entity.Property(e => e.FurnizorNume)
                    .HasMaxLength(255)
                    .HasColumnName("furnizor_nume");

                entity.Property(e => e.InDate)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("in_date")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.InUserId)
                    .HasMaxLength(150)
                    .HasColumnName("in_user_id")
                    .HasDefaultValueSql("\"current_user\"()");

                entity.Property(e => e.ModDate)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("mod_date");

                entity.Property(e => e.ModUserId)
                    .HasMaxLength(150)
                    .HasColumnName("mod_user_id");

                entity.Property(e => e.OfertaAcceptata).HasColumnName("oferta_acceptata");

                entity.Property(e => e.OfertaRespinsa).HasColumnName("oferta_respinsa");

                entity.Property(e => e.OpportunityId).HasColumnName("opportunity_id");

                entity.Property(e => e.PartenerId).HasColumnName("partener_id");

                entity.HasOne(d => d.Partener)
                    .WithMany()
                    .HasForeignKey(d => d.PartenerId)
                    .HasConstraintName("fk_crm_oferte_antent_parteneri");
            });

            modelBuilder.Entity<CrmOferteDetalii>(entity =>
            {
                entity.HasKey(e => e.IdOfertaDetalii)
                    .HasName("pk_crm_oferte_detalii");

                entity.ToTable("crm_oferte_detalii");

                entity.Property(e => e.IdOfertaDetalii).HasColumnName("id_oferta_detalii");

                entity.Property(e => e.ArticolId).HasColumnName("articol_id");

                entity.Property(e => e.Cantitate).HasColumnName("cantitate");

                entity.Property(e => e.InDate)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("in_date")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.InUserId)
                    .HasMaxLength(150)
                    .HasColumnName("in_user_id")
                    .HasDefaultValueSql("\"current_user\"()");

                entity.Property(e => e.ModDate)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("mod_date");

                entity.Property(e => e.ModUserId)
                    .HasMaxLength(150)
                    .HasColumnName("mod_user_id");

                entity.Property(e => e.OfertaAntentId).HasColumnName("oferta_antent_id");

                entity.Property(e => e.PretTotalNet)
                    .HasColumnType("money")
                    .HasColumnName("pret_total_net");

                entity.Property(e => e.PretUnitar)
                    .HasColumnType("money")
                    .HasColumnName("pret_unitar");

                entity.HasOne(d => d.OfertaAntent)
                    .WithMany(p => p.CrmOferteDetaliis)
                    .HasForeignKey(d => d.OfertaAntentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_crm_oferte_detalii_crm_oferte_antent");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
