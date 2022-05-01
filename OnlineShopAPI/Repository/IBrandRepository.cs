using OnlineShopAPI.Model;

namespace OnlineShopAPI.Repository;

public interface IBrandRepository
{
    void Add(BrandModel brandModel);
    IEnumerable<BrandModel> GetAll();
    BrandModel Find(string key);
    BrandModel Remove(string key);
    void Update(BrandModel item);
}