using CRAms.Data.DTOs.Write;
using CRAms.Data.Models;

namespace CRAms.Data.DTOs.Extensions
{
    internal static class CreateProductDtoExtensions
    {
        public static Product ToModel(this CreateProductDto createProductDto, Guid technicalGuidelineId)
        {
            return new Product
            {
                Description = createProductDto.Description,
                Id = Guid.NewGuid(),
                Name = createProductDto.Name,
                TechnicalGuidelineId = technicalGuidelineId,
            };
        }
    }
}
