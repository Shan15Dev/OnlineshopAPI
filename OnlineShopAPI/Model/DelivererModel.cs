using System.ComponentModel.DataAnnotations;

namespace OnlineShopAPI.Model;

public class DelivererModel
{
    [Key] public int Id { get; set; }
    [Required] [MaxLength(45)] public string Deliverer { get; set; }
}