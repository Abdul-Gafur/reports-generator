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
    public partial class Forget_password_window : Form
    {
        public Forget_password_window()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void submitbt_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "" || txtgirlfriendname.Text == "")
            {
                MessageBox.Show("Enter Designer details");
            }
            else if (txtname.Text == "Abdul-Gafur" && txtgirlfriendname.Text == "Yushrat")
            {
                using (Form1 frm = new Form1())
                {
                    frm.ShowDialog();
                    this.Hide();  
                }
            }else
            {
                MessageBox.Show("Wrong Details or information");
                txtname.Text = "";
                txtgirlfriendname.Text = "";
            }


        }


        private void txtgirlfriendname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
