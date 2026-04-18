using CRAms.Data.DTOs.Read;
using CRAms.Data.Interfaces;
using CRAms.Data.Models;

namespace CRAms.Data.Services
{
    internal sealed class TechnicalGuidelineService : ITechnicalGuidelineService
    {
        private readonly IEntityRepository<TechnicalGuideline> technicalGuidelineRepository;

        public TechnicalGuidelineService(IEntityRepository<TechnicalGuideline> technicalGuidelineRepository)
        {
            this.technicalGuidelineRepository = technicalGuidelineRepository;
        }

        public async Task<TechnicalGuideline> AddParentRequirementAsync(TechnicalGuideline technicalGuideline, Requirement requirement)
        {
            technicalGuideline.ParentRequirements ??= new List<Requirement>();
            technicalGuideline.ParentRequirements.Add(requirement);

            await technicalGuidelineRepository.UpdateAsync(technicalGuideline);

            return technicalGuideline;
        }

        public async Task<TechnicalGuideline> CreateTechnicalGuidelineAsync(string languageName, string version, ICollection<Requirement> parentRequirements)
        {
            parentRequirements ??= new List<Requirement>();

            var technicalGuideline = new TechnicalGuideline
            {
                CreatedAt = DateTime.UtcNow,
                Id = Guid.NewGuid(),
                LanguageName = languageName,
                Version = version,
                ParentRequirements = parentRequirements,
            };

            await technicalGuidelineRepository.AddAsync(technicalGuideline);

            return technicalGuideline;
        }

