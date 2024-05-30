using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_4._2
{
    public partial class FinalForm : Form
    {
        bool logonStatus = false;
        string userName = "Teacher";
        string password = "Admin";
        public FinalForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UserIdTextBox.Text == userName && PasswordTextBox.Text == password)
            {
                logonStatus = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password");
            }
        }

    }

}
