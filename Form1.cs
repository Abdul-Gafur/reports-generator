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
    public partial class Form1 : Form
    { 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("confirm if you want exit", "Student Ranking", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(txtstudentname.Text, txtmathematics.Text, txtenglish.Text, txtscience.Text, txtsocial.Text, txtrme.Text
                , txtict.Text, txtbdt.Text, txtdagaare.Text, txttotal.Text, txtstaverage.Text);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblrme_Click(object sender, EventArgs e)
        {

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            int q;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
                q = dataGridView1.Rows.Count;

            }
            else
            {
                MessageBox.Show("Select a row to be deleted", "Student Result and Ranking");
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            {
                txtstudentname.Clear();
                txtclass.Clear();
                txtgender.Clear(); 
                txtstaverage.Clear();
                txtmathematics.Clear();
                txtenglish.Clear();
                txtscience.Clear();
                txtsocial.Clear();
                txtrme.Clear();
                txtdagaare.Clear();
                txtbdt.Clear();
                txtict.Clear();
                txttotal.Clear();
                txtterm.Clear();

                lbltotal.Text = ("");
                    lblterm.Text = ("");
                lblstaverage.Text = ("");
                lblgender.Text = ("");
                lblclass.Text = ("");


                lblmathematics.Text = ("");
                lblenglish.Text = ("");
                lblsocial.Text = ("");
                lblscience.Text = ("");
                lblrme.Text = ("");
                lbldagaare.Text = ("");
                lblbdt.Text = ("");
                lblict.Text = ("");

                lblmr.Text = ("");
                lbler.Text = ("");
                lblisr.Text = ("");
                lblsr.Text = ("");
                lblrr.Text = ("");
                lblir.Text = ("");
                lblbr.Text = ("");
                lbldr.Text = ("");


                Action<Control.ControlCollection> func = null;

                func = (controls) =>
                {
                    foreach (Control control in controls)
                        if (control is TextBox)
                            (control as TextBox).Clear();
                        else
                            func(control.Controls);
                };
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void btntranscript_Click(object sender, EventArgs e)
        {
            lblmathematics.Text = txtmathematics.Text;
            lblenglish.Text = txtenglish.Text;
            lblscience.Text = txtscience.Text;
            lblsocial.Text = txtsocial.Text;
            lblrme.Text = txtrme.Text;
            lblict.Text = txtict.Text;
            lblbdt.Text = txtbdt.Text;
            lbldagaare.Text = txtdagaare.Text;
            lblname.Text = txtstudentname.Text;
            lblclass.Text = txtclass.Text;
            lbltotal.Text = txttotal.Text;
            lblstaverage.Text = txtstaverage.Text;
            lblmathematics.Text = txtmathematics.Text;
            lblterm.Text = txtterm.Text;
            lblgender.Text = txtgender.Text;
            lbltotal.Text = txttotal.Text;

            Double[] R = new double[14];

            R[0] = Convert.ToDouble(txtmathematics.Text);
            R[1] = Convert.ToDouble(txtenglish.Text);
            R[2] = Convert.ToDouble(txtscience.Text);
            R[3] = Convert.ToDouble(txtsocial.Text);
            R[4] = Convert.ToDouble(txtrme.Text);
            R[5] = Convert.ToDouble(txtict.Text);
            R[6] = Convert.ToDouble(txtbdt.Text);
            R[7] = Convert.ToDouble(txtdagaare.Text);

            if (R[0] >= 80)
            {
                lblmr.Text = "Excellent";
            }
            else if (R[0] >= 70)
            {
                lblmr.Text = "Very Good";
            }
            else if (R[0] >= 60)
            {
                lblmr.Text = "Good";
            }
            else if (R[0] >= 50)
            {
                lblmr.Text = "Good";
            }
            else if (R[0] <= 40)
            {
                lblmr.Text = "Poor";
            }

            if (R[1] >= 80)
            {
                lbler.Text = "Excellent";
            }
            else if (R[1] >= 70)
            {
                lbler.Text = "Very Good";
            }
            else if (R[1] >= 60)
            {
                lbler.Text = "Good";
            }
            else if (R[1] >= 50)
            {
                lbler.Text = "Good";
            }
            else if (R[1] <= 40)
            {
                lbler.Text = "Poor";
            }
            if (R[2] >= 80)
            {
                lblisr.Text = "Excellent";
            }
            else if (R[2] >= 70)
            {
                lblisr.Text = "Very Good";
            }
            else if (R[2] >= 60)
            {
                lblisr.Text = "Good";
            }
            else if (R[2] >= 50)
            {
                lblisr.Text = "Good";
            }
            else if (R[2] <= 40)
            {
                lblisr.Text = "Poor";
            }
            if (R[3] >= 80)
            {
                lblsr.Text = "Excellent";
            }
            else if (R[3] >= 70)
            {
                lblsr.Text = "Very Good";
            }
            else if (R[3] >= 60)
            {
                lblsr.Text = "Good";
            }
            else if (R[3] >= 50)
            {
                lblsr.Text = "Good";
            }
            else if (R[3] <= 40)
            {
                lblsr.Text = "Poor";
            }
            if (R[4] >= 80)
            {
                lblrr.Text = "Excellent";
            }
            else if (R[4] >= 70)
            {
                lblrr.Text = "Very Good";
            }
            else if (R[4] >= 60)
            {
                lblrr.Text = "Good";
            }
            else if (R[4] >= 50)
            {
                lblrr.Text = "Good";
            }
            else if (R[4] <= 40)
            {
                lblrr.Text = "Poor";
            }
            if (R[5] >= 80)
            {
                lblir.Text = "Excellent";
            }
            else if (R[5] >= 70)
            {
                lblir.Text = "Very Good";
            }
            else if (R[5] >= 60)
            {
                lblir.Text = "Good";
            }
            else if (R[5] >= 50)
            {
                lblir.Text = "Good";
            }
            else if (R[5] <= 40)
            {
                lblir.Text = "Poor";
            }
            if (R[6] >= 80)
            {
                lblbr.Text = "Excellent";
            }
            else if (R[6] >= 70)
            {
                lblbr.Text = "Very Good";
            }
            else if (R[6] >= 60)
            {
                lblbr.Text = "Good";
            }
            else if (R[6] >= 50)
            {
                lblbr.Text = "Good";
            }
            else if (R[6] <= 40)
            {
                lblbr.Text = "Poor";
            }
            {
                if (R[7] >= 80)
                {
                    lbldr.Text = "Excellent";
                }
                else if (R[7] >= 70)
                {
                    lbldr.Text = "Very Good";
                }
                else if (R[7] >= 60)
                {
                    lbldr.Text = "Good";
                }
                else if (R[7] >= 50)
                {
                    lbldr.Text = "Good";
                }
                else if (R[7] <= 40)
                {
                    lbldr.Text = "Poor";
                }

                }

            }
        


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnranking_Click(object sender, EventArgs e)
        {
            Double[] R = new double[14];

            R[0] = Convert.ToDouble(txtmathematics.Text);
            R[1] = Convert.ToDouble(txtenglish.Text);
            R[2] = Convert.ToDouble(txtscience.Text);
            R[3] = Convert.ToDouble(txtsocial.Text);
            R[4] = Convert.ToDouble(txtrme.Text);
            R[5] = Convert.ToDouble(txtict.Text);
            R[6] = Convert.ToDouble(txtbdt.Text);
            R[7] = Convert.ToDouble(txtdagaare.Text);

            R[8] = (R[0] + R[1] + R[2] + R[3] + R[4] + R[5] + R[6] + R[7]) / 8;
            R[9] = (R[0] + R[2] + R[3] + R[4] + R[5] + R[6] + R[7]);

            string average = Convert.ToString(R[8]);
            string total = Convert.ToString(R[9]);

            txtstaverage.Text = average;
            txttotal.Text = total;
            lbltotal.Text = total;
            lblstaverage.Text = average;




        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
