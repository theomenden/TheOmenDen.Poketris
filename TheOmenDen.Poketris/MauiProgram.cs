using System.Text.Json;
using System.Text.Json.Serialization;
using BlazorDexie.Extensions;
using Blazored.LocalStorage;
using Blazorise;
using Blazorise.Bootstrap5;
using Blazorise.Icons.FontAwesome;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Serilog;
using TheOmenDen.Poketris.Data;

namespace TheOmenDen.Poketris;
public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts => fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular"));
        builder.Configuration.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

        Log.Logger = new LoggerConfiguration()
            .ReadFrom.Configuration(builder.Configuration)
            .CreateLogger();

        builder.Services.AddSerilog(dispose: true, logger: Log.Logger);
        builder.Logging
            .ClearProviders()
            .AddSerilog(dispose: true, logger: Log.Logger);
        builder.Services.AddMauiBlazorWebView();
        builder.Services.AddHttpClient<IPokeApiResolverService, PokeApiResolverService>(cfg =>
            cfg.BaseAddress = new(builder.Configuration.GetConnectionString("JsonApiUrl") ?? String.Empty));
        builder.Services.AddBlazorise(options => options.Immediate = true)
            .AddBootstrap5Providers()
            .AddBootstrap5Components()
            .AddFontAwesomeIcons();
        builder.Services.AddBlazoredLocalStorageAsSingleton();
        builder.Services.AddDexieWrapper();

#if DEBUG
        builder.Services.AddBlazorWebViewDeveloperTools();
        builder.Logging.AddDebug();
#endif


        return builder.Build();
    }
}
