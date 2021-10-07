using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Acces_BDClassLibrary;
using System.Data.SqlClient;

namespace BDMO_GSB
{
    public partial class Frm_suppression_CR : Form
    {
        #region déclaration des objets

        #region pour les requêtes
        String strRequete;
        #endregion

        #endregion
        public Frm_suppression_CR()
        {
            InitializeComponent();
        }

        private void Frm_suppression_CR_Load(object sender, EventArgs e)
        {
            listerapport();
        }

        private void listerapport()
        {
            outils.MaConnexion();
            string requete = "EXEC BDMO_ListeRapportsSupp";
            try
            {
                DataTable DT1 = new DataTable();
                DT1.Load(outils.ExecuteReader(requete));
                dtg_SuppressionCompteRendu.DataSource = DT1;
                #region Mise en forme de la grille
                // grille en lecture seule
                dtg_SuppressionCompteRendu.ReadOnly = true;
                // rafraichissement de la grille
                dtg_SuppressionCompteRendu.Refresh();
                // ajustement des colonnes au contenu automatiquement
                dtg_SuppressionCompteRendu.AutoResizeColumns();
                // ajustement des lignes au contenu automatiquement
                dtg_SuppressionCompteRendu.AutoResizeRows();
                // ajustement de la largeur des colonnes à la grille
                //par rapport à la grille
                dtg_SuppressionCompteRendu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                // par rapport au contenu des colonnes
                dtg_SuppressionCompteRendu.AutoResizeColumns();
                // ajustement de la hauteur des lignes : ici les lignes s'ajustent mais pas au contenu de l'en-tête
                // de ligne 
                dtg_SuppressionCompteRendu.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
                // interdit à l'utilisateur de redimensionner la largeur des colonnes
                dtg_SuppressionCompteRendu.AllowUserToResizeColumns = false;
                //interdit à l'utilisateur d'ajouter des lignes
                dtg_SuppressionCompteRendu.AllowUserToAddRows = false;
                // supprimer la colonne des en-têtes de ligne
                dtg_SuppressionCompteRendu.RowHeadersVisible = false;
                #endregion
            }
            catch (System.Data.SqlClient.SqlException probleme)
            {
                MessageBox.Show("l'Erreur suivante à été rencontrée : " + probleme.Message);

            }
            outils.MaDeconnexion();
        }

        private void dtg_SuppressionCompteRendu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dtg_SuppressionCompteRendu.CurrentRow.Selected = true;

            DialogResult Resultat;
            Resultat = MessageBox.Show("Êtes-vous sur de vouloir supprimer le compte-rendu ?", "Confirmation suppression compte-rendu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Resultat == DialogResult.Yes)
            {

                string celluleSelectionne;
                celluleSelectionne = dtg_SuppressionCompteRendu.Rows[e.RowIndex].Cells["RAP_NUM"].FormattedValue.ToString();
                outils.MaConnexion();

                strRequete = "EXEC BDMO_SuppCR " + celluleSelectionne; 
                try
                {
                    outils.ExecuteReader(strRequete);
                }
                catch (System.Data.SqlClient.SqlException probleme)
                {
                    MessageBox.Show("problème de requête : " + probleme.Message);
                }

                outils.MaDeconnexion();
                listerapport();

            }
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
