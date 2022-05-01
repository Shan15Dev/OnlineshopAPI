using System.ComponentModel.DataAnnotations;

namespace OnlineShopAPI.Model;

public class CustomerModel
{
    [Key] public int Id { get; set; }
    [Required] [MaxLength(45)] public string Name { get; set; }
    [Required] [MaxLength(45)] public string Firstname { get; set; }
    [Required] [MaxLength(45)] public string Address { get; set; }
    [Required] public int PostalCode { get; set; }
    [Required] [MaxLength(45)] public string Place { get; set; }
}