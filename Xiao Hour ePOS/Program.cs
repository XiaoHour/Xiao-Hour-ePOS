namespace Xiao_Hour_ePOS
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new frmLogin());
        }




        public static frmLogin loginForm { get; set; }
        public static frmHome homeForm { get; set; }
        public static bool is_exit { get; set; }
        public static string currentLoginUsername { get; set; } = "";


    }
}