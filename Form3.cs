using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace College_Fee_Record
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Start3();
        }

        public void Start3()
        {
            txtid.Text = "ID";
            txtid.ForeColor = Color.LightGray;

            txtstudentid.Text = "Student ID";
            txtstudentid.ForeColor = Color.LightGray;

            txtmonthly.Text = "Monthly";
            txtmonthly.ForeColor = Color.LightGray;

            txtfine.Text = "Fine";
            txtfine.ForeColor = Color.LightGray;

            txtdetails.Text = "Details";
            txtdetails.ForeColor = Color.LightGray;

        }

        private void txtid_Enter(object sender, EventArgs e)
        {
            if (txtid.Text == "ID")
            {
                txtid.Text = "";
                txtid.ForeColor = Color.Black;
            }
        }

        private void txtid_Leave(object sender, EventArgs e)
        {
            if (txtid.Text == "" || txtid.Text == "ID")
            {
                txtid.Text = "ID";
                txtid.ForeColor = Color.LightGray;
            }
        }

        private void txtstudentid_Enter(object sender, EventArgs e)
        {
            if (txtstudentid.Text == "Student ID")
            {
                txtstudentid.Text = "";
                txtstudentid.ForeColor = Color.Black;
            }
        }

        private void txtstudentid_Leave(object sender, EventArgs e)
        {
            if (txtstudentid.Text == "" || txtstudentid.Text == "Student ID")
            {
                txtstudentid.Text = "Student ID";
                txtstudentid.ForeColor = Color.LightGray;
            }
        }

        private void txtdaterecieved_Enter(object sender, EventArgs e)
        {
            
        }

        private void txtdaterecieved_Leave(object sender, EventArgs e)
        {
            
        }

        private void txtmonthly_Enter(object sender, EventArgs e)
        {
            if (txtmonthly.Text == "Monthly")
            {
                txtmonthly.Text = "";
                txtmonthly.ForeColor = Color.Black;
            }
        }

        private void txtmonthly_Leave(object sender, EventArgs e)
        {
            if (txtmonthly.Text == "" || txtmonthly.Text == "Monthly")
            {
                txtmonthly.Text = "Monthly";
                txtmonthly.ForeColor = Color.LightGray;
            }
        }

        private void txtfine_Enter(object sender, EventArgs e)
        {
            if (txtfine.Text == "Fine")
            {
                txtfine.Text = "";
                txtfine.ForeColor = Color.Black;
            }
        }

        private void txtfine_Leave(object sender, EventArgs e)
        {
            if (txtfine.Text == "" || txtfine.Text == "Fine")
            {
                txtfine.Text = "Fine";
                txtfine.ForeColor = Color.LightGray;
            }
        }

        private void txtdetails_Enter(object sender, EventArgs e)
        {
            if (txtdetails.Text == "Details")
            {
                txtdetails.Text = "";
                txtdetails.ForeColor = Color.Black;
            }
        }

        private void txtdetails_Leave(object sender, EventArgs e)
        {
            if (txtdetails.Text == "" || txtdetails.Text == "Details")
            {
                txtdetails.Text = "Details";
                txtdetails.ForeColor = Color.LightGray;
            }
        }

        private void txtmonthly_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
