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
            this.cmb = new System.Windows.Forms.ComboBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnEffacer = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.lstEcoles = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.cmbGymnase = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmb
            // 
            this.cmb.ForeColor = System.Drawing.Color.DarkRed;
            this.cmb.FormattingEnabled = true;
            this.cmb.Items.AddRange(new object[] {
            "Swisscom",
            "Arches"});
            this.cmb.Location = new System.Drawing.Point(29, 29);
            this.cmb.Name = "cmb";
            this.cmb.Size = new System.Drawing.Size(121, 21);
            this.cmb.TabIndex = 0;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(191, 29);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(105, 33);
            this.btnAjouter.TabIndex = 1;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
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
            // listBox1
            // 
            this.listBox1.ForeColor = System.Drawing.Color.Blue;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(337, 29);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(121, 238);
            this.listBox1.TabIndex = 6;
            // 
            // cmbGymnase
            // 
            this.cmbGymnase.ForeColor = System.Drawing.Color.Fuchsia;
            this.cmbGymnase.FormattingEnabled = true;
            this.cmbGymnase.Items.AddRange(new object[] {
            "Gymnase du Bugnon",
            "Gymnase de Beaulieu",
            "Gymnase d\'Yverdon"});
            this.cmbGymnase.Location = new System.Drawing.Point(29, 311);
            this.cmbGymnase.Name = "cmbGymnase";
            this.cmbGymnase.Size = new System.Drawing.Size(121, 21);
            this.cmbGymnase.TabIndex = 7;
            // 
            // ComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 442);
            this.Controls.Add(this.cmbGymnase);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lstEcoles);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnEffacer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.cmb);
            this.Name = "ComboBox";
            this.Text = "ListBox et ComboBox avec des styles différents";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnEffacer;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.ListBox lstEcoles;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox cmbGymnase;
    }
}

