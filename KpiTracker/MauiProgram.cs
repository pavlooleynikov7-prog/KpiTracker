using KpiTracker.Services;
using KpiTracker.ViewModels;
using KpiTracker.Views;
using Microsoft.Extensions.Logging;

namespace KpiTracker;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder.UseMauiApp<App>();

        // Services: одне сховище на весь час роботи застосунку
        builder.Services.AddSingleton<IKpiService, InMemoryKpiService>();

        // ViewModels
        builder.Services.AddSingleton<MainViewModel>();

        // Views (Shell створює сторінку через DI, тому MainViewModel
        // автоматично передається в конструктор MainPage)
        builder.Services.AddSingleton<MainPage>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}
