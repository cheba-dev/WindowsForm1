using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;

namespace _eq
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public string url = "https://formwork-9b7a9-default-rtdb.europe-west1.firebasedatabase.app/";

        public async void Login()
        {

        }

        private async void Enter_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            string serverpass = (await client.GetStringAsync(url + login.Text + "/.json ")).Replace("\"", "");
            if (password.Text == serverpass)
            {
                Hide();
                Form2  Account = new Form2();
                Account.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Проверьте ваши данные еще раз");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Close();
        }
    }
}
