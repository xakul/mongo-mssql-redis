using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mockProject.Persistences.Mssql
{
    public class BaseEntity
    {
        public string CreatedBy { get; set; }

        public DateTime CreatedAt { get; set; }

        public string ChangedBy { get; set; }

        public DateTime? ChangedAt { get; set; }

    }
}
