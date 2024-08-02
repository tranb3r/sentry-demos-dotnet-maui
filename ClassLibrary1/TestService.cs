using Flurl.Http;

namespace ClassLibrary1
{
    public class TestService
    {
        private readonly FlurlClient _flurlClient;

        public TestService(IHttpClientFactory httpClientFactory)
        {
            var httpClient = httpClientFactory.CreateClient("test");
            _flurlClient = new FlurlClient(httpClient);
        }

        public async Task RunAsync()
        {
            // throws an exception
            var response = await _flurlClient
                .Request("https://www.sentrybadhostname.com")
                .GetAsync();
        }
    }
}
