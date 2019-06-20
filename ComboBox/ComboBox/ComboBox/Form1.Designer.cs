namespace ComboBox
{
    partial class ComboBox
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboHG = new System.Windows.Forms.ComboBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnEffacer = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.lstEcoles = new System.Windows.Forms.ListBox();
            this.cboGymnase = new System.Windows.Forms.ComboBox();
            this.lstRes = new System.Windows.Forms.ListBox();
            this.lblEcoles = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboHG
            // 
            this.cboHG.ForeColor = System.Drawing.Color.DarkRed;
            this.cboHG.FormattingEnabled = true;
            this.cboHG.Location = new System.Drawing.Point(29, 29);
            this.cboHG.Name = "cboHG";
            this.cboHG.Size = new System.Drawing.Size(121, 21);
            this.cboHG.TabIndex = 0;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(191, 29);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(105, 33);
            this.btnAjouter.TabIndex = 1;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnEffacer
            // 
            this.btnEffacer.Location = new System.Drawing.Point(191, 121);
            this.btnEffacer.Name = "btnEffacer";
            this.btnEffacer.Size = new System.Drawing.Size(103, 36);
            this.btnEffacer.TabIndex = 2;
            this.btnEffacer.Text = "Effacer";
            this.btnEffacer.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(191, 196);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(103, 36);
            this.btnSupprimer.TabIndex = 3;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(191, 311);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(105, 37);
            this.btnQuitter.TabIndex = 4;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            // 
            // lstEcoles
            // 
            this.lstEcoles.ForeColor = System.Drawing.Color.Green;
            this.lstEcoles.FormattingEnabled = true;
            this.lstEcoles.Items.AddRange(new object[] {
            "CEPM",
            "CPNV",
            "ECL",
            "EPCL",
            "EPSIC",
            "ETML"});
            this.lstEcoles.Location = new System.Drawing.Point(29, 97);
            this.lstEcoles.Name = "lstEcoles";
            this.lstEcoles.Size = new System.Drawing.Size(121, 173);
            this.lstEcoles.TabIndex = 5;
            // 
            // cboGymnase
            // 
            this.cboGymnase.ForeColor = System.Drawing.Color.Fuchsia;
            this.cboGymnase.FormattingEnabled = true;
            this.cboGymnase.Location = new System.Drawing.Point(29, 311);
            this.cboGymnase.Name = "cboGymnase";
            this.cboGymnase.Size = new System.Drawing.Size(121, 21);
            this.cboGymnase.TabIndex = 7;
            // 
            // lstRes
            // 
            this.lstRes.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lstRes.FormattingEnabled = true;
            this.lstRes.Location = new System.Drawing.Point(343, 29);
            this.lstRes.Name = "lstRes";
            this.lstRes.Size = new System.Drawing.Size(121, 238);
            this.lstRes.TabIndex = 8;
            // 
            // lblEcoles
            // 
            this.lblEcoles.AutoSize = true;
            this.lblEcoles.Location = new System.Drawing.Point(349, 306);
            this.lblEcoles.Name = "lblEcoles";
            this.lblEcoles.Size = new System.Drawing.Size(106, 13);
            this.lblEcoles.TabIndex = 10;
            this.lblEcoles.Text = "écoles sélectionnées";
            // 
            // ComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 442);
            this.Controls.Add(this.lblEcoles);
            this.Controls.Add(this.lstRes);
            this.Controls.Add(this.cboGymnase);
            this.Controls.Add(this.lstEcoles);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnEffacer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.cboHG);
            this.Name = "ComboBox";
            this.Text = "ListBox et ComboBox avec des styles différents";
            this.Load += new System.EventHandler(this.ComboBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboHG;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnEffacer;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.ListBox lstEcoles;
        private System.Windows.Forms.ComboBox cboGymnase;
        private System.Windows.Forms.ListBox lstRes;
        private System.Windows.Forms.Label lblEcoles;
    }
}

