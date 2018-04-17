using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1_82UsingAnActionToExposeEvent
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateAndRaise();
        }

        //the pub class is completely unaware of any subscribers it just raises the event
        public class Pub {
            //if no subscribers this would be null
            public Action OnChange { get; set; }

            public void Raise() {
                if (OnChange != null)
                {
                    OnChange();
                }
            }
        }

        public static void CreateAndRaise() {
            //create a new instance of pub
            Pub p = new Pub();

            //subscribe to the event woth two different methods
            p.OnChange += () => Console.WriteLine("Event to raise to method 1");
            p.OnChange += () => Console.WriteLine("Event to raise to method 2");
            //p.OnChange = () => Console.WriteLine("Event to raise to method 2"); this would remove all other sunscribers

            //raise the event
            p.Raise();
        }
    }
}
