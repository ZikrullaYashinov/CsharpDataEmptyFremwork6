using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z
{
    [Table("products")]
    internal class Product
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("name"), MaxLength(50)]
        public string Name { get; set; }

        [Column("price")]
        public decimal Price { get; set; }

        [Column("units")]
        public int Units { get; set; }
    
    }
}
