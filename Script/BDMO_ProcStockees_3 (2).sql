/* -----------------------------------------------------------
					Procédures Stockées BDMO_GSB
   ----------------------------------------------------------- */

USE BDMO_GSB
go

/* -----------------------------------------------------------
							Visiteurs
   ----------------------------------------------------------- */

/*PROC LISTE VISITEURS*/

create proc BDMO_ListeVisiteur
AS
select VIS_MATRICULE as 'MATRICULE', VIS_NOM as 'NOM', VIS_PRENOM as 'PRENOM', VIS_DATEEMBAUCHE as 'DATE EMBAUCHE' from VISITEUR
ORDER BY VIS_NOM
go

/*PROC LISTE VISITEUR DETAILLE*/

create proc BDMO_ListeVisiteurDetail
	@matricule char(4)
AS
select VIS_ADRESSE + ', ' + VIS_CP + ' ' + VIS_VILLE AS 'Adresse' from VISITEUR where VIS_MATRICULE = @matricule
go

/*PROC LISTE VISITEUR DATE EMBAUCHE*/

create proc BDMO_ListeVisiteurDate
	@dateEmbauche date
AS
select VIS_MATRICULE as 'MATRICULE', VIS_NOM as 'NOM', VIS_PRENOM as 'PRENOM' from VISITEUR where VIS_DATEEMBAUCHE = @dateEmbauche
go

/*PROC NOMBRE VISITEURS*/

create proc BDMO_NBVisiteur
AS
select COUNT(*) AS NbVisiteurs from VISITEUR
go

/*PROC NOMBRE VISITEURS PAR DATE*/
create proc BDMO_NbVisiteurParDate
	@dateEmbauche date
AS
select COUNT(*) AS NbVisiteurs from VISITEUR where VIS_DATEEMBAUCHE = @dateEmbauche
go

/*PROC LISTE MATRICULE VISITEURS*/

create proc BDMO_ListeMatriculeVisiteur
AS
select VIS_MATRICULE, CONCAT(VIS_MATRICULE, ' '+  '(' + VIS_NOM + ' ' + VIS_PRENOM + ')') AS NomPrenom
from VISITEUR
go

/* -----------------------------------------------------------
						   Praticiens
   ----------------------------------------------------------- */

/*PROC LISTE PRATICIENS DETAILLE*/

create proc BDMO_ListePraticienDetail
	@code varchar(25)
AS
select PRA_ADRESSE + ', ' + PRA_CP + ' ' + PRA_VILLE AS 'Adresse' from PRATICIEN where PRA_NUM = @code
go


/*PROC LISTE PRATICIENS*/

create proc BDMO_ListePraticiens
AS
select PRA_NUM AS 'NUM', PRA_NOM AS 'NOM' , PRA_PRENOM as 'PRENOM', TYP_LIBELLE as 'LIBELE' from PRATICIEN INNER JOIN TYPE_PRATICIEN ON TYPE_PRATICIEN.TYP_CODE = PRATICIEN.TYP_CODE
ORDER BY PRA_NOM
go

/*PROC LIEU PRATICIENS*/
create proc BDMO_lieupraticiens
	@code varchar(25)
AS
SELECT TYP_LIEU FROM TYPE_PRATICIEN INNER JOIN PRATICIEN ON TYPE_PRATICIEN.TYP_CODE = PRATICIEN.TYP_CODE
WHERE PRA_NUM = @code
go

/*PROC LISTE NUM PRATICIENS*/
create proc BDMO_ListeNumPrac
AS
select PRA_NUM, CONCAT(PRA_NUM ,' ' +  '(' + PRA_NOM + ' ' + PRA_PRENOM + ')') AS NumNom
from PRATICIEN
go

/*PROC NOMBRE PRATICIENS*/

create proc BDMO_NBPraticiens
AS
select COUNT(*) AS NbPraticiens  from PRATICIEN
go

/*PROC NOMBRE PRATICIENS PAR FONCTION*/

create proc BDMO_NBPraticiensfonction
@fonction varchar(25)
AS
select COUNT(*) AS NbPraticiens  from PRATICIEN INNER JOIN TYPE_PRATICIEN ON TYPE_PRATICIEN.TYP_CODE = PRATICIEN.TYP_CODE
where TYPE_PRATICIEN.TYP_CODE = @fonction
go

/*PROC LISTE PRATICIENS PAR FONCTION*/
create proc BDMO_ListePraticienfonction
	@fonction varchar(25)
AS
select PRA_NUM as 'NUM' , PRA_NOM as 'NOM', PRA_PRENOM as 'PRENOM'  from PRATICIEN INNER JOIN TYPE_PRATICIEN ON TYPE_PRATICIEN.TYP_CODE = PRATICIEN.TYP_CODE
where TYPE_PRATICIEN.TYP_CODE = @fonction
ORDER BY PRA_NOM
go

/*PROC LISTE FONCTIONS*/

