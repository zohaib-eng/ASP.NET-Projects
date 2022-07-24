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

namespace Calculator
{
    public partial class Form1 : Form
    {
        MySqlConnection  con = new MySqlConnection("server=localhost;user id=root;database=items_calculator;" +
       "persistsecurityinfo=True;allowuservariables=True");
        MySqlCommand cmd;
        MySqlDataAdapter sda;
        int i = 0;
        String Choice = "";
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Start();
            Display();
        }

        public void Start()
        {
            txtitem.Text = "Items";
            txtitem.ForeColor = Color.LightGray;

            txtrate.Text = "Rate";
            txtrate.ForeColor = Color.LightGray;

            txttotal.Text = "Total";
            txttotal.ForeColor = Color.LightGray;

            txtgrandtotal.Text = "G.Total";
            txtgrandtotal.ForeColor = Color.LightGray;
        }

        private void txtitem_Enter(object sender, EventArgs e)
        {
            if (txtitem.Text == "Items")
            {
                txtitem.Text = "";
                txtitem.ForeColor = Color.Black;
            }
        }

        private void txtitem_Leave(object sender, EventArgs e)
        {
            if (txtitem.Text == "" || txtitem.Text == "Items")
            {
                txtitem.Text = "Items";
                txtitem.ForeColor = Color.LightGray;
            }
        }

        private void txtrate_Enter(object sender, EventArgs e)
        {
            if (txtrate.Text == "Rate")
            {
                txtrate.Text = "";
                txtrate.ForeColor = Color.Black;
            }
        }

        private void txtrate_Leave(object sender, EventArgs e)
        {
            if (txtrate.Text == "" || txtrate.Text == "Rate")
            {
                txtrate.Text = "Rate";
                txtrate.ForeColor = Color.LightGray;
            }
        }

        private void txttotal_Enter(object sender, EventArgs e)
        {
            if (txttotal.Text == "Total")
            {
                txttotal.Text = "";
                txttotal.ForeColor = Color.Black;
            }
        }

        private void txttotal_Leave(object sender, EventArgs e)
        {
            if (txttotal.Text == "" || txttotal.Text == "Total")
            {
                txttotal.Text = "Total";
                txttotal.ForeColor = Color.LightGray;
            }
        }

        private void txtgrandtotal_Enter(object sender, EventArgs e)
        {
            if (txtgrandtotal.Text == "G.Total")
            {
                txtgrandtotal.Text = "";
                txtgrandtotal.ForeColor = Color.Black;
            }
        }

        private void txtgrandtotal_Leave(object sender, EventArgs e)
        {
            if (txtgrandtotal.Text == "" || txtgrandtotal.Text == "G.Total")
            {
                txtgrandtotal.Text = "G.Total";
                txtgrandtotal.ForeColor = Color.LightGray;
            }
        }

        private void btnresult_Click(object sender, EventArgs e)
        {
            if (checkBox1Garments.Checked == true)
            {
                Choice = "Garment";
            }else if(checkBox2jewllery.Checked==true)
            {
                Choice = "Jewellery";
            }else if(checkBox3others.Checked==true)
            {
                Choice = "Others";
            }
            else
            {
                Choice = "None";
            }

            try
            {
                cmd = new MySqlCommand("insert into items(Total_items, Items_Value, Total, Grand_Total,Choice) values('" + txtitem.Text + "', '" + txtrate.Text + "', '" + txttotal.Text + "', '" + txtgrandtotal.Text + "','"+Choice+"')", con);
                con.Open();
                cmd.Parameters.AddWithValue("@Total_items", txtitem.Text);
                cmd.Parameters.AddWithValue("@Items_Value", txtrate.Text);
                cmd.Parameters.AddWithValue("@Total", txttotal.Text);
                cmd.Parameters.AddWithValue("@Grand_Total", txtgrandtotal.Text);
                //cmd.Parameters.AddWithValue("@Choice", Choicecheck.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Inserted Successfully");
            }
            catch
            {
                MessageBox.Show("Record Inserted Failed");
            }

        }

        public void Display()
        {
            con.Open();
            DataTable dt = new DataTable();
            sda = new MySqlDataAdapter("select * from items", con);
            sda.Fill(dt);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap dataGridViewBitmap = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);

            dataGridView1.DrawToBitmap(dataGridViewBitmap, new System.Drawing.Rectangle(50, 50, this.dataGridView1.Width, this.dataGridView1.Height));

            e.Graphics.DrawImage(dataGridViewBitmap, 50, 50);

        }
    }
}
