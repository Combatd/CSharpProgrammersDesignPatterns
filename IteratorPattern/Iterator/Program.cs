using Iterator.Aggregate;
using Iterator.Iterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    /* The Iterator Pattern provides a way to access the elements of
     * an aggregate object sequentially without exposing its underlying
     * representation.
     * 
     * It provides a way to access and iterate through collections
     * in the same way, regardless of type.
     */

    class Program
    {
        static void Main(string[] args)
        {
            INewspaper nyt = new NYPaper();
            INewspaper lat = new LAPaper();

            IIterator nypIterator = nyt.CreateIterator();
            IIterator lapIterator = lat.CreateIterator();

            Console.WriteLine("--------   NYPaper");
            PrintReporters(nypIterator);

            Console.WriteLine("--------   LAPaper");
            PrintReporters(lapIterator);

            Console.ReadLine();
        }

        static void PrintReporters(IIterator iterator) {
            iterator.First();
            while(!iterator.IsDone()){
                Console.WriteLine(iterator.Next());
            }
        }
    }
}
