using Pry_sistema_metroVia.Vista.Administrador;
using Pry_sistema_metroVia.Vista.Cliente;

namespace Pry_sistema_metroVia
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //To customize application configuration such as set high DPI settings or default font,
            //see https://aka.ms/applicationconfiguration.
            //ApplicationConfiguration.Initialize();
            //Application.Run(new frmRutas());            
            //Application.Run(new frmRegistroCliente());
            Application.Run(new frmPantallaPrincipal());
            //Application.Run(new frmInicioSesion());
            //Application.Run(new frmUsuarios("UA", "N"));
            //Application.Run(new frmAdministrador ());
        }
    }
}