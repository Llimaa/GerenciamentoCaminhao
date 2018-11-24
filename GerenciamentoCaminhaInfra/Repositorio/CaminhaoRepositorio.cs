using Dapper;
using GerenciamentoCaminhaInfra.Infra;
using GerenciamentoCaminhao.Dominio.Entidades;
using GerenciamentoCaminhao.Dominio.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoCaminhaInfra.Repositorio
{
    public class CaminhaoRepositorio : ICaminhaoRepositorio
    {
        private IDb DB;
        public CaminhaoRepositorio(IDb db)
        {
            DB = db;
        }

        public void Salvar(Caminhao caminhao)
        {
            using (var con = DB._con())
            {
                var sql = "INSERT INTO [dbo].[CAMINAHO]" +
           "       ([ID]					   " +
           "       ,[DATACADASTRO]			   " +
           "       ,[MODELO]				   " +
           "       ,[ANO]					   " +
           "       ,[DESCRICAOPLACA]		   " +
           "       ,[NUMERORENAVAN]			   " +
           "       ,[COR]					   " +
           "       ,[NUMEROCHASSIS]			   " +
           "       ,[NUMEROMOTOR]			   " +
           "       ,[QUANTIDADECARGA]		   " +
           "       ,[STATUSCAMINHAO])		   " +
                   " VALUES					   " +
           "       (@ID						   " +
           "       ,@DATACADASTRO			   " +
           "       ,@MODELO					   " +
           "       ,@ANO					   " +
           "       ,@DESCRICAOPLACA			   " +
           "       ,@NUMERORENAVAN			   " +
           "       ,@COR					   " +
           "       ,@NUMEROCHASSIS			   " +
           "       ,@NUMEROMOTOR			   " +
           "       ,@QUANTIDADECARGA		   " +
           "       ,@STATUSCAMINHAO)		    ";

                con.Execute(sql, new
                {
                    ID = caminhao.ID,
                    DataCadastro = caminhao.DataCadastro,
                    StatusCaminhao = caminhao.StatusCaminhao,
                    Modelo = caminhao.Modelo,
                    Ano = caminhao.Ano,
                    DescricaoPlaca = caminhao.Placa.DescricaoPlaca,
                    NumeroRenavan = caminhao.NumeroRenavan,
                    Cor = caminhao.Cor,
                    NumeroChassis = caminhao.NumeroChassis,
                    QuantidadeCarga = caminhao.QuantidadeCarga,
                    NumeroMotor = caminhao.NumeroMotor
                   
                });
            }
        }

        public void Desativar(Caminhao caminhao)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Caminhao> Listar()
        {
            throw new NotImplementedException();
        }


    }
}
