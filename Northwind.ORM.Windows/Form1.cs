using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Northwind.ORM.Main;
using Northwind.ORM.Main.Data;

namespace Northwind.ORM.Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            bsCustomers.DataSource = CustomerManager.GetCustomers();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var random = new Random();
            var newCustomer = new Customers()
            {
                CustomerID = string.Format("RHK{0}", random.Next(0, 12)),
                CompanyName = "Queaso Systems NV",
                ContactName = "Ruben Haeck",
                ContactTitle = "ICT Architect/Senior Developer",
                Address = "Hendrik Waelputstraat 21",
                City = "Ghent",
                PostalCode = "9000",
                Country = "Belgium",
                Phone = "092260000"
            };

            CustomerManager.AddCustomer(newCustomer);
        }

        private void btnTestValidation_Click(object sender, EventArgs e)
        {
            var newCustomer = new Customers()
            {
                CustomerID = "XXHA",
                CompanyName = "Queaso Systems NV",
                ContactName = "Ruben Haeck",
                ContactTitle = "ICT Architect/Senior Developer",
                Address = "Hendrik Waelputstraat 21",
                City = "Ghent",
                PostalCode = "9000",
                Country = "Belgium",
                Phone = "092260000"
            };

            CustomerManager.AddCustomer(newCustomer);
        }
    }
}
