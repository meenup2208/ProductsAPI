
using ProductsAPI.Models;

namespace ProductsAPI.Business
{
    public interface IProductBusiness
    {
        bool AddProduct(ProductDetails productDetails);
        bool DeleteProduct(int Id);
        ProductDetails GetProduct(int Id);
        List<ProductListItem> GetAllProducts();
    }
}
