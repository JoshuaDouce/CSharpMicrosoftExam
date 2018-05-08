using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example3_1CustomerAndAddress
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public class Customer {
            public int Id { get; set; }

            [Required, MaxLength(20)]
            public string FirstName { get; set; }

            [Required, MaxLength(20)]
            public string LastName { get; set; }

            [Required]
            public Address ShippingAddress { get; set; }

            public Address BillingAddress { get; set; }

        }

        public class Address {
            public int Id { get; set; }

            [Required, MaxLength(20)]
            public string AddressLine1 { get; set; }

            [Required, MaxLength(20)]
            public string AddressLine2 { get; set; }

            [Required, MaxLength(20)]
            public string City { get; set; }

            [RegularExpression(@"^[1-9][0-9]{3}\s?[a-zA-Z]{2}$")]
            public string ZipCode { get; set; }
        }
    }
}
