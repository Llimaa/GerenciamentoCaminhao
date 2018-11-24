using FluentValidator;
using GerenciamentoCaminhao.Dominio.Comandos.Entrada;
using GerenciamentoCaminhao.Dominio.Comandos.Resultado;
using GerenciamentoCaminhao.Dominio.Entidades;
using GerenciamentoCaminhao.Dominio.ObjetoValor;
using GerenciamentoCaminhao.Dominio.Repositorio;
using GerencimentoCaminhao.Compartilhado.Comandos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoCaminhao.Dominio.Comandos.Manipulador
{
    public class RegistrarComandoManipuladorCaminhao :Notifiable,
       IComandoManipulador<RegistrarComandoCaminhao>
    {
        private readonly ICaminhaoRepositorio _caminhaoRepositorio;
        public RegistrarComandoManipuladorCaminhao(ICaminhaoRepositorio Repcaminhao)
        {
            _caminhaoRepositorio = Repcaminhao;
        }
        public IComandoResultado Manipulador(RegistrarComandoCaminhao comando)
        {
            //COmportamento para criação de um caminhao apartir da area publica.
            //Criação das VOs.

            Placa placa = new Placa(comando.DescricaoPraca);

            //Criar entidade caminhão.
            Caminhao caminhao = new Caminhao
                (
                comando.Modelo,
                comando.Ano,
                placa,
                comando.NumeroRenavan,
                comando.Cor,
                comando.NumeroChassis,
                comando.NumeroMotor,
                comando.QuantidadeCarga
                );

            if(!IsValid())
                foreach(var message in caminhao.Notifications)
                {
                    return  new RegistrarComandoResultadoCaminhao(message);
                }

            //Salvar no banco.
            _caminhaoRepositorio.Salvar(caminhao);

            //Criar comando resultado.
           
            return new RegistrarComandoResultadoCaminhao("Caminhão Registrado com sucesso");
        }
    }
}
