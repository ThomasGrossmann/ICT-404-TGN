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
            int Table = int.Parse(txtTable.Text);

            if (txtTable.Text == "")
            {
                MessageBox.Show("Table requise.", "ERREUR");
                txtCommande.Text = "";
            }
            if(optExtra.Checked == true)
            {
                txtCommande.Text = String.Format("Pour la {0} : pâte {1} ", Table, optExtra.Text);
                if(chkAnchois.Checked == true)
                {
                    txtCommande.Text = String.Format("Pour la {0} : pâte {1} avec {2}", Table, optExtra.Text, chkAnchois.Text);
                }
            }else if(optFine.Checked == true)
            {
                txtCommande.Text = String.Format("Pour la {0} : pâte {1} ", Table, optFine.Text);
            }else if(optNormale.Checked == true)
            {
                txtCommande.Text = String.Format("Pour la {0} : pâte {1} ", Table, optNormale.Text);
            }else if(optEpaisse.Checked == true)
            {
                txtCommande.Text = String.Format("Pour la {0} : pâte {1} ", Table, optEpaisse.Text);
            }
        }
    }
}
