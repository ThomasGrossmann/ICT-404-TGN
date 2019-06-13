namespace Traban
{
    partial class Trabant2000
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
            this.lblPrix = new System.Windows.Forms.Label();
            this.txtPrix = new System.Windows.Forms.TextBox();
            this.grpMoteur = new System.Windows.Forms.GroupBox();
            this.optPrixBase = new System.Windows.Forms.RadioButton();
            this.optPlus = new System.Windows.Forms.RadioButton();
            this.lblTaxe = new System.Windows.Forms.Label();
            this.chkTaxe = new System.Windows.Forms.CheckBox();
            this.lblFinal = new System.Windows.Forms.Label();
            this.txtFinal = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.grpMoteur.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPrix
            // 
            this.lblPrix.AutoSize = true;
            this.lblPrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrix.Location = new System.Drawing.Point(36, 43);
            this.lblPrix.Name = "lblPrix";
            this.lblPrix.Size = new System.Drawing.Size(327, 24);
            this.lblPrix.TabIndex = 0;
            this.lblPrix.Text = "Prix de base en € (doit être >10000 €):";
            // 
            // txtPrix
            // 
            this.txtPrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrix.Location = new System.Drawing.Point(405, 40);
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.Size = new System.Drawing.Size(100, 29);
            this.txtPrix.TabIndex = 1;
            this.txtPrix.Text = "12300";
            // 
            // grpMoteur
            // 
            this.grpMoteur.Controls.Add(this.optPlus);
            this.grpMoteur.Controls.Add(this.optPrixBase);
            this.grpMoteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMoteur.Location = new System.Drawing.Point(40, 129);
            this.grpMoteur.Name = "grpMoteur";
            this.grpMoteur.Size = new System.Drawing.Size(365, 131);
            this.grpMoteur.TabIndex = 2;
            this.grpMoteur.TabStop = false;
            this.grpMoteur.Text = "Choix du moteur";
            // 
            // optPrixBase
            // 
            this.optPrixBase.AutoSize = true;
            this.optPrixBase.Checked = true;
            this.optPrixBase.Location = new System.Drawing.Point(15, 39);
            this.optPrixBase.Name = "optPrixBase";
            this.optPrixBase.Size = new System.Drawing.Size(307, 28);
            this.optPrixBase.TabIndex = 0;
            this.optPrixBase.TabStop = true;
            this.optPrixBase.Text = "1.4L : inclus dans le prix de base.";
            this.optPrixBase.UseVisualStyleBackColor = true;
            // 
            // optPlus
            // 
            this.optPlus.AutoSize = true;
            this.optPlus.Location = new System.Drawing.Point(15, 85);
            this.optPlus.Name = "optPlus";
            this.optPlus.Size = new System.Drawing.Size(133, 28);
            this.optPlus.TabIndex = 1;
            this.optPlus.Text = "1.6L : 2210 €";
            this.optPlus.UseVisualStyleBackColor = true;
            // 
            // lblTaxe
            // 
            this.lblTaxe.AutoSize = true;
            this.lblTaxe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxe.Location = new System.Drawing.Point(51, 280);
            this.lblTaxe.Name = "lblTaxe";
            this.lblTaxe.Size = new System.Drawing.Size(63, 24);
            this.lblTaxe.TabIndex = 3;
            this.lblTaxe.Text = "Taxe :";
            // 
            // chkTaxe
            // 
            this.chkTaxe.AutoSize = true;
            this.chkTaxe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTaxe.Location = new System.Drawing.Point(55, 329);
            this.chkTaxe.Name = "chkTaxe";
            this.chkTaxe.Size = new System.Drawing.Size(217, 28);
            this.chkTaxe.TabIndex = 4;
            this.chkTaxe.Text = "Inclure la taxe de 6.8%";
            this.chkTaxe.UseVisualStyleBackColor = true;
            // 
            // lblFinal
            // 
            this.lblFinal.AutoSize = true;
            this.lblFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinal.Location = new System.Drawing.Point(52, 407);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(110, 24);
            this.lblFinal.TabIndex = 5;
            this.lblFinal.Text = "Prix FINAL :";
            // 
            // txtFinal
            // 
            this.txtFinal.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.txtFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinal.ForeColor = System.Drawing.Color.Yellow;
            this.txtFinal.Location = new System.Drawing.Point(235, 401);
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Size = new System.Drawing.Size(100, 32);
            this.txtFinal.TabIndex = 6;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(374, 395);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(289, 38);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Remettre le formulaire à zéro";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.Location = new System.Drawing.Point(521, 463);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(142, 34);
            this.btnQuitter.TabIndex = 8;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // Trabant2000
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 530);
            this.ControlBox = false;
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtFinal);
            this.Controls.Add(this.lblFinal);
            this.Controls.Add(this.chkTaxe);
            this.Controls.Add(this.lblTaxe);
            this.Controls.Add(this.grpMoteur);
            this.Controls.Add(this.txtPrix);
            this.Controls.Add(this.lblPrix);
            this.Name = "Trabant2000";
            this.Text = "Trabant 2000";
            this.Load += new System.EventHandler(this.Trabant2000_Load);
            this.grpMoteur.ResumeLayout(false);
            this.grpMoteur.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrix;
        private System.Windows.Forms.TextBox txtPrix;
        private System.Windows.Forms.GroupBox grpMoteur;
        private System.Windows.Forms.RadioButton optPlus;
        private System.Windows.Forms.RadioButton optPrixBase;
        private System.Windows.Forms.Label lblTaxe;
        private System.Windows.Forms.CheckBox chkTaxe;
        private System.Windows.Forms.Label lblFinal;
        private System.Windows.Forms.TextBox txtFinal;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnQuitter;
    }
}

