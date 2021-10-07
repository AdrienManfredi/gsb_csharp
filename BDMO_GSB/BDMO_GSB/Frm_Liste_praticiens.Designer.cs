namespace BDMO_GSB
{
    partial class Frm_Liste_praticiens
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
            this.dtgListePraticiens = new System.Windows.Forms.DataGridView();
            this.Btnrafraichir = new System.Windows.Forms.Button();
            this.Btnfermer = new System.Windows.Forms.Button();
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
            this.Dtgpracticien.Location = new System.Drawing.Point(1214, 288);
            this.Dtgpracticien.Name = "Dtgpracticien";
            this.Dtgpracticien.Size = new System.Drawing.Size(552, 262);
            this.Dtgpracticien.TabIndex = 20;
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
            this.Lblnbpraticienres.Location = new System.Drawing.Point(655, 590);
            this.Lblnbpraticienres.Name = "Lblnbpraticienres";
            this.Lblnbpraticienres.Size = new System.Drawing.Size(16, 17);
            this.Lblnbpraticienres.TabIndex = 19;
            this.Lblnbpraticienres.Text = "0";
            // 
            // Lblnbpraticien
            // 
            this.Lblnbpraticien.AutoSize = true;
            this.Lblnbpraticien.Location = new System.Drawing.Point(480, 590);
            this.Lblnbpraticien.Name = "Lblnbpraticien";
            this.Lblnbpraticien.Size = new System.Drawing.Size(155, 17);
            this.Lblnbpraticien.TabIndex = 18;
            this.Lblnbpraticien.Text = "Nombre de praticiens : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(924, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 38);
            this.label1.TabIndex = 17;
            this.label1.Text = "Liste des praticiens";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dtgListePraticiens
            // 
            this.dtgListePraticiens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListePraticiens.Location = new System.Drawing.Point(483, 288);
            this.dtgListePraticiens.Name = "dtgListePraticiens";
            this.dtgListePraticiens.RowTemplate.Height = 24;
            this.dtgListePraticiens.Size = new System.Drawing.Size(705, 262);
            this.dtgListePraticiens.TabIndex = 14;
            this.dtgListePraticiens.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgListePraticiens_CellClick);
            // 
            // Btnrafraichir
            // 
            this.Btnrafraichir.Location = new System.Drawing.Point(483, 644);
            this.Btnrafraichir.Name = "Btnrafraichir";
            this.Btnrafraichir.Size = new System.Drawing.Size(112, 37);
            this.Btnrafraichir.TabIndex = 16;
            this.Btnrafraichir.Text = "Rafraîchir";
            this.Btnrafraichir.UseVisualStyleBackColor = true;
            // 
            // Btnfermer
            // 
            this.Btnfermer.Location = new System.Drawing.Point(712, 644);
            this.Btnfermer.Name = "Btnfermer";
            this.Btnfermer.Size = new System.Drawing.Size(124, 37);
            this.Btnfermer.TabIndex = 15;
            this.Btnfermer.Text = "Fermer";
            this.Btnfermer.UseVisualStyleBackColor = true;
            this.Btnfermer.Click += new System.EventHandler(this.Btnfermer_Click);
            // 
            // Frm_Liste_praticiens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1784, 752);
            this.ControlBox = false;
            this.Controls.Add(this.Dtgpracticien);
            this.Controls.Add(this.Lblnbpraticienres);
            this.Controls.Add(this.Lblnbpraticien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgListePraticiens);
            this.Controls.Add(this.Btnrafraichir);
            this.Controls.Add(this.Btnfermer);
            this.Name = "Frm_Liste_praticiens";
            this.Text = "Liste_practiciens";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Liste_practiciens_Load);
            this.Dtgpracticien.ResumeLayout(false);
            this.Dtgpracticien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListePraticiens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Dtgpracticien;
        private System.Windows.Forms.Label lbladresseres;
        private System.Windows.Forms.Label Lbladresse;
        private System.Windows.Forms.Label Lblnbpraticienres;
        private System.Windows.Forms.Label Lblnbpraticien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgListePraticiens;
        private System.Windows.Forms.Button Btnrafraichir;
        private System.Windows.Forms.Button Btnfermer;
        private System.Windows.Forms.Label Lbllieures;
        private System.Windows.Forms.Label Lbllieutravail;
    }
}