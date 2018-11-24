using GerencimentoCaminhao.Compartilhado.Comandos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoCaminhao.Dominio.Comandos.Entrada
{
    public class RegistrarComandoCaminhao : IComando
    {
        public string Modelo { get; set; }
        public int Ano { get;  set; }
        public string DescricaoPraca { get;  set; }
        public string NumeroRenavan { get;  set; }
        public string Cor { get;  set; }
        public string NumeroChassis { get;  set; }
        public string NumeroMotor { get;  set; }
        public double QuantidadeCarga { get;  set; }
    }
}
