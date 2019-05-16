//Projet : Déductions
//Auteur : Thomas Grossmann
//Date : 13.05.2019

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Déductions_sociales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblImposable.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtRevenu.Text == "" || txtCoefficient.Text == "")
            {
                MessageBox.Show("Veuillez remplir les cases vides", "TES NUL");
            }
            else
            {
                float Revenu = float.Parse(txtRevenu.Text);
                float Coefficient = float.Parse(txtCoefficient.Text);
                int Jeune = int.Parse(txtJeune.Text);
                int Transport = int.Parse(txtTransport.Text);
                float Rabais = float.Parse(txtRabais.Text);
                float Imposable = Revenu / Coefficient;
                if (ckbRabais.Checked == true)
                {
                    Imposable = Imposable - ((Rabais / 100) * Imposable);
                }
                if (ckbJeune.Checked == true)
                {
                    Imposable = Imposable - Jeune;
                }
                if (ckbTransport.Checked == true)
                {
                    Imposable = Imposable - Transport;
                }
                lblImposable.Visible = true;
                lblImposable.Text = String.Format("Revenu imposable: {0:C2}", Imposable);
            }
        }
    }
}
