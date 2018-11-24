using GerenciamentoCaminhao.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoCaminhao.Dominio.Repositorio
{
    public interface ICaminhaoRepositorio
    {
        void Salvar(Caminhao caminhao);
        void Desativar(Caminhao caminhao);
        IEnumerable<Caminhao> Listar();
    }
}
