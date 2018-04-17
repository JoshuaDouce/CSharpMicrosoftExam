using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1_84CustomEventArgs
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public class MyArgs : EventArgs
        {
            public MyArgs(int value)
            {
                Value = value;
            }

            public int Value { get; set; }
        }

        public class Pub {

            //specifies the type of the event args
            public event EventHandler<MyArgs> OnChange = delegate { };

            //raising an event requires you to pass an in instance of MyArgs
            //Subscribes can access the arguments
            public void Raise() {
                OnChange(this, new MyArgs(42));
            }
        }

        public void CreateAndRaise() {
            Pub p = new Pub();

            p.OnChange += (sender, e) => Console.WriteLine("Event raised: {0}", e.Value);

            p.Raise();
        }
    }
}
