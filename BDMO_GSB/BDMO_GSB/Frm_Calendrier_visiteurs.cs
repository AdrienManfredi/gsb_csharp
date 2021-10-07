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
    public partial class Frm_Calendrier_visiteurs : Form
    {
        #region déclaration des objets

        #region pour les requêtes
        String strRequete;
        String requetenbvisiteur;
        #endregion


        #endregion

        public Frm_Calendrier_visiteurs()
        {
            InitializeComponent();
        }

        private void BtnValider_Click(object sender, EventArgs e)
        {
            
 
            outils.MaConnexion();
            string dateembauche; 
            dateembauche = Dtpvisiteurs.Value.ToString();
            #region liste practiciens par fonctions
            strRequete = "EXEC BDMO_ListeVisiteurDate " + "'" + dateembauche + "'";
            try
            {
                
                DataTable DT1 = new DataTable();
                DT1.Load(outils.ExecuteReader(strRequete));
                dtgdateembauche.DataSource = DT1;
                
                #region Mise en forme de la grille
                // grille en lecture seule
                dtgdateembauche.ReadOnly = true;
                // rafraichissement de la grille
                dtgdateembauche.Refresh();
                // ajustement des colonnes au contenu automatiquement
                dtgdateembauche.AutoResizeColumns();
                // ajustement des lignes au contenu automatiquement
                dtgdateembauche.AutoResizeRows();
                // ajustement de la largeur des colonnes à la grille
                //par rapport à la grille
                dtgdateembauche.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                // par rapport au contenu des colonnes
                dtgdateembauche.AutoResizeColumns();
                // ajustement de la hauteur des lignes : ici les lignes s'ajustent mais pas au contenu de l'en-tête
                // de ligne 
                dtgdateembauche.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
                // interdit à l'utilisateur de redimensionner la largeur des colonnes
                dtgdateembauche.AllowUserToResizeColumns = false;
                //interdit à l'utilisateur d'ajouter des lignes
                dtgdateembauche.AllowUserToAddRows = false;
                // supprimer la colonne des en-têtes de ligne
                dtgdateembauche.RowHeadersVisible = false;
                #endregion
                
            }
            catch (System.Data.SqlClient.SqlException probleme)
            {
                MessageBox.Show("l'Erreur suivante à été rencontrée : " + probleme.Message);

            }
            #endregion

            #region nombre practiciens par fonction
            requetenbvisiteur = "EXEC BDMO_NbVisiteurParDate" + "'" + dateembauche + "'";
            try
            {
                Lblnbvisiteurdateres.Text = outils.ExecuteScalar(requetenbvisiteur);
            }
            catch (System.Data.SqlClient.SqlException probleme)
            {
                MessageBox.Show("l'Erreur suivante à été rencontrée : " + probleme.Message);

            }
            #endregion

            outils.MaDeconnexion();
        }

        private void Calendrier_visiteurs_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
