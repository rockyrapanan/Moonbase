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
    public partial class East : Form
    {
        public East()
        {
            InitializeComponent();
        }

        private void East_Load(object sender, EventArgs e)
        {

        }

        // This is the north button to get to the Main site(main form) in the navigator.
        private void HMbuttonE_Click(object sender, EventArgs e)
        {
            Mainform frm = new Mainform();
            this.Hide();
            frm.ShowDialog();
        }

        // This is the north button to get to the north site in the navigator.
        private void NRTHbuttonE_Click(object sender, EventArgs e)
        {
           North frm = new North();
            this.Hide();
            frm.ShowDialog();
        }

        // This is the north button to get to the west site in the navigator.
        private void WSTbuttonE_Click(object sender, EventArgs e)
        {
            West frm = new West();
            this.Hide();
            frm.ShowDialog();
        }

        // This is the north button to get to the south site in the navigator.
        private void STHbuttonE_Click(object sender, EventArgs e)
        {
            South frm = new South();
            this.Hide();
            frm.ShowDialog();
        }
    }
}
