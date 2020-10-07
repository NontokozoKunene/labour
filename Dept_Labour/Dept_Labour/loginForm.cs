using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DepartmentOfLabour.connection;

namespace DepartmentOfLabour
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            Emailtext.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            regForm1 register = new regForm1();
            register.ShowDialog();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(Emailtext.Text)&&
               !string.IsNullOrEmpty(textBox2.Text))
            {
                string mySql = string.Empty;

                mySql += "Select * From Tbl_Userlogin";
                mySql += "Where Email_Address ='"+ Emailtext.Text+"'";
                mySql += "And password ='"+textBox2.Text+"'";

                DataTable userData = ClassConnection.executeSQL(mySql);
                if (userData.Rows.Count > 0)
                {
                    Emailtext.Clear();
                    textBox2.Clear();
                    checkBox1.Checked = false;

                    this.Hide();


                    main formMain = new main();
                    formMain.ShowDialog();
                    formMain = null;


                    this.Show();
                }
                else {
                    MessageBox.Show("Please enter your email and password", "Please",
                   MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    Emailtext.Focus();
                    Emailtext.Select();
                }

            }
            else
            {
                MessageBox.Show("Please enter your email and password","Please",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Emailtext.Select();
            }
        }
    }
}
