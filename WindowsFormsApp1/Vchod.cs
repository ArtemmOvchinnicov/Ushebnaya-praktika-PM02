﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Vchod : Form
    {
        public Vchod()
        {
            InitializeComponent();

            this.parowPast.AutoSize = false;
            this.parowPast.Size = new Size(this.parowPast.Size.Width, 30);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String loginUser = loginPast.Text;
            String passUser = parowPast.Text;

            BD bD = new BD();

            DataTable dt = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users`WHERE `login`= @uL AND `pass` = @uP", bD.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value= loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;    
            adapter.Fill(dt);


            if (dt.Rows.Count > 0)
                MessageBox.Show("Yes");
            else
                MessageBox.Show("No");


            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}
