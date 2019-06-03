// Auteur : Thomas Grossmann
// Programme : Pizza (bis)
// Date : 03.06.2019

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Pizza__bis_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChanger_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            DialogResult result = folderDlg.ShowDialog();
            txtRepertoire.Text = folderDlg.SelectedPath;
        }

        private void btnCommander_Click(object sender, EventArgs e)
        {
            int Table = int.Parse(txtTable.Text);
            StreamWriter file = new StreamWriter("Table" + txtTable.Text + ".txt");
            MessageBox.Show("Commande envoyée !");
        }
    }
}
