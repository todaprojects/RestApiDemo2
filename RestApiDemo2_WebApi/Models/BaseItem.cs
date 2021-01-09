using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestApiDemo_WebApi.Models
{
    public abstract class BaseItem
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        [Column(TypeName = "decimal(5, 2)")]
        public decimal Price { get; set; }
        
        public int Quantity { get; set; }
    }
}