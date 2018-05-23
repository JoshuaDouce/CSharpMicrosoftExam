using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question25_1
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public class Product {

        }

        //Specifies a strongly typed save method which allows only types inherited from the product class that
        //use a constructor with no params
        //Save<T> amkes it strongly type
        //Where T:Product specifies it must be a product or inherit from one
        //new() specifies it must have an empty constructor
        public static void Save<T>(T target) where T : Product, new()
        {

        }
    }
}
