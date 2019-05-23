namespace Pizza
{
    partial class Form1
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
            this.lblTable = new System.Windows.Forms.Label();
            this.txtTable = new System.Windows.Forms.TextBox();
            this.optExtra = new System.Windows.Forms.RadioButton();
            this.optFine = new System.Windows.Forms.RadioButton();
            this.optNormale = new System.Windows.Forms.RadioButton();
            this.optEpaisse = new System.Windows.Forms.RadioButton();
            this.grpPâte = new System.Windows.Forms.GroupBox();
            this.chkAnchois = new System.Windows.Forms.CheckBox();
            this.chkCapres = new System.Windows.Forms.CheckBox();
            this.chkJambon = new System.Windows.Forms.CheckBox();
            this.chkCrevettes = new System.Windows.Forms.CheckBox();
            this.btnCommander = new System.Windows.Forms.Button();
            this.lblCommande = new System.Windows.Forms.Label();
            this.txtCommande = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.Location = new System.Drawing.Point(42, 16);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(34, 13);
            this.lblTable.TabIndex = 0;
            this.lblTable.Text = "Table";
            // 
            // txtTable
            // 
            this.txtTable.Location = new System.Drawing.Point(82, 13);
            this.txtTable.Name = "txtTable";
            this.txtTable.Size = new System.Drawing.Size(40, 20);
            this.txtTable.TabIndex = 1;
            // 
            // optExtra
            // 
            this.optExtra.AutoSize = true;
            this.optExtra.Location = new System.Drawing.Point(59, 79);
            this.optExtra.Name = "optExtra";
            this.optExtra.Size = new System.Drawing.Size(69, 17);
            this.optExtra.TabIndex = 2;
            this.optExtra.TabStop = true;
            this.optExtra.Text = "Extra-fine";
            this.optExtra.UseVisualStyleBackColor = true;
            // 
            // optFine
            // 
            this.optFine.AutoSize = true;
            this.optFine.Location = new System.Drawing.Point(59, 102);
            this.optFine.Name = "optFine";
            this.optFine.Size = new System.Drawing.Size(45, 17);
            this.optFine.TabIndex = 3;
            this.optFine.TabStop = true;
            this.optFine.Text = "Fine";
            this.optFine.UseVisualStyleBackColor = true;
            // 
            // optNormale
            // 
            this.optNormale.AutoSize = true;
            this.optNormale.Location = new System.Drawing.Point(59, 125);
            this.optNormale.Name = "optNormale";
            this.optNormale.Size = new System.Drawing.Size(64, 17);
            this.optNormale.TabIndex = 4;
            this.optNormale.TabStop = true;
            this.optNormale.Text = "Normale";
            this.optNormale.UseVisualStyleBackColor = true;
            // 
            // optEpaisse
            // 
            this.optEpaisse.AutoSize = true;
            this.optEpaisse.Location = new System.Drawing.Point(59, 148);
            this.optEpaisse.Name = "optEpaisse";
            this.optEpaisse.Size = new System.Drawing.Size(62, 17);
            this.optEpaisse.TabIndex = 5;
            this.optEpaisse.TabStop = true;
            this.optEpaisse.Text = "Epaisse";
            this.optEpaisse.UseVisualStyleBackColor = true;
            // 
            // grpPâte
            // 
            this.grpPâte.Location = new System.Drawing.Point(45, 57);
            this.grpPâte.Name = "grpPâte";
            this.grpPâte.Size = new System.Drawing.Size(98, 121);
            this.grpPâte.TabIndex = 6;
            this.grpPâte.TabStop = false;
            this.grpPâte.Text = "Pâte";
            // 
            // chkAnchois
            // 
            this.chkAnchois.AutoSize = true;
            this.chkAnchois.Location = new System.Drawing.Point(217, 79);
            this.chkAnchois.Name = "chkAnchois";
            this.chkAnchois.Size = new System.Drawing.Size(64, 17);
            this.chkAnchois.TabIndex = 7;
            this.chkAnchois.Text = "Anchois";
            this.chkAnchois.UseVisualStyleBackColor = true;
            // 
            // chkCapres
            // 
            this.chkCapres.AutoSize = true;
            this.chkCapres.Location = new System.Drawing.Point(217, 103);
            this.chkCapres.Name = "chkCapres";
            this.chkCapres.Size = new System.Drawing.Size(59, 17);
            this.chkCapres.TabIndex = 8;
            this.chkCapres.Text = "Câpres";
            this.chkCapres.UseVisualStyleBackColor = true;
            // 
            // chkJambon
            // 
            this.chkJambon.AutoSize = true;
            this.chkJambon.Location = new System.Drawing.Point(217, 127);
            this.chkJambon.Name = "chkJambon";
            this.chkJambon.Size = new System.Drawing.Size(63, 17);
            this.chkJambon.TabIndex = 9;
            this.chkJambon.Text = "Jambon";
            this.chkJambon.UseVisualStyleBackColor = true;
            // 
            // chkCrevettes
            // 
            this.chkCrevettes.AutoSize = true;
            this.chkCrevettes.Location = new System.Drawing.Point(217, 151);
            this.chkCrevettes.Name = "chkCrevettes";
            this.chkCrevettes.Size = new System.Drawing.Size(71, 17);
            this.chkCrevettes.TabIndex = 10;
            this.chkCrevettes.Text = "Crevettes";
            this.chkCrevettes.UseVisualStyleBackColor = true;
            // 
            // btnCommander
            // 
            this.btnCommander.Location = new System.Drawing.Point(237, 201);
            this.btnCommander.Name = "btnCommander";
            this.btnCommander.Size = new System.Drawing.Size(75, 23);
            this.btnCommander.TabIndex = 11;
            this.btnCommander.Text = "Commander";
            this.btnCommander.UseVisualStyleBackColor = true;
            this.btnCommander.Click += new System.EventHandler(this.btnCommander_Click);
            // 
            // lblCommande
            // 
            this.lblCommande.AutoSize = true;
            this.lblCommande.Location = new System.Drawing.Point(42, 211);
            this.lblCommande.Name = "lblCommande";
            this.lblCommande.Size = new System.Drawing.Size(60, 13);
            this.lblCommande.TabIndex = 12;
            this.lblCommande.Text = "Commande";
            // 
            // txtCommande
            // 
            this.txtCommande.BackColor = System.Drawing.Color.Yellow;
            this.txtCommande.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCommande.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommande.Location = new System.Drawing.Point(45, 230);
            this.txtCommande.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtCommande.Multiline = true;
            this.txtCommande.Name = "txtCommande";
            this.txtCommande.Size = new System.Drawing.Size(267, 65);
            this.txtCommande.TabIndex = 13;
            this.txtCommande.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 307);
            this.Controls.Add(this.txtCommande);
            this.Controls.Add(this.lblCommande);
            this.Controls.Add(this.btnCommander);
            this.Controls.Add(this.chkCrevettes);
            this.Controls.Add(this.chkJambon);
            this.Controls.Add(this.chkCapres);
            this.Controls.Add(this.chkAnchois);
            this.Controls.Add(this.optEpaisse);
            this.Controls.Add(this.optNormale);
            this.Controls.Add(this.optFine);
            this.Controls.Add(this.optExtra);
            this.Controls.Add(this.txtTable);
            this.Controls.Add(this.lblTable);
            this.Controls.Add(this.grpPâte);
            this.Name = "Form1";
            this.Text = "Pizza";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.TextBox txtTable;
        private System.Windows.Forms.RadioButton optExtra;
        private System.Windows.Forms.RadioButton optFine;
        private System.Windows.Forms.RadioButton optNormale;
        private System.Windows.Forms.RadioButton optEpaisse;
        private System.Windows.Forms.GroupBox grpPâte;
        private System.Windows.Forms.CheckBox chkAnchois;
        private System.Windows.Forms.CheckBox chkCapres;
        private System.Windows.Forms.CheckBox chkJambon;
        private System.Windows.Forms.CheckBox chkCrevettes;
        private System.Windows.Forms.Button btnCommander;
        private System.Windows.Forms.Label lblCommande;
        private System.Windows.Forms.TextBox txtCommande;
    }
}

