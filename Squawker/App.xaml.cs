using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Squawker.Services;

namespace Squawker;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    public static IHost? AppHost { get; private set; }


    public App()
    {
        AppHost = Host.CreateDefaultBuilder()
            .ConfigureServices((hostContext, services) =>
            {
                services.AddSingleton<MainWindow>();
                services.AddSingleton<MainWindowViewModel>();
                services.AddSingleton<IvaoApiService>();
            })
            .Build();
    }

    protected override async void OnStartup(StartupEventArgs e)
    {
        // Start the app host.
        await AppHost!.StartAsync();

        var mainWindow = AppHost!.Services.GetService<MainWindow>();

        mainWindow.Show();

        base.OnStartup(e);
    }

    protected override async void OnExit(ExitEventArgs e)
    {
        // Stop the app host.
        await AppHost!.StopAsync();

        base.OnExit(e);
    }
}
