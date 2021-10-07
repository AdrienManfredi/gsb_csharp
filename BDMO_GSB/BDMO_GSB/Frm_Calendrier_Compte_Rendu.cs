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
    public partial class Frm_Calendrier_Compte_Rendu : Form
    {
        #region déclaration des objets

        #region pour les requêtes
        String strRequete;
        String requetenbvisiteur;
        #endregion
        #endregion

        public Frm_Calendrier_Compte_Rendu()
        {
            InitializeComponent();
        }

        private void Lblnbrapportdate_Click(object sender, EventArgs e)
        {

        }

        private void BtnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnValider_Click(object sender, EventArgs e)
        {
            outils.MaConnexion();
            string daterapport;
            daterapport = Dtprapports.Value.ToString();
            #region liste rapport par date
            strRequete = "EXEC BDMO_ListeRapportspardate " + "'" + daterapport + "'";
            try
            {

                DataTable DT1 = new DataTable();
                DT1.Load(outils.ExecuteReader(strRequete));
                dtgdaterapport.DataSource = DT1;

                #region Mise en forme de la grille
                // grille en lecture seule
                dtgdaterapport.ReadOnly = true;
                // rafraichissement de la grille
                dtgdaterapport.Refresh();
                // ajustement des colonnes au contenu automatiquement
                dtgdaterapport.AutoResizeColumns();
                // ajustement des lignes au contenu automatiquement
                dtgdaterapport.AutoResizeRows();
                // ajustement de la largeur des colonnes à la grille
                //par rapport à la grille
                dtgdaterapport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                // par rapport au contenu des colonnes
                dtgdaterapport.AutoResizeColumns();
                // ajustement de la hauteur des lignes : ici les lignes s'ajustent mais pas au contenu de l'en-tête
                // de ligne 
                dtgdaterapport.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
                // interdit à l'utilisateur de redimensionner la largeur des colonnes
                dtgdaterapport.AllowUserToResizeColumns = false;
                //interdit à l'utilisateur d'ajouter des lignes
                dtgdaterapport.AllowUserToAddRows = false;
                // supprimer la colonne des en-têtes de ligne
                dtgdaterapport.RowHeadersVisible = false;
                #endregion

            }
            catch (System.Data.SqlClient.SqlException probleme)
            {
                MessageBox.Show("l'Erreur suivante à été rencontrée : " + probleme.Message);

            }
            #endregion

            #region nombre rapport par date
            requetenbvisiteur = "EXEC BDMO_NbrapportParDate" + "'" + daterapport + "'";
            try
            {
                Lblnbrapportdateres.Text = outils.ExecuteScalar(requetenbvisiteur);
            }
            catch (System.Data.SqlClient.SqlException probleme)
            {
                MessageBox.Show("l'Erreur suivante à été rencontrée : " + probleme.Message);

            }
            #endregion

            outils.MaDeconnexion();
        }

        private void Calendrier_Compte_Rendu_Load(object sender, EventArgs e)
        {

        }
    }
}
