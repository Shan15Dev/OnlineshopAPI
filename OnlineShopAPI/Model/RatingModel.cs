using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineShopAPI.Model;

public class RatingModel
{
    [Key] public int Id { get; set; }
    [Required] public Decimal StarRating { get; set; }
    [ForeignKey("ProductModel")] public int Product_id { get; set; }

    public ProductModel ProductModel { get; set; }
}