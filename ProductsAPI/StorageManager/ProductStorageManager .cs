using ProductsAPI.Models;

namespace ProductsAPI.StorageManager
{
    public class ProductStorageManager : IProductStorageManager
    {
        //DataHelper _dataHelper = new DataHelper();
        public  bool AddProduct(ProductDetails product)
        {
            return DataHelper.Add(product);            
        }

        public bool DeleteProduct(int Id)
        {
            return DataHelper.Delete(Id);
             
        }

        public List<ProductListItem> GetAllProducts()
        {
            return DataHelper.GetAll();
             
        }

        public ProductDetails GetProduct(int Id)
        {
            return DataHelper.Get(Id);
        }
    }
}
