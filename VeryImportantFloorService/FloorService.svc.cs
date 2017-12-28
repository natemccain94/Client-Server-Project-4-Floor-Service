using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace VeryImportantFloorService
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="VeryImportantFloorService.IFloorService" />
    public class FloorService : IFloorService
    {
        /// <summary>
        /// Gets the floor plate one value.
        /// </summary>
        /// <returns></returns>
        public string GetFloorPlateOneVal()
        {
            Random rand = new Random();
            float floor;
            // Generate a random value
            var temp = rand.Next(0, 1001);
            
            // Make sure the reported value will not be over 1000 lbs
            switch (temp)
            {
                case 1000:
                    floor = (float) temp;
                    break;
                default:
                    floor = (float) temp + (float) rand.NextDouble();
                    break;
            }
            // Show that data is being returned by the service.
            Console.WriteLine("Returning the value for the floor plate at the front of reception.");
            Console.WriteLine("The floor sensor reads: " + floor.ToString() + " lbs");
            return floor.ToString();
        }

        /// <summary>
        /// Gets the floor plate two value.
        /// </summary>
        /// <returns></returns>
        public string GetFloorPlateTwoVal()
        {
            Random rand = new Random();
            float floor;
            // Generate a random value
            var temp = rand.Next(0, 1001);
            // Make sure the reported value will not be over 1000 lbs
            switch (temp)
            {
                case 1000:
                    floor = (float)temp;
                    break;
                default:
                    floor = (float)temp + (float)rand.NextDouble();
                    break;
            }
            // Show that data is being returned by the service.
            Console.WriteLine("Returning the value for the floor plate at the back of reception.");
            Console.WriteLine("The floor sensor reads: " + floor.ToString() + " lbs");
            return floor.ToString();
        }

        /// <summary>
        /// Gets the floor plate three value.
        /// </summary>
        /// <returns></returns>
        public string GetFloorPlateThreeVal()
        {
            Random rand = new Random();
            float floor;
            // Generate a random value
            var temp = rand.Next(0, 1001);
            // Make sure the reported value will not be over 1000 lbs
            switch (temp)
            {
                case 1000:
                    floor = (float)temp;
                    break;
                default:
                    floor = (float)temp + (float)rand.NextDouble();
                    break;
            }
            // Show that data is being returned by the service.
            Console.WriteLine("Returning the value for the floor plate at the front of important person's office.");
            Console.WriteLine("The floor sensor reads: " + floor.ToString() + " lbs");
            return floor.ToString();
        }

        /// <summary>
        /// Gets the floor plate four value.
        /// </summary>
        /// <returns></returns>
        public string GetFloorPlateFourVal()
        {
            Random rand = new Random();
            float floor;
            // Generate a random value
            var temp = rand.Next(0, 1001);
            // Make sure the reported value will not be over 1000 lbs
            switch (temp)
            {
                case 1000:
                    floor = (float)temp;
                    break;
                default:
                    floor = (float)temp + (float)rand.NextDouble();
                    break;
            }
            // Show that data is being returned by the service.
            Console.WriteLine("Returning the value for the floor plate at the back of important person's office.");
            Console.WriteLine("The floor sensor reads: " + floor.ToString() + " lbs");
            return floor.ToString();
        }
    }
}
