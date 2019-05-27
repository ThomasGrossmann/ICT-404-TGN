using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCommander_Click(object sender, EventArgs e)
        {
            if (txtTable.Text == "")
            {
                MessageBox.Show("Table requise.", "ERREUR");
                txtCommande.Text = "";
            }
            if(optExtra.Checked == true)
            {
                txtCommande.Text = "Pour la " + txtTable.Text + " : pâte extra-fine avec ";
            }else if(optFine.Checked == true)
            {
                txtCommande.Text = "Pour la " + txtTable.Text + " : pâte fine avec ";
            }else if(optNormale.Checked == true)
            {
                txtCommande.Text = "Pour la " + txtTable.Text + " : pâte normale avec ";
            }else if(optEpaisse.Checked == true)
            {
                txtCommande.Text = "Pour la " + txtTable.Text + " : pâte epaisse avec ";
            }
            if (chkAnchois.Checked == true)
            {
                txtCommande.Text += " anchois,";
            }
            if (chkCapres.Checked == true)
            {
                txtCommande.Text += " capres,";
            }
            if (chkCrevettes.Checked == true)
            {
                txtCommande.Text += " crevettes,";
            }
            if(chkJambon.Checked == true)
            {
                txtCommande.Text += " jambon,";
            }
            if (txtCommande.Text != "")
            {
                txtCommande.Text = txtCommande.Text.Substring(0, txtCommande.Text.Length - 1);
            }
        }
    }
}
