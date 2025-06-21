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

namespace RiceMillManagementSystem
{
    public partial class Dashboard : Form
    {
        private int userId;
        public Dashboard(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=Afridi;Initial Catalog=ricemillmanagement;Integrated Security=True;TrustServerCertificate=True");
            conn.Open();
            String query = "SELECT Name FROM Users where UserID=@userId";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@userId", userId);
            string name = cmd.ExecuteScalar()?.ToString();
            if (name != null)
            {
                label2.Text = name;
            }
            else
            {
                label2.Text = "User name not found!";
            }
        }
    }
}
