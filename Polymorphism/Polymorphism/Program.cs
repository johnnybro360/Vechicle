using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle[] Vehicles =
            {
                new  Car(Guid.NewGuid().ToString(), "Black", "Golf GTI", "Volkswagen", new DateTime(1994, 06, 27)),
                new  Automatic(Guid.NewGuid().ToString(), "White", "Club Sport", "Holden", new DateTime(1997, 06, 27), "Hard"),
                new  Automatic(Guid.NewGuid().ToString(), "Cow Brown", "Combine 3000", "John Deere", new DateTime(1987, 06, 27), "Easy"),
                new  Car(Guid.NewGuid().ToString(), "Red", "Cooper", "Mini", new DateTime(2000, 06, 27)),

            };

            foreach (Vehicle vehicle in Vehicles)
            {
                vehicle.Drive();
            }

            //Vehicle v = new Vehicle();
            //Vehicle v = new Car("one","Black", "Golf GTI", "Volkswagen", new DateTime(1994, 06, 27));
            //Console.WriteLine(v.GetType());
            //v.Drive();            
            //Car car = (Car) v;
            //Console.WriteLine(car.Color);

            //Vehicle v = new Automatic("one", "Black", "Golf GTI", "Volkswagen", new DateTime(1994, 06, 27), "Easy");
            //v.Drive();

            //Automatic a = (Automatic) v;

            Console.ReadLine();
        }
    }
}
