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
<<<<<<< HEAD
            Application.Run(new FormPrincipal());
=======

            Application.Run(new FormPrincipal());

>>>>>>> caa996077b44030053f2a36bb4f596b08cf5440d
=======

            Application.Run(new FormPrincipal());

>>>>>>> caa996077b44030053f2a36bb4f596b08cf5440d
        }
    }
}