using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Reports_Generator
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
                {
                    if (Usernametb.Text == "" || Passwordtb.Text == "")
                    {
                        MessageBox.Show("Enter UserName and Password");
                    } else if(Usernametb.Text == "Ghafcodes" && Passwordtb.Text == "Password")
                    {
                using (Form1 frm = new Form1())
                {
                    frm.ShowDialog();
                    this.Hide();    
                }
 
                    }else
            {
                MessageBox.Show("Wrong Username or Password");
                Usernametb.Text = "";
                Passwordtb.Text = "";

            }
                }

        private void Passwordtb_TextChanged(object sender, EventArgs e)
        {
            Passwordtb.PasswordChar = '*';

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (Forget_password_window frm = new Forget_password_window ())
            {
                frm.ShowDialog();
                this.Hide();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
