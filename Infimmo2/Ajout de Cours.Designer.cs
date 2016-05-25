namespace Infimmo2
{
    partial class Ajout_de_Cours
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
            this.txbTitre = new System.Windows.Forms.TextBox();
            this.btnValiderTitre = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Veuillez entrer le titre du nouveau chapitre:";
            // 
            // txbTitre
            // 
            this.txbTitre.Location = new System.Drawing.Point(63, 96);
            this.txbTitre.Name = "txbTitre";
            this.txbTitre.Size = new System.Drawing.Size(205, 20);
            this.txbTitre.TabIndex = 1;
            this.txbTitre.TextChanged += new System.EventHandler(this.txbTitre_TextChanged);
            // 
            // btnValiderTitre
            // 
            this.btnValiderTitre.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnValiderTitre.Location = new System.Drawing.Point(192, 167);
            this.btnValiderTitre.Name = "btnValiderTitre";
            this.btnValiderTitre.Size = new System.Drawing.Size(75, 23);
            this.btnValiderTitre.TabIndex = 2;
            this.btnValiderTitre.Text = "OK";
            this.btnValiderTitre.UseVisualStyleBackColor = true;
            this.btnValiderTitre.Click += new System.EventHandler(this.btnValiderTitre_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Location = new System.Drawing.Point(102, 167);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 3;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // Ajout_de_Cours
            // 
            this.AcceptButton = this.btnValiderTitre;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 262);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnValiderTitre);
            this.Controls.Add(this.txbTitre);
            this.Controls.Add(this.label1);
            this.Name = "Ajout_de_Cours";
            this.Text = "Ajout_de_Cours";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbTitre;
        private System.Windows.Forms.Button btnValiderTitre;
        private System.Windows.Forms.Button btnAnnuler;
    }
}