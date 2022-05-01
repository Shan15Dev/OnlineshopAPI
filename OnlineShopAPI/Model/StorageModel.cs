using System.ComponentModel.DataAnnotations;

namespace OnlineShopAPI.Model;

public class StorageModel
{
    [Key] public int Id { get; set; }
    [Required] [MaxLength(45)] public string Storage { get; set; }
    [Required] [MaxLength(45)] public string Place { get; set; }
}