
namespace De_fyra_OOP_principerna
{
    // jag ska skappa en basklass på Truck  
    public class Truck
    {
        //  här har vi egenskaperna som klassen har
        public string Make;
       
        public string Model;
       
        public int Year;
       
        // metod
        public void Start()
        {
            Console.WriteLine("The Truck is starting.");
        }
    }

    // här skapar jag en subklass som ärver från basklassen Vehicle

    public class Car : Truck
    {
        // egenskap som är specifik för Car
        
        public string Color;

        // metod som är specifik för Car
        public void Honk()
        {
            Console.WriteLine("The car is honking.");
        }
    }
}
