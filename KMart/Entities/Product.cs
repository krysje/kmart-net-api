using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KMart.Entities
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public int PId { get; set; }

        [Column]
        [Required]
        public string Pname { get; set; }
        
        [Column]
        [Required]
        public int price { get; set; }

        [Column]
        [Required]
        public int stock { get; set; }


    }
}
