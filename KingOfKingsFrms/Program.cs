using KingOfKingsClass;
using KingoOfKingsClass;

namespace KingOfKingsFrms
{
    internal static class Program
    {
        public static Usuario UsuarioLogado { get; set; } = new Usuario();
        public static Cliente CLientelogado { get; set; } = new Cliente();


        public class Cliente
        {
            public int Id { get; set; }
            public string Nome { get; set; }
        }
    

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FormLogin());
        }
    }
}