namespace BDMO_GSB
{
    partial class Frm_suppression_CR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_suppression_CR));
            this.label1 = new System.Windows.Forms.Label();
            this.dtg_SuppressionCompteRendu = new System.Windows.Forms.DataGridView();
            this.btnFermer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_SuppressionCompteRendu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // dtg_SuppressionCompteRendu
            // 
            this.dtg_SuppressionCompteRendu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dtg_SuppressionCompteRendu, "dtg_SuppressionCompteRendu");
            this.dtg_SuppressionCompteRendu.Name = "dtg_SuppressionCompteRendu";
            this.dtg_SuppressionCompteRendu.RowTemplate.Height = 24;
            this.dtg_SuppressionCompteRendu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_SuppressionCompteRendu_CellClick);
            // 
            // btnFermer
            // 
            resources.ApplyResources(this.btnFermer, "btnFermer");
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // Frm_suppression_CR
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ControlBox = false;
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.dtg_SuppressionCompteRendu);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_suppression_CR";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_suppression_CR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_SuppressionCompteRendu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtg_SuppressionCompteRendu;
        private System.Windows.Forms.Button btnFermer;
    }
}