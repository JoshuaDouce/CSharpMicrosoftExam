using System;

namespace Example3_1
{
    public class Customer
    {
        public int Id { get; set; }

        [Required, MaxLength(20)]
        public string FirstName { get; set; }
    }
}
