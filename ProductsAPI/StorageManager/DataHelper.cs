using ProductsAPI.Models;
using System.Linq;

namespace ProductsAPI.StorageManager
{
    public static class DataHelper
    {
        public static List<ProductDetails> products = new List<ProductDetails>();

        public static bool Add(ProductDetails productDetails)
        {
            products.Add(productDetails);
            return true;
        }

        public static ProductDetails Get(int id)
        {
           ProductDetails product = products.FirstOrDefault(x => x.Id == id);

            if(product != null)
            {
                return product;
            }
            else
                return null;
        }

        public static bool Delete(int id)
        {
            products.Remove(Get(id));
            return true;
        }

        public static List<ProductListItem> GetAll()
        {
           List<ProductListItem> list = new List<ProductListItem>();
            list = products.Select(x => new ProductListItem { Id = x.Id, Name = x.Name }).ToList();
            
            return list;
        }
    }
}
