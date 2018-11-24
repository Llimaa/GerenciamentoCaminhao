using GerenciamentoCaminhao.WinForms.Servicos;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciamentoCaminhao.WinForms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var servicos = ConfigureServicos.configuracao(new ServiceCollection());
            var prov = servicos.BuildServiceProvider();
            var form = prov.GetRequiredService<frmCadastrarCaminhao>();

            Application.Run(form);
        }
    }
}
