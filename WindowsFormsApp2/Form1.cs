using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            var query = "SELECT * FROM [User]";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter sda = new SqlDataAdapter(query, connection);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                this.dataGridView1.DataSource = ds.Tables[0];
            }
        }
    }
}
