namespace ClassesObjetos.Classes
{
    public class Animal
    {
        public string Raca;
        public string cor;
        public string nome;
        public int idade = 0;

        public void FazerBarulho(string barulho)
        {
            Console.WriteLine($"som do animal: {barulho}");

        }

        public void Envelhecer()
        {

            idade = idade + 1;
        }
    }
}

