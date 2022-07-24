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
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=firstdatabaseone;" +
        "persistsecurityinfo=True;allowuservariables=True");
        MySqlCommand cmd;
        MySqlDataAdapter sda;
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

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                int stdid = Convert.ToInt32(txtstudentid.Text);
               // DateTime daterecieved = Convert.ToDateTime(dateTimePicker1.Value);
                String monthly = txtmonthly.Text;
                int fine = Convert.ToInt32(txtfine.Text);
                String details = txtdetails.Text;
                String query = "insert into feestructure(studentid,daterecieved,monthly,fine,details)values('" + txtstudentid.Text + "','" + dateTimePicker1.Value.Date + "','" + txtmonthly.Text + "','" + txtfine.Text + "','" + txtdetails.Text + "')";
                cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = query;
                //cmd.Parameters.AddWithValue("@studentid", txtstudentid.Text);
                //cmd.Parameters.AddWithValue("@monthly", txtmonthly.Text);
                //cmd.Parameters.AddWithValue("@fine", txtfine.Text);
                //cmd.Parameters.AddWithValue("@details", txtdetails.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Inserted Successfully");
            }
            catch
            {
                MessageBox.Show("Record Inserted Failed");
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtstudentid.Text =
                txtmonthly.Text =
                txtfine.Text =
                txtdetails.Text = "";
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                int stdid = Convert.ToInt32(txtstudentid.Text);
                // DateTime daterecieved = Convert.ToDateTime(dateTimePicker1.Value);
                String monthly = txtmonthly.Text;
                int fine = Convert.ToInt32(txtfine.Text);
                String details = txtdetails.Text;
                String query = "UPDATE feestructure SET studentid='" + txtstudentid.Text+"',daterecieved='"+dateTimePicker1.Value.Date+"',monthly='"+txtmonthly.Text+"',fine='"+txtfine.Text+"',details='"+txtdetails.Text+"' where studentid="+txtstudentid.Text+"";
                cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = query;
                //cmd.Parameters.AddWithValue("@studentid", txtstudentid.Text);
                //cmd.Parameters.AddWithValue("@monthly", txtmonthly.Text);
                //cmd.Parameters.AddWithValue("@fine", txtfine.Text);
                //cmd.Parameters.AddWithValue("@details", txtdetails.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record updated Successfully");
            }
            catch
            {
                MessageBox.Show("Record updated Failed");
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                int stdid = Convert.ToInt32(txtstudentid.Text);
                // DateTime daterecieved = Convert.ToDateTime(dateTimePicker1.Value);
                String monthly = txtmonthly.Text;
                int fine = Convert.ToInt32(txtfine.Text);
                String details = txtdetails.Text;
                String query = "DELETE from feestructure where studentid=" + txtstudentid.Text+"";
                cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = query;
                //cmd.Parameters.AddWithValue("@studentid", txtstudentid.Text);
                //cmd.Parameters.AddWithValue("@monthly", txtmonthly.Text);
                //cmd.Parameters.AddWithValue("@fine", txtfine.Text);
                //cmd.Parameters.AddWithValue("@details", txtdetails.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Delete Successfully");
            }
            catch
            {
                MessageBox.Show("Record Delete Failed");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMDI h = new frmMDI();
            h.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMDI h = new frmMDI();
            h.Show();
        }
    }
}
