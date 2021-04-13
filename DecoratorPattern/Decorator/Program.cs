using Decorator.Component;
using Decorator.ConcreteComponent;
using Decorator.ConcreteDecorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    /* The Decorator Pattern attaches additional responsibilities to an object dynamically.
     * Decorators provide a flexible alternative to subclassing for extending functionality.
     * 
     * Decorators use composition to limit inheritance and simplify object relationships
     * to make them more manageable.
     * 
     * Sometimes the Decorator Pattern is called the Wrapper Pattern.
     */

    class Program
    {
        static void Main(string[] args)
        {
            Car theCar = new CompactCar();
            theCar = new Navigation(theCar);
            theCar = new Sunroof(theCar);
            theCar = new LeatherSeats(theCar);

            Console.WriteLine(theCar.GetDescription());
            Console.WriteLine($"{theCar.GetCarPrice():C2}");
            Console.ReadKey();
        }
    }
}
