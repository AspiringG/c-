using System;


namespace CH09
{
    public class AppSettings
    {
        public static readonly string AppName;

        static AppSettings()
        {
            Console.WriteLine("Static constructor ran");
            AppName = "My program";
        }
    }
}