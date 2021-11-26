using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace KMart.Entities
{
    [Table ("Order")]
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        [ForeignKey("Product")]
        public int PId { get; set; }

        [JsonIgnore]
        public Product Product { get; set; }

        [Column(TypeName = "Date")]
        public DateTime? OrderDate { get; set; }

    }
}
