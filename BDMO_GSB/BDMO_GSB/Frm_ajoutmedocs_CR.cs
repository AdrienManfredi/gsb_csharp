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
    public partial class Frm_ajoutmedocs_CR : Form
    {
        #region déclaration des objets

        #region pour les requêtes
        String strRequete;
        
        #endregion

        #region Pour exécuter les requêtes
       // SqlCommand command;
        #endregion
        #endregion

        private void ListeMédicament()
        {
            outils.MaConnexion();
            strRequete = "EXEC BDMO_listeDepotLegal";
            try
            {
                //utilisation de la classe SqlDataReader
                SqlDataReader Sdrfonction;
                // exécution de la requête            
                Sdrfonction = outils.ExecuteReader(strRequete);
                DataTable Dt1 = new DataTable(); // déclaration et instanciation d’un objet de la classe DataTable
                Dt1.Load(Sdrfonction);
                Cbxlistemedoc.DataSource = Dt1;
                Cbxlistemedoc.DisplayMember = "MED_DEPOTLEGAL";
                Cbxlistemedoc.ValueMember = "MED_DEPOTLEGAL";
                Sdrfonction.Close(); // fermeture du DataReader
                // mise en forme de la comboBox
                Cbxlistemedoc.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            catch (System.Data.SqlClient.SqlException probleme)
            {
                MessageBox.Show("problème dans la requête : " + probleme.Message);
            }
            outils.MaDeconnexion();

        }
        public Frm_ajoutmedocs_CR()
        {
            InitializeComponent();
        }

        private void Frm_ajoutmedocs_CR_Load(object sender, EventArgs e)
        {
            ListeMédicament();
        }

        private void btnajoutmedoc_Click(object sender, EventArgs e)
        {

            outils.MaConnexion();
            string fonction = Cbxlistemedoc.SelectedValue.ToString();
            string quantite = Txtqte.Text;
            #region ajout medicament
            strRequete = "EXEC BDMO_ajoutMedicamentCR" + "'" + fonction + "'," + quantite;
            try
            {
                outils.ExecuteReader(strRequete);
                MessageBox.Show("Médicament ajouté au compte rendu");
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
    }
}
