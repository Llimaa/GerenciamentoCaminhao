using GerencimentoCaminhao.Compartilhado.Comandos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoCaminhao.Dominio.Comandos.Resultado
{
    public class RegistrarComandoResultadoCaminhao : IComandoResultado
    {
        public RegistrarComandoResultadoCaminhao(object mensagem)
        {
            Mensagem = mensagem;
        }

        public object Mensagem { get; set; }
    }
}
