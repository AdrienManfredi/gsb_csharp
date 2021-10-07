namespace BDMO_GSB
{
    partial class Frm_insertion_cr
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Cbx_matricule = new System.Windows.Forms.ComboBox();
            this.Cbx_Numpraticiens = new System.Windows.Forms.ComboBox();
            this.Btn_ajouter = new System.Windows.Forms.Button();
            this.Tbx_bilan = new System.Windows.Forms.TextBox();
            this.Tbx_motif = new System.Windows.Forms.TextBox();
            this.btnFermer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1032, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ajout rapport de visite";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(716, 408);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Matricule visiteur: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1144, 408);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Num praticiens: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(716, 475);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date : ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(863, 475);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(719, 543);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Bilan : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(719, 610);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Motif : ";
            // 
            // Cbx_matricule
            // 
            this.Cbx_matricule.FormattingEnabled = true;
            this.Cbx_matricule.Location = new System.Drawing.Point(863, 405);
            this.Cbx_matricule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cbx_matricule.Name = "Cbx_matricule";
            this.Cbx_matricule.Size = new System.Drawing.Size(215, 24);
            this.Cbx_matricule.TabIndex = 9;
            // 
            // Cbx_Numpraticiens
            // 
            this.Cbx_Numpraticiens.FormattingEnabled = true;
            this.Cbx_Numpraticiens.Location = new System.Drawing.Point(1296, 402);
            this.Cbx_Numpraticiens.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cbx_Numpraticiens.Name = "Cbx_Numpraticiens";
            this.Cbx_Numpraticiens.Size = new System.Drawing.Size(201, 24);
            this.Cbx_Numpraticiens.TabIndex = 10;
            // 
            // Btn_ajouter
            // 
            this.Btn_ajouter.Location = new System.Drawing.Point(1119, 690);
            this.Btn_ajouter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_ajouter.Name = "Btn_ajouter";
            this.Btn_ajouter.Size = new System.Drawing.Size(108, 46);
            this.Btn_ajouter.TabIndex = 11;
            this.Btn_ajouter.Text = "Ajouter";
            this.Btn_ajouter.UseVisualStyleBackColor = true;
            this.Btn_ajouter.Click += new System.EventHandler(this.Btn_ajouter_Click);
            // 
            // Tbx_bilan
            // 
            this.Tbx_bilan.Location = new System.Drawing.Point(863, 539);
            this.Tbx_bilan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Tbx_bilan.Name = "Tbx_bilan";
            this.Tbx_bilan.Size = new System.Drawing.Size(200, 22);
            this.Tbx_bilan.TabIndex = 12;
            this.Tbx_bilan.Text = "0";
            // 
            // Tbx_motif
            // 
            this.Tbx_motif.Location = new System.Drawing.Point(863, 607);
            this.Tbx_motif.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Tbx_motif.Name = "Tbx_motif";
            this.Tbx_motif.Size = new System.Drawing.Size(200, 22);
            this.Tbx_motif.TabIndex = 13;
            this.Tbx_motif.Text = "0";
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(1296, 690);
            this.btnFermer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(108, 47);
            this.btnFermer.TabIndex = 14;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // Frm_insertion_cr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1559, 991);
            this.ControlBox = false;
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.Tbx_motif);
            this.Controls.Add(this.Tbx_bilan);
            this.Controls.Add(this.Btn_ajouter);
            this.Controls.Add(this.Cbx_Numpraticiens);
            this.Controls.Add(this.Cbx_matricule);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_insertion_cr";
            this.Text = "Insertion Compte Rendus";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_insertion_cr_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Cbx_matricule;
        private System.Windows.Forms.ComboBox Cbx_Numpraticiens;
        private System.Windows.Forms.Button Btn_ajouter;
        private System.Windows.Forms.TextBox Tbx_bilan;
        private System.Windows.Forms.TextBox Tbx_motif;
        private System.Windows.Forms.Button btnFermer;
    }
}