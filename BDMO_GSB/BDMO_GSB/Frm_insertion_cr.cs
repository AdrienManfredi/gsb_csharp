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
    public partial class Frm_insertion_cr : Form
    {
        #region déclaration des objets

        #region pour les requêtes
        String strRequete;
        #endregion

        #endregion

        public Frm_insertion_cr()
        {
            InitializeComponent();
        }

        private void ListeMatricule()
        {
            outils.MaConnexion();
            strRequete = "EXEC BDMO_ListeMatriculeVisiteur";
            try
            {
                //utilisation de la classe SqlDataReader
                SqlDataReader Sdrfonction;
                // exécution de la requête            
                Sdrfonction = outils.ExecuteReader(strRequete);
                DataTable Dt1 = new DataTable(); // déclaration et instanciation d’un objet de la classe DataTable
                Dt1.Load(Sdrfonction);
                Cbx_matricule.DataSource = Dt1;
                Cbx_matricule.DisplayMember = "NomPrenom";
                Cbx_matricule.ValueMember = "VIS_MATRICULE";
                Sdrfonction.Close(); // fermeture du DataReader
                // mise en forme de la comboBox
                Cbx_matricule.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            catch (System.Data.SqlClient.SqlException probleme)
            {
                MessageBox.Show("problème dans la requête : " + probleme.Message);
            }
            outils.MaDeconnexion();

        }
        private void ListeNumPraticiens()
        {
            outils.MaConnexion();
            strRequete = "EXEC BDMO_ListeNumPrac ";
            try
            {
                //utilisation de la classe SqlDataReader
                SqlDataReader Sdrfonction;
                // exécution de la requête            
                Sdrfonction = outils.ExecuteReader(strRequete);
                DataTable Dt1 = new DataTable(); // déclaration et instanciation d’un objet de la classe DataTable
                Dt1.Load(Sdrfonction);
                Cbx_Numpraticiens.DataSource = Dt1;
                Cbx_Numpraticiens.DisplayMember = "NumNom";
                Cbx_Numpraticiens.ValueMember = "PRA_NUM";
                Sdrfonction.Close(); // fermeture du DataReader
                // mise en forme de la comboBox
                Cbx_matricule.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            catch (System.Data.SqlClient.SqlException probleme)
            {
                MessageBox.Show("problème dans la requête : " + probleme.Message);
            }
            outils.MaDeconnexion();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Frm_insertion_cr_Load(object sender, EventArgs e)
        {
            ListeMatricule();
            ListeNumPraticiens();

        }

        private void Btn_ajouter_Click(object sender, EventArgs e)
        {

            string matricule, bilan, motif;
            int Numpraticiens;
            DateTime daterapport;

            matricule = Cbx_matricule.SelectedValue.ToString();
            Numpraticiens = Convert.ToInt16(Cbx_Numpraticiens.SelectedValue);
            daterapport = dateTimePicker1.Value;
            bilan = Tbx_bilan.Text;
            motif = Tbx_motif.Text;
            outils.MaConnexion();
            strRequete = "EXEC BDMO_AjoutRapportVisite" + "'" + matricule + "'," + "'" + Numpraticiens + "'," + "'" + daterapport + "'," + "'" + bilan + "'," + "'" + motif + "'";
            try
            {
                outils.ExecuteReader(strRequete);
                MessageBox.Show("Insertion réussie","message de confirmation",MessageBoxButtons.OK);
            }
            catch (System.Data.SqlClient.SqlException probleme)
            {

                MessageBox.Show("l'Erreur suivante à été rencontrée : " + probleme.Message);
            }

            outils.MaDeconnexion();
            DialogResult Resultat;
            Resultat = MessageBox.Show("Voulez-vous ajouter des médicament au compte rendu?", "Message d'ajout d'un médicament", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Resultat == DialogResult.Yes)
            {
                Form Frm_ajoutmedocs_CR = new Frm_ajoutmedocs_CR();
                Frm_ajoutmedocs_CR.Show();
            }

        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
