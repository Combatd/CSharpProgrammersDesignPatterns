using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // invoke an instance of each ConcreteSubject
            var gClooney = new GClooney("I love my new wife");
            var tSwift = new TSwift("1981 is now my favorite number.");

            // Create an instance of 2 ConcreteObserver
            var firstFan = new Fan();
            var secondFan = new Fan();

            // Add 2 ConcreteObservers to 2 ConcreteSubjects
            gClooney.AddFollower(firstFan);
            tSwift.AddFollower(secondFan);

            // The 2 ConcreteObservers will be notified of a change in state (ICelebrity.Tweet)
            gClooney.Tweet = "My wife didn't force me to tweet.";
            tSwift.Tweet = "I love my new music.";

            Console.Read();
        }
    }
}

/* Observer Pattern
 * 
 * Defines a one-to-many dependency between objects so that when one object
 * changes state, all its dependents are notified and updated automatically.
 * 
 * A change in one object causes a change or action in another.
 * 
 * Publisher/Subscriber on Windows
 * 
 * Event handling uses the observer pattern.
 * Mouse clicks trigger an event as the publisher.
 * Object executes an action as the subscriber.
 */