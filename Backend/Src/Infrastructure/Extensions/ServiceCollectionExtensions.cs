namespace Infrastructure.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        return services
            .AddTransient<IRequestRepository, RequestRepository>();
    }
    
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        return services
            .AddTransient<IRequestService, RequestService>();
    }
}