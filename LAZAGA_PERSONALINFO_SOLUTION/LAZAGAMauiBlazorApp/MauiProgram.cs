using Microsoft.Extensions.Logging;
using LAZAGAMauiBlazorApp.Components.Endpoint;

namespace LAZAGAMauiBlazorApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.Services.AddMauiBlazorWebView();


            var baseAddress = "https://rochemagsayo-001-site56.jtempurl.com/";
            builder.Services.AddSingleton(sp =>
            {
                var handler = new HttpClientHandler
                {
                    ServerCertificateCustomValidationCallback = (m, c, ch, e) => true
                };
                return new HttpClient(handler) { BaseAddress = new Uri(baseAddress) };
            });

            builder.Services.AddSingleton<InfoEndpoint>();

#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}