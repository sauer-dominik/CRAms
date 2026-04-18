using CRAms.Data.DTOs.Read;
using CRAms.Data.DTOs.Write;
using CRAms.Data.Interfaces;
using CRAms.Data.Models;

namespace CRAms.Data.Services
{
    internal sealed class ProductService : IProductService
    {
        private readonly IEntityRepository<Product> productRepository;

        public ProductService(IEntityRepository<Product> productRepository)
        {
            this.productRepository = productRepository;
        }

        public async Task<ProductDto> CreateProductAsync(CreateProductDto createProductDto, Guid technicalGuidelineId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ProductDto>> GetAllProductsAsync()
        {
            // TODO: Implementation just for Demo purposes
            return [
                new ProductDto
                {
                    Description = "A product description",
                    Id = Guid.NewGuid(),
                    ItemTasks = [],
                    Name = "ProductName",
                    TechnicalGuidelineId = Guid.NewGuid(),
                },
                new ProductDto
                {
                    Description = "A product description",
                    Id = Guid.NewGuid(),
                    ItemTasks = [],
                    Name = "ProductName 2",
                    TechnicalGuidelineId = Guid.NewGuid(),
                },
            ];
        }

        public async Task<ProductDto?> GetProductByIdAsync(Guid productId)
        {
            // TODO: Implementation just for Demo purposes
            return new ProductDto
            {
                Description = "A product description",
                Id = productId,
                ItemTasks = [
                    new ItemTaskDto
                    {
                        Id = Guid.Parse("00000000-0000-0000-0000-000000000031"),
                        IsApplicable = true,
                        IsCompleted = false,
                        ItemId = Guid.Parse("00000000-0000-0000-0000-000000000003"),
                        RequirementId = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    },
                    new ItemTaskDto
                    {
                        Id = Guid.Parse("00000000-0000-0000-0000-000000000032"),
                        IsApplicable = true,
                        IsCompleted = false,
                        ItemId = Guid.Parse("00000000-0000-0000-0000-000000000004"),
                        RequirementId = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    },
                    new ItemTaskDto
                    {
                        Id = Guid.Parse("00000000-0000-0000-0000-000000000033"),
                        IsApplicable = true,
                        IsCompleted = true,
                        ItemId = Guid.Parse("00000000-0000-0000-0000-000000000006"),
                        RequirementId = Guid.Parse("00000000-0000-0000-0000-000000000005"),
                    },
                    new ItemTaskDto
                    {
                        Id = Guid.Parse("00000000-0000-0000-0000-000000000034"),
                        IsApplicable = true,
                        IsCompleted = true,
                        ItemId = Guid.Parse("00000000-0000-0000-0000-000000000007"),
                        RequirementId = Guid.Parse("00000000-0000-0000-0000-000000000005"),
                    },
                    new ItemTaskDto
                    {
                        Id = Guid.Parse("00000000-0000-0000-0000-000000000035"),
                        IsApplicable = true,
                        IsCompleted = false,
                        ItemId = Guid.Parse("00000000-0000-0000-0000-000000000010"),
                        RequirementId = Guid.Parse("00000000-0000-0000-0000-000000000009"),
                    },
                    new ItemTaskDto
                    {
                        Id = Guid.Parse("00000000-0000-0000-0000-000000000036"),
                        IsApplicable = true,
                        IsCompleted = true,
                        ItemId = Guid.Parse("00000000-0000-0000-0000-000000000011"),
                        RequirementId = Guid.Parse("00000000-0000-0000-0000-000000000009"),
                    },
                    new ItemTaskDto
                    {
                        Id = Guid.Parse("00000000-0000-0000-0000-000000000037"),
                        IsApplicable = true,
                        IsCompleted = false,
                        ItemId = Guid.Parse("00000000-0000-0000-0000-000000000013"),
                        RequirementId = Guid.Parse("00000000-0000-0000-0000-000000000012"),
                    },
                    new ItemTaskDto
                    {
                        Id = Guid.Parse("00000000-0000-0000-0000-000000000038"),
                        IsApplicable = true,
                        IsCompleted = false,
                        ItemId = Guid.Parse("00000000-0000-0000-0000-000000000014"),
                        RequirementId = Guid.Parse("00000000-0000-0000-0000-000000000012"),
                    },
                    new ItemTaskDto
                    {
                        Id = Guid.Parse("00000000-0000-0000-0000-000000000039"),
                        IsApplicable = true,
                        IsCompleted = false,
                        ItemId = Guid.Parse("00000000-0000-0000-0000-000000000015"),
                        RequirementId = Guid.Parse("00000000-0000-0000-0000-000000000012"),
                    },
                    new ItemTaskDto
                    {
                        Id = Guid.Parse("00000000-0000-0000-0000-000000000040"),
                        IsApplicable = true,
                        IsCompleted = false,
                        ItemId = Guid.Parse("00000000-0000-0000-0000-000000000016"),
                        RequirementId = Guid.Parse("00000000-0000-0000-0000-000000000012"),
                    },
                    new ItemTaskDto
                    {
                        Id = Guid.Parse("00000000-0000-0000-0000-000000000041"),
                        IsApplicable = true,
                        IsCompleted = false,
                        ItemId = Guid.Parse("00000000-0000-0000-0000-000000000017"),
                        RequirementId = Guid.Parse("00000000-0000-0000-0000-000000000012"),
                    },
                    new ItemTaskDto
                    {
                        Id = Guid.Parse("00000000-0000-0000-0000-000000000042"),
                        IsApplicable = true,
                        IsCompleted = false,
                        ItemId = Guid.Parse("00000000-0000-0000-0000-000000000018"),
                        RequirementId = Guid.Parse("00000000-0000-0000-0000-000000000012"),
                    },
                    new ItemTaskDto
                    {
                        Id = Guid.Parse("00000000-0000-0000-0000-000000000043"),
                        IsApplicable = false,
                        IsCompleted = true,
                        ItemId = Guid.Parse("00000000-0000-0000-0000-000000000020"),
                        RequirementId = Guid.Parse("00000000-0000-0000-0000-000000000019"),
                    },
                    new ItemTaskDto
                    {
                        Id = Guid.Parse("00000000-0000-0000-0000-000000000044"),
                        IsApplicable = false,
                        IsCompleted = true,
                        ItemId = Guid.Parse("00000000-0000-0000-0000-000000000021"),
                        RequirementId = Guid.Parse("00000000-0000-0000-0000-000000000019"),
                    },
                    new ItemTaskDto
                    {
                        Id = Guid.Parse("00000000-0000-0000-0000-000000000045"),
                        IsApplicable = true,
                        IsCompleted = false,
                        ItemId = Guid.Parse("00000000-0000-0000-0000-000000000024"),
                        RequirementId = Guid.Parse("00000000-0000-0000-0000-000000000023"),
                    },
                    new ItemTaskDto
                    {
                        Id = Guid.Parse("00000000-0000-0000-0000-000000000046"),
                        IsApplicable = true,
                        IsCompleted = false,
                        ItemId = Guid.Parse("00000000-0000-0000-0000-000000000025"),
                        RequirementId = Guid.Parse("00000000-0000-0000-0000-000000000023"),
                    },
                    new ItemTaskDto
                    {
                        Id = Guid.Parse("00000000-0000-0000-0000-000000000047"),
                        IsApplicable = true,
                        IsCompleted = false,
                        ItemId = Guid.Parse("00000000-0000-0000-0000-000000000026"),
                        RequirementId = Guid.Parse("00000000-0000-0000-0000-000000000023"),
                    },
                    new ItemTaskDto
                    {
                        Id = Guid.Parse("00000000-0000-0000-0000-000000000048"),
                        IsApplicable = true,
                        IsCompleted = false,
                        ItemId = Guid.Parse("00000000-0000-0000-0000-000000000028"),
                        RequirementId = Guid.Parse("00000000-0000-0000-0000-000000000027"),
                    },
                    new ItemTaskDto
                    {
                        Id = Guid.Parse("00000000-0000-0000-0000-000000000049"),
                        IsApplicable = true,
                        IsCompleted = false,
                        ItemId = Guid.Parse("00000000-0000-0000-0000-000000000029"),
                        RequirementId = Guid.Parse("00000000-0000-0000-0000-000000000027"),
                    },
                    new ItemTaskDto
                    {
                        Id = Guid.Parse("00000000-0000-0000-0000-000000000050"),
                        IsApplicable = true,
                        IsCompleted = false,
                        ItemId = Guid.Parse("00000000-0000-0000-0000-000000000030"),
                        RequirementId = Guid.Parse("00000000-0000-0000-0000-000000000027"),
                    },
                ],
                Name = "ProductName",
                TechnicalGuidelineId = Guid.NewGuid(),
            };
        }
    }
}
