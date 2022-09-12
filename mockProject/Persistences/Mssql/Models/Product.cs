using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using mockProject.Persistences.Mssql;

namespace mockProject.Persistences.Mssql
{
    public partial class Product : BaseEntity
    {
        public Product()
        {
            Orders = new HashSet<Order>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(100)]
        public string Name { get; set; } = null!;
        public int Quantity { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal Price { get; set; }
        [StringLength(100)]
        public string Description { get; set; } = null!;
        [InverseProperty("Product")]
        public virtual ICollection<Order> Orders { get; set; }
    }
}
