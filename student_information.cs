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
    public partial class Form1 : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=firstdatabaseone;" +
       "persistsecurityinfo=True;allowuservariables=True");
        MySqlCommand cmd;
        MySqlDataAdapter sda;
        public Form1()
        {
            InitializeComponent();
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblprojectname_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Start1();
        }

        public void Start1()
        {
            txtStudentid.Text = "Student ID";
            txtStudentid.ForeColor = Color.LightGray;

            txtname.Text = "Name";
            txtname.ForeColor = Color.LightGray;

            txtfathername.Text = "Father Name";
            txtfathername.ForeColor = Color.LightGray;

            txtCNIC.Text = "CNIC";
            txtCNIC.ForeColor = Color.LightGray;

            txtaddress.Text = "Address";
            txtaddress.ForeColor = Color.LightGray;

            txtphone.Text = "Phone";
            txtphone.ForeColor = Color.LightGray;

            txtdegree.Text = "Degree";
            txtdegree.ForeColor = Color.LightGray;

            txtsession.Text = "Session";
            txtsession.ForeColor = Color.LightGray;

            txtdetails.Text = "Details";
            txtdetails.ForeColor = Color.LightGray;

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Enter(object sender, EventArgs e)
        {

        }

        private void txtStudentid_Enter(object sender, EventArgs e)
        {
            if(txtStudentid.Text=="Student ID")
            {
                txtStudentid.Text = "";
                txtStudentid.ForeColor = Color.Black;
            }
        }

        private void txtStudentid_Leave(object sender, EventArgs e)
        {
            if(txtStudentid.Text==""||txtStudentid.Text=="Student ID")
            {
                txtStudentid.Text = "Student ID";
                txtStudentid.ForeColor = Color.LightGray;
            }
        }

        private void txtname_Enter(object sender, EventArgs e)
        {
            if (txtname.Text == "Name")
            {
                txtname.Text = "";
                txtname.ForeColor = Color.Black;
            }
        }

        private void txtname_Leave(object sender, EventArgs e)
        {
            if (txtname.Text == "" || txtname.Text == "Name")
            {
                txtname.Text = "Name";
                txtname.ForeColor = Color.LightGray;
            }
        }

        private void txtfathername_Enter(object sender, EventArgs e)
        {
            if (txtfathername.Text == "Father Name")
            {
                txtfathername.Text = "";
                txtfathername.ForeColor = Color.Black;
            }
        }

        private void txtfathername_Leave(object sender, EventArgs e)
        {
            if (txtfathername.Text == "" || txtname.Text == "Father Name")
            {
                txtfathername.Text = "Father Name";
                txtfathername.ForeColor = Color.LightGray;
            }
        }

        private void txtCNIC_Enter(object sender, EventArgs e)
        {
            if (txtCNIC.Text == "CNIC")
            {
                txtCNIC.Text = "";
                txtCNIC.ForeColor = Color.Black;
            }
        }

        private void txtCNIC_Leave(object sender, EventArgs e)
        {
            if (txtCNIC.Text == "" || txtCNIC.Text == "CNIC")
            {
                txtCNIC.Text = "CNIC";
                txtCNIC.ForeColor = Color.LightGray;
            }
        }

        private void txtDOB_Enter(object sender, EventArgs e)
        {
            
        }

        private void txtDOB_Leave(object sender, EventArgs e)
        {
            
        }

        private void txtadddress_Enter(object sender, EventArgs e)
        {
            
        }

        private void txtaddress_Leave(object sender, EventArgs e)
        {
            if (txtaddress.Text == "" || txtaddress.Text == "Address")
            {
                txtaddress.Text = "Address";
                txtaddress.ForeColor = Color.LightGray;
            }
        }

        private void txtphone_Enter(object sender, EventArgs e)
        {
            if (txtphone.Text == "Phone")
            {
                txtphone.Text = "";
                txtphone.ForeColor = Color.Black;
            }
        }

        private void txtphone_Leave(object sender, EventArgs e)
        {
            if (txtphone.Text == "" || txtphone.Text == "Phone")
            {
                txtphone.Text = "Phone";
                txtphone.ForeColor = Color.LightGray;
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

        private void txtsession_Enter(object sender, EventArgs e)
        {
            if (txtsession.Text == "Session")
            {
                txtsession.Text = "";
                txtsession.ForeColor = Color.Black;
            }
        }

        private void txtsession_Leave(object sender, EventArgs e)
        {
            if (txtsession.Text == "" || txtsession.Text == "Session")
            {
                txtsession.Text = "Session";
                txtsession.ForeColor = Color.LightGray;
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

        private void txtaddress_Enter(object sender, EventArgs e)
        {
            if (txtaddress.Text == "Address")
            {
                txtaddress.Text = "";
                txtaddress.ForeColor = Color.Black;
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                int stdid = Convert.ToInt32(txtStudentid.Text);
                String name = txtname.Text;
                String fathername = txtfathername.Text;
                int cnic = Convert.ToInt32(txtCNIC.Text);
                String address = txtaddress.Text;
                int phone = Convert.ToInt32(txtphone.Text);
                String degree = txtdegree.Text;
                String session = txtsession.Text;
                String details = txtdetails.Text;
                String query = "insert into studentinformation(studentid,name,fathername,cnic,address,phone,degree,session,details)values('" + txtStudentid.Text + "','" + txtname.Text + "','" + txtfathername.Text + "','" + txtCNIC.Text + "','" + txtaddress.Text + "','" + txtphone.Text + "','" + txtdegree.Text + "','" + txtsession.Text + "','" + txtdetails.Text+ "' )";
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
            try
            {
                con.Open();
                int stdid = Convert.ToInt32(txtStudentid.Text);
                String name = txtname.Text;
                String fathername = txtfathername.Text;
                int cnic = Convert.ToInt32(txtCNIC.Text);
                String address = txtaddress.Text;
                int phone = Convert.ToInt32(txtphone.Text);
                String degree = txtdegree.Text;
                String session = txtsession.Text;
                String details = txtdetails.Text;
                String query = "UPDATE studentinformation SET studentid='" + txtStudentid.Text + "',name='" + txtname.Text + "',fathername='" + txtfathername.Text + "',cnic='" + txtCNIC.Text + "',address='" + txtaddress.Text + "',phone='" + txtphone.Text + "',degree='" + txtdegree.Text + "',session='" + txtsession.Text + "',details='" + txtdetails.Text + "' where studentid=" + txtStudentid.Text + "";
                cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Update Successfully");
            }
            catch
            {
                MessageBox.Show("Record Update Failed");
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                int stdid = Convert.ToInt32(txtStudentid.Text);
                String name = txtname.Text;
                String fathername = txtfathername.Text;
                int cnic = Convert.ToInt32(txtCNIC.Text);
                String address = txtaddress.Text;
                int phone = Convert.ToInt32(txtphone.Text);
                String degree = txtdegree.Text;
                String session = txtsession.Text;
                String details = txtdetails.Text;
                String query = "DELETE from studentinformation where studentid=" + txtStudentid.Text + "";
                cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Delete Successfully");
            }
            catch
            {
                MessageBox.Show("Record Delete Failed");
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtStudentid.Text =
                txtname.Text =
                txtfathername.Text =
                txtCNIC.Text =
                txtaddress.Text =
                txtphone.Text =
                txtdegree.Text =
                txtsession.Text =
                txtdetails.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMDI h = new frmMDI();
            h.Show();
        }
    }
}
