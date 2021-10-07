using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Acces_BDClassLibrary;

namespace BDMO_GSB
{
    public partial class Frm_Liste_visiteurs : Form
    {
        #region déclaration des objets

        #region pour les requêtes
        String strRequete;
        #endregion

        #endregion

        public Frm_Liste_visiteurs()
        {
            InitializeComponent();
        }


        private void Grblistealb_Enter(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Dtglistevisiteur.Refresh();
        }
        private void AffichageListeVisiteurs()
        {
                         
            outils.MaConnexion();             
            string requete = "EXEC BDMO_ListeVisiteur";
            try
            {
                DataTable DT1 = new DataTable();
                DT1.Load(outils.ExecuteReader(requete));
                Dtglistevisiteur.DataSource = DT1;
                #region Mise en forme de la grille
                // grille en lecture seule
                Dtglistevisiteur.ReadOnly = true;
                // rafraichissement de la grille
                Dtglistevisiteur.Refresh();
                // ajustement des colonnes au contenu automatiquement
                Dtglistevisiteur.AutoResizeColumns();
                // ajustement des lignes au contenu automatiquement
                Dtglistevisiteur.AutoResizeRows();
                // ajustement de la largeur des colonnes à la grille
                //par rapport à la grille
                Dtglistevisiteur.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                // par rapport au contenu des colonnes
                Dtglistevisiteur.AutoResizeColumns();
                // ajustement de la hauteur des lignes : ici les lignes s'ajustent mais pas au contenu de l'en-tête
                // de ligne 
                Dtglistevisiteur.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
                // interdit à l'utilisateur de redimensionner la largeur des colonnes
                Dtglistevisiteur.AllowUserToResizeColumns = false;
                //interdit à l'utilisateur d'ajouter des lignes
                Dtglistevisiteur.AllowUserToAddRows = false;
                // supprimer la colonne des en-têtes de ligne
                Dtglistevisiteur.RowHeadersVisible = false;
                #endregion
            }
            catch (System.Data.SqlClient.SqlException probleme)
            {
                MessageBox.Show("l'Erreur suivante à été rencontrée : " + probleme.Message);

            }
            outils.MaDeconnexion();
        }

        private void NBvisiteur()
        {
            outils.MaConnexion();
            strRequete = "EXEC BDMO_NBVisiteur";
            try
            {
                
                Lblnbvisiteurres.Text = outils.ExecuteScalar(strRequete);
            }
            catch (System.Data.SqlClient.SqlException probleme)
            {
                MessageBox.Show("problème de requête : " + probleme.Message);
            }
            outils.MaDeconnexion();
        }
        private void Adressecomplete()
        {
            
        }
        private void Liste_visiteurs_Load(object sender, EventArgs e)
        {
            
            AffichageListeVisiteurs();
            NBvisiteur();
        }

        private void Dtglistevisiteur_SelectionChanged(object sender, EventArgs e)
        {
           
        }

        private void Dtglistevisiteur_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Btnfermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Dtglistevisiteur_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Dtgvisiteur.Visible = true;
            Dtglistevisiteur.CurrentRow.Selected = true;
            string var;
            var = Dtglistevisiteur.Rows[e.RowIndex].Cells["MATRICULE"].FormattedValue.ToString();
            outils.MaConnexion();
            strRequete = " EXEC BDMO_ListeVisiteurDetail '" + var + "'";
            try
            {
                lbladresseres.Text = outils.ExecuteScalar(strRequete);
            }
            catch (System.Data.SqlClient.SqlException probleme)
            {
                MessageBox.Show("problème de requête : " + probleme.Message);
            }
            outils.MaDeconnexion();
        }
    }
}
