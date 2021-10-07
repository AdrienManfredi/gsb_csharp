namespace BDMO_GSB
{
    partial class Frm_ajoutmedocs_CR
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
            this.Txtqte = new System.Windows.Forms.TextBox();
            this.Cbxlistemedoc = new System.Windows.Forms.ComboBox();
            this.btnajoutmedoc = new System.Windows.Forms.Button();
            this.Btnfermer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(789, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(522, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ajout d\'un médicament au compte rendu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(664, 415);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Liste médicaments:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1156, 414);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantité à ajouter:";
            // 
            // Txtqte
            // 
            this.Txtqte.Location = new System.Drawing.Point(1288, 414);
            this.Txtqte.Name = "Txtqte";
            this.Txtqte.Size = new System.Drawing.Size(100, 22);
            this.Txtqte.TabIndex = 3;
            this.Txtqte.Text = "1";
            // 
            // Cbxlistemedoc
            // 
            this.Cbxlistemedoc.FormattingEnabled = true;
            this.Cbxlistemedoc.Location = new System.Drawing.Point(810, 418);
            this.Cbxlistemedoc.Name = "Cbxlistemedoc";
            this.Cbxlistemedoc.Size = new System.Drawing.Size(231, 24);
            this.Cbxlistemedoc.TabIndex = 4;
            // 
            // btnajoutmedoc
            // 
            this.btnajoutmedoc.Location = new System.Drawing.Point(752, 518);
            this.btnajoutmedoc.Name = "btnajoutmedoc";
            this.btnajoutmedoc.Size = new System.Drawing.Size(228, 49);
            this.btnajoutmedoc.TabIndex = 5;
            this.btnajoutmedoc.Text = "Ajouter médicament";
            this.btnajoutmedoc.UseVisualStyleBackColor = true;
            this.btnajoutmedoc.Click += new System.EventHandler(this.btnajoutmedoc_Click);
            // 
            // Btnfermer
            // 
            this.Btnfermer.Location = new System.Drawing.Point(1169, 518);
            this.Btnfermer.Name = "Btnfermer";
            this.Btnfermer.Size = new System.Drawing.Size(165, 49);
            this.Btnfermer.TabIndex = 6;
            this.Btnfermer.Text = "Fermer";
            this.Btnfermer.UseVisualStyleBackColor = true;
            this.Btnfermer.Click += new System.EventHandler(this.Btnfermer_Click);
            // 
            // Frm_ajoutmedocs_CR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1500, 901);
            this.ControlBox = false;
            this.Controls.Add(this.Btnfermer);
            this.Controls.Add(this.btnajoutmedoc);
            this.Controls.Add(this.Cbxlistemedoc);
            this.Controls.Add(this.Txtqte);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_ajoutmedocs_CR";
            this.Text = "ajout médicaments";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_ajoutmedocs_CR_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txtqte;
        private System.Windows.Forms.ComboBox Cbxlistemedoc;
        private System.Windows.Forms.Button btnajoutmedoc;
        private System.Windows.Forms.Button Btnfermer;
    }
}