using ProductsAPI.Models;

namespace ProductsAPI.StorageManager
{
    public interface IProductStorageManager
    {
        void Add(ProductDetails product);
    }
}
