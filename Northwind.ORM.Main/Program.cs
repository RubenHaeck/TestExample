using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Logging;
using Northwind.ORM.Main.Data;

namespace Northwind.ORM.Main
{
    class Program
    {
        private static ILog _log = LogManager.GetLogger<Program>();

        static void Main(string[] args)
        {
            _log.Info(l => l("Start"));

            using (var dbContext = new NorthwindDbContext())
            {
                var customers = dbContext.Customers.ToList();

                foreach (var c in customers)
                {
                    _log.Info(l => l("CustomerID: {0}, CompanyName: {1}, ContactName: {2}", c.CustomerID,
                        c.CompanyName, c.ContactName));
                    //Console.WriteLine(string.Format("CustomerID: {0}, CompanyName: {1}, ContactName: {2}", c.CustomerID,
                    //    c.CompanyName, c.ContactName));
                }
            }

            _log.Info(l => l("Stop"));
        }
    }
}