        public async Task<TechnicalGuidelineDto?> GetCurrentTechnicalGuidelineAsync(string languageName)
        {
            // TODO: Implementation just for Demo purposes
            return new TechnicalGuidelineDto
            {
                Requirements = [
                    new RequirementDto
                    {
                        Description = "Requirement stated in the current draft of the CRA Annex I Part 1: Products with digital elements shall be designed, developed and produced in such a way that they ensure an appropriate level of cybersecurity based on the risks.",
                        Id = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                        IsParent = true,
                        Name = "5.3.1 REQ_ER 1 - Security by design",
                        RequirementItems = [],
                        SubRequirements = [
                            new RequirementDto
                            {
                                Description = null,
                                Id = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                                Name = "5.3.1.1 REQ_ER 1.1",
                                RequirementItems = [
                                    new ItemDto
                                    {
                                        Description = "The manufacturer MUST document and implement a process which ensures that the product is designed, developed and produced with an appropriate level of cybersecurity, based on the risk assessment in section 4.2.",
                                        Id = Guid.Parse("00000000-0000-0000-0000-000000000003"),
                                        Type = Enums.ItemType.Requirement,
                                    },
                                    new ItemDto
                                    {
                                        Description = "The evaluator MUST assess that the process is based on the risk assessment and contains appropriate mitigation strategies for the documented risks.",
                                        Id = Guid.Parse("00000000-0000-0000-0000-000000000004"),
                                        Type = Enums.ItemType.Assessment,
                                    },
                                ],
                                SubRequirements = [],
                            },
                            new RequirementDto
                            {
                                Description = null,
                                Id = Guid.Parse("00000000-0000-0000-0000-000000000005"),
                                Name = "5.3.1.2 REQ_ER 1.2",
                                RequirementItems = [
                                    new ItemDto
                                    {
                                        Description = "The manufacturer MUST follow best practices for the secure (software-) development lifecycle e.g. OWASP SAMM, BSI TR-03185, ISO 27034.",
                                        Id = Guid.Parse("00000000-0000-0000-0000-000000000006"),
                                        Type = Enums.ItemType.Requirement,
                                    },
                                    new ItemDto
                                    {
                                        Description = "The evaluator MUST assess that the documented process contains best practices for secure governance, design, implementation and testing of the product before set on the market and afterwards following e.g.OWASP SAMM, BSI TR - 03185 and ISO 27034.",
                                        Id = Guid.Parse("00000000-0000-0000-0000-000000000007"),
                                        Type = Enums.ItemType.Assessment,
                                    },
                                ],
                                SubRequirements = [],
                            },
                        ],
                    },
                    new RequirementDto
                    {
                        Description = "Requirement stated in the current draft of the CRA Annex I Part 1: On the basis of the cybersecurity risk assessment referred to in Article 13 (2) and where applicable, products with digital elements shall be made available on the market without known exploitable vulnerabilities.",
                        Id = Guid.Parse("00000000-0000-0000-0000-000000000008"),
                        IsParent = true,
                        Name = "5.3.2 REQ_ER 2 - No known vulnerabilities",
                        RequirementItems = [],
                        SubRequirements = [
                            new RequirementDto
                            {
                                Description = null,
                                Id = Guid.Parse("00000000-0000-0000-0000-000000000009"),
                                Name = "5.3.2.1 REQ_ER 2.1",
                                RequirementItems = [
                                    new ItemDto
                                    {
                                        Description = "The manufacturer MUST ensure that the TOE is updated to the newest available software/firmware version during or before the initial setup.",
                                        Id = Guid.Parse("00000000-0000-0000-0000-000000000010"),
                                        Type = Enums.ItemType.Requirement,
                                    },
                                    new ItemDto
                                    {
                                        Description = "The evaluator MUST assess that the newest security update is installed on the TOE before the first usage by the user.",
                                        Id = Guid.Parse("00000000-0000-0000-0000-000000000011"),
                                        Type = Enums.ItemType.Assessment,
                                    },
                                ],
                                SubRequirements = [],
                            },
                            new RequirementDto
                            {
                                Description = null,
                                Id = Guid.Parse("00000000-0000-0000-0000-000000000012"),
                                Name = "5.3.2.2 REQ_ER 2.2",
                                RequirementItems = [
                                    new ItemDto
                                    {
                                        Description = "The manufacturer MUST test, if the security properties of the product are working correctly following section 5.4.3.1 before making the product available.",
                                        Id = Guid.Parse("00000000-0000-0000-0000-000000000013"),
                                        Type = Enums.ItemType.Requirement,
                                    },
                                    new ItemDto
                                    {
                                        Description = "The manufacturer MUST document the result of the test.",
                                        Id = Guid.Parse("00000000-0000-0000-0000-000000000014"),
                                        Type = Enums.ItemType.Requirement,
                                    },
                                    new ItemDto
                                    {
                                        Description = "The manufacturer MUST fix all known actively exploited vulnerabilities before making the TOE available.",
                                        Id = Guid.Parse("00000000-0000-0000-0000-000000000015"),
                                        Type = Enums.ItemType.Requirement,
                                    },
                                    new ItemDto
                                    {
                                        Description = "The evaluator MUST assess that the TOE is tested following section 5.4.3.1 before being made available.",
                                        Id = Guid.Parse("00000000-0000-0000-0000-000000000016"),
                                        Type = Enums.ItemType.Assessment,
                                    },
                                    new ItemDto
                                    {
                                        Description = "The evaluator MUST assess that the results of the test are documented.",
                                        Id = Guid.Parse("00000000-0000-0000-0000-000000000017"),
                                        Type = Enums.ItemType.Assessment,
                                    },
                                    new ItemDto
                                    {
                                        Description = "The evaluator MUST check that actively exploited vulnerabilities of the TOE known to the manufacturer are fixed before being made available.",
                                        Id = Guid.Parse("00000000-0000-0000-0000-000000000018"),
                                        Type = Enums.ItemType.Assessment,
                                    },
                                ],
                                SubRequirements = [],
                            },
                            new RequirementDto
                            {
                                Description = null,
                                Id = Guid.Parse("00000000-0000-0000-0000-000000000019"),
                                Name = "5.3.2.3 REC_ER 2.3",
                                RequirementItems = [
                                    new ItemDto
                                    {
                                        Description = "The manufacturer SHOULD fix all known exploitable vulnerabilities before making the product available.",
                                        Id = Guid.Parse("00000000-0000-0000-0000-000000000020"),
                                        Type = Enums.ItemType.Recommendation,
                                    },
                                    new ItemDto
                                    {
                                        Description = "The evaluator SHOULD check that exploitable vulnerabilities of the TOE known to the manufacturer are fixed before being made available.",
                                        Id = Guid.Parse("00000000-0000-0000-0000-000000000021"),
                                        Type = Enums.ItemType.Assessment,
                                    },
                                ],
                                SubRequirements = [],
                            },
                        ],
                    },
                    new RequirementDto
                    {
                        Description = "Requirement stated in the current draft of the CRA Annex I Part 1: On the basis of the cybersecurity risk assessment referred to in Article 13 (2) and where applicable, products with digital elements shall be made available on the market with a secure by default configuration, unless otherwise agreed between manufacturer and business user in relation to a tailor-made product with digital elements, including the possibility to reset the product to its original state.",
                        Id = Guid.Parse("00000000-0000-0000-0000-000000000022"),
                        IsParent = true,
                        Name = "5.3.3 REQ_ER 3 – Secure default configuration",
                        RequirementItems = [],
                        SubRequirements = [
                            new RequirementDto
                            {
                                Description = null,
                                Id = Guid.Parse("00000000-0000-0000-0000-000000000023"),
                                Name = "5.3.3.1 REQ_ER 3.1",
                                RequirementItems = [
                                    new ItemDto
                                    {
                                        Description = "The TOE MUST be able to be reset to its original state. The original state consists of the deletion of all local user data, resetting the software to the initial or newest version and resetting the default configuration.",
                                        Id = Guid.Parse("00000000-0000-0000-0000-000000000024"),
                                        Type = Enums.ItemType.Requirement,
                                    },
                                    new ItemDto
                                    {
                                        Description = "The evaluator MUST assess that the TOE can be reset to its original state through a factory reset or reinstallation.",
                                        Id = Guid.Parse("00000000-0000-0000-0000-000000000025"),
                                        Type = Enums.ItemType.Assessment,
                                    },
                                    new ItemDto
                                    {
                                        Description = "The TOE can be configured.",
                                        Id = Guid.Parse("00000000-0000-0000-0000-000000000026"),
                                        Type = Enums.ItemType.Condition,
                                    },
                                ],
                                SubRequirements = [],
                            },
                            new RequirementDto
                            {
                                Description = null,
                                Id = Guid.Parse("00000000-0000-0000-0000-000000000027"),
                                Name = "5.3.3.2 REQ_ER 3.2",
                                RequirementItems = [
                                    new ItemDto
                                    {
                                        Description = "The software of the TOE MUST NOT contain hard coded security data and critical security data.",
                                        Id = Guid.Parse("00000000-0000-0000-0000-000000000028"),
                                        Type = Enums.ItemType.Requirement,
                                    },
                                    new ItemDto
                                    {
                                        Description = "The evaluator MUST assess that security data and critical security data are not hard coded in the software of the TOE.",
                                        Id = Guid.Parse("00000000-0000-0000-0000-000000000029"),
                                        Type = Enums.ItemType.Assessment,
                                    },
                                    new ItemDto
                                    {
                                        Description = "The TOE stores security data or critical security data specific to the TOE.",
                                        Id = Guid.Parse("00000000-0000-0000-0000-000000000030"),
                                        Type = Enums.ItemType.Condition,
                                    },
                                ],
                                SubRequirements = [],
                            },
                        ],
                    },
                ],
                Id = Guid.NewGuid(),
                Version = "0.9.0",
            };
        }

        public async Task<TechnicalGuideline?> GetTechnicalGuidelineAsync(string languageName, string version)
        {
            return await technicalGuidelineRepository.FirstOrDefaultAsync(tg => tg.LanguageName == languageName && tg.Version == version);
        }
    }
}
