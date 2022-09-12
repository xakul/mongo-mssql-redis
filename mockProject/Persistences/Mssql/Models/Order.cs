using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using mockProject.Persistences.Mssql;

namespace mockProject.Persistences.Mssql
{
    public partial class Order : BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedAt { get; set; }
        [StringLength(100)]
        public string? CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ChangedAt { get; set; }
        [StringLength(100)]
        public string? ChangedBy { get; set; }

        [ForeignKey("CustomerId")]
        [InverseProperty("Orders")]
        public virtual Customer Customer { get; set; } = null!;
        [ForeignKey("ProductId")]
        [InverseProperty("Orders")]
        public virtual Product Product { get; set; } = null!;
    }
}
