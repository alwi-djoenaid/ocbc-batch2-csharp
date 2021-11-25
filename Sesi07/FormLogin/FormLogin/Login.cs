using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormLogin
{
    public partial class Login : Form
    {
        // Init connection class
        Config db = new Config();

        public Login()
        {
            InitializeComponent();

            // Passing database to connect
            db.Connect("userdata");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // query mysql db for passing data from textbox
            db.ExecuteSelect("SELECT * FROM user_info WHERE USERNAME='" + textboxUsername.Text + "' AND PASSWORD ='" + textboxPassword.Text + "'");

            if (db.Count() == 1)
            {
                MessageBox.Show("Success, you will login as " + db.Results(0, "names"));
            }
            else
            {
                MessageBox.Show("Wrong username and password combination");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
