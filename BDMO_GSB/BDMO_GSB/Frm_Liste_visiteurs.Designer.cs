namespace BDMO_GSB
{
    partial class Frm_Liste_visiteurs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Dtglistevisiteur = new System.Windows.Forms.DataGridView();
            this.Btnfermer = new System.Windows.Forms.Button();
            this.Btnrafraichir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Lblnbvisiteur = new System.Windows.Forms.Label();
            this.Lblnbvisiteurres = new System.Windows.Forms.Label();
            this.Dtgvisiteur = new System.Windows.Forms.GroupBox();
            this.lbladresseres = new System.Windows.Forms.Label();
            this.Lbladresse = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dtglistevisiteur)).BeginInit();
            this.Dtgvisiteur.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dtglistevisiteur
            // 
            this.Dtglistevisiteur.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Dtglistevisiteur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dtglistevisiteur.Location = new System.Drawing.Point(272, 208);
            this.Dtglistevisiteur.Name = "Dtglistevisiteur";
            this.Dtglistevisiteur.RowTemplate.Height = 24;
            this.Dtglistevisiteur.Size = new System.Drawing.Size(800, 357);
            this.Dtglistevisiteur.TabIndex = 1;
            this.Dtglistevisiteur.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dtglistevisiteur_CellClick);
            this.Dtglistevisiteur.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dtglistevisiteur_CellContentClick);
            this.Dtglistevisiteur.SelectionChanged += new System.EventHandler(this.Dtglistevisiteur_SelectionChanged);
            // 
            // Btnfermer
            // 
            this.Btnfermer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btnfermer.Location = new System.Drawing.Point(625, 596);
            this.Btnfermer.Name = "Btnfermer";
            this.Btnfermer.Size = new System.Drawing.Size(216, 37);
            this.Btnfermer.TabIndex = 8;
            this.Btnfermer.Text = "Fermer";
            this.Btnfermer.UseVisualStyleBackColor = true;
            this.Btnfermer.Click += new System.EventHandler(this.Btnfermer_Click);
            // 
            // Btnrafraichir
            // 
            this.Btnrafraichir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btnrafraichir.Location = new System.Drawing.Point(374, 596);
            this.Btnrafraichir.Name = "Btnrafraichir";
            this.Btnrafraichir.Size = new System.Drawing.Size(204, 37);
            this.Btnrafraichir.TabIndex = 9;
            this.Btnrafraichir.Text = "Rafraîchir";
            this.Btnrafraichir.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(712, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 44);
            this.label1.TabIndex = 10;
            this.label1.Text = "Liste des visiteurs";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Lblnbvisiteur
            // 
            this.Lblnbvisiteur.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lblnbvisiteur.AutoSize = true;
            this.Lblnbvisiteur.Location = new System.Drawing.Point(1078, 596);
            this.Lblnbvisiteur.Name = "Lblnbvisiteur";
            this.Lblnbvisiteur.Size = new System.Drawing.Size(146, 17);
            this.Lblnbvisiteur.TabIndex = 11;
            this.Lblnbvisiteur.Text = "Nombre de visiteurs : ";
            // 
            // Lblnbvisiteurres
            // 
            this.Lblnbvisiteurres.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lblnbvisiteurres.AutoSize = true;
            this.Lblnbvisiteurres.Location = new System.Drawing.Point(1244, 596);
            this.Lblnbvisiteurres.Name = "Lblnbvisiteurres";
            this.Lblnbvisiteurres.Size = new System.Drawing.Size(16, 17);
            this.Lblnbvisiteurres.TabIndex = 12;
            this.Lblnbvisiteurres.Text = "0";
            // 
            // Dtgvisiteur
            // 
            this.Dtgvisiteur.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Dtgvisiteur.Controls.Add(this.lbladresseres);
            this.Dtgvisiteur.Controls.Add(this.Lbladresse);
            this.Dtgvisiteur.Location = new System.Drawing.Point(1095, 208);
            this.Dtgvisiteur.Name = "Dtgvisiteur";
            this.Dtgvisiteur.Size = new System.Drawing.Size(420, 357);
            this.Dtgvisiteur.TabIndex = 13;
            this.Dtgvisiteur.TabStop = false;
            this.Dtgvisiteur.Text = "Détails visiteur";
            this.Dtgvisiteur.Visible = false;
            // 
            // lbladresseres
            // 
            this.lbladresseres.AutoSize = true;
            this.lbladresseres.Location = new System.Drawing.Point(22, 88);
            this.lbladresseres.Name = "lbladresseres";
            this.lbladresseres.Size = new System.Drawing.Size(16, 17);
            this.lbladresseres.TabIndex = 1;
            this.lbladresseres.Text = "0";
            // 
            // Lbladresse
            // 
            this.Lbladresse.AutoSize = true;
            this.Lbladresse.Location = new System.Drawing.Point(22, 52);
            this.Lbladresse.Name = "Lbladresse";
            this.Lbladresse.Size = new System.Drawing.Size(129, 17);
            this.Lbladresse.TabIndex = 0;
            this.Lbladresse.Text = "Adresse complète :";
            // 
            // Frm_Liste_visiteurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1527, 750);
            this.ControlBox = false;
            this.Controls.Add(this.Dtgvisiteur);
            this.Controls.Add(this.Lblnbvisiteurres);
            this.Controls.Add(this.Lblnbvisiteur);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dtglistevisiteur);
            this.Controls.Add(this.Btnrafraichir);
            this.Controls.Add(this.Btnfermer);
            this.Name = "Frm_Liste_visiteurs";
            this.Text = "Liste_visiteurs";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Liste_visiteurs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dtglistevisiteur)).EndInit();
            this.Dtgvisiteur.ResumeLayout(false);
            this.Dtgvisiteur.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView Dtglistevisiteur;
        private System.Windows.Forms.Button Btnfermer;
        private System.Windows.Forms.Button Btnrafraichir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lblnbvisiteur;
        private System.Windows.Forms.Label Lblnbvisiteurres;
        private System.Windows.Forms.GroupBox Dtgvisiteur;
        private System.Windows.Forms.Label lbladresseres;
        private System.Windows.Forms.Label Lbladresse;
    }
}