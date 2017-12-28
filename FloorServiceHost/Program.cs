using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;
using VeryImportantFloorService;

namespace FloorServiceHost
{
    /// <summary>
    /// 
    /// </summary>
    class Program
    {
        /// <summary>
        /// Mains the specified arguments.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            // Set the Uri to port 8181
            Uri baseAddress = new Uri("http://localhost:8181/FloorService");

            // Create the ServiceHost
            using (ServiceHost host = new ServiceHost(typeof(VeryImportantFloorService.FloorService), baseAddress))
            {
                // Enable metadata publishing.
                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                smb.MetadataExporter.PolicyVersion = PolicyVersion.Policy15;
                host.Description.Behaviors.Add(smb); // Add the service behavior to the host description

                // Open the ServiceHost to start listening for messages on port 8181
                host.Open();

                // Tell the user where the service is listening
                Console.WriteLine("There service is ready at {0}", baseAddress);
                Console.WriteLine("Press <Enter> to stop the service.");
                // Keep the service open until the user presses the enter key.
                Console.ReadLine();

                // Close the ServiceHost.
                host.Close();
            }
        }
    }
}
