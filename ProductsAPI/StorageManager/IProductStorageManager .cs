using ProductsAPI.Models;

namespace ProductsAPI.StorageManager
{
    public interface IProductStorageManager
    {
        void Add(ProductDetails product);
        void Delete(string Id);
        void GetSingle (string Id);    
        List<ProductDetails> GetAll ();


    }
}
