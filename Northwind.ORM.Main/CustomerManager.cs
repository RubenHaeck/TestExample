using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Logging;
using Northwind.ORM.Main.Data;

namespace Northwind.ORM.Main
{
    public static class CustomerManager
    {
        private static ILog _log = LogManager.GetCurrentClassLogger();

        public static List<Customers> GetCustomers()
        {
            using (var dbContext = new NorthwindDbContext())
            {
                return dbContext.Customers.ToList();
                
            }
        }

        public static void AddCustomer(Customers customer)
        {
            try
            {
                _log.Info(l => l("Start adding a new customer with PK: {0}", customer.CustomerID));

                using (var dbContext = new NorthwindDbContext())
                {
                    var validation = dbContext.GetValidationErrors();
                    
                    dbContext.Customers.Add(customer);
                    dbContext.SaveChanges();
                }
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        _log.Error(l => l("Property: {0} Error: {1}", validationError.PropertyName,
                            validationError.ErrorMessage));
                    }
                }
            }
            catch (ExecutionEngineException ex)
            {
                throw ex;
            }
        }
    }
}
