using FluentValidator;
using System;

namespace GerencimentoCaminhao.Compartilhado.Entidades
{
    public abstract class Entidade: Notifiable
    {
        protected Entidade()
        {
            ID = Guid.NewGuid();
            DataCadastro = DateTime.Now;
            StatusCaminhao = true; // Cainhao ativo.
        }

        public Guid ID { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public bool StatusCaminhao { get; private set; }
    }
}
