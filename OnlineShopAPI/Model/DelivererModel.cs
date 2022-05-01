using System.ComponentModel.DataAnnotations;

namespace OnlineShopAPI.Model;

public class DelivererModel
{
    [Key] public string Id { get; set; }
    [Required] [MaxLength(45)] public string Deliverer { get; set; }
}