namespace PilaresPOO.Classes
{
    public abstract class Conta
    {
        public string? Titular { get; set; }
        public float? Saldo { get; set; }

        public abstract float Sacar(float valor);
        public abstract bool Depositar(float valor);

    }
}