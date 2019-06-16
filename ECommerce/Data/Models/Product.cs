using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Models
{
  public class Product
  {
    [Key]
    [Required]
    public int Id { get; set; }

    [MaxLength(100)]
    [Required]
    public string Title { get; set; }
    
    [MaxLength(255)]
    public string ImageUrl { get; set; }

    [Column(TypeName="DECIMAL(18,2)")]
    public decimal Price { get; set; }

    [MaxLength(100)]
    [Required]
    public string Company { get; set; }

    public string Info { get; set; }
  }
}
