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

namespace Atm_system
{
    public partial class account : Form
    {
        public account()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\HH\C#\Atm system\Atm system\Atm system\ATMDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void account_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bal = 0;
            if(AccNumTb.Text=="" || AccNumTb.Text=="" || FanameTb.Text=="" || PhoneTb.Text=="" || AddressTb.Text=="" || occupationtb.Text=="" || pintb.Text=="")
            {
                MessageBox.Show("Missing Information");
            }else
            {
                try 
                {
                    Con.Open();
                    string query = "insert into AccountTbl values('" + AccNumTb.Text + "' , '" + AccNameTb.Text + "' , '" + FanameTb.Text + "' , '" + dobdate.Value.Date + "' , '" + PhoneTb.Text + "' , '" + AddressTb.Text + "' , '" + educationcb.SelectedItem.ToString() + "' , '" + occupationtb.Text + "' , " + pintb.Text + " , "+bal+")";
                    SqlCommand cmd = new SqlCommand(query,Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Created Successfully");
                    Con.Close();
                    Login log =new Login();
                    log.Show();
                    this.Hide(); 

                }catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void dobdate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
