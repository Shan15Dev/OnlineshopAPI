using System.ComponentModel.DataAnnotations;

namespace OnlineShopAPI.Model;

public class BrandModel
{
    [Key] public string Id { get; set; }
    [MaxLength(45)] [Required] public string Brand { get; set; }
}