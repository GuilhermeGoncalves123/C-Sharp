using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Construtores.Classes
{
    public class Jogo
    {
        public string nome2 { get; set; }
        public string dataLancamento { get; set; }
        public string genero { get; set; }
        public int preco { get; set; }

         public Jogo (string no, string dl, string gn, int pr){
        nome2 = no;
        dataLancamento = dl;
        genero = gn;
        preco = pr;
      }

      public void ExibirDados2()
      {
        Console.WriteLine(@$"
        Nome: {nome2}

        Data de Lançamento: {dataLancamento}

        Genero do Jogo: {genero}

        Preço: {preco}");
        
        Console.WriteLine($"");
        
      }
      
      public void Jogos()
      {
        Console.WriteLine($"Jogos Criados com Sucesso!");
        
      }
    }
 }