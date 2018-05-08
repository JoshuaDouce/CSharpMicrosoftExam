using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example3_2SavingToADatabase
{
    class ShopContext : DbContext
    {
        public IDbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //make sure database can handle duplicates
            modelBuilder.Entity<Customer>().HasRequired(bm => bm.BillingAddress).WithMany().WillCascadeOnDelete(false);
        }
    }
}
