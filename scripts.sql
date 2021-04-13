CREATE TABLE public.config_um
(
    id_um SERIAL,
    um character varying(255) COLLATE pg_catalog."default",
    in_user_id character varying(150) COLLATE pg_catalog."default" DEFAULT "current_user"(),
    in_date timestamp(6) without time zone DEFAULT now(),
    mod_user_id character varying(150) COLLATE pg_catalog."default",
    mod_date timestamp(6) without time zone,
    CONSTRAINT pk_ds_config_um PRIMARY KEY (id_um),
    CONSTRAINT uk_ds_config_um UNIQUE (um)
)
WITH (
    OIDS = FALSE
)
TABLESPACE pg_default;
ALTER TABLE public.config_um  OWNER to postgres;
GRANT ALL ON TABLE public.config_um TO postgres;
GRANT ALL ON TABLE public.config_um TO PUBLIC;


CREATE TABLE public.config_motive
(
    id_motiv SERIAL,
    motiv character varying(255) COLLATE pg_catalog."default",
    e_motiv_lead boolean default false,
    e_motiv_opportunity boolean default false,
    in_user_id character varying(150) COLLATE pg_catalog."default" DEFAULT "current_user"(),
    in_date timestamp(6) without time zone DEFAULT now(),
    mod_user_id character varying(150) COLLATE pg_catalog."default",
    mod_date timestamp(6) without time zone,
    CONSTRAINT pk_ds_config_motive PRIMARY KEY (id_motiv),
    CONSTRAINT uk_ds_config_motive UNIQUE (motiv)
)
WITH (
    OIDS = FALSE
)
TABLESPACE pg_default;
ALTER TABLE public.config_motive  OWNER to postgres;
GRANT ALL ON TABLE public.config_motive TO postgres;
GRANT ALL ON TABLE public.config_motive TO PUBLIC;


CREATE TABLE public.config_monede
(
    id_moneda SERIAL,
    moneda character varying(5) COLLATE pg_catalog."default",
    curs_valutar double precision DEFAULT 0,
    data_curs timestamp(6) without time zone,
    symbol character varying(5) COLLATE pg_catalog."default",
    in_user_id character varying(150) COLLATE pg_catalog."default" DEFAULT "current_user"(),
    in_date timestamp(6) without time zone DEFAULT now(),
    mod_user_id character varying(150) COLLATE pg_catalog."default",
    mod_date timestamp(6) without time zone,
    CONSTRAINT pk_ds_config_monede PRIMARY KEY (id_moneda),
    CONSTRAINT uk_ds_config_monede UNIQUE (moneda)
)
WITH (
    OIDS = FALSE
)
TABLESPACE pg_default;
ALTER TABLE public.config_monede OWNER to postgres;
GRANT ALL ON TABLE public.config_monede TO postgres;
GRANT ALL ON TABLE public.config_monede TO PUBLIC;


CREATE TABLE public.config_tari
(
    id_tara SERIAL,
    nume_tara character varying(255) COLLATE pg_catalog."default",
    cod_tara character varying(10) COLLATE pg_catalog."default",
    in_user_id character varying(150) COLLATE pg_catalog."default" DEFAULT "current_user"(),
    in_date timestamp(6) without time zone DEFAULT now(),
    mod_user_id character varying(150) COLLATE pg_catalog."default",
    mod_date timestamp(6) without time zone,
    CONSTRAINT pk_ds_config_tari PRIMARY KEY (id_tara),
    CONSTRAINT uk_ds_config_tari UNIQUE (nume_tara)
)
WITH (
    OIDS = FALSE
)
TABLESPACE pg_default;
ALTER TABLE public.config_tari OWNER to postgres;
GRANT ALL ON TABLE public.config_tari TO postgres;
GRANT ALL ON TABLE public.config_tari TO PUBLIC;


CREATE TABLE public.config_judete
(
    id_judet serial,
    nume_judet character varying(255) COLLATE pg_catalog."default",
    abreviere_judet character varying(5) COLLATE pg_catalog."default",
    tara_id int, 
    in_user_id character varying(150) COLLATE pg_catalog."default" DEFAULT "current_user"(),
    in_date timestamp(6) without time zone DEFAULT now(),
    mod_user_id character varying(150) COLLATE pg_catalog."default",
    mod_date timestamp(6) without time zone,
    CONSTRAINT pk_ds_config_judete PRIMARY KEY (id_judet),
    CONSTRAINT uk_ds_config_judete UNIQUE (nume_judet),
    CONSTRAINT fk_ds_config_judete_tara_id FOREIGN KEY (tara_id)
    REFERENCES public.config_tari (id_tara) MATCH SIMPLE
    ON UPDATE NO ACTION
    ON DELETE NO ACTION
)
WITH (
    OIDS = FALSE
)
TABLESPACE pg_default;
ALTER TABLE public.config_judete OWNER to postgres;
GRANT ALL ON TABLE public.config_judete TO postgres;
GRANT ALL ON TABLE public.config_judete TO PUBLIC;


