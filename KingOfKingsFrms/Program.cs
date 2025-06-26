using KingoOfKingsClass;

namespace KingOfKingsFrms
{
    internal static class Program
    {
        public static Usuario UsuarioLogado { get; set; } = new Usuario();

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
<<<<<<< HEAD
            Application.Run(new FormPrincipal());
=======
            Application.Run(new FormLogin());
>>>>>>> ceec07ccfdfe2871956b2f5630084dbfd5698de7
        }
    }
}