create proc BDMO_ListeFonctions
AS
select TYP_CODE, TYP_LIBELLE  from  TYPE_PRATICIEN 
ORDER BY TYP_LIBELLE
go


/* -----------------------------------------------------------
						Comptes Rendus
   ----------------------------------------------------------- */

/* PROC LISTE RAPPORT */
create proc BDMO_ListeRapports
as
SELECT RAP_NUM as 'NUM', RAP_DATE as 'DATE' ,VIS_NOM as 'NOM VISITEUR', VIS_PRENOM as 'PRENOM VISITEUR', PRA_NOM as 'NOM PRATICIENS', PRA_PRENOM as 'PRENOM PRATICIENS' FROM RAPPORT_VISITE AS RAP 
INNER JOIN VISITEUR AS VI ON RAP.VIS_MATRICULE = VI.VIS_MATRICULE 
INNER JOIN PRATICIEN AS PRA ON PRA.PRA_NUM = RAP.PRA_NUM
go

/* PROC LISTE RAPPORT  SUPPRESSION*/
create proc BDMO_ListeRapportsSupp
as
SELECT RAP_NUM, RAP_DATE as 'DATE' ,VIS_NOM as 'NOM VISITEUR', VIS_PRENOM as 'PRENOM VISITEUR', PRA_NOM as 'NOM PRATICIENS', PRA_PRENOM as 'PRENOM PRATICIENS' FROM RAPPORT_VISITE AS RAP 
INNER JOIN VISITEUR AS VI ON RAP.VIS_MATRICULE = VI.VIS_MATRICULE 
INNER JOIN PRATICIEN AS PRA ON PRA.PRA_NUM = RAP.PRA_NUM
go

/* PROC NOMBRE RAPPORT */
create proc BDMO_Nbrapport
AS
SELECT COUNT(*) FROM RAPPORT_VISITE
go

/*PROC RAPPORT PAR DATE*/
create proc BDMO_ListeRapportspardate
 @daterapport date
as
SELECT RAP_NUM as 'NUM', RAP_MOTIF as 'MOTIF', RAP_BILAN as 'BILAN' ,VIS_NOM as 'NOM VISITEUR', VIS_PRENOM as 'PRENOM VISITEUR', PRA_NOM as 'NOM PRATICIENS', PRA_PRENOM as 'PRENOM PRATICIENS' FROM RAPPORT_VISITE AS RAP 
INNER JOIN VISITEUR AS VI ON RAP.VIS_MATRICULE = VI.VIS_MATRICULE 
INNER JOIN PRATICIEN AS PRA ON PRA.PRA_NUM = RAP.PRA_NUM
where RAP_DATE = @daterapport
go

/*PROC NOMBRE RAPPORT PAR DATE*/
create proc BDMO_NbrapportParDate
	@daterapport date
AS
select COUNT(*) AS NbRapport from RAPPORT_VISITE where RAP_DATE = @daterapport
go

/*PROC AJOUT COMPTE-RENDUS*/
create proc BDMO_AjoutRapportVisite
	@VisMatricule char(4), @NumPraticien int, @DateRapport date, @BilanRapport text, @MotifRapport varchar(128)
as
insert into RAPPORT_VISITE(VIS_MATRICULE, PRA_NUM, RAP_DATE, RAP_BILAN, RAP_MOTIF)
values(@VisMatricule, @NumPraticien, @DateRapport, @BilanRapport, @MotifRapport)

go

/*PROC SUPPRESSION COMPTE-RENDUS*/
create proc BDMO_SuppCR
	@id int
AS
insert into ARCHIVAGE_RAPPORT_VISITE(ARC_VIS_MATRICULE, ARC_PRA_NUM, ARC_RAP_DATE, ARC_RAP_BILAN, ARC_RAP_MOTIF)
select VIS_MATRICULE, PRA_NUM, RAP_DATE, RAP_BILAN, RAP_MOTIF
from RAPPORT_VISITE
where RAP_NUM = @id

insert into ARCHIVAGE_OFFRIR(ARC_RAP_NUM, ARC_MED_DEPOTLEGAL, ARC_OFF_QTE)
select RAP_NUM, MED_DEPOTLEGAL, OFF_QTE
from OFFRIR
where RAP_NUM = @id

delete from OFFRIR
where RAP_NUM = @id
delete from RAPPORT_VISITE
where RAP_NUM = @id
go


/*PROC AJOUT MEDOC COMPTE RENDU*/
create proc BDMO_ajoutMedicamentCR
	@DepotLegal varchar(50), @Qte int
AS
declare @IdRep int
select @IdRep = max(RAP_NUM) from RAPPORT_VISITE
insert into OFFRIR(RAP_NUM, MED_DEPOTLEGAL, OFF_QTE)
values(@IdRep, @DepotLegal, @Qte)
go


/*PROC LISTE DEPOT LEGAL */
create proc BDMO_listeDepotLegal
AS
select MED_DEPOTLEGAL from MEDICAMENT
go

