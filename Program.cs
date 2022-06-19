using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using LaPizza.Views;

namespace LaPizza
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new FormPrincipal());
            /************************
             * Manter o Login comentado para não atrapalhar na construção de outras rotinas.
             * Caso precise realizar manutenção no Login descomente e utilize somente no seu ambiente de testes.
             ************************
            FormAcesso Acesso = new FormAcesso();
            if (DialogResult.Yes == Acesso.ShowDialog())
                Application.Run(new FormPrincipal());*/
        }
    }
}