CREATE TABLE public.config_localitati
(
    id_localitate serial,
    nume_localitate character varying(255) COLLATE pg_catalog."default",
    judet_id int,
    in_user_id character varying(150) COLLATE pg_catalog."default" DEFAULT "current_user"(),
    in_date timestamp(6) without time zone DEFAULT now(),
    mod_user_id character varying(150) COLLATE pg_catalog."default",
    mod_date timestamp(6) without time zone,
    CONSTRAINT pk_ds_config_localitati PRIMARY KEY (id_localitate),
    CONSTRAINT fk_ds_config_localitati_judet_id FOREIGN KEY (judet_id)
    REFERENCES public.config_judete (id_judet) MATCH SIMPLE
    ON UPDATE NO ACTION
    ON DELETE NO ACTION
)
WITH (
    OIDS = FALSE
)
TABLESPACE pg_default;
ALTER TABLE public.config_localitati OWNER to postgres;
GRANT ALL ON TABLE public.config_localitati TO postgres;
GRANT ALL ON TABLE public.config_localitati TO PUBLIC;



CREATE TABLE public.config_grupe
(
    id_grupa SERIAL,
    grupa character varying(255) COLLATE pg_catalog."default",
    in_user_id character varying(150) COLLATE pg_catalog."default" DEFAULT "current_user"(),
    in_date timestamp(6) without time zone DEFAULT now(),
    mod_user_id character varying(150) COLLATE pg_catalog."default",
    mod_date timestamp(6) without time zone,
    CONSTRAINT pk_ds_config_grupe PRIMARY KEY (id_grupa),
    CONSTRAINT uk_ds_config_grupe UNIQUE (grupa)
)
WITH (
    OIDS = FALSE
)
TABLESPACE pg_default;
ALTER TABLE public.config_grupe OWNER to postgres;
GRANT ALL ON TABLE public.config_grupe TO postgres;
GRANT ALL ON TABLE public.config_grupe TO PUBLIC;


CREATE TABLE public.crm_articole
(
    id_articol  SERIAL,
    denumire character varying(255) COLLATE pg_catalog."default",
    cod character varying(150) COLLATE pg_catalog."default",
    cod_ean character varying(25) COLLATE pg_catalog."default",
    is_inactiva boolean DEFAULT false,
    pretlista numeric DEFAULT 0,
    pretaman numeric DEFAULT 0,
    adaosmin numeric DEFAULT 0,
    um_id integer,
    grupa_id integer,
    moneda_id integer,
    in_user_id character varying(150) COLLATE pg_catalog."default" DEFAULT "current_user"(),
    in_date timestamp(6) without time zone DEFAULT now(),
    mod_user_id character varying(150) COLLATE pg_catalog."default",
    mod_date timestamp(6) without time zone,
    CONSTRAINT pk_ds_crm_articole PRIMARY KEY (id_articol),
    CONSTRAINT fk_ds_crm_articol_grupa FOREIGN KEY (grupa_id)
        REFERENCES public.config_grupe (id_grupa) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION,
    CONSTRAINT fk_ds_crm_articol_moneda FOREIGN KEY (moneda_id)
        REFERENCES public.config_monede (id_moneda) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION,
    CONSTRAINT fk_ds_crm_articol_um FOREIGN KEY (um_id)
        REFERENCES public.config_um (id_um) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
)
WITH (
    OIDS = TRUE
)
TABLESPACE pg_default;
ALTER TABLE public.crm_articole OWNER to postgres;
GRANT ALL ON TABLE public.crm_articole TO postgres;
GRANT ALL ON TABLE public.crm_articole TO PUBLIC;


