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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Name = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.BonjourNom = new System.Windows.Forms.Label();
            this.btnBienvenue = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
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
            this.NameBox.Location = new System.Drawing.Point(194, 17);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(224, 36);
            this.NameBox.TabIndex = 1;
            this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
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
            // btnBienvenue
            // 
            this.btnBienvenue.Enabled = false;
            this.btnBienvenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnBienvenue.Location = new System.Drawing.Point(147, 185);
            this.btnBienvenue.Name = "btnBienvenue";
            this.btnBienvenue.Size = new System.Drawing.Size(153, 55);
            this.btnBienvenue.TabIndex = 4;
            this.btnBienvenue.Text = "Bienvenue";
            this.btnBienvenue.UseVisualStyleBackColor = true;
            this.btnBienvenue.Click += new System.EventHandler(this.btnBienvenue_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQuitter.BackgroundImage")));
            this.btnQuitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuitter.Location = new System.Drawing.Point(364, 185);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(54, 53);
            this.btnQuitter.TabIndex = 5;
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 252);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnBienvenue);
            this.Controls.Add(this.BonjourNom);
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
        private System.Windows.Forms.Label BonjourNom;
        private System.Windows.Forms.Button btnBienvenue;
        private System.Windows.Forms.Button btnQuitter;
    }
}

