using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace z
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using(var db=new ShopContext())
            {
                db.Products.Add(new Product { Name = "Iphone", Price = 4000, Units = 1 });
                db.SaveChanges();
            }
        }
    }
}
