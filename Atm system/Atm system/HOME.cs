﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atm_system
{
    public partial class HOME : Form
    {
        public HOME()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Balance bal = new Balance();
            bal.Show();
            this.Hide();
        }
        public static String AccNumber;
        private void HOME_Load(object sender, EventArgs e)
        {
            AccNumlbl.Text = "Account Number :" + Login.AccNumber;
            AccNumber = Login.AccNumber;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Deposit depo = new Deposit();
            depo.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ChangePin Pin = new ChangePin();
            Pin.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            withdraw wd = new withdraw();
            wd.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FASTCASH Fcash = new FASTCASH();
            Fcash.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ministatemenet mini = new ministatemenet();
            mini.Show();
            this.Hide();
        }
    }
}