CREATE TABLE public.crm_parteneri
(
    id_partener SERIAL,
    nume_partener text COLLATE pg_catalog."default",
    persoana_fizica boolean DEFAULT false,
    cod_fiscal character varying(50) COLLATE pg_catalog."default",
    cnp character varying(15) COLLATE pg_catalog."default",
    serie_bi character varying(15) COLLATE pg_catalog."default",
    pagina_web character varying(100) COLLATE pg_catalog."default",
    nr_angajati integer,
    cifra_de_afacere double precision DEFAULT 0,
    tara_id integer,
    judet_id integer,
    localitate_id integer,
    adresa character varying(200),
    cod_postal character varying(50) COLLATE pg_catalog."default",
    platitortva boolean DEFAULT false,
    dataplatitortva timestamp without time zone,
    dataverif timestamp without time zone,
    tva_incasare boolean DEFAULT false,
    data_tvaincasare timestamp without time zone,
    dataverif_tvainc timestamp without time zone,
    validat_vs boolean DEFAULT false,
    data_verif_vs timestamp without time zone,
    in_user_id character varying(150) COLLATE pg_catalog."default" DEFAULT "current_user"(),
    in_date timestamp(6) without time zone DEFAULT now(),
    mod_user_id character varying(150) COLLATE pg_catalog."default",
    mod_date timestamp(6) without time zone,
    CONSTRAINT pk_gen_partners PRIMARY KEY (id_partener),
    CONSTRAINT uk_gen_parteneri UNIQUE (cod_fiscal),
    CONSTRAINT uk_gen_parteneri_cnp UNIQUE (cnp), 
    CONSTRAINT fk_ds_crm_parteneri_judet_id FOREIGN KEY (judet_id)
        REFERENCES public.config_judete (id_judet) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION,
    CONSTRAINT fk_ds_crm_parteneri_localitate_id FOREIGN KEY (localitate_id)
        REFERENCES public.config_localitati (id_localitate) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION,
    CONSTRAINT fk_ds_crm_parteneri_tara_id FOREIGN KEY (tara_id)
        REFERENCES public.config_tari (id_tara) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
)
WITH (
    OIDS = FALSE
)
TABLESPACE pg_default;
ALTER TABLE public.crm_parteneri OWNER to postgres;
GRANT ALL ON TABLE public.crm_parteneri TO postgres;
GRANT ALL ON TABLE public.crm_parteneri TO PUBLIC;


CREATE TABLE public.crm_partener_contacte
(
    id_partener_contact SERIAL,
    partener_id integer,
    nume_contact character varying(250) COLLATE pg_catalog."default",
    prenume_contact character varying(250) COLLATE pg_catalog."default",
    telefon character varying(30) COLLATE pg_catalog."default",
    email character varying(255) COLLATE pg_catalog."default",
    functia character varying(255) COLLATE pg_catalog."default",
    note text COLLATE pg_catalog."default",
    in_user_id character varying(150) COLLATE pg_catalog."default" DEFAULT "current_user"(),
    in_date timestamp(6) without time zone DEFAULT now(),
    mod_user_id character varying(150) COLLATE pg_catalog."default",
    mod_date timestamp(6) without time zone,
    CONSTRAINT pk_ds_crm_partener_contacte PRIMARY KEY (id_partener_contact),
    CONSTRAINT fk_ds_crm_partener_contacte_crm_parteneri FOREIGN KEY (partener_id)
        REFERENCES public.crm_parteneri (id_partener) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
)
WITH (
    OIDS = FALSE
)
TABLESPACE pg_default;
ALTER TABLE public.crm_partener_contacte OWNER to postgres;
GRANT ALL ON TABLE public.crm_partener_contacte TO postgres;
GRANT ALL ON TABLE public.crm_partener_contacte TO PUBLIC;



CREATE TABLE public.crm_lista_notite
(
    id_notita SERIAL,
    notita_desc character varying(250) COLLATE pg_catalog."default",
    e_finalizata boolean default false,
    in_user_id character varying(150) COLLATE pg_catalog."default" DEFAULT "current_user"(),
    in_date timestamp(6) without time zone DEFAULT now(),
    mod_user_id character varying(150) COLLATE pg_catalog."default",
    mod_date timestamp(6) without time zone,
    CONSTRAINT pk_ds_crm_lista_notite PRIMARY KEY (id_notita)
)
WITH (
    OIDS = FALSE
)
TABLESPACE pg_default;
ALTER TABLE public.crm_lista_notite OWNER to postgres;
GRANT ALL ON TABLE public.crm_lista_notite TO postgres;
GRANT ALL ON TABLE public.crm_lista_notite TO PUBLIC;

 crm_lead_status


 CREATE TABLE public.crm_lead_status
(
    id_lead_status SERIAL,
    status_nume character varying(100) COLLATE pg_catalog."default",
    in_user_id character varying(150) COLLATE pg_catalog."default" DEFAULT "current_user"(),
    in_date timestamp(6) without time zone DEFAULT now(),
    mod_user_id character varying(150) COLLATE pg_catalog."default",
    mod_date timestamp(6) without time zone,
    CONSTRAINT pk_ds_crm_lead_status PRIMARY KEY (id_lead_status)
)
WITH (
    OIDS = FALSE
)
TABLESPACE pg_default;
ALTER TABLE public.crm_lead_status OWNER to postgres;
GRANT ALL ON TABLE public.crm_lead_status TO postgres;
GRANT ALL ON TABLE public.crm_lead_status TO PUBLIC;


