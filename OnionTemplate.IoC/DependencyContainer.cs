namespace OnionTemplate.IoC
{
    using Microsoft.Extensions.DependencyInjection;
    using OnionTemplate.Repository;
    using OnionTemplate.UsesCases;
    using OnionTemplate.Presenters;

    public static class DependencyContainer
    {
        public static IServiceCollection AddOnionTemplateDependencies(this IServiceCollection services)
        {
            services.AddRepositories();
            services.AddUseCasesServices();
            services.AddPresenters();

            return services;
        }
    }
}
