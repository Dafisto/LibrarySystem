using LibrarySystem.ClassPackage.Persistence;
using Microsoft.Extensions.Logging;


namespace LibrarySystem
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

#if DEBUG
    		builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();
#endif
            var dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../../..", "resources", "data", "alexandriaDB.db");
            var bookScript = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../../..", "resources", "sql", "books.sql");
            var clientScript = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../../..", "resources", "sql", "clients.sql");
            builder.Services.AddSingleton<LibraryDB>(s => ActivatorUtilities.CreateInstance<LibraryDB>(s, dbPath));
            builder.Services.AddSingleton<ClientTable>();
            builder.Services.AddSingleton<BookTable>();
            builder.Services.AddSingleton<CheckoutTable>();
      
     
            return builder.Build();
        }
    }
}
