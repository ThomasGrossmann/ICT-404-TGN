namespace Déductions_sociales
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
            this.lblRevenu = new System.Windows.Forms.Label();
            this.txtRevenu = new System.Windows.Forms.TextBox();
            this.lblCoefficient = new System.Windows.Forms.Label();
            this.txtCoefficient = new System.Windows.Forms.TextBox();
            this.ckbJeune = new System.Windows.Forms.CheckBox();
            this.txtJeune = new System.Windows.Forms.TextBox();
            this.ckbTransport = new System.Windows.Forms.CheckBox();
            this.txtTransport = new System.Windows.Forms.TextBox();
            this.ckbRabais = new System.Windows.Forms.CheckBox();
            this.txtRabais = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblImposable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRevenu
            // 
            this.lblRevenu.AutoSize = true;
            this.lblRevenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevenu.Location = new System.Drawing.Point(24, 43);
            this.lblRevenu.Name = "lblRevenu";
            this.lblRevenu.Size = new System.Drawing.Size(133, 17);
            this.lblRevenu.TabIndex = 0;
            this.lblRevenu.Text = "Revenu annuel brut";
            // 
            // txtRevenu
            // 
            this.txtRevenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRevenu.Location = new System.Drawing.Point(223, 43);
            this.txtRevenu.Name = "txtRevenu";
            this.txtRevenu.Size = new System.Drawing.Size(128, 21);
            this.txtRevenu.TabIndex = 1;
            this.txtRevenu.Text = "145000";
            this.txtRevenu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCoefficient
            // 
            this.lblCoefficient.AutoSize = true;
            this.lblCoefficient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoefficient.Location = new System.Drawing.Point(27, 111);
            this.lblCoefficient.Name = "lblCoefficient";
            this.lblCoefficient.Size = new System.Drawing.Size(121, 17);
            this.lblCoefficient.TabIndex = 2;
            this.lblCoefficient.Text = "Coefficient familial";
            // 
            // txtCoefficient
            // 
            this.txtCoefficient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCoefficient.Location = new System.Drawing.Point(299, 111);
            this.txtCoefficient.Name = "txtCoefficient";
            this.txtCoefficient.Size = new System.Drawing.Size(51, 21);
            this.txtCoefficient.TabIndex = 2;
            this.txtCoefficient.Text = "2.5";
            this.txtCoefficient.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ckbJeune
            // 
            this.ckbJeune.AutoSize = true;
            this.ckbJeune.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbJeune.Location = new System.Drawing.Point(87, 182);
            this.ckbJeune.Name = "ckbJeune";
            this.ckbJeune.Size = new System.Drawing.Size(130, 21);
            this.ckbJeune.TabIndex = 3;
            this.ckbJeune.Text = "Déduction jeune";
            this.ckbJeune.UseVisualStyleBackColor = true;
            // 
            // txtJeune
            // 
            this.txtJeune.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJeune.Location = new System.Drawing.Point(299, 182);
            this.txtJeune.Name = "txtJeune";
            this.txtJeune.Size = new System.Drawing.Size(50, 21);
            this.txtJeune.TabIndex = 4;
            this.txtJeune.Text = "900";
            this.txtJeune.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ckbTransport
            // 
            this.ckbTransport.AutoSize = true;
            this.ckbTransport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbTransport.Location = new System.Drawing.Point(87, 220);
            this.ckbTransport.Name = "ckbTransport";
            this.ckbTransport.Size = new System.Drawing.Size(152, 21);
            this.ckbTransport.TabIndex = 5;
            this.ckbTransport.Text = "Déduction transport";
            this.ckbTransport.UseVisualStyleBackColor = true;
            // 
            // txtTransport
            // 
            this.txtTransport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransport.Location = new System.Drawing.Point(299, 220);
            this.txtTransport.Name = "txtTransport";
            this.txtTransport.Size = new System.Drawing.Size(50, 21);
            this.txtTransport.TabIndex = 6;
            this.txtTransport.Text = "650";
            this.txtTransport.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ckbRabais
            // 
            this.ckbRabais.AutoSize = true;
            this.ckbRabais.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbRabais.Location = new System.Drawing.Point(87, 259);
            this.ckbRabais.Name = "ckbRabais";
            this.ckbRabais.Size = new System.Drawing.Size(142, 21);
            this.ckbRabais.TabIndex = 7;
            this.ckbRabais.Text = "Rabais fidélité (%)";
            this.ckbRabais.UseVisualStyleBackColor = true;
            // 
            // txtRabais
            // 
            this.txtRabais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRabais.Location = new System.Drawing.Point(299, 259);
            this.txtRabais.Name = "txtRabais";
            this.txtRabais.Size = new System.Drawing.Size(50, 21);
            this.txtRabais.TabIndex = 8;
            this.txtRabais.Text = "0";
            this.txtRabais.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(145, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 30);
            this.button1.TabIndex = 9;
            this.button1.Text = "Calcul";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblImposable
            // 
            this.lblImposable.AutoSize = true;
            this.lblImposable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImposable.Location = new System.Drawing.Point(83, 354);
            this.lblImposable.Name = "lblImposable";
            this.lblImposable.Size = new System.Drawing.Size(183, 20);
            this.lblImposable.TabIndex = 10;
            this.lblImposable.Text = "Revenu imposable: fr.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 383);
            this.Controls.Add(this.lblImposable);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtRabais);
            this.Controls.Add(this.ckbRabais);
            this.Controls.Add(this.txtTransport);
            this.Controls.Add(this.ckbTransport);
            this.Controls.Add(this.txtJeune);
            this.Controls.Add(this.ckbJeune);
            this.Controls.Add(this.txtCoefficient);
            this.Controls.Add(this.lblCoefficient);
            this.Controls.Add(this.txtRevenu);
            this.Controls.Add(this.lblRevenu);
            this.Name = "Form1";
            this.Text = "Déductions";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRevenu;
        private System.Windows.Forms.TextBox txtRevenu;
        private System.Windows.Forms.Label lblCoefficient;
        private System.Windows.Forms.TextBox txtCoefficient;
        private System.Windows.Forms.CheckBox ckbJeune;
        private System.Windows.Forms.TextBox txtJeune;
        private System.Windows.Forms.CheckBox ckbTransport;
        private System.Windows.Forms.TextBox txtTransport;
        private System.Windows.Forms.CheckBox ckbRabais;
        private System.Windows.Forms.TextBox txtRabais;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblImposable;
    }
}

