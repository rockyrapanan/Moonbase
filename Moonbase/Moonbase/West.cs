using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 Name: Leonardo l. Rapanan
 Class: CSC202
 Assignment: Moonbase
 Date: 06/30/2024
 */

namespace Moonbase
{
    public partial class West : Form
    {
        public West()
        {
            InitializeComponent();
        }

        private void West_Load(object sender, EventArgs e)
        {

        }

        // This is the north button to get to the Main site(main form) in the navigator.
        private void HMbuttonW_Click(object sender, EventArgs e)
        {
            Mainform frm = new Mainform();
            this.Hide();
            frm.Show();
        }

        // This is the north button to get to the north site in the navigator.
        private void NTHbuttonW_Click(object sender, EventArgs e)
        {
            North frm = new North();
            this.Hide();
            frm.Show();
        }

        // This is the north button to get to the east site in the navigator.
        private void ESTbuttonW_Click(object sender, EventArgs e)
        {
            East frm = new East();
            this.Hide();
            frm.Show();
        }

        // This is the north button to get to the south site in the navigator.
        private void STHbuttonW_Click(object sender, EventArgs e)
        {
            South frm = new South();
            this.Hide();
            frm.Show();
        }
    }
}
