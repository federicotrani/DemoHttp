using DemoHttp.Services;
using Microsoft.Extensions.Logging;

namespace DemoHttp
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
            // Register HttpClient for ITodoService
            builder.Services.AddSingleton<HttpClient>(
                sp =>
                {
                    var handler = new HttpClientHandler
                    {
                        ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
                    };
                    return new HttpClient(handler)
                    {
                        BaseAddress = new Uri("https://jsonplaceholder.typicode.com/")
                    };
                });

            builder.Services.AddSingleton<ITodoService, TodoService>();


#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
