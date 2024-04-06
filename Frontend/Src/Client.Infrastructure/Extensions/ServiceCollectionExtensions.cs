namespace Client.Infrastructure.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddManagers(this IServiceCollection services)
    {
        return services
            .AddTransient<IRequestManager, RequestManager>();
    }
    
    public static IServiceCollection AddClientServices(this IServiceCollection services)
    {
        services
            .AddHttpClient("client")
            .ConfigureHttpClient(client =>
            {
                client.BaseAddress = new Uri("http://localhost:5004");
            });
        return services;
    }
}