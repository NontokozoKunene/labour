using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepartmentOfLabour
{
    public partial class regForm1 : Form
    {
        public regForm1()
        {
            InitializeComponent();
        }

        private void regForm1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            MessageBoxButtons btn = MessageBoxButtons.OK;
            MessageBoxIcon icon = MessageBoxIcon.Information;
            String caption = "Submit your Data";

            if (string.IsNullOrEmpty(Fnametext.Text))
            {
                MessageBox.Show("Please Enter Your first name!",caption,btn,icon);
                Fnametext.Focus();

                return;

            }
            if (string.IsNullOrEmpty(Surnametext.Text))
            {
                MessageBox.Show("Please Enter Your Surname!", caption, btn, icon);
                Surnametext.Focus();

                return;

            }
            if (string.IsNullOrEmpty(Emailtext.Text))
            {
                MessageBox.Show("Please Enter Your Email_Address!", caption, btn, icon);
                Emailtext.Focus();

                return;

            }

            if (string.IsNullOrEmpty(Passswordtext.Text))
            {
                MessageBox.Show("Please Enter Your Password!", caption, btn, icon);
                Passswordtext.Focus();

                return;

            }
            if (string.IsNullOrEmpty(cornfirmtext.Text))
            {
                MessageBox.Show("Please Confirm your Password!", caption, btn, icon);
                cornfirmtext.Focus();

                return;

            }

            if(Passswordtext.Text != cornfirmtext.Text)
            {
                MessageBox.Show("Your confirmation Password doesn't match with your Password!", caption, btn, icon);
                cornfirmtext.Focus();

                return;
            }
            string query = "Select * From Tbl_Userlogin Where Email_Address ='" + Emailtext.Text + "'";

            DataTable checkDuplicate = DepartmentOfLabour.connection.ClassConnection.executeSQL(query);

            if(checkDuplicate.Rows.Count > 0)
            {
                MessageBox.Show("The email is already exist. Please Try another email","Or Register again with unique email"
                    ,MessageBoxButtons.OK, MessageBoxIcon.Information);
                Emailtext.Focus();
                return;
            }

            string myQuery = string.Empty;
            myQuery += "Insert INTO Tbl_Userlogin(First_Name,SurName,Email_Address,password)";
            myQuery += "VALUE ('"+Fnametext.Text+"','"+ Surnametext.Text +"','"+Emailtext.Text+ "','"+Passswordtext.Text + "'";

            DepartmentOfLabour.connection.ClassConnection.executeSQL(myQuery);




        }
    }
}
