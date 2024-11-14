using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Construtores.Classes
{
    public class Aluno2
    {
        public string Nome;
        public int CPF { get; set; }
        
        public Aluno2(string _chuchu){
            Nome = _chuchu;
        }
    }
}