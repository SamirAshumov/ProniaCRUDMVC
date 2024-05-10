using Pronia.Core.Models;


namespace Pronia.Business.Services.Abstracts
{
    public interface IProductService
    {
        Task AddProduct(Product product);
        void DeleteProduct(int id);
        void UpdateProduct(int id,  Product newProduct);
        Product GetProduct(Func<Product, bool>? predicate = null);
        List<Product> GetAllProducts(Func<Product, bool>? predicate = null); 

    }
}
