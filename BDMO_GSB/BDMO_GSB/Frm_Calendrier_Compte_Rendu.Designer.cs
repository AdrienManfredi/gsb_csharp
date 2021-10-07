namespace BDMO_GSB
{
    partial class Frm_Calendrier_Compte_Rendu
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
            this.Lblnbrapportdateres = new System.Windows.Forms.Label();
            this.Lblnbrapportdate = new System.Windows.Forms.Label();
            this.Lbltitredate = new System.Windows.Forms.Label();
            this.BtnFermer = new System.Windows.Forms.Button();
            this.dtgdaterapport = new System.Windows.Forms.DataGridView();
            this.BtnValider = new System.Windows.Forms.Button();
            this.Dtprapports = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dtgdaterapport)).BeginInit();
            this.SuspendLayout();
            // 
            // Lblnbrapportdateres
            // 
            this.Lblnbrapportdateres.AutoSize = true;
            this.Lblnbrapportdateres.Location = new System.Drawing.Point(755, 649);
            this.Lblnbrapportdateres.Name = "Lblnbrapportdateres";
            this.Lblnbrapportdateres.Size = new System.Drawing.Size(16, 17);
            this.Lblnbrapportdateres.TabIndex = 21;
            this.Lblnbrapportdateres.Text = "0";
            // 
            // Lblnbrapportdate
            // 
            this.Lblnbrapportdate.AutoSize = true;
            this.Lblnbrapportdate.Location = new System.Drawing.Point(584, 649);
            this.Lblnbrapportdate.Name = "Lblnbrapportdate";
            this.Lblnbrapportdate.Size = new System.Drawing.Size(147, 17);
            this.Lblnbrapportdate.TabIndex = 20;
            this.Lblnbrapportdate.Text = "Nombre de rapports : ";
            this.Lblnbrapportdate.Click += new System.EventHandler(this.Lblnbrapportdate_Click);
            // 
            // Lbltitredate
            // 
            this.Lbltitredate.AutoSize = true;
            this.Lbltitredate.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbltitredate.Location = new System.Drawing.Point(901, 244);
            this.Lbltitredate.Name = "Lbltitredate";
            this.Lbltitredate.Size = new System.Drawing.Size(301, 38);
            this.Lbltitredate.TabIndex = 19;
            this.Lbltitredate.Text = "Date liste rapports";
            // 
            // BtnFermer
            // 
            this.BtnFermer.Location = new System.Drawing.Point(587, 705);
            this.BtnFermer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnFermer.Name = "BtnFermer";
            this.BtnFermer.Size = new System.Drawing.Size(85, 30);
            this.BtnFermer.TabIndex = 18;
            this.BtnFermer.Text = "Fermer";
            this.BtnFermer.UseVisualStyleBackColor = true;
            this.BtnFermer.Click += new System.EventHandler(this.BtnFermer_Click);
            // 
            // dtgdaterapport
            // 
            this.dtgdaterapport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgdaterapport.Location = new System.Drawing.Point(587, 369);
            this.dtgdaterapport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgdaterapport.Name = "dtgdaterapport";
            this.dtgdaterapport.RowTemplate.Height = 24;
            this.dtgdaterapport.Size = new System.Drawing.Size(1296, 249);
            this.dtgdaterapport.TabIndex = 17;
            // 
            // BtnValider
            // 
            this.BtnValider.Location = new System.Drawing.Point(843, 324);
            this.BtnValider.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnValider.Name = "BtnValider";
            this.BtnValider.Size = new System.Drawing.Size(85, 30);
            this.BtnValider.TabIndex = 16;
            this.BtnValider.Text = "Valider";
            this.BtnValider.UseVisualStyleBackColor = true;
            this.BtnValider.Click += new System.EventHandler(this.BtnValider_Click);
            // 
            // Dtprapports
            // 
            this.Dtprapports.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtprapports.Location = new System.Drawing.Point(587, 324);
            this.Dtprapports.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dtprapports.Name = "Dtprapports";
            this.Dtprapports.Size = new System.Drawing.Size(200, 22);
            this.Dtprapports.TabIndex = 15;
            // 
            // Frm_Calendrier_Compte_Rendu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1885, 775);
            this.ControlBox = false;
            this.Controls.Add(this.Lblnbrapportdateres);
            this.Controls.Add(this.Lblnbrapportdate);
            this.Controls.Add(this.Lbltitredate);
            this.Controls.Add(this.BtnFermer);
            this.Controls.Add(this.dtgdaterapport);
            this.Controls.Add(this.BtnValider);
            this.Controls.Add(this.Dtprapports);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_Calendrier_Compte_Rendu";
            this.Text = "Calendrier_Compte_Rendu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Calendrier_Compte_Rendu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgdaterapport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lblnbrapportdateres;
        private System.Windows.Forms.Label Lblnbrapportdate;
        private System.Windows.Forms.Label Lbltitredate;
        private System.Windows.Forms.Button BtnFermer;
        private System.Windows.Forms.DataGridView dtgdaterapport;
        private System.Windows.Forms.Button BtnValider;
        private System.Windows.Forms.DateTimePicker Dtprapports;
    }
}