using FluentValidator;
using GerenciamentoCaminhao.Dominio.ObjetoValor;
using GerencimentoCaminhao.Compartilhado.Entidades;
using System;

namespace GerenciamentoCaminhao.Dominio.Entidades
{
    public class Caminhao :Entidade
    {
        public Caminhao(string modelo, int ano, Placa placa, string numeroRenavan, string cor, string numeroChassis, string numeroMotor, double quantidadeCarga)
        {
            Modelo = modelo;
            Ano = ano;
            Placa = placa;
            NumeroRenavan = numeroRenavan;
            Cor = cor;
            NumeroChassis = numeroChassis;
            NumeroMotor = numeroMotor;
            QuantidadeCarga = quantidadeCarga;

            new ValidationContract<Caminhao>(this);
        }

        public string Modelo { get; private set; }
        public int Ano { get; private set; }
        public Placa Placa { get; private set; }
        public string NumeroRenavan { get; private set; }
        public string Cor { get; private set; }
        public string NumeroChassis { get; private set; }
        public string NumeroMotor { get; private set; }
        public double QuantidadeCarga { get; private set; }
    }
}
