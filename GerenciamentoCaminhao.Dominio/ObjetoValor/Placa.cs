using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoCaminhao.Dominio.ObjetoValor
{
    public class Placa
    {
        public Placa(string descricaoPlaca)
        {
            DescricaoPlaca = descricaoPlaca;
        }

        public string DescricaoPlaca { get; private set; }
    }
}


//public class Placa : Notifiable
//{
//    public Placa(string descricaoPlaca)
//    {
//        new ValidationContract<Placa>(this)
//           .IsRequired(x => x.DescricaoPlaca, "*")
//           .HasMaxLenght(x => x.DescricaoPlaca, 7, "No maximo 7 caractéres!")
//           .HasMinLenght(x => x.DescricaoPlaca, 6, "No minimo 6 caractéres!");

//        DescricaoPlaca = descricaoPlaca;
//    }

//    public string DescricaoPlaca { get; private set; }
//}