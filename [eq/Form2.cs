using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _eq
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ваш пароль: progpro2013");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 Login = new Form1();
            Login.ShowDialog();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            Form3 WindowsForm = new Form3();
            WindowsForm.ShowDialog();
            Close();
        }
    }
}
