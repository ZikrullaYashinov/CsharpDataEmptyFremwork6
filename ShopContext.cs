using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace z
{
    internal class ShopContext: DbContext
    {
        public DbSet<Product> Products { get; set; }
        public ShopContext():base(nameOrConnectionString: "DBConnectionString") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            base.OnModelCreating(modelBuilder);

        }

    }
}
