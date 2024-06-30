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
 Name: Leonardo L. Rapanan
 Class: CSC202
 Assignment: Moonbase
 Date: 06/30/2024
 
 */

namespace Moonbase
{
    public partial class South : Form
    {
        public South()
        {
            InitializeComponent();
        }

        private void South_Load(object sender, EventArgs e)
        {

        }
        // This is the north button to get to the home site(main form) in the navigator.
        private void HMbuttonS_Click(object sender, EventArgs e)
        {
            Mainform frm = new Mainform();
            this.Hide();
            frm.ShowDialog();
        }

        // This is the north button to get to the north site in the navigator.
        private void NTHbuttonS_Click(object sender, EventArgs e)
        {
            North frm = new North();
            this.Hide();
            frm.ShowDialog();
        }

        // This is the north button to get to the west site in the navigator.
        private void WSTButtonS_Click(object sender, EventArgs e)
        {
            West frm = new West();
            this.Hide();
            frm.ShowDialog();
        }

        // This is the north button to get to the east site in the navigator.
        private void ESTbuttonS_Click(object sender, EventArgs e)
        {
            East frm = new East();
            this.Hide();
            frm.ShowDialog();
        }
    }
}
