using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.DependencyInjection;

namespace ClassLibrary1
{
    public partial class ViewModel
    {
        private readonly IServiceProvider _serviceProvider;

        public ViewModel(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        [RelayCommand]
        private async Task ThrowExceptionWithNugetsAsync()
        {
            var testService = _serviceProvider.GetRequiredService<TestService>();
            await testService.RunAsync();
        }
    }
}
