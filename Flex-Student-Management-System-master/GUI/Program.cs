namespace GUI
{
    internal static class Program
    {
        
        ///  The main entry point for the application.
        
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm());
        }
    }
}