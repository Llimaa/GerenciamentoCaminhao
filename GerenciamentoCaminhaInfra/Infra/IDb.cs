using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoCaminhaInfra.Infra
{
    public interface IDb
    {
        IDbConnection _con();
    }
}
