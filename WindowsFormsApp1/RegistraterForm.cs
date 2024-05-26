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
    public partial class RegistraterForm : Form
    {
        public RegistraterForm()
        {
            InitializeComponent();

            this.phoneFill.AutoSize = false;
            this.phoneFill.Size = new Size(this.phoneFill.Size.Width, 30);

            this.parolFill.AutoSize = false;
            this.parolFill.Size = new Size(this.parolFill.Size.Width, 30);
        }

        private void RegistraterForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
