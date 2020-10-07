using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace DepartmentOfLabour.connection
{
    class ClassConnection
    {
        public static string stringConection = "Data Source=DESKTOP-13V1ED4;Initial Catalog=DepartmentOfLabour;Integrated Security=True";

        public static DataTable executeSQL(string sql) 
        {
            SqlConnection connection = new SqlConnection();
            SqlDataAdapter adapter = default(SqlDataAdapter);
            DataTable dt = new DataTable();

            try
            {
                connection.ConnectionString = stringConection;
                connection.Open();
                adapter = new SqlDataAdapter(sql, connection);
                adapter.Fill(dt);

                connection.Close();
                connection = null;
                return dt;
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("An arror occured: " + ex.Message,
                    "sql Server connection failed ", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                dt = null;
            }
            return dt;
        }

    }
}
