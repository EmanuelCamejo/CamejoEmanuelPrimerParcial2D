using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;

namespace CiberOne
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormPanelPrincipal());

            Cliente c1 = new Cliente("Cliente1", 31222001, 36, "recepcionado");
            Cliente c2 = new Cliente("Cliente2", 31222002, 18, "recepcionado");
            Cliente c3 = new Cliente("Cliente3", 31222003, 30, "recepcionado");
            Cliente c4 = new Cliente("Cliente4", 31222004, 54, "recepcionado");


            
        }
    }
}
