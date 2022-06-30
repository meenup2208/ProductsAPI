using ProductsAPI.Models;
using ProductsAPI.StorageManager;

namespace ProductsAPI.Business
{
    public class ProductBusiness : IProductBusiness
    {
        ProductStorageManager _storageManager = new ProductStorageManager();
        
        public bool AddProduct(ProductDetails productDetails)
        {
            if(productDetails != null)
            {
                return _storageManager.AddProduct(productDetails);
            }
            else
                return false;
        }
        public ProductDetails GetProduct(int Id)
        {
            if(Id != 0)
            {
                return _storageManager.GetProduct(Id);
            }
            else
                return null;

        }

        public bool DeleteProduct(int Id)
        {
            if (Id > 0)
            {
                return (_storageManager.DeleteProduct(Id));
            }
            else
                return false;
        }

        public List<ProductListItem> GetAllProducts()
        {
            List<ProductListItem> products = new List<ProductListItem>();   

            if (DataHelper.GetAll().Count > 0)
            {
                return _storageManager.GetAllProducts();
            }

            else

                return null ;
        }

        
    }
}
