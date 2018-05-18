using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1_24OrderedParalellQuery
{
    internal class Program
    {
        //displays in order
        private static void Main(string[] args)
        {
            var numbers = Enumerable.Range(0, 10);
            //adding the .AsOrdered to the LINQ statement ensure the result is returned in order
            //Note to self: How does AdOrdered work on a list of custom objects
            var parallelResult = numbers.AsParallel().AsOrdered()
                .Where(i => i % 2 == 0)
                .ToArray();

            foreach (var i in parallelResult)
            {
                Console.WriteLine(i);
            }

            //A collection of custom objects
            var people = new[]
            {
                new Person("Joe", "Bloggs"),
                new Person("Jeff", "Banks"),
                new Person("Fred", "Clauser"),
                new Person("Elvis", "Presley"),
                new Person("Alex", "Higgins")
            };

            var peopleFilter = people.AsParallel().AsOrdered()
                .Where(i => i.FirstName.ToLowerInvariant().Contains("f"))
                .ToArray();

            foreach (var person in peopleFilter)
            {
                Console.WriteLine(person.ToString());
            }

        }

        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public Person(string fname, string lname)
            {
                FirstName = fname;
                LastName = lname;
            }

            public override string ToString() => $"{FirstName}, {LastName}";
        }

    }
}
