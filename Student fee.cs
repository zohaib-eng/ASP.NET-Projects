﻿using System;
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
    public partial class Form2 : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=firstdatabaseone;" +
        "persistsecurityinfo=True;allowuservariables=True");
        MySqlCommand cmd;
        MySqlDataAdapter sda;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Start2();
        }

        public void Start2()
        {
            txtfeeid.Text = "Fee ID";
            txtfeeid.ForeColor = Color.LightGray;

            txtdegree.Text = "Degree";
            txtdegree.ForeColor = Color.LightGray;

            txtamount.Text = "Amount";
            txtamount.ForeColor = Color.LightGray;

            txtapplicableform.Text = "Applicable Form";
            txtapplicableform.ForeColor = Color.LightGray;

            txtapplicableto.Text = "Applicable To";
            txtapplicableto.ForeColor = Color.LightGray;
        }

        private void txtfeeid_Enter(object sender, EventArgs e)
        {
            if (txtfeeid.Text == "Fee ID")
            {
                txtfeeid.Text = "";
                txtfeeid.ForeColor = Color.Black;
            }
        }

        private void txtfeeid_Leave(object sender, EventArgs e)
        {
            if (txtfeeid.Text == "" || txtfeeid.Text == "Fee ID")
            {
                txtfeeid.Text = "Fee ID";
                txtfeeid.ForeColor = Color.LightGray;
            }
        }

        private void txtdegree_Enter(object sender, EventArgs e)
        {
            if (txtdegree.Text == "Degree")
            {
                txtdegree.Text = "";
                txtdegree.ForeColor = Color.Black;
            }
        }

        private void txtdegree_Leave(object sender, EventArgs e)
        {
            if (txtdegree.Text == "" || txtdegree.Text == "Degree")
            {
                txtdegree.Text = "Degree";
                txtdegree.ForeColor = Color.LightGray;
            }
        }

        private void txtamount_Enter(object sender, EventArgs e)
        {
            if (txtamount.Text == "Amount")
            {
                txtamount.Text = "";
                txtamount.ForeColor = Color.Black;
            }
        }

        private void txtamount_Leave(object sender, EventArgs e)
        {
            if (txtamount.Text == "" || txtamount.Text == "Amount")
            {
                txtamount.Text = "Amount";
                txtamount.ForeColor = Color.LightGray;
            }
        }

        private void txtapplicableform_Enter(object sender, EventArgs e)
        {
            if (txtapplicableform.Text == "Applicable Form")
            {
                txtapplicableform.Text = "";
                txtapplicableform.ForeColor = Color.Black;
            }
        }

        private void txtapplicableform_Leave(object sender, EventArgs e)
        {
            if (txtapplicableform.Text == "" || txtapplicableform.Text == "Applicable Form")
            {
                txtapplicableform.Text = "Applicable Form";
                txtapplicableform.ForeColor = Color.LightGray;
            }
        }

        private void txtapplicableto_Enter(object sender, EventArgs e)
        {
            if (txtapplicableto.Text == "Applicable To")
            {
                txtapplicableto.Text = "";
                txtapplicableto.ForeColor = Color.Black;
            }
        }

        private void txtapplicableto_Leave(object sender, EventArgs e)
        {
            if (txtapplicableto.Text == "" || txtapplicableto.Text == "Applicable To")
            {
                txtapplicableto.Text = "Applicable To";
                txtapplicableto.ForeColor = Color.LightGray;
            }
        }

        private void lblfeeid_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMDI h = new frmMDI();
            h.Show();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                int feeid = Convert.ToInt32(txtfeeid.Text);
                String degree = txtdegree.Text;
                int amount = Convert.ToInt32(txtamount.Text);
                int applicableform = Convert.ToInt32(txtapplicableform.Text);
                String applicableto = txtapplicableto.Text;
                String query = "insert into studentfee(feeid,degree,amount,applicableform,applicableto)values('" + txtfeeid.Text + "','" + txtdegree.Text + "','" + txtamount.Text + "','" + txtapplicableform.Text + "','" + txtapplicableto.Text + "')";
                cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Inserted Successfully");
            }
            catch
            {
                MessageBox.Show("Record Inserted Failed");
            }

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {

        }

        private void btndelete_Click(object sender, EventArgs e)
        {

        }

        private void btnreset_Click(object sender, EventArgs e)
        {

        }
    }
}