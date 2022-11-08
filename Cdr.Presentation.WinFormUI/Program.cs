namespace Cdr.Presentation.WinFormUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Cdr.AppLayer.ApplicationServiceSettings.RegisterAllService();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //var f = new Form1();  böylede yapabilirim
            //Application.Run(f);
            Application.Run(new FrmMain());
            //Application.Run(new Form1());
        }
    }
}