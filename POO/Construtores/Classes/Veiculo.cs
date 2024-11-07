using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Construtores.Classes
{
    public class Veiculo
    {
      public string marca { get; set; }  
      public string modelo { get; set; }
      public int ano { get; set; }
      public string cor { get; set; }
      public string VelocidadeMaxima { get; set; }
      public string cilindradas { get; set; }

      public Veiculo(string ma, string md, int an, string cr, string vm, string cl){
        marca = ma;
        modelo = md;
        ano = an;
        cor = cr;
        VelocidadeMaxima = vm;
        cilindradas = cl;
      }

      public void ExibirDados()
      {
        Console.WriteLine(@$"
        Marca: {marca}
        Modelo: {modelo}
        Ano: {ano}
        Cor: {cor}
        Velocidade Maxima: {VelocidadeMaxima}
        Cilindrada de: {cilindradas}


        ");
        
      }
      public void Veiculo3 ()
      {
        Console.WriteLine($"Motos Criadas com Sucesso");
        
      }
    }
}   