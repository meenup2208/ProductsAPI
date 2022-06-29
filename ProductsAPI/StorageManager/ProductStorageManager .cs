using ProductsAPI.Models;

namespace ProductsAPI.StorageManager
{
    public class ProductStorageManager : IProductStorageManager
    {
        
       public void AddProduct(ProductDetails product)
        {
            DataHelper.Add(product);            
        }
        
        public void Delete(string Id)
        {
            //pro
        }
       
    }
}
