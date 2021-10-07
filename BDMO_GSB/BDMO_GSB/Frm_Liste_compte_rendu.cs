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
    public partial class Frm_Liste_compte_rendu : Form
    {
        #region déclaration des objets

        #region pour les requêtes
        String strRequete;
        #endregion


        #endregion

        public Frm_Liste_compte_rendu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Lblnbvisiteur_Click(object sender, EventArgs e)
        {

        }

        private void Lblnbvisiteurres_Click(object sender, EventArgs e)
        {

        }

        private void Dtglistevisiteur_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void Btnrafraichir_Click(object sender, EventArgs e)
        {
            Dtglisterapport.Refresh();
        }

        private void Btnfermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void listerapport()
        {
            outils.MaConnexion();
            string requete = "EXEC BDMO_ListeRapports";
            try
            {
                DataTable DT1 = new DataTable();
                DT1.Load(outils.ExecuteReader(requete));
                Dtglisterapport.DataSource = DT1;
                #region Mise en forme de la grille
                // grille en lecture seule
                Dtglisterapport.ReadOnly = true;
                // rafraichissement de la grille
                Dtglisterapport.Refresh();
                // ajustement des colonnes au contenu automatiquement
                Dtglisterapport.AutoResizeColumns();
                // ajustement des lignes au contenu automatiquement
                Dtglisterapport.AutoResizeRows();
                // ajustement de la largeur des colonnes à la grille
                //par rapport à la grille
                Dtglisterapport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                // par rapport au contenu des colonnes
                Dtglisterapport.AutoResizeColumns();
                // ajustement de la hauteur des lignes : ici les lignes s'ajustent mais pas au contenu de l'en-tête
                // de ligne 
                Dtglisterapport.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
                // interdit à l'utilisateur de redimensionner la largeur des colonnes
                Dtglisterapport.AllowUserToResizeColumns = false;
                //interdit à l'utilisateur d'ajouter des lignes
                Dtglisterapport.AllowUserToAddRows = false;
                // supprimer la colonne des en-têtes de ligne
                Dtglisterapport.RowHeadersVisible = false;
                #endregion
            }
            catch (System.Data.SqlClient.SqlException probleme)
            {
                MessageBox.Show("l'Erreur suivante à été rencontrée : " + probleme.Message);

            }
            outils.MaDeconnexion();
        }

        private void Nbrapport()
        {
            outils.MaConnexion();
            strRequete = "EXEC BDMO_Nbrapport";
            try
            {

                Lblnbrapportres.Text = outils.ExecuteScalar(strRequete);
            }
            catch (System.Data.SqlClient.SqlException probleme)
            {
                MessageBox.Show("problème de requête : " + probleme.Message);
            }
            outils.MaDeconnexion();
        }

        private void Liste_compte_rendu_Load(object sender, EventArgs e)
        {
            listerapport();
            Nbrapport();
        }
    }
}
