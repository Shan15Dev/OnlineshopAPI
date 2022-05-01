using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineShopAPI.Model;

public class ProductModel
{
    [Key] public int Id { get; set; }
    [Required] [MaxLength(45)] public string Product { get; set; }

    [ForeignKey("BrandModel")] public int Brand_id { get; set; }
    public BrandModel BrandModel { get; set; }
}