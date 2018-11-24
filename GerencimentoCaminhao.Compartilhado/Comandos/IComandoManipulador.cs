using System;

namespace GerencimentoCaminhao.Compartilhado.Comandos
{
    public interface IComandoManipulador<Comando> where Comando : IComando
    {
        IComandoResultado Manipulador(Comando comando);
    }
}
