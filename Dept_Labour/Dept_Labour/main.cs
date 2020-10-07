using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;


namespace DepartmentOfLabour
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
            dtp_AppTm.Format = DateTimePickerFormat.Time;
            dtp_AppTm.ShowUpDown = true;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string myQuery = string.Empty;
            myQuery += "Insert INTO Tbl_Appointment(AppDate, AppTime, AppDetails)";
            myQuery += "VALUE ('" + dtp_appDt.Value.ToShortDateString() + "','" + dtp_AppTm.Value.ToShortTimeString() + "','" + txtAppDetails.Text + "'";

            DataTable checkDuplicate =   DepartmentOfLabour.connection.ClassConnection.executeSQL(myQuery);



          
            if (checkDuplicate.Rows.Count> 0)  
        {
            MessageBox.Show("Appointment Saved successfully!");  
        }  
        else  
        {
            MessageBox.Show("Error in saving Appointment!");  
        }  
    
        }

        private void txtAppDetails_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
