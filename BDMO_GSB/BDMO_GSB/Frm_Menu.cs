using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDMO_GSB
{
    public partial class Frm_Menu : Form
    {
        public Frm_Menu()
        {
            InitializeComponent();
        }

        private void visiteursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void listeVisiteursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Liste_visiteurs = new Frm_Liste_visiteurs();
            Liste_visiteurs.MdiParent = this;
            Liste_visiteurs.Show();
        }

        private void dateEmbaucheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Calendrier_visiteurs = new Frm_Calendrier_visiteurs();
            Calendrier_visiteurs.MdiParent = this;
            Calendrier_visiteurs.Show();
        }

        private void listePracticiensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Liste_praticiens = new Frm_Liste_praticiens();
            Liste_praticiens.MdiParent = this;
            Liste_praticiens.Show();
        }

        private void fonctionsPracticiensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Fonctions_praticiens = new Frm_Fonctions_praticiens();
            Fonctions_praticiens.MdiParent = this;
            Fonctions_praticiens.Show();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Resultat;
            Resultat = MessageBox.Show("Voulez-vous quitter l'application ?", "Message de fermeture de l'application", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Resultat == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void listeCompteRenduToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Frm_Liste_compte_rendu = new Frm_Liste_compte_rendu();
            Frm_Liste_compte_rendu.MdiParent = this;
            Frm_Liste_compte_rendu.Show();
        }

        private void calendrierCompteRenduToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Calendrier_Compte_Rendu = new Frm_Calendrier_Compte_Rendu();
            Calendrier_Compte_Rendu.MdiParent = this;
            Calendrier_Compte_Rendu.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (grbvisiteur.Visible == false)
            {
                grbvisiteur.Visible = true;
            }
            else
            {
                grbvisiteur.Visible = false;
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form Liste_visiteurs = new Frm_Liste_visiteurs();
            Liste_visiteurs.MdiParent = this;
            Liste_visiteurs.Show();
            grbvisiteur.Visible = false;
            grbpraticiens.Visible = false;
            grbcompterendu.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form Calendrier_visiteurs = new Frm_Calendrier_visiteurs();
            Calendrier_visiteurs.MdiParent = this;
            Calendrier_visiteurs.Show();
            grbvisiteur.Visible = false;
            grbpraticiens.Visible = false;
            grbcompterendu.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form Liste_praticiens = new Frm_Liste_praticiens();
            Liste_praticiens.MdiParent = this;
            Liste_praticiens.Show();
            grbvisiteur.Visible = false;
            grbpraticiens.Visible = false;
            grbcompterendu.Visible = false;
        }

        private void btnfoncprat_Click(object sender, EventArgs e)
        {
            Form Fonctions_praticiens = new Frm_Fonctions_praticiens();
            Fonctions_praticiens.MdiParent = this;
            Fonctions_praticiens.Show();
            grbvisiteur.Visible = false;
            grbpraticiens.Visible = false;
            grbcompterendu.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (grbpraticiens.Visible == false)
            {
                grbpraticiens.Visible = true;
            }
            else
            {
                grbpraticiens.Visible = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (grbcompterendu.Visible == false)
            {
                grbcompterendu.Visible = true;
            }
            else
            {
                grbcompterendu.Visible = false;
            }
        }

        private void listecompterendu_Click(object sender, EventArgs e)
        {
            Form Frm_Liste_compte_rendu = new Frm_Liste_compte_rendu();
            Frm_Liste_compte_rendu.MdiParent = this;
            Frm_Liste_compte_rendu.Show();
            grbvisiteur.Visible = false;
            grbpraticiens.Visible = false;
            grbcompterendu.Visible = false;
        }

        private void btndaterapport_Click(object sender, EventArgs e)
        {
            Form Calendrier_Compte_Rendu = new Frm_Calendrier_Compte_Rendu();
            Calendrier_Compte_Rendu.MdiParent = this;
            Calendrier_Compte_Rendu.Show();
            grbvisiteur.Visible = false;
            grbpraticiens.Visible = false;
            grbcompterendu.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form Frm_insertion_cr = new Frm_insertion_cr();
            Frm_insertion_cr.MdiParent = this;
            Frm_insertion_cr.Show();
            grbvisiteur.Visible = false;
            grbpraticiens.Visible = false;
            grbcompterendu.Visible = false;
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            Form Frm_suppression_CR = new Frm_suppression_CR();
            Frm_suppression_CR.MdiParent = this;
            Frm_suppression_CR.Show();
            grbvisiteur.Visible = false;
            grbpraticiens.Visible = false;
            grbcompterendu.Visible = false;
        }

        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            DialogResult Resultat;
            Resultat = MessageBox.Show("Voulez-vous quitter l'application?", "Message de fermeture de l'application", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Resultat == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
