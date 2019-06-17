//Auteur : Thomas Grossmann
//Programme : Trabant 2000
//Date : 17.06.2019

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Traban
{
    public partial class Trabant2000 : Form
    {
        public Trabant2000()
        {
            InitializeComponent();
        }

        private void Trabant2000_Load(object sender, EventArgs e)
        {
            float PrixBase = float.Parse(txtPrix.Text);
            if(txtPrix.Text == "12300" && optPrixBase.Checked == true && chkTaxe.Checked == false)
            {
                txtFinal.Text = PrixBase + " €";
            }
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtPrix.Text = "12300";
            optPlus.Checked = false;
            optPrixBase.Checked = true;
            chkTaxe.Checked = false;
            txtFinal.Text = "";
        }
    }
}
