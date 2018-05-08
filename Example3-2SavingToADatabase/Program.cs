using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example3_2SavingToADatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ShopContext ctx = new ShopContext())
            {
                Address a = new Address()
                {
                    AddressLine1 = "Here",
                    AddressLine2 = "There",
                    City = "Far",
                    ZipCode = "1111AA",
                };

                Customer c = new Customer()
                {
                    FirstName = "Joe",
                    LastName = "Bloggs",
                    BillingAddress = a,
                    ShippingAddress = a,
                };

                ctx.Customers.Add(c);
                ctx.SaveChanges();
            }
        }
    }
}
