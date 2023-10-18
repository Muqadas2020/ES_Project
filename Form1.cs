using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            string username = UserNameTextBox.Text;
            string password = PasswordTextBox.Text;
            if (username == "abc" && password == "123")
            {
                // MessageBox.Show("Sucessfully Logined!");
                this.Hide(); //hide the current form
                //create the object of 2nd form
                Dashboard dboard = new Dashboard();
                dboard.Show();
            }
            else
            {
                MessageBox.Show("Wrong username or password!");
            }
        }
    }
}
