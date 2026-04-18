using CRAms.Data.Interfaces;
using CRAms.Data.Models;
using CRAms.Data.Repositories;
using CRAms.Data.Services;
using Microsoft.Extensions.DependencyInjection;

namespace CRAms.Data
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDataServices(this IServiceCollection serviceCollection)
        {
            // TODO: ConnectionString hardcoded, should be set via AppSettings or ENV
            serviceCollection.AddScoped(b => CRAmsDbContextFactory.Create(string.Empty));

            serviceCollection.AddScoped<IEntityRepository<Product>, EntityRepository<Product>>();
            serviceCollection.AddScoped<IEntityRepository<TechnicalGuideline>, EntityRepository<TechnicalGuideline>>();

            serviceCollection.AddScoped<IProductService, ProductService>();
            serviceCollection.AddScoped<ITechnicalGuidelineService, TechnicalGuidelineService>();

            return serviceCollection;
        }
    }
}
