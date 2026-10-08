using Microsoft.Extensions.Logging;
using MultiplikationKungen.Data;


namespace MultiplikationKungen
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
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            builder.Services.AddSingleton<AppDatabase>();
            builder.Services.AddTransient<MainPage>();
            builder.Services.AddSingleton<AppShell>();

            return builder.Build();
        }
    }
}
