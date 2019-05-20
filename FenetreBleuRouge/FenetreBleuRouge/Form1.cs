using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FenetreBleuRouge
{
    public partial class Form1 : Form
    {
        int Moves = 0;
        int ColorChanges = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHG_Click(object sender, EventArgs e)
        {
            Rectangle scr = Screen.GetBounds(this.Bounds);
            this.SetBounds(-6, 0, 395, 369);
            Moves++;
        }

        private void btnBleu_Click(object sender, EventArgs e)
        {
            BackColor = Color.Blue;
            ColorChanges++;
        }

        private void btnRouge_Click(object sender, EventArgs e)
        {
            BackColor = Color.Red;
            ColorChanges++;
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Moves + " déplacement(s), " + ColorChanges + " changement(s) de couleur.");
        }

        private void btnHD_Click(object sender, EventArgs e)
        {
            this.SetBounds(1532, 0, 395, 369);
            Moves++;
        }

        private void btnBG_Click(object sender, EventArgs e)
        {
            this.SetBounds(-6, 677, 395, 369);
            Moves++;
        }

        private void btnBD_Click(object sender, EventArgs e)
        {
            this.SetBounds(1532, 677, 395, 369);
            Moves++;
        }
    }
}
