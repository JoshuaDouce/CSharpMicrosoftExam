using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1_83_UsingEvent
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateAndRaise();
        }

        public class Pub
        {
            //the event keyword means you are using a public field however the compiler protects
            //it from unwanted access. You can no longer use = to assign a subscriber. 
            //Can now only be raised by code that's part of the class that defined the event; 
            public event Action OnChange = delegate { };

            public void Raise()
            {
                OnChange();
            }
        }

        public static void CreateAndRaise()
        {
            Pub p = new Pub();

            p.OnChange += () => Console.WriteLine("Event to raise to method 1");
            p.OnChange += () => Console.WriteLine("Event to raise to method 2");

            p.Raise();
        }
    }
}
