namespace OnionTemplate.UsesCases
{
    using Microsoft.Extensions.DependencyInjection;
    using OnionTemplate.UseCasesPort;
    using OnionTemplate.UsesCases.GetAllProducts;

    public static class DependencyContainer
    {
        public static IServiceCollection AddUseCasesServices(this IServiceCollection services)
        {
            services.AddTransient<IGetAllProductInputPort, GetAllProductInteractor>();
            
            return services;
        }
    }
}
