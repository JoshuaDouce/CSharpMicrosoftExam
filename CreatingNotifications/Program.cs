using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingNotifications
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public class Lease
        {
            //An event variable forstoring the Maximum term reached even
            public event MaximumTermReachedHandler OnMaximumTermReached;

            private int _term;
            private const int Maximumterm = 5;
            private const decimal Rate = 0.034m;

            //A variable to store the term
            public int Term
            {
                //getter
                get { return _term; }

                //setter
                set
                {
                    if (value <= Maximumterm)
                    {
                        _term = value;
                    }
                    else
                    {
                        //if even is not null
                        if (OnMaximumTermReached != null)
                        {
                            //Create new event
                            OnMaximumTermReached(this, new EventArgs());
                        }
                    }
                }
            }

            //A delegate that handles the maximum term reached event
            public delegate void MaximumTermReachedHandler(object source, EventArgs e);
        }
    }
}
