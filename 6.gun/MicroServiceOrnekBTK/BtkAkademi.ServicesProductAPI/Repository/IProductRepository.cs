using BtkAkademi.ServicesProductAPI.Models;

namespace BtkAkademi.ServicesProductAPI.Repository
{
    public interface IProductRepository
    {

        //crud  create read update delete  
        Task<IEnumerable<ProductDto>> GetProducts();
        Task<ProductDto> GetProductById(int productId);
        Task<ProductDto> CreateUpdateProduct(ProductDto productDto);
        Task<bool> DeleteProduct(int productId);
    }
}
