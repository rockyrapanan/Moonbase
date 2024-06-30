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
 Name: Leonardo L. Rapanan(Rocky)
 Class: CSC202
 Assignmaent: Moonbase (UX design)
 Date: 06/30/2024
 
 */


namespace Moonbase
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        private void Mainform_Load(object sender, EventArgs e)
        {

        }
        // This is the north button to get to the north site in the navigator.
        private void button1_Click(object sender, EventArgs e)
        {
            North frm = new North();
            this.Hide();
            frm.Show();
        }

        // This is the north button to get to the west site in the navigator.
        private void button3_Click(object sender, EventArgs e)
        {
            West frm = new West();
            this.Hide();
            frm.Show();
        }

        // This is the north button to get to the south site in the navigator.
        private void button4_Click(object sender, EventArgs e)
        {
            South frm = new South();
            this.Hide();
            frm.Show();
        }

        // This is the north button to get to the East site in the navigator.
        private void button2_Click(object sender, EventArgs e)
        {
            East frm = new East();
            this.Hide();
            frm.Show();
        }
    }
}
