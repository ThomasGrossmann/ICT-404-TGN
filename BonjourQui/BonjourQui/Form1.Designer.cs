namespace BonjourQui
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
            this.Name = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.btnBienvenue = new System.Windows.Forms.Button();
            this.BonjourNom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Name.Location = new System.Drawing.Point(25, 20);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(138, 29);
            this.Name.TabIndex = 0;
            this.Name.Text = "Votre nom";
            this.Name.Click += new System.EventHandler(this.label1_Click);
            // 
            // NameBox
            // 
            this.NameBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameBox.Location = new System.Drawing.Point(195, 20);
            this.NameBox.Multiline = true;
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(224, 31);
            this.NameBox.TabIndex = 1;
            // 
            // btnBienvenue
            // 
            this.btnBienvenue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnBienvenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBienvenue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBienvenue.Location = new System.Drawing.Point(150, 179);
            this.btnBienvenue.Name = "btnBienvenue";
            this.btnBienvenue.Size = new System.Drawing.Size(138, 49);
            this.btnBienvenue.TabIndex = 2;
            this.btnBienvenue.Text = "Bienvenue";
            this.btnBienvenue.UseVisualStyleBackColor = true;
            // 
            // BonjourNom
            // 
            this.BonjourNom.AutoSize = true;
            this.BonjourNom.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.BonjourNom.Location = new System.Drawing.Point(30, 110);
            this.BonjourNom.Name = "BonjourNom";
            this.BonjourNom.Size = new System.Drawing.Size(37, 29);
            this.BonjourNom.TabIndex = 3;
            this.BonjourNom.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 252);
            this.Controls.Add(this.BonjourNom);
            this.Controls.Add(this.btnBienvenue);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.Name);
            this.Name = "Form1";
            this.Text = "Bonjour Qui ?";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Button btnBienvenue;
        private System.Windows.Forms.Label BonjourNom;
    }
}

