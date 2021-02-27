using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace DataAccessAnalysis3
{
    public partial class SalesData : Form
    {
        public SalesData()
        {
            InitializeComponent();
        }

        private AdventureWorks2016Entities AdventureWorksContext;

        private void SalesData_Load(object sender, EventArgs e)
        {
            AdventureWorksContext = new AdventureWorks2016Entities();

            var salesterritory =
                from s in
                AdventureWorksContext.SalesTerritories.Include("SalesPersons")
                orderby s.Name
                select s;

            try
            {
                this.TerritoryName.DisplayMember = "Name";
                this.TerritoryName.DataSource = salesterritory.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            UpdateGrid.DataSource = AdventureWorksContext.SalesPersons.Local.ToBindingList();
        }

        private void TerritoryName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SalesTerritory salesTerritory =
               (SalesTerritory)this.TerritoryName.SelectedItem;                
                SalesTerritoryGrid.DataSource = salesTerritory.SalesPersons.ToList();
                //SalesTerritoryGrid.Columns["TerritoryID"].Visible = false;
                SalesTerritoryGrid.Columns["BusinessEntityID"].Visible = false;
                SalesTerritoryGrid.Columns["Bonus"].Visible = false;
                SalesTerritoryGrid.Columns["CommissionPct"].Visible = false;               
                SalesTerritoryGrid.Columns["rowguid"].Visible = false;
                SalesTerritoryGrid.Columns["ModifiedDate"].Visible = false;

                SalesTerritoryGrid.Columns["Employee"].Visible = false;
                SalesTerritoryGrid.Columns["SalesOrderHeaders"].Visible = false;
                SalesTerritoryGrid.Columns["SalesTerritory"].Visible = false;
                SalesTerritoryGrid.Columns["SalesPersonQuotaHistories"].Visible = false;
                SalesTerritoryGrid.Columns["SalesTerritoryHistories"].Visible = false;
                SalesTerritoryGrid.Columns["Stores"].Visible = false;

                SalesTerritoryGrid.AllowUserToDeleteRows = false;
                SalesTerritoryGrid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
                

        private void saveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                AdventureWorksContext.SaveChanges();
                MessageBox.Show("Changes saved to the database.");
                this.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void closeForm_Click(object sender, EventArgs e)
        {
            this.Close();
            AdventureWorksContext.Dispose();
        }        
    }
}
