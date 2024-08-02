using Microsoft.Extensions.DependencyInjection;
using SecureHttpClient;

namespace ClassLibrary1
{
    public static class HttpClientBuilderExtensions
    {
        public static IHttpClientBuilder ConfigurePrimaryHttpMessageHandler(this IHttpClientBuilder clientBuilder)
        {
            return clientBuilder.ConfigurePrimaryHttpMessageHandler(p =>
            {
                var secureHttpClientHandler = p.GetRequiredService<SecureHttpClientHandler>();
                return secureHttpClientHandler;
            });
        }
    }
}
