namespace Assignment_4._2
{
    public static class Program
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
            Application.Run(new AccountLogin());
        }
        
        internal static List<Student> studentlist = new List<Student>();

    }
}