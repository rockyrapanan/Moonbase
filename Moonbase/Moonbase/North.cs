using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 Name: Leonardo L. Rapanan
 Class: CSC202
 Assignment: Moonbase
 Date: 06/30/2024
 */


namespace Moonbase
{
    public partial class North : Form
    {
        public North()
        {
            InitializeComponent();
        }

        private void North_Load(object sender, EventArgs e)
        {

        }

        // This is the north button to get to the main site(main page) in the navigator.
        private void HMbuttonN_Click(object sender, EventArgs e)
        {
            Mainform frm = new Mainform();
            this.Hide();
            frm.ShowDialog();
        }

        // This is the north button to get to the east site in the navigator.
        private void ESTbuttonN_Click(object sender, EventArgs e)
        {
            East frm = new East();
            this.Hide(); 
            frm.ShowDialog();
            
        }

        // This is the north button to get to the south site in the navigator.
        private void STHbuttonN_Click(object sender, EventArgs e)
        {
            South frm = new South();
            this.Hide();
            frm.ShowDialog();
        }

        // This is the north button to get to the west site in the navigator.
        private void WSTbuttonN_Click(object sender, EventArgs e)
        {
            West frm = new West();
            this.Hide();
            frm.ShowDialog();
        }
    }
}
