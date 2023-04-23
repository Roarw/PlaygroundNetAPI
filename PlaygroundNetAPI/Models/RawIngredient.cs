using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlaygroundNetAPI.Models
{
    public class RawIngredient
    {
        public int ID { get; set; }
        public string? GUID { get; set; }
        public string? Name { get; set; }
        public string? Type { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal Price { get; set; }
        public DateTime Updated { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime Created { get; set; }
        public string? CreatedBy { get; set; }
    }
}
