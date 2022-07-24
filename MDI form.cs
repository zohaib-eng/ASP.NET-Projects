using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace College_Fee_Record
{
    public partial class frmMDI : Form
    {
        public frmMDI()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void studentInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 h = new Form1();
            h.Show();
        }

        private void studentFeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 h = new Form2();
            h.Show();
        }

        private void feeStructureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 h = new Form3();
            h.Show();
        }

        private void lOGOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
