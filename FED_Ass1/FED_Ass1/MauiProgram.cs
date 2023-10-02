using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Extensions.Logging;
using System.Collections.ObjectModel;
using System.ComponentModel;
using CommunityToolkit.Maui;
using CommunityToolkit.Mvvm.Input;

// Lundse: Jeg har prøvet at gå ud fra:
// https://dev.to/hnicolus/bye-old-ways-hello-mvvm-community-toolkit-4nb

namespace FED_Ass1
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
                })
                .UseMauiCommunityToolkit();

			return builder.Build();
        }
    }
}