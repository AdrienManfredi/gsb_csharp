namespace BDMO_GSB
{
    partial class Frm_Liste_compte_rendu
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
            this.Lblnbrapportres = new System.Windows.Forms.Label();
            this.Lblnbrapport = new System.Windows.Forms.Label();
            this.lblrapport = new System.Windows.Forms.Label();
            this.Dtglisterapport = new System.Windows.Forms.DataGridView();
            this.Btnrafraichir = new System.Windows.Forms.Button();
            this.Btnfermer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dtglisterapport)).BeginInit();
            this.SuspendLayout();
            // 
            // Lblnbrapportres
            // 
            this.Lblnbrapportres.AutoSize = true;
            this.Lblnbrapportres.Location = new System.Drawing.Point(736, 669);
            this.Lblnbrapportres.Name = "Lblnbrapportres";
            this.Lblnbrapportres.Size = new System.Drawing.Size(16, 17);
            this.Lblnbrapportres.TabIndex = 18;
            this.Lblnbrapportres.Text = "0";
            this.Lblnbrapportres.Click += new System.EventHandler(this.Lblnbvisiteurres_Click);
            // 
            // Lblnbrapport
            // 
            this.Lblnbrapport.AutoSize = true;
            this.Lblnbrapport.Location = new System.Drawing.Point(551, 669);
            this.Lblnbrapport.Name = "Lblnbrapport";
            this.Lblnbrapport.Size = new System.Drawing.Size(147, 17);
            this.Lblnbrapport.TabIndex = 17;
            this.Lblnbrapport.Text = "Nombre de rapports : ";
            this.Lblnbrapport.Click += new System.EventHandler(this.Lblnbvisiteur_Click);
            // 
            // lblrapport
            // 
            this.lblrapport.AutoSize = true;
            this.lblrapport.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrapport.Location = new System.Drawing.Point(897, 176);
            this.lblrapport.Name = "lblrapport";
            this.lblrapport.Size = new System.Drawing.Size(305, 38);
            this.lblrapport.TabIndex = 16;
            this.lblrapport.Text = "Liste des rapports:";
            this.lblrapport.Click += new System.EventHandler(this.label1_Click);
            // 
            // Dtglisterapport
            // 
            this.Dtglisterapport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dtglisterapport.Location = new System.Drawing.Point(554, 243);
            this.Dtglisterapport.Name = "Dtglisterapport";
            this.Dtglisterapport.RowTemplate.Height = 24;
            this.Dtglisterapport.Size = new System.Drawing.Size(1011, 408);
            this.Dtglisterapport.TabIndex = 13;
            this.Dtglisterapport.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dtglistevisiteur_CellContentClick);
            // 
            // Btnrafraichir
            // 
            this.Btnrafraichir.Location = new System.Drawing.Point(554, 711);
            this.Btnrafraichir.Name = "Btnrafraichir";
            this.Btnrafraichir.Size = new System.Drawing.Size(112, 37);
            this.Btnrafraichir.TabIndex = 15;
            this.Btnrafraichir.Text = "Rafraîchir";
            this.Btnrafraichir.UseVisualStyleBackColor = true;
            this.Btnrafraichir.Click += new System.EventHandler(this.Btnrafraichir_Click);
            // 
            // Btnfermer
            // 
            this.Btnfermer.Location = new System.Drawing.Point(787, 711);
            this.Btnfermer.Name = "Btnfermer";
            this.Btnfermer.Size = new System.Drawing.Size(124, 37);
            this.Btnfermer.TabIndex = 14;
            this.Btnfermer.Text = "Fermer";
            this.Btnfermer.UseVisualStyleBackColor = true;
            this.Btnfermer.Click += new System.EventHandler(this.Btnfermer_Click);
            // 
            // Frm_Liste_compte_rendu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1640, 791);
            this.ControlBox = false;
            this.Controls.Add(this.Lblnbrapportres);
            this.Controls.Add(this.Lblnbrapport);
            this.Controls.Add(this.lblrapport);
            this.Controls.Add(this.Dtglisterapport);
            this.Controls.Add(this.Btnrafraichir);
            this.Controls.Add(this.Btnfermer);
            this.Name = "Frm_Liste_compte_rendu";
            this.Text = "Liste_compte_rendu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Liste_compte_rendu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dtglisterapport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lblnbrapportres;
        private System.Windows.Forms.Label Lblnbrapport;
        private System.Windows.Forms.Label lblrapport;
        private System.Windows.Forms.DataGridView Dtglisterapport;
        private System.Windows.Forms.Button Btnrafraichir;
        private System.Windows.Forms.Button Btnfermer;
    }
}