namespace OnionTemplate.Presenters
{
    using Microsoft.Extensions.DependencyInjection;
    using OnionTemplate.UseCasesPort;

    public static class DependencyContainer
    {
        public static IServiceCollection AddPresenters( this IServiceCollection services)
        {
            services.AddScoped<IGetAllProductOuputPort,GetAllProductPresenter>();
            services.AddScoped<ICreateProductOutputPort, CreateProductPresenter>();

            return services;
        }
    }
}
