using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineShopAPI.Model;

public class OrderModel
{
    [Key] public int Id { get; set; }
    [Required] [MaxLength(45)] public DateTime Storage { get; set; }
    
    [ForeignKey("CustomerModel")]
    public int Customer_id { get; set; }
    public CustomerModel CustomerModel { get; set; }
    
    [ForeignKey("DelivererModel")]
    public int Deliverer_id { get; set; }
    public DelivererModel DelivererModel { get; set; }
    
    [ForeignKey("StorageModel")]
    public int Storage_id { get; set; }
    public StorageModel StorageModel { get; set; }
}