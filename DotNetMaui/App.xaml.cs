namespace DotNetMaui;

public partial class App : Application
{
    public App(IServiceProvider serviceProvider)
	{
		InitializeComponent();

        MainPage = new MainPage(serviceProvider);
	}
}
