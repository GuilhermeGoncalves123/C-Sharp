using Banco.Classes;

Console.Clear();
Console.WriteLine($"Bem Vindo ao Nubanquinho");
Console.WriteLine();

ContaCorrente ContaEmilly = new ContaCorrente();
ContaCorrente ContaClara = new ContaCorrente();

ContaEmilly.Titular = "Emeilly";
ContaEmilly.Depositar(100000f);