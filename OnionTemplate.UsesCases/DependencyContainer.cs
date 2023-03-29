namespace OnionTemplate.UsesCases
{
    using Microsoft.Extensions.DependencyInjection;
    using OnionTemplate.UseCasesPort;
    using OnionTemplate.UsesCases.CreateProduct;
    using OnionTemplate.UsesCases.GetAllProducts;

    public static class DependencyContainer
    {
        public static IServiceCollection AddUseCasesServices(this IServiceCollection services)
        {
            services.AddTransient<IGetAllProductInputPort, GetAllProductInteractor>();
            services.AddTransient<ICreateProductInportPort, CreateProductInteractor>();
            
            return services;
        }
    }
}