CREATE TABLE public.crm_leads
(
    id_lead SERIAL,
    lead_nume character varying(255) COLLATE pg_catalog."default",
    lead_descriere character varying(255) COLLATE pg_catalog."default",
    persoana_fizica boolean DEFAULT false,
    cod_fiscal character varying(25) COLLATE pg_catalog."default",
    email character varying(255) COLLATE pg_catalog."default",
    telefon character varying(25) COLLATE pg_catalog."default",
    hot_or_not boolean DEFAULT false,
    note_sursa text COLLATE pg_catalog."default",
    contact_firstname text COLLATE pg_catalog."default",
    contact_lastname text COLLATE pg_catalog."default",
    lead_status_id integer,
    partener_id integer DEFAULT 0,
    e_calificat boolean DEFAULT false,
    e_inactiv boolean DEFAULT false,
    e_convertit boolean DEFAULT false,
    motiv_id integer,
    in_user_id character varying(150) COLLATE pg_catalog."default" DEFAULT "current_user"(),
    in_date timestamp(6) without time zone DEFAULT now(),
    mod_user_id character varying(150) COLLATE pg_catalog."default",
    mod_date timestamp(6) without time zone,
    CONSTRAINT pk_ds_crm_leads PRIMARY KEY (id_lead),
    CONSTRAINT fk_ds_crm_lead_partener_id FOREIGN KEY (partener_id)
        REFERENCES public.crm_parteneri (id_partener) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION,
    CONSTRAINT fk_ds_crm_leads_lead_status_id FOREIGN KEY (lead_status_id)
        REFERENCES public.crm_lead_status (id_lead_status) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION,
    CONSTRAINT fk_crm_opportunities_config_motive FOREIGN KEY (motiv_id)
    REFERENCES public.config_motive (id_motiv) MATCH SIMPLE
    ON UPDATE NO ACTION
    ON DELETE NO ACTION
)
WITH (
    OIDS = FALSE
)
TABLESPACE pg_default;
ALTER TABLE public.crm_leads    OWNER to postgres;
GRANT ALL ON TABLE public.crm_leads TO postgres;
GRANT ALL ON TABLE public.crm_leads TO PUBLIC;
-- Index: idx_crm_leads_id_lead
-- DROP INDEX public.idx_crm_leads_id_lead;

CREATE INDEX idx_ds_crm_leads_id_lead
    ON public.crm_leads USING btree
    (id_lead ASC NULLS LAST)
    TABLESPACE pg_default;



 CREATE TABLE public.crm_opportunity_status
(
    id_opportunity_status SERIAL,
    status_nume character varying(100) COLLATE pg_catalog."default",
    in_user_id character varying(150) COLLATE pg_catalog."default" DEFAULT "current_user"(),
    in_date timestamp(6) without time zone DEFAULT now(),
    mod_user_id character varying(150) COLLATE pg_catalog."default",
    mod_date timestamp(6) without time zone,
    CONSTRAINT pk_ds_crm_opportunity_status PRIMARY KEY (id_opportunity_status)
)
WITH (
    OIDS = FALSE
)
TABLESPACE pg_default;
ALTER TABLE public.crm_opportunity_status OWNER to postgres;
GRANT ALL ON TABLE public.crm_opportunity_status TO postgres;
GRANT ALL ON TABLE public.crm_opportunity_status TO PUBLIC;


 CREATE TABLE public.crm_opportunity_faza
(
    id_opportunity_faza SERIAL,
    faza_nume character varying(100) COLLATE pg_catalog."default",
    in_user_id character varying(150) COLLATE pg_catalog."default" DEFAULT "current_user"(),
    in_date timestamp(6) without time zone DEFAULT now(),
    mod_user_id character varying(150) COLLATE pg_catalog."default",
    mod_date timestamp(6) without time zone,
    CONSTRAINT pk_ds_crm_opportunity_faza PRIMARY KEY (id_opportunity_faza)
)
WITH (
    OIDS = FALSE
)
TABLESPACE pg_default;
ALTER TABLE public.crm_opportunity_faza OWNER to postgres;
GRANT ALL ON TABLE public.crm_opportunity_faza TO postgres;
GRANT ALL ON TABLE public.crm_opportunity_faza TO PUBLIC;



