
using ProductsAPI.Models;

namespace ProductsAPI.Business
{
    public interface IProductBusiness
    {
        void AddProduct(ProductDetails productDetails);
        void DeleteProduct(string Id);
        void GetProduct(string Id);
        List<ProductDetails> GetAllProducts();
    }
}
