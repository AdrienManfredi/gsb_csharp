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
    public partial class Frm_Fonctions_praticiens : Form
    {
        #region déclaration des objets

        #region pour les requêtes
        String strRequete;
        String strRequetelieu;
        #endregion

    
        #endregion

        private void ListeFonction()
        {
            outils.MaConnexion();
            strRequete = "EXEC BDMO_ListeFonctions ";
            try
            {
                //utilisation de la classe SqlDataReader
                SqlDataReader Sdrfonction;
                // exécution de la requête            
                Sdrfonction = outils.ExecuteReader(strRequete);
                DataTable Dt1 = new DataTable(); // déclaration et instanciation d’un objet de la classe DataTable
                Dt1.Load(Sdrfonction); // chargement du DataReader dans la DataTable
                // Déclaration de la source de la combobox
                Cbxfonction.DataSource = Dt1;
                //La valeur affichée sera le libelle
                Cbxfonction.DisplayMember = "TYP_LIBELLE";
                // La valeur récupérée lors d'un choix dans la liste sera le code
                Cbxfonction.ValueMember = "TYP_CODE";
                Sdrfonction.Close(); // fermeture du DataReader
                // mise en forme de la comboBox
                Cbxfonction.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            catch (System.Data.SqlClient.SqlException probleme)
            {
                MessageBox.Show("problème dans la requête : " + probleme.Message);
            }

        }

    
        public Frm_Fonctions_praticiens()
        {
            InitializeComponent();
        }

        private void Fonctions_praticiens_Load(object sender, EventArgs e)
        {
            ListeFonction();
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            outils.MaConnexion();
            dtgListePraticiens.Visible = true;
            string fonction = Cbxfonction.SelectedValue.ToString();

            #region nb praticiens
            strRequete = "EXEC BDMO_NBPraticiensfonction " + "'" + fonction + "'";
            try
            {
                Lblnbpraticienres.Text =  outils.ExecuteScalar(strRequete);
            }
            catch (System.Data.SqlClient.SqlException probleme)
            {
                MessageBox.Show("problème dans la requête : " + probleme.Message);
            }
            #endregion

            #region Liste praticiens
            strRequete = "EXEC BDMO_ListePraticienfonction " + "'" + fonction + "'";
            try
            {
                DataTable DT1 = new DataTable();
                DT1.Load(outils.ExecuteReader(strRequete));
                dtgListePraticiens.DataSource = DT1;
                #region Mise en forme de la grille
                // grille en lecture seule
                dtgListePraticiens.ReadOnly = true;
                // rafraichissement de la grille
                dtgListePraticiens.Refresh();
                // ajustement des colonnes au contenu automatiquement
                dtgListePraticiens.AutoResizeColumns();
                // ajustement des lignes au contenu automatiquement
                dtgListePraticiens.AutoResizeRows();
                // ajustement de la largeur des colonnes à la grille
                //par rapport à la grille
                dtgListePraticiens.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                // par rapport au contenu des colonnes
                dtgListePraticiens.AutoResizeColumns();
                // ajustement de la hauteur des lignes : ici les lignes s'ajustent mais pas au contenu de l'en-tête
                // de ligne 
                //cacher colonne num
                this.dtgListePraticiens.Columns["NUM"].Visible = false;
                dtgListePraticiens.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
                // interdit à l'utilisateur de redimensionner la largeur des colonnes
                dtgListePraticiens.AllowUserToResizeColumns = false;
                //interdit à l'utilisateur d'ajouter des lignes
                dtgListePraticiens.AllowUserToAddRows = false;
                // supprimer la colonne des en-têtes de ligne
                dtgListePraticiens.RowHeadersVisible = false;
                #endregion
            }
            catch (System.Data.SqlClient.SqlException probleme)
            {
                MessageBox.Show("problème dans la requête : " + probleme.Message);
            }
            #endregion

            outils.MaDeconnexion();
        }

        private void Btnfermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgListePraticiens_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dtgListePraticiens.Visible = true;
            dtgListePraticiens.CurrentRow.Selected = true;
            String var;
            var = dtgListePraticiens.Rows[e.RowIndex].Cells["NUM"].FormattedValue.ToString();
            outils.MaConnexion();
            #region adresse complète
            strRequete = " EXEC BDMO_ListePraticienDetail " + var ;
            try
            {
                lbladresseres.Text = Convert.ToString(outils.ExecuteScalar(strRequete)); 
            }

            catch (System.Data.SqlClient.SqlException probleme)
            {
                MessageBox.Show("problème de requête : " + probleme.Message);
            }
            #endregion
            #region lieu de travail
            strRequetelieu = " EXEC BDMO_lieupraticiens '" + var + "'";
            try
            {
                Lbllieures.Text = Convert.ToString(outils.ExecuteScalar(strRequetelieu));
            }
            catch (System.Data.SqlClient.SqlException probleme)
            {
                MessageBox.Show("problème de requête : " + probleme.Message);
            }
            #endregion
            outils.MaDeconnexion();
        }
    }
}
