using ProductsAPI.Models;

namespace ProductsAPI.StorageManager
{
    public class ProductStorageManager : IProductStorageManager
    {
        
       public void Add(ProductDetails product)
        {
            //DataHelper.Add(product);
            DataHelper.products.Add(product);
        }
        
        
    }
}
