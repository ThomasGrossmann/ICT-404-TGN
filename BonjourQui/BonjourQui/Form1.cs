//Projet : BonjourQui
//Auteur : Thomas Grossmann
//Date : 09.05.2019

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BonjourQui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            btnBienvenue.Enabled = true; //État du bouton quand on écrit
        }

        private void btnBienvenue_Click(object sender, EventArgs e)
        {
            BonjourNom.Text = "Bonjour " + NameBox.Text; //Changer le texte du label
            NameBox.Text = ""; //Texte de la TextBox après clic
            btnBienvenue.Enabled = false; //État du bouton après clic
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
