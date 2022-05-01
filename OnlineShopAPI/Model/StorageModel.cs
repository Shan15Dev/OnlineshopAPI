using System.ComponentModel.DataAnnotations;

namespace OnlineShopAPI.Model;

public class StorageModel
{
    [Key] public string Id { get; set; }
    [Required] [MaxLength(45)] public string Storage { get; set; }
    [Required] [MaxLength(45)] public string Place { get; set; }
}