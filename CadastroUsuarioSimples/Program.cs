using CadastroUsuarioSimples.Views;
using System;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace CadastroUsuarioSimples
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ConnectionView());
        }
    }
}
