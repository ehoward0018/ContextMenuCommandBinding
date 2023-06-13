using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;
using ContextMenuCommandBinding.ViewModels;
using ContextMenuCommandBinding.Pages;

namespace ContextMenuCommandBinding;
public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder.UseMauiApp<App>().ConfigureFonts(fonts =>
        {
            fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
        }).UseMauiCommunityToolkit();
#if DEBUG
        builder.Logging.AddDebug();
#endif

        var services = builder.Services;

        services.AddSingleton<AppShellViewModel>();
        services.AddSingleton<HomePageViewModel>();

        services.AddSingleton<HomePage>();

        return builder.Build();
    }
}