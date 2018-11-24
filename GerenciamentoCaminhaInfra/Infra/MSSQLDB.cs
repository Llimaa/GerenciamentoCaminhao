using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoCaminhaInfra.Infra
{
    public class MSSQLDB : IDb, IDisposable
    {
        private SqlConnection DB;
        private string strcon;

        public MSSQLDB(IDbConexao conexao)
        {
            strcon = conexao.ConnectionString;
        }
        public void Dispose()
        {
            DB.Close();
            DB.Dispose();
        }

        public IDbConnection _con()
        {
            DB = new SqlConnection(strcon);
            return DB;
        }
    }
}