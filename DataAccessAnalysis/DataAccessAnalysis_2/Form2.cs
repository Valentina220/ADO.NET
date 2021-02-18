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

namespace DataAccessAnalysis
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        static SqlConnection AdventureWorksConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=AdventureWorks2016;Integrated Security=True");
        static string query = "SELECT * FROM Sales.SalesOrderDetail";
        static SqlDataAdapter SqlDataAdapter1 = new SqlDataAdapter(query, AdventureWorksConnection);

        DataSet AdventureWorksDataset = new DataSet("Sales.SalesOrderDetail");
        SqlCommandBuilder commands = new SqlCommandBuilder(SqlDataAdapter1);

        private void Form2_Load(object sender, EventArgs e)
        {
            SqlDataAdapter1.Fill(AdventureWorksDataset, "Sales.SalesOrderDetail");
            dataGridView1.DataSource = AdventureWorksDataset.Tables["Sales.SalesOrderDetail"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdventureWorksDataset.EndInit();
            SqlDataAdapter1.Update(AdventureWorksDataset.Tables["Sales.SalesOrderDetail"]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataRow SalRow = AdventureWorksDataset.Tables["Sales.SalesOrderDetail"].NewRow();
            Object[] SalRecord = { 43890, 1001, "7DF2-4E54-B0", 1, 775, 1, (decimal)2024.9940, (decimal)0.0000 };
            SalRow.ItemArray = SalRecord;
            AdventureWorksDataset.Tables["Sales.SalesOrderDetail"].Rows.Add(SalRow);

            SqlDataAdapter1.Update(AdventureWorksDataset.Tables["Sales.SalesOrderDetail"]);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            AdventureWorksDataset.EndInit();
            var index = dataGridView1.CurrentRow.Index;
            AdventureWorksDataset.Tables["Sales.SalesOrderDetail"].Rows[index].Delete();
            SqlDataAdapter1.Update(AdventureWorksDataset.Tables["Sales.SalesOrderDetail"]);
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.Show();
            this.Close();
        }
    }
}
