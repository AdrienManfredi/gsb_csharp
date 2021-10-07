namespace BDMO_GSB
{
    partial class Frm_Calendrier_visiteurs
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
            this.Dtpvisiteurs = new System.Windows.Forms.DateTimePicker();
            this.BtnValider = new System.Windows.Forms.Button();
            this.dtgdateembauche = new System.Windows.Forms.DataGridView();
            this.BtnFermer = new System.Windows.Forms.Button();
            this.Lbltitredate = new System.Windows.Forms.Label();
            this.Lblnbvisiteurdateres = new System.Windows.Forms.Label();
            this.Lblnbvisiteurdate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgdateembauche)).BeginInit();
            this.SuspendLayout();
            // 
            // Dtpvisiteurs
            // 
            this.Dtpvisiteurs.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtpvisiteurs.Location = new System.Drawing.Point(545, 327);
            this.Dtpvisiteurs.Name = "Dtpvisiteurs";
            this.Dtpvisiteurs.Size = new System.Drawing.Size(200, 22);
            this.Dtpvisiteurs.TabIndex = 0;
            // 
            // BtnValider
            // 
            this.BtnValider.Location = new System.Drawing.Point(599, 384);
            this.BtnValider.Name = "BtnValider";
            this.BtnValider.Size = new System.Drawing.Size(101, 38);
            this.BtnValider.TabIndex = 1;
            this.BtnValider.Text = "Valider";
            this.BtnValider.UseVisualStyleBackColor = true;
            this.BtnValider.Click += new System.EventHandler(this.BtnValider_Click);
            // 
            // dtgdateembauche
            // 
            this.dtgdateembauche.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgdateembauche.Location = new System.Drawing.Point(807, 274);
            this.dtgdateembauche.Name = "dtgdateembauche";
            this.dtgdateembauche.RowTemplate.Height = 24;
            this.dtgdateembauche.Size = new System.Drawing.Size(803, 336);
            this.dtgdateembauche.TabIndex = 2;
            // 
            // BtnFermer
            // 
            this.BtnFermer.Location = new System.Drawing.Point(599, 444);
            this.BtnFermer.Name = "BtnFermer";
            this.BtnFermer.Size = new System.Drawing.Size(101, 34);
            this.BtnFermer.TabIndex = 3;
            this.BtnFermer.Text = "Fermer";
            this.BtnFermer.UseVisualStyleBackColor = true;
            this.BtnFermer.Click += new System.EventHandler(this.BtnFermer_Click);
            // 
            // Lbltitredate
            // 
            this.Lbltitredate.AutoSize = true;
            this.Lbltitredate.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbltitredate.Location = new System.Drawing.Point(833, 188);
            this.Lbltitredate.Name = "Lbltitredate";
            this.Lbltitredate.Size = new System.Drawing.Size(459, 46);
            this.Lbltitredate.TabIndex = 4;
            this.Lbltitredate.Text = "Date embauche visiteur";
            // 
            // Lblnbvisiteurdateres
            // 
            this.Lblnbvisiteurdateres.AutoSize = true;
            this.Lblnbvisiteurdateres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblnbvisiteurdateres.Location = new System.Drawing.Point(743, 274);
            this.Lblnbvisiteurdateres.Name = "Lblnbvisiteurdateres";
            this.Lblnbvisiteurdateres.Size = new System.Drawing.Size(23, 25);
            this.Lblnbvisiteurdateres.TabIndex = 14;
            this.Lblnbvisiteurdateres.Text = "0";
            // 
            // Lblnbvisiteurdate
            // 
            this.Lblnbvisiteurdate.AutoSize = true;
            this.Lblnbvisiteurdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblnbvisiteurdate.Location = new System.Drawing.Point(542, 274);
            this.Lblnbvisiteurdate.Name = "Lblnbvisiteurdate";
            this.Lblnbvisiteurdate.Size = new System.Drawing.Size(200, 25);
            this.Lblnbvisiteurdate.TabIndex = 13;
            this.Lblnbvisiteurdate.Text = "Nombre de visiteurs : ";
            // 
            // Frm_Calendrier_visiteurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1808, 773);
            this.ControlBox = false;
            this.Controls.Add(this.Lblnbvisiteurdateres);
            this.Controls.Add(this.Lblnbvisiteurdate);
            this.Controls.Add(this.Lbltitredate);
            this.Controls.Add(this.BtnFermer);
            this.Controls.Add(this.dtgdateembauche);
            this.Controls.Add(this.BtnValider);
            this.Controls.Add(this.Dtpvisiteurs);
            this.Name = "Frm_Calendrier_visiteurs";
            this.Text = "Date embauche";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Calendrier_visiteurs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgdateembauche)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker Dtpvisiteurs;
        private System.Windows.Forms.Button BtnValider;
        private System.Windows.Forms.DataGridView dtgdateembauche;
        private System.Windows.Forms.Button BtnFermer;
        private System.Windows.Forms.Label Lbltitredate;
        private System.Windows.Forms.Label Lblnbvisiteurdateres;
        private System.Windows.Forms.Label Lblnbvisiteurdate;
    }
}