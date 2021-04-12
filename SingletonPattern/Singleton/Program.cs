using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    /* Singleton Pattern
     * 
     * Ensures a class has only one instance, and provides
     * a global point of access to it.
     * 
     * Eliminates the option of instantiating more than one of the same object.
     */

    public class Program
    {
        static void Main(string[] args)
        {
            var policy = new Policy();
            var insuredName = policy.GetInsuredName();

            Console.WriteLine(insuredName);
        }
    }
}
