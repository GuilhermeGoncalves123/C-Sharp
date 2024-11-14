string[] Frutas = {"Melancia", "Carambola", "Maracuja", "Morango", "Limao", "Jabuticaba","Abacate", "Kiwi", "Acerola", "Pinha", "Lichia", "Pitaya", "Pessego", "Banana"};

Console.Write($"Sua sacola contem {Frutas.Length} frutas");

foreach (string f in Frutas)
{
    Console.Write($"{f}, ");
}
Console.WriteLine();