using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PilaresPOO.Classes.Pilares
{
    public class ContaPoupança : Conta
    {
        public int LimiteSaque { get; set; }
        public float Rendimento { get; set; }
        public override bool Depositar(float valor)
        {
            throw new NotImplementedException();
        }

        public override float Sacar(float valor)
        {
            throw new NotImplementedException();
        }
    }
}