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
    public partial class Frm_Liste_praticiens : Form
    {
        #region déclaration des objets

        #region pour les requêtes
        String strRequete;
        String strRequetelieu;
        #endregion

        #endregion

        public Frm_Liste_praticiens()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            dtgListePraticiens.Refresh();
        }

        private void Liste_practiciens_Load(object sender, EventArgs e)
        {
            #region Liste des Praticiens
            #region affichage DataGridView de la liste des praticiens 
            outils.MaConnexion();
            try
            {
                String requeteListePraticien = "EXEC BDMO_ListePraticiens ";
                DataTable DT1 = new DataTable();
                DT1.Load(outils.ExecuteReader(requeteListePraticien));
                dtgListePraticiens.DataSource = DT1;
            }

            catch (System.Data.SqlClient.SqlException probleme)
            {
                MessageBox.Show("L'erreur suivante a été rencontrée :" + probleme.Message);
            }

            outils.MaDeconnexion();
            #endregion

            #region Mise en forme de la grille
            dtgListePraticiens.ReadOnly = true;
            dtgListePraticiens.Refresh();
            dtgListePraticiens.AutoResizeColumns();
            dtgListePraticiens.AutoResizeRows();
            dtgListePraticiens.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgListePraticiens.AutoResizeColumns();
            dtgListePraticiens.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dtgListePraticiens.AllowUserToResizeColumns = false;
            dtgListePraticiens.AllowUserToAddRows = false;
            dtgListePraticiens.RowHeadersVisible = false;
            #endregion
            #endregion

            #region nombre de Praticiens
            outils.MaConnexion();
            try
            {
                String NbPraticiens = "EXEC BDMO_NBPraticiens";
                Lblnbpraticienres.Text = outils.ExecuteScalar(NbPraticiens).ToString();
            }

            catch (System.Data.SqlClient.SqlException probleme)
            {
                MessageBox.Show("L'erreur suivante a été rencontrée :" + probleme.Message);
            }
            outils.MaDeconnexion();
            #endregion

        }

        private void Btnfermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgListePraticiens_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dtgListePraticiens.Visible = true;
            dtgListePraticiens.CurrentRow.Selected = true;
            string var;
            var = dtgListePraticiens.Rows[e.RowIndex].Cells["NUM"].FormattedValue.ToString();
            outils.MaConnexion();
            #region adresse complète
            strRequete = " EXEC BDMO_ListePraticienDetail " + var;
            try
            {
                Convert.ToString(lbladresseres.Text = outils.ExecuteScalar(strRequete));
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
