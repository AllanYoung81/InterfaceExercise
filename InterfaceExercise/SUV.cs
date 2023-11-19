using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public SUV() 
        { 
        
        }
        public int Year { get; set; } = 2000;
        public string Make { get; set; } = "Dodge";
        public string Model { get; set; } = "Durango";
        public string Engine { get; set; } = "V6";
        public string Logo { get; set; } = "Different";
        public string CompanyName { get; set; } = "Antwerpen Dodge";

        public bool AllWheelDrive { get; set; } = true;


        public void Park()
        {
            Console.WriteLine($"{GetType().Name} is in Park.");
        }

        public void Reverse()
        {
            Console.WriteLine($"{GetType().Name} is in Reverse.");
        }
        public void Neutral()
        {
            Console.WriteLine($"{GetType().Name} is in Neutral.");
        }
        public void Drive()
        {
            if (AllWheelDrive == true)
            {

                Console.WriteLine($"{GetType().Name} is in All Wheel Drive mode.");
            }
        }
    }
}
