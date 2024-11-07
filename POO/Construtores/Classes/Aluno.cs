using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Construtores.Classes
{
    public class Aluno
    {
        public string nome3 { get; set; }
        public string matricula { get; set; }
        public int idade { get; set; }

          public Aluno (string nm, string mt, int id){
        nome3 = nm;
        matricula = mt;
        idade = id;
          }
          public void ExibirDados3()
          {
             Console.WriteLine(@$"
        Nome do Aluno: {nome3}

        Matricula {matricula}

         Idade do Aluno: {idade}

        ");
        

          }
          public void Alunos()
          {
            Console.WriteLine($"Programa Alunos Feito Com Sucesso");
            
          }
    }
}