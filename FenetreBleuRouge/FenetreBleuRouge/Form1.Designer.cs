namespace FenetreBleuRouge
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
            this.btnHG = new System.Windows.Forms.Button();
            this.btnBG = new System.Windows.Forms.Button();
            this.btnHD = new System.Windows.Forms.Button();
            this.btnBD = new System.Windows.Forms.Button();
            this.btnBleu = new System.Windows.Forms.Button();
            this.btnRouge = new System.Windows.Forms.Button();
            this.btnStats = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHG
            // 
            this.btnHG.Location = new System.Drawing.Point(12, 12);
            this.btnHG.Name = "btnHG";
            this.btnHG.Size = new System.Drawing.Size(85, 23);
            this.btnHG.TabIndex = 0;
            this.btnHG.Text = "Haut/Gauche";
            this.btnHG.UseVisualStyleBackColor = true;
            this.btnHG.Click += new System.EventHandler(this.btnHG_Click);
            // 
            // btnBG
            // 
            this.btnBG.Location = new System.Drawing.Point(12, 295);
            this.btnBG.Name = "btnBG";
            this.btnBG.Size = new System.Drawing.Size(85, 23);
            this.btnBG.TabIndex = 1;
            this.btnBG.Text = "Bas/Gauche";
            this.btnBG.UseVisualStyleBackColor = true;
            this.btnBG.Click += new System.EventHandler(this.btnBG_Click);
            // 
            // btnHD
            // 
            this.btnHD.Location = new System.Drawing.Point(286, 12);
            this.btnHD.Name = "btnHD";
            this.btnHD.Size = new System.Drawing.Size(81, 23);
            this.btnHD.TabIndex = 2;
            this.btnHD.Text = "Haut/Droite";
            this.btnHD.UseVisualStyleBackColor = true;
            this.btnHD.Click += new System.EventHandler(this.btnHD_Click);
            // 
            // btnBD
            // 
            this.btnBD.Location = new System.Drawing.Point(292, 295);
            this.btnBD.Name = "btnBD";
            this.btnBD.Size = new System.Drawing.Size(75, 23);
            this.btnBD.TabIndex = 3;
            this.btnBD.Text = "Bas/Droite";
            this.btnBD.UseVisualStyleBackColor = true;
            this.btnBD.Click += new System.EventHandler(this.btnBD_Click);
            // 
            // btnBleu
            // 
            this.btnBleu.Location = new System.Drawing.Point(149, 77);
            this.btnBleu.Name = "btnBleu";
            this.btnBleu.Size = new System.Drawing.Size(75, 23);
            this.btnBleu.TabIndex = 4;
            this.btnBleu.Text = "Bleu";
            this.btnBleu.UseVisualStyleBackColor = true;
            this.btnBleu.Click += new System.EventHandler(this.btnBleu_Click);
            // 
            // btnRouge
            // 
            this.btnRouge.Location = new System.Drawing.Point(149, 106);
            this.btnRouge.Name = "btnRouge";
            this.btnRouge.Size = new System.Drawing.Size(75, 23);
            this.btnRouge.TabIndex = 5;
            this.btnRouge.Text = "Rouge";
            this.btnRouge.UseVisualStyleBackColor = true;
            this.btnRouge.Click += new System.EventHandler(this.btnRouge_Click);
            // 
            // btnStats
            // 
            this.btnStats.Location = new System.Drawing.Point(149, 174);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(75, 23);
            this.btnStats.TabIndex = 6;
            this.btnStats.Text = "Stats";
            this.btnStats.UseVisualStyleBackColor = true;
            this.btnStats.Click += new System.EventHandler(this.btnStats_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(149, 243);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 7;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 330);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnStats);
            this.Controls.Add(this.btnRouge);
            this.Controls.Add(this.btnBleu);
            this.Controls.Add(this.btnBD);
            this.Controls.Add(this.btnHD);
            this.Controls.Add(this.btnBG);
            this.Controls.Add(this.btnHG);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fenetre";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHG;
        private System.Windows.Forms.Button btnBG;
        private System.Windows.Forms.Button btnHD;
        private System.Windows.Forms.Button btnBD;
        private System.Windows.Forms.Button btnBleu;
        private System.Windows.Forms.Button btnRouge;
        private System.Windows.Forms.Button btnStats;
        private System.Windows.Forms.Button btnQuitter;
    }
}