CREATE TABLE public.crm_opportunities
(
    id_opportunity SERIAL,
    opp_descriere text COLLATE pg_catalog."default",
    probabilitatea double precision DEFAULT 0,
    suma double precision DEFAULT 0,
    hot_or_not boolean DEFAULT false,
    competitori text COLLATE pg_catalog."default",
    partener_id integer,
    partener_contact_id integer,
    status_id integer,
    faza_id integer,
    motiv_id integer,
    in_user_id character varying(150) COLLATE pg_catalog."default" DEFAULT "current_user"(),
    in_date timestamp(6) without time zone DEFAULT now(),
    mod_user_id character varying(150) COLLATE pg_catalog."default",
    mod_date timestamp(6) without time zone,
    CONSTRAINT pk_opportunities PRIMARY KEY (id_opportunity),
        CONSTRAINT fk_crm_opportunities_crm_parteneri FOREIGN KEY (partener_id)
        REFERENCES public.crm_parteneri (id_partener) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION,
    CONSTRAINT fk_crm_opportunities_crm_partener_contacte FOREIGN KEY (partener_contact_id)
        REFERENCES public.crm_partener_contacte (id_partener_contact) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION,
    CONSTRAINT fk_ds_crm_opportunities_crm_opportunity_status FOREIGN KEY (status_id)
        REFERENCES public.crm_opportunity_status (id_opportunity_status) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION,
    CONSTRAINT fk_ds_crm_opportunities_crm_opportunity_faza FOREIGN KEY (faza_id)
        REFERENCES public.crm_opportunity_faza (id_opportunity_faza) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION,
    CONSTRAINT fk_crm_opportunities_config_motive FOREIGN KEY (motiv_id)
        REFERENCES public.config_motive (id_motiv) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION

)
WITH (
    OIDS = FALSE
)
TABLESPACE pg_default;
ALTER TABLE public.crm_opportunities  OWNER to postgres;
GRANT ALL ON TABLE public.crm_opportunities TO postgres;
GRANT ALL ON TABLE public.crm_opportunities TO PUBLIC;




CREATE TABLE public.app_utilizatori
(
    id_utilizator serial,
    nume character varying(255) COLLATE pg_catalog."default" NOT NULL,
    prenume character varying(255) COLLATE pg_catalog."default" NOT NULL,
    email character varying(255) COLLATE pg_catalog."default" NOT NULL,
    parola character varying(255) COLLATE pg_catalog."default" NOT NULL,
    db_nume character varying(255) COLLATE pg_catalog."default" NOT NULL,
    db_parola character varying(255) COLLATE pg_catalog."default" NOT NULL,
    e_inactiv boolean DEFAULT false,
    cod_recuperare_parola character varying(100),
    in_user_id character varying(150) COLLATE pg_catalog."default" DEFAULT "current_user"(),
    in_date timestamp(6) without time zone DEFAULT now(),
    mod_user_id character varying(150) COLLATE pg_catalog."default",
    mod_date timestamp(6) without time zone,

    CONSTRAINT pk_ds_app_utilizatori PRIMARY KEY (id_utilizator),
    CONSTRAINT uk_ds_app_utilizatori_email UNIQUE (email)
)
WITH (
    OIDS = FALSE
)
TABLESPACE pg_default;
ALTER TABLE public.app_utilizatori OWNER to postgres;
GRANT ALL ON TABLE public.app_utilizatori TO postgres;
GRANT ALL ON TABLE public.app_utilizatori TO PUBLIC;


INSERT INTO config_tari (nume_tara, cod_tara)
VALUES
    ('Austria','AT'),
    ('Belgia','BE'),
    ('Bulgaria','BG'),
    ('Cehia','CZ'),
    ('Cipru','CY'),
    ('Croatia','HR'),
    ('Danemarca','DK'),
    ('Estonia','EE'),
    ('Finlanda','FI'),
    ('Franta','FR'),
    ('Germania','DE'),
    ('Grecia','EL'),
    ('Irlanda','IE'),
    ('Italia','IT'),
    ('Letonia','LV'),
    ('Lituania','LT'),
    ('Luxemburg','LU'),
    ('Malta','MT'),
    ('Olanda','NL'),
    ('Polonia','PL'),
    ('Portugalia','PT'),
    ('Romania','RO'),
    ('Slovacia','SK'),
    ('Slovenia','SI'),
    ('Spania','ES'),
    ('Suedia','SE'),
    ('Ungaria','HU');

INSERT INTO config_um (um)
VALUES
('BUC'),
('L'),
('KG')

INSERT INTO config_judete(nume_judet, abreviere_judet , tara_id)
VALUES
    ('Timis','TM', 22)
    ('Bucuresti','B', 22)
