using GerenciamentoCaminhaInfra.Infra;
using GerenciamentoCaminhaInfra.Repositorio;
using GerenciamentoCaminhao.Dominio.Comandos.Manipulador;
using GerenciamentoCaminhao.Dominio.Repositorio;
using GerenciamentoCaminhao.WinForms.ConfiguracaoDB;
using Microsoft.Extensions.DependencyInjection;

namespace GerenciamentoCaminhao.WinForms.Servicos
{
    public static class ConfigureServicos
    {
        public static ServiceCollection configuracao(ServiceCollection servico)
        {
            servico.AddTransient<ICaminhaoRepositorio, CaminhaoRepositorio>();
            servico.AddTransient<RegistrarComandoManipuladorCaminhao>();
            servico.AddTransient<frmCadastrarCaminhao>();
            servico.AddTransient<IDbConexao, MSQLConfiguracao>();
            servico.AddTransient<IDb, MSSQLDB>();

            return servico;
        }
    }
}
