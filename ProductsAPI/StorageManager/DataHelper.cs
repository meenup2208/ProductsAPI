using ProductsAPI.Models;

namespace ProductsAPI.StorageManager
{
    public class DataHelper
    {
        public static List<ProductDetails> products = new List<ProductDetails>();

        //public static void Add(ProductDetails productDetails)
        ///{
           // products.Add(productDetails);
        //}

        static DataHelper()
        {
            products.Add(new ProductDetails()
            {
                Name = "Boat Storm",
                Category = "Watch",
                Description = "Bluetooth Watch",
                Rate = "4000"
            });


            products.Add(new ProductDetails()
            {
                Name = "Xiaomi 11i",
                Category = "Mobile",
                Description = "Made in China",
                Rate = "27000"
            });
        }
    }
}
