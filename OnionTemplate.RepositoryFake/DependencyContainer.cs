namespace OnionTemplate.Repository
{
    using Microsoft.Extensions.DependencyInjection;
    using OnionTemplate.Entities.Interfaces;
    using OnionTemplate.RepositoryFake.Repositories;

    public static class DependencyContainer
    {
        public static IServiceCollection AddRepositories( this IServiceCollection service )
        {
            service.AddScoped<IProductRepository, ProductRepositoryFake>();

            return service;
        }
    }
}

