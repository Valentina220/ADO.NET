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
using CodeFirst;

namespace OrderManager
{
    public partial class SalesData : Form
    {
        public SalesData()
        {
            InitializeComponent();
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<SampleContext>());
        }

        SampleContext context = new SampleContext();

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Model.Customer customer = new Model.Customer
                {
                    FirstName = this.textBoxname.Text,
                    LastName = this.textBoxlastname.Text,
                    Age = Int32.Parse(this.textBoxage.Text),
                    Email = this.textBoxemail.Text,
                    PhoneNumber = this.textBoxphone.Text                    
                };
                context.Customers.Add(customer);
                context.SaveChanges();
                Output();
                textBoxname.Text = String.Empty;
                textBoxlastname.Text = String.Empty;
                textBoxage.Text = String.Empty;
                textBoxemail.Text = String.Empty;
                textBoxphone.Text = String.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.ToString());
            }

            List<Model.Order> Orders = orderlistBox.SelectedItems.OfType<Model.Order>().ToList();
        }

        private void Output()
        {
            if (this.CustomerradioButton.Checked == true)
                GridView.DataSource = context.Customers.ToList();
            else if (this.OrderradioButton.Checked == true)
                GridView.DataSource = context.Orders.ToList();
        }

        private void buttonOut_Click(object sender, EventArgs e)
        {
            Output();

            var query = 
                from b in context.Customers
                orderby b.LastName
                select b;

            customerList.DataSource = query.ToList();
        }

        private void SalesData_Load(object sender, EventArgs e)
        {
            context.Orders.Add(new Model.Order
            {
                ProductName = "Парфюмерая вода Lancome",
                UnitPrice = 4371,
                Quantity = 1,
                PurchaseDate = DateTime.Parse("12.10.2020")
            });
            context.Orders.Add(new Model.Order
            {
                ProductName = "Тушь для ресниц Estee Lauder",
                UnitPrice = 2190,
                Quantity = 2,
                PurchaseDate = DateTime.Parse("09.02.2021")
            });
            context.SaveChanges();
            orderlistBox.DataSource = context.Orders.ToList();
        }

        private void GridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridView.CurrentRow == null) return;
            var customer = GridView.CurrentRow.DataBoundItem as Model.Customer;
            if (customer == null) return;

            labelid.Text = Convert.ToString(customer.CustomerId);
            textBoxCustomer.Text = customer.ToString();
            textBoxname.Text = customer.FirstName;
            textBoxlastname.Text = customer.LastName;
            textBoxage.Text = Convert.ToString(customer.Age);
            textBoxemail.Text = customer.Email;
            textBoxphone.Text = customer.PhoneNumber;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (labelid.Text == String.Empty) return;
            var id = Convert.ToInt32(labelid.Text);
            var customer = context.Customers.Find(id);
            if (customer == null) return;
            customer.FirstName = this.textBoxname.Text;
            customer.LastName = this.textBoxlastname.Text;
            customer.Age = Int32.Parse(this.textBoxage.Text);
            customer.Email = this.textBoxemail.Text;
            customer.PhoneNumber = this.textBoxphone.Text;
            context.Entry(customer).State = EntityState.Modified;
            context.SaveChanges();
            Output();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (labelid.Text == String.Empty) return;
            var id = Convert.ToInt32(labelid.Text);
            var customer = context.Customers.Find(id);
            context.Entry(customer).State = EntityState.Deleted;
            context.SaveChanges();
            Output();
        }     
        
    }
}
