using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Core;
using Microsoft.Extensions.Logging;

namespace sevillaMath
{
    /// <summary>
    /// ======= Sevilla Math Team ========
    /// 
    /// Ortiz Avelar Jesús
    /// Garrido Flores Eduardo
    /// Sotres Pastrana Aarón Tadeo
    /// Gómez Mireles Bruno Denilson
    /// Gonzalez Martinez Alfredo Emiliano
    /// ==================================
    /// </summary>
    
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .UseMauiCommunityToolkitCore()
                .UseMauiCommunityToolkitMediaElement()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("Lora-VariableFont_wght.ttf", "Lora");
                    fonts.AddFont("RobotoSlab-VariableFont_wght.ttf", "RobotoSlab");
                });

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
