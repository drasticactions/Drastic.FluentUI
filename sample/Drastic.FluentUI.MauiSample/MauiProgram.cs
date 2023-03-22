using Microsoft.Extensions.Logging;
using Microsoft.Maui.Handlers;

namespace Drastic.FluentUI.MauiSample;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();

#if IOS
		ButtonHandler.PlatformViewFactory = (_) =>
        {
            return new Drastic.FluentUI.MSFButton();
        };
#elif ANDROID
        ButtonHandler.PlatformViewFactory = (test2) =>
        {
			var test = new global::FluentUI.Token.ControlToken.ButtonTokens();
			return test2.PlatformView;
        };
#endif

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

		return builder.Build();
	}
}
