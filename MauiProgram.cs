using Microsoft.Extensions.Logging;

namespace LifeBooks
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
                    fonts.AddFont("BIZ-UDPGothic-02.ttf", "BIZUDPGothicRegular");
                    fonts.AddFont("BIZ-UDPGothic-Bold-02.ttf", "BIZUDPGothicBold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
