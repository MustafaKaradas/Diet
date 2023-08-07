using DietProgram.UI.AdminUI;
using DietProgram.UI.AppUI;
using DietProgram.UI.EFContextForm;

namespace DietProgram.UI
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

            var form = EFContextForm.EFContextForm.ConfigureService<frmMainPage>();

            Application.Run(form);
        }
    }
}