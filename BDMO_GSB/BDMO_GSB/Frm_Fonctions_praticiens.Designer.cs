namespace BDMO_GSB
{
    partial class Frm_Fonctions_praticiens
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
            this.Dtgpracticien = new System.Windows.Forms.GroupBox();
            this.Lbllieures = new System.Windows.Forms.Label();
            this.Lbllieutravail = new System.Windows.Forms.Label();
            this.lbladresseres = new System.Windows.Forms.Label();
            this.Lbladresse = new System.Windows.Forms.Label();
            this.Lblnbpraticienres = new System.Windows.Forms.Label();
            this.Lblnbpraticien = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Btnfermer = new System.Windows.Forms.Button();
            this.Btnrafraichir = new System.Windows.Forms.Button();
            this.dtgListePraticiens = new System.Windows.Forms.DataGridView();
            this.Cbxfonction = new System.Windows.Forms.ComboBox();
            this.Dtgpracticien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListePraticiens)).BeginInit();
            this.SuspendLayout();
            // 
            // Dtgpracticien
            // 
            this.Dtgpracticien.Controls.Add(this.Lbllieures);
            this.Dtgpracticien.Controls.Add(this.Lbllieutravail);
            this.Dtgpracticien.Controls.Add(this.lbladresseres);
            this.Dtgpracticien.Controls.Add(this.Lbladresse);
            this.Dtgpracticien.Location = new System.Drawing.Point(1139, 297);
            this.Dtgpracticien.Name = "Dtgpracticien";
            this.Dtgpracticien.Size = new System.Drawing.Size(552, 262);
            this.Dtgpracticien.TabIndex = 27;
            this.Dtgpracticien.TabStop = false;
            this.Dtgpracticien.Text = "Détails praticien";
            // 
            // Lbllieures
            // 
            this.Lbllieures.AutoSize = true;
            this.Lbllieures.Location = new System.Drawing.Point(28, 179);
            this.Lbllieures.Name = "Lbllieures";
            this.Lbllieures.Size = new System.Drawing.Size(16, 17);
            this.Lbllieures.TabIndex = 3;
            this.Lbllieures.Text = "0";
            // 
            // Lbllieutravail
            // 
            this.Lbllieutravail.AutoSize = true;
            this.Lbllieutravail.Location = new System.Drawing.Point(25, 141);
            this.Lbllieutravail.Name = "Lbllieutravail";
            this.Lbllieutravail.Size = new System.Drawing.Size(101, 17);
            this.Lbllieutravail.TabIndex = 2;
            this.Lbllieutravail.Text = "Lieu de travail:";
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
            // Lblnbpraticienres
            // 
            this.Lblnbpraticienres.AutoSize = true;
            this.Lblnbpraticienres.Location = new System.Drawing.Point(580, 599);
            this.Lblnbpraticienres.Name = "Lblnbpraticienres";
            this.Lblnbpraticienres.Size = new System.Drawing.Size(16, 17);
            this.Lblnbpraticienres.TabIndex = 26;
            this.Lblnbpraticienres.Text = "0";
            // 
            // Lblnbpraticien
            // 
            this.Lblnbpraticien.AutoSize = true;
            this.Lblnbpraticien.Location = new System.Drawing.Point(405, 599);
            this.Lblnbpraticien.Name = "Lblnbpraticien";
            this.Lblnbpraticien.Size = new System.Drawing.Size(155, 17);
            this.Lblnbpraticien.TabIndex = 25;
            this.Lblnbpraticien.Text = "Nombre de praticiens : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(800, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(527, 38);
            this.label1.TabIndex = 24;
            this.label1.Text = "Liste des praticiens par fonctions";
            // 
            // Btnfermer
            // 
            this.Btnfermer.Location = new System.Drawing.Point(637, 660);
            this.Btnfermer.Name = "Btnfermer";
            this.Btnfermer.Size = new System.Drawing.Size(124, 37);
            this.Btnfermer.TabIndex = 22;
            this.Btnfermer.Text = "Fermer";
            this.Btnfermer.UseVisualStyleBackColor = true;
            this.Btnfermer.Click += new System.EventHandler(this.Btnfermer_Click);
            // 
            // Btnrafraichir
            // 
            this.Btnrafraichir.Location = new System.Drawing.Point(408, 660);
            this.Btnrafraichir.Name = "Btnrafraichir";
            this.Btnrafraichir.Size = new System.Drawing.Size(112, 37);
            this.Btnrafraichir.TabIndex = 23;
            this.Btnrafraichir.Text = "Rafraîchir";
            this.Btnrafraichir.UseVisualStyleBackColor = true;
            // 
            // dtgListePraticiens
            // 
            this.dtgListePraticiens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListePraticiens.Location = new System.Drawing.Point(408, 297);
            this.dtgListePraticiens.Name = "dtgListePraticiens";
            this.dtgListePraticiens.RowTemplate.Height = 24;
            this.dtgListePraticiens.Size = new System.Drawing.Size(705, 262);
            this.dtgListePraticiens.TabIndex = 21;
            this.dtgListePraticiens.Visible = false;
            this.dtgListePraticiens.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgListePraticiens_CellClick);
            // 
            // Cbxfonction
            // 
            this.Cbxfonction.FormattingEnabled = true;
            this.Cbxfonction.Location = new System.Drawing.Point(408, 233);
            this.Cbxfonction.Name = "Cbxfonction";
            this.Cbxfonction.Size = new System.Drawing.Size(219, 24);
            this.Cbxfonction.TabIndex = 28;
            this.Cbxfonction.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // Frm_Fonctions_praticiens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1778, 769);
            this.ControlBox = false;
            this.Controls.Add(this.Cbxfonction);
            this.Controls.Add(this.Dtgpracticien);
            this.Controls.Add(this.Lblnbpraticienres);
            this.Controls.Add(this.Lblnbpraticien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgListePraticiens);
            this.Controls.Add(this.Btnrafraichir);
            this.Controls.Add(this.Btnfermer);
            this.Name = "Frm_Fonctions_praticiens";
            this.Text = "Fonctions_praticiens";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Fonctions_praticiens_Load);
            this.Dtgpracticien.ResumeLayout(false);
            this.Dtgpracticien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListePraticiens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Dtgpracticien;
        private System.Windows.Forms.Label Lbllieures;
        private System.Windows.Forms.Label Lbllieutravail;
        private System.Windows.Forms.Label lbladresseres;
        private System.Windows.Forms.Label Lbladresse;
        private System.Windows.Forms.Label Lblnbpraticienres;
        private System.Windows.Forms.Label Lblnbpraticien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btnfermer;
        private System.Windows.Forms.Button Btnrafraichir;
        private System.Windows.Forms.DataGridView dtgListePraticiens;
        private System.Windows.Forms.ComboBox Cbxfonction;
    }
}