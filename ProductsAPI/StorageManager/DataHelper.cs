using ProductsAPI.Models;
using System.Linq;

namespace ProductsAPI.StorageManager
{
    public class DataHelper
    {
        public static List<ProductDetails> products = new List<ProductDetails>();

        public static void Add(ProductDetails productDetails)
        {
            products.Add(productDetails);
        }

        public static void Delete(string Id)
        {
            //products.Remove(Id);
        }

    }
}
