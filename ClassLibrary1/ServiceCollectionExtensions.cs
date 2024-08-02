using Microsoft.Extensions.DependencyInjection;
using SecureHttpClient;

namespace ClassLibrary1
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection ConfigureLibrary(this IServiceCollection services)
        {
            services
                .AddTransient<CustomDelegatingHandler>()
                .AddTransient<TestService>()
                .AddTransient<SecureHttpClientHandler>()
                .AddHttpClient("test")
                .ConfigurePrimaryHttpMessageHandler()
                .AddHttpMessageHandler<CustomDelegatingHandler>();
            return services;
        }
    }
}
