using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG.Classes
{
    public class Personagens
    {
        public string nome;
        public int idade;
        public string armadura;
        public string IA;

        public void atacar()
        {
            Console.WriteLine($"O {nome} Atacou!!");

        }

        public void defender()
        {
            Console.WriteLine($"O {nome} Defendeu");

        }

        public void RestaurarArmadura()
        {
            Console.WriteLine($"O {nome} Restaurou a Armadura");

        }
    }
}