namespace Pizza__bis_
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
            this.grpPâte = new System.Windows.Forms.GroupBox();
            this.optExtrafine = new System.Windows.Forms.RadioButton();
            this.optFine = new System.Windows.Forms.RadioButton();
            this.optNormale = new System.Windows.Forms.RadioButton();
            this.optEpaisse = new System.Windows.Forms.RadioButton();
            this.grpMozza = new System.Windows.Forms.GroupBox();
            this.optMozzaNorm = new System.Windows.Forms.RadioButton();
            this.optMozzaMaigre = new System.Windows.Forms.RadioButton();
            this.optMozzaBuff = new System.Windows.Forms.RadioButton();
            this.chkAnchois = new System.Windows.Forms.CheckBox();
            this.chkCapres = new System.Windows.Forms.CheckBox();
            this.chkJambon = new System.Windows.Forms.CheckBox();
            this.chkCrevettes = new System.Windows.Forms.CheckBox();
            this.btnCommander = new System.Windows.Forms.Button();
            this.btnChanger = new System.Windows.Forms.Button();
            this.lblRépertoire = new System.Windows.Forms.Label();
            this.txtRépertoire = new System.Windows.Forms.TextBox();
            this.grpPâte.SuspendLayout();
            this.grpMozza.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.Location = new System.Drawing.Point(30, 13);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(34, 13);
            this.lblTable.TabIndex = 0;
            this.lblTable.Text = "Table";
            // 
            // txtTable
            // 
            this.txtTable.Location = new System.Drawing.Point(70, 10);
            this.txtTable.Name = "txtTable";
            this.txtTable.Size = new System.Drawing.Size(44, 20);
            this.txtTable.TabIndex = 1;
            // 
            // grpPâte
            // 
            this.grpPâte.Controls.Add(this.optEpaisse);
            this.grpPâte.Controls.Add(this.optNormale);
            this.grpPâte.Controls.Add(this.optFine);
            this.grpPâte.Controls.Add(this.optExtrafine);
            this.grpPâte.Location = new System.Drawing.Point(33, 57);
            this.grpPâte.Name = "grpPâte";
            this.grpPâte.Size = new System.Drawing.Size(113, 121);
            this.grpPâte.TabIndex = 2;
            this.grpPâte.TabStop = false;
            this.grpPâte.Text = "Pâte";
            // 
            // optExtrafine
            // 
            this.optExtrafine.AutoSize = true;
            this.optExtrafine.Location = new System.Drawing.Point(7, 20);
            this.optExtrafine.Name = "optExtrafine";
            this.optExtrafine.Size = new System.Drawing.Size(69, 17);
            this.optExtrafine.TabIndex = 0;
            this.optExtrafine.TabStop = true;
            this.optExtrafine.Text = "Extra-fine";
            this.optExtrafine.UseVisualStyleBackColor = true;
            // 
            // optFine
            // 
            this.optFine.AutoSize = true;
            this.optFine.Location = new System.Drawing.Point(7, 44);
            this.optFine.Name = "optFine";
            this.optFine.Size = new System.Drawing.Size(45, 17);
            this.optFine.TabIndex = 1;
            this.optFine.TabStop = true;
            this.optFine.Text = "Fine";
            this.optFine.UseVisualStyleBackColor = true;
            // 
            // optNormale
            // 
            this.optNormale.AutoSize = true;
            this.optNormale.Location = new System.Drawing.Point(7, 68);
            this.optNormale.Name = "optNormale";
            this.optNormale.Size = new System.Drawing.Size(64, 17);
            this.optNormale.TabIndex = 2;
            this.optNormale.TabStop = true;
            this.optNormale.Text = "Normale";
            this.optNormale.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.optNormale.UseVisualStyleBackColor = true;
            // 
            // optEpaisse
            // 
            this.optEpaisse.AutoSize = true;
            this.optEpaisse.Location = new System.Drawing.Point(7, 92);
            this.optEpaisse.Name = "optEpaisse";
            this.optEpaisse.Size = new System.Drawing.Size(62, 17);
            this.optEpaisse.TabIndex = 3;
            this.optEpaisse.TabStop = true;
            this.optEpaisse.Text = "Epaisse";
            this.optEpaisse.UseVisualStyleBackColor = true;
            // 
            // grpMozza
            // 
            this.grpMozza.Controls.Add(this.optMozzaBuff);
            this.grpMozza.Controls.Add(this.optMozzaMaigre);
            this.grpMozza.Controls.Add(this.optMozzaNorm);
            this.grpMozza.Location = new System.Drawing.Point(163, 57);
            this.grpMozza.Name = "grpMozza";
            this.grpMozza.Size = new System.Drawing.Size(117, 121);
            this.grpMozza.TabIndex = 3;
            this.grpMozza.TabStop = false;
            this.grpMozza.Text = "Mozzarella";
            // 
            // optMozzaNorm
            // 
            this.optMozzaNorm.AutoSize = true;
            this.optMozzaNorm.Location = new System.Drawing.Point(7, 29);
            this.optMozzaNorm.Name = "optMozzaNorm";
            this.optMozzaNorm.Size = new System.Drawing.Size(64, 17);
            this.optMozzaNorm.TabIndex = 0;
            this.optMozzaNorm.TabStop = true;
            this.optMozzaNorm.Text = "Normale";
            this.optMozzaNorm.UseVisualStyleBackColor = true;
            // 
            // optMozzaMaigre
            // 
            this.optMozzaMaigre.AutoSize = true;
            this.optMozzaMaigre.Location = new System.Drawing.Point(7, 53);
            this.optMozzaMaigre.Name = "optMozzaMaigre";
            this.optMozzaMaigre.Size = new System.Drawing.Size(57, 17);
            this.optMozzaMaigre.TabIndex = 1;
            this.optMozzaMaigre.TabStop = true;
            this.optMozzaMaigre.Text = "Maigre";
            this.optMozzaMaigre.UseVisualStyleBackColor = true;
            // 
            // optMozzaBuff
            // 
            this.optMozzaBuff.AutoSize = true;
            this.optMozzaBuff.Location = new System.Drawing.Point(7, 77);
            this.optMozzaBuff.Name = "optMozzaBuff";
            this.optMozzaBuff.Size = new System.Drawing.Size(70, 17);
            this.optMozzaBuff.TabIndex = 2;
            this.optMozzaBuff.TabStop = true;
            this.optMozzaBuff.Text = "Bufflonne";
            this.optMozzaBuff.UseVisualStyleBackColor = true;
            // 
            // chkAnchois
            // 
            this.chkAnchois.AutoSize = true;
            this.chkAnchois.Location = new System.Drawing.Point(334, 77);
            this.chkAnchois.Name = "chkAnchois";
            this.chkAnchois.Size = new System.Drawing.Size(64, 17);
            this.chkAnchois.TabIndex = 4;
            this.chkAnchois.Text = "Anchois";
            this.chkAnchois.UseVisualStyleBackColor = true;
            // 
            // chkCapres
            // 
            this.chkCapres.AutoSize = true;
            this.chkCapres.Location = new System.Drawing.Point(334, 101);
            this.chkCapres.Name = "chkCapres";
            this.chkCapres.Size = new System.Drawing.Size(59, 17);
            this.chkCapres.TabIndex = 5;
            this.chkCapres.Text = "Câpres";
            this.chkCapres.UseVisualStyleBackColor = true;
            // 
            // chkJambon
            // 
            this.chkJambon.AutoSize = true;
            this.chkJambon.Location = new System.Drawing.Point(334, 125);
            this.chkJambon.Name = "chkJambon";
            this.chkJambon.Size = new System.Drawing.Size(63, 17);
            this.chkJambon.TabIndex = 6;
            this.chkJambon.Text = "Jambon";
            this.chkJambon.UseVisualStyleBackColor = true;
            // 
            // chkCrevettes
            // 
            this.chkCrevettes.AutoSize = true;
            this.chkCrevettes.Location = new System.Drawing.Point(334, 149);
            this.chkCrevettes.Name = "chkCrevettes";
            this.chkCrevettes.Size = new System.Drawing.Size(71, 17);
            this.chkCrevettes.TabIndex = 7;
            this.chkCrevettes.Text = "Crevettes";
            this.chkCrevettes.UseVisualStyleBackColor = true;
            // 
            // btnCommander
            // 
            this.btnCommander.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCommander.Location = new System.Drawing.Point(210, 209);
            this.btnCommander.Name = "btnCommander";
            this.btnCommander.Size = new System.Drawing.Size(114, 26);
            this.btnCommander.TabIndex = 8;
            this.btnCommander.Text = "Commander";
            this.btnCommander.UseVisualStyleBackColor = true;
            // 
            // btnChanger
            // 
            this.btnChanger.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChanger.Location = new System.Drawing.Point(13, 278);
            this.btnChanger.Name = "btnChanger";
            this.btnChanger.Size = new System.Drawing.Size(75, 23);
            this.btnChanger.TabIndex = 9;
            this.btnChanger.Text = "Changer";
            this.btnChanger.UseVisualStyleBackColor = true;
            // 
            // lblRépertoire
            // 
            this.lblRépertoire.AutoSize = true;
            this.lblRépertoire.Location = new System.Drawing.Point(107, 287);
            this.lblRépertoire.Name = "lblRépertoire";
            this.lblRépertoire.Size = new System.Drawing.Size(59, 13);
            this.lblRépertoire.TabIndex = 10;
            this.lblRépertoire.Text = "Répertoire:";
            // 
            // txtRépertoire
            // 
            this.txtRépertoire.Location = new System.Drawing.Point(170, 281);
            this.txtRépertoire.Name = "txtRépertoire";
            this.txtRépertoire.Size = new System.Drawing.Size(370, 20);
            this.txtRépertoire.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 313);
            this.Controls.Add(this.txtRépertoire);
            this.Controls.Add(this.lblRépertoire);
            this.Controls.Add(this.btnChanger);
            this.Controls.Add(this.btnCommander);
            this.Controls.Add(this.chkCrevettes);
            this.Controls.Add(this.chkJambon);
            this.Controls.Add(this.chkCapres);
            this.Controls.Add(this.chkAnchois);
            this.Controls.Add(this.grpMozza);
            this.Controls.Add(this.grpPâte);
            this.Controls.Add(this.txtTable);
            this.Controls.Add(this.lblTable);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpPâte.ResumeLayout(false);
            this.grpPâte.PerformLayout();
            this.grpMozza.ResumeLayout(false);
            this.grpMozza.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.TextBox txtTable;
        private System.Windows.Forms.GroupBox grpPâte;
        private System.Windows.Forms.RadioButton optEpaisse;
        private System.Windows.Forms.RadioButton optNormale;
        private System.Windows.Forms.RadioButton optFine;
        private System.Windows.Forms.RadioButton optExtrafine;
        private System.Windows.Forms.GroupBox grpMozza;
        private System.Windows.Forms.RadioButton optMozzaBuff;
        private System.Windows.Forms.RadioButton optMozzaMaigre;
        private System.Windows.Forms.RadioButton optMozzaNorm;
        private System.Windows.Forms.CheckBox chkAnchois;
        private System.Windows.Forms.CheckBox chkCapres;
        private System.Windows.Forms.CheckBox chkJambon;
        private System.Windows.Forms.CheckBox chkCrevettes;
        private System.Windows.Forms.Button btnCommander;
        private System.Windows.Forms.Button btnChanger;
        private System.Windows.Forms.Label lblRépertoire;
        private System.Windows.Forms.TextBox txtRépertoire;
    }
}

