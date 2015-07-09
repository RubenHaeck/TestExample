using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Northwind.ORM.ServiceHost
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SecureTestService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select SecureTestService.svc or SecureTestService.svc.cs at the Solution Explorer and start debugging.
    public class SecureTestService : ISecureTestService
    {
        public void DoWork()
        {
        }

        public int Calculate(int t = 0)
        { 
            return 5 + t;
        }
    }
}
