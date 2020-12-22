using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace ATMTuto
{
    public partial class account : Form
    {
        public account()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-9AGEG02;Initial Catalog=ATMDb;Integrated Security=True");
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            int bal = 0;
            if (AccNametb.Text =="" || AccNumTb.Text == "" ||  PhoneTb.Text == "" || Addresstb.Text =="" ||  pintb.Text =="")
            {
                MessageBox.Show("Missing Information");
            }else
            {
                try
                {
                    Con.Open();
                    string query = "insert into AccountTbl values('" + AccNumTb.Text + "','" + AccNametb.Text + "','"  + PhoneTb.Text + "','" + Addresstb.Text + "','" +  "'," + pintb.Text + ","+bal+")";
                    SqlCommand cmd = new SqlCommand(query,Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Created Successfully");
                    Con.Close();
                    Login log = new Login();
                    log.Show();
                    this.Hide();
                }catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void account_Load(object sender, EventArgs e)
        {

        }
    }
}
