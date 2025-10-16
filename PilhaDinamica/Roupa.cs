using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaDinamica
{
    internal class Roupa
    {
        public string Descricao { get; set; }
        public string Cor { get; set; }

        public Roupa Proximo { get; set; }

        public Roupa(string descricao, string cor)
        {
            Descricao = descricao;
            Cor = cor;
            Proximo = null;
        }

        public override string ToString()
        {
            return $"Descricao: {Descricao}\nCor: {Cor}";
        }
    }
}
