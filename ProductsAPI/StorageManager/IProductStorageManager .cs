using ProductsAPI.Models;

namespace ProductsAPI.StorageManager
{
    public interface IProductStorageManager
    {
        bool AddProduct(ProductDetails product);
        bool DeleteProduct(int Id);
        ProductDetails GetProduct (int Id);    
        List<ProductListItem> GetAllProducts ();


    }
}
