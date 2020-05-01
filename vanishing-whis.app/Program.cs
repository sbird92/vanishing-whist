using System;

namespace vanishing_whist.app
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
            var version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version?.ToString();
            var description = "Vanishing Whist Game";
            var appFactory = AppFactory.GetAppFactory();
            var summary = appFactory.AppSummary;

            summary.AppStart(name, version, description);
        }


    }
}
