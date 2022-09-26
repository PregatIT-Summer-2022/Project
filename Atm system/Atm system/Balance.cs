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
    public partial class Balance : Form
    {
        public Balance()
        {
            InitializeComponent();
        } 

        private void panel1_Paint(object sender, PaintEventArgs e) // method naming with PascalCase maybe
        {

        }
        
        // get the connection from a config file
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\HH\C#\Atm system\Atm system\Atm system\ATMDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void getbalance()
        {
            Con.Open();
            
            // watch out for sql injection. If acc number text is like 'a; drop table AccountTbl;--' you might have a problem 
            SqlDataAdapter sda = new SqlDataAdapter(" select Balance from AccountTbl where AccNum='"+AccNumberlbl.Text+"'",Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Balancelbl.Text = "$ " + dt.Rows[0][0].ToString();
            Con.Close();

        }
        
        private void Balance_Load(object sender, EventArgs e)
        {
            AccNumberlbl.Text = HOME.AccNumber;
            getbalance();
        }

        private void button2_Click(object sender, EventArgs e) // never button2 as no one knows which one is it. Maybe ExitButton, or HomeButton, etc
        {
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            HOME home = new HOME();
            this.Hide();
            home.Show();
        }

        private void Balancelbl_Click(object sender, EventArgs e)
        {

        }
    }
}
