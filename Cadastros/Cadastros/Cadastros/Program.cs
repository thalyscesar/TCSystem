using Cadastros.Forms;
using Cadastros.Forms.Banco;

namespace Cadastros
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new frmProprietario());
        }
    }
}