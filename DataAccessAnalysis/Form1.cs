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

namespace DataAccessAnalysis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }

        static string GetConnectionStringByName(string name)
        {
            string returnValue = null;
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings[name];
            if (settings != null)
                returnValue = settings.ConnectionString;
            return returnValue;
        }

        string connectionString = GetConnectionStringByName("DataAccessAnalysis.AdventureWorksConnectionString");                   
              

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand("SELECT Name, SalesYTD, SalesLastYear FROM Sales.SalesTerritory", connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        ListViewItem newItem = listView1.Items.Add(reader["Name"].ToString());
                        newItem.SubItems.Add(reader["SalesYTD"].ToString());
                        newItem.SubItems.Add(reader["SalesLastYear"].ToString());
                    }
                }

                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand("SELECT Product.Name, SUM(SalesOrderDetail.LineTotal) AS TotalSum FROM Production.Product LEFT JOIN Sales.SalesOrderDetail ON Product.ProductID = SalesOrderDetail.ProductID GROUP BY Product.Name", connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        ListViewItem newItem = listView2.Items.Add(reader["Name"].ToString());
                        newItem.SubItems.Add(reader["TotalSum"].ToString());
                    }
                }

                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
            }
                
        }
    }
}
