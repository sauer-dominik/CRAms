using CRAms.Data.Constants;
using CRAms.Data.DTOs.Read;
using CRAms.Data.DTOs.Write;
using CRAms.Data.Enums;
using TypeGen.Core.SpecGeneration;

namespace CRAms.Data
{
    public class TsGenerationSpec : GenerationSpec
    {
        private const string ConstantDirectory = "constants";
        private const string EnumDirectory = "enums";
        private const string ReadDirectory = "read";
        private const string WriteDirectory = "write";

        public TsGenerationSpec()
        {
            // Constants
            AddClass<ProductClassifications>(ConstantDirectory);
            AddBarrel(ConstantDirectory, BarrelScope.Files);

            // Enums
            AddEnum<Classification>(EnumDirectory);
            AddEnum<ItemType>(EnumDirectory);
            AddEnum<Role>(EnumDirectory);
            AddBarrel(EnumDirectory, BarrelScope.Files);

            // Read DTOs
            AddInterface<EntityDto>(ReadDirectory);
            AddInterface<ItemDto>(ReadDirectory);
            AddInterface<ItemTaskDto>(ReadDirectory);
            AddInterface<NamedEntityDto>(ReadDirectory);
            AddInterface<ProductDto>(ReadDirectory);
            AddInterface<RequirementDto>(ReadDirectory);
            AddInterface<TechnicalGuidelineDto>(ReadDirectory);
            AddInterface<UserDto>(ReadDirectory);
            AddBarrel(ReadDirectory, BarrelScope.Files);

            // Write DTOs
            AddInterface<CreateProductDto>(WriteDirectory);
            AddBarrel(WriteDirectory, BarrelScope.Files);

            AddBarrel(".", BarrelScope.Files);
        }
    }
}
