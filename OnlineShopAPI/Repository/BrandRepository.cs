using System.Collections.Concurrent;
using System.Net.Sockets;
using OnlineShopAPI.Model;

namespace OnlineShopAPI.Repository;

public class BrandRepository : IBrandRepository
{
    private static ConcurrentDictionary<string, BrandModel> _brand = new ConcurrentDictionary<string, BrandModel>();


    public void Add(BrandModel brandModel)
    {
        brandModel.Id = Guid.NewGuid().ToString();
        _brand[brandModel.Id] = brandModel;
    }

    public IEnumerable<BrandModel> GetAll()
    {
        return _brand.Values;
    }

    public BrandModel Find(string key)
    {
        BrandModel brandModel;
        _brand.TryGetValue(key, out brandModel);
        return brandModel;
    }

    public BrandModel Remove(string key)
    {
        BrandModel brandModel;
        _brand.TryGetValue(key, out brandModel);
        _brand.TryRemove(key, out brandModel);
        return brandModel;
    }

    public void Update(BrandModel brandModel)
    {
        _brand[brandModel.Id] = brandModel;
    }
}