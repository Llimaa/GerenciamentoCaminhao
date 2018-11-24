using GerenciamentoCaminhaInfra.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoCaminhao.WinForms.ConfiguracaoDB
{
    class MSQLConfiguracao : IDbConexao
    {
        public string ConnectionString { get=> @"SERVER=MARCOS-PC\SQLEXPRESS; DATABASE=GERENCIACAMINHAO; USER ID=ROOT; PASSWORD=123;"; }
    }
}
