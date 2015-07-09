using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Northwind.ORM.ServiceHost;

namespace Northwind.ORM.Windows
{
    public partial class TestWebServiceForm : Form
    {
        public TestWebServiceForm()
        {
            InitializeComponent();
        }

        private void btnSecureTestService_Click(object sender, EventArgs e)
        {
            var channelFactory = new ChannelFactory<ISecureTestService>(new BasicHttpBinding("secureBasicHttpBindingConfiguration"), new EndpointAddress("https://localhost/Northwind.ORM.ServiceHost/SecureTestService.svc"));
            var secureTestService = channelFactory.CreateChannel();
            var calculatedValue = secureTestService.Calculate(5);


        }

        private void btnTestService_Click(object sender, EventArgs e)
        {
            var channelFactory =
                new ChannelFactory<ITestService>(new BasicHttpBinding("basicHttpBindingConfiguration"),
                    new EndpointAddress("http://localhost/Northwind.ORM.ServiceHost/TestService.svc"));

            var testService = channelFactory.CreateChannel();
            var outputTest = testService.WhoAmI();
        }
    }
}
