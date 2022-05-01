using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineShopAPI.Model;

public class Product_has_OrderModel
{
    [ForeignKey("ProductModel")]
    public int Product_id { get; set; }
    public ProductModel ProductModel { get; set; }
    
    [ForeignKey("OrderModel")]
    public int Order_id { get; set; }
    public OrderModel OrderModel { get; set; }
}