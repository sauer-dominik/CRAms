using CRAms.Data.DTOs.Read;
using CRAms.Data.DTOs.Write;

namespace CRAms.Data.Interfaces
{
    public interface IProductService
    {
        public Task<ProductDto> CreateProductAsync(CreateProductDto createProductDto, Guid technicalGuidelineId);
        public Task<IEnumerable<ProductDto>> GetAllProductsAsync();
        public Task<ProductDto?> GetProductByIdAsync(Guid productId);
    }
}
