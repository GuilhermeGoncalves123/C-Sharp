using RPG.Classes;
using System.Diagnostics.Contracts;
using System.Net.Http.Headers;
using System.Transactions;

Personagens rpg = new Personagens();
rpg.nome = "";
rpg.idade = 0;
rpg.armadura = "";
rpg.IA = "";

Console.Clear();
Console.WriteLine($"𝑺𝑬𝑱𝑨 𝑩𝑬𝑴 𝑽𝑰𝑵𝑫𝑶 𝑨𝑶");
Console.WriteLine($"");
Console.WriteLine($"▂▃▄▅▆▇█▓▒░FrontNite░▒▓█▇▆▅▄▃▂");
Console.WriteLine($"");
Console.WriteLine($"");
Console.WriteLine(@"░░░░▄▄▄▄▀▀▀▀▀▀▀▀▄▄▄▄▄▄
░░░░█░░░░▒▒▒▒▒▒▒▒▒▒▒▒░░▀▀▄
░░░█░░░▒▒▒▒▒▒░░░░░░░░▒▒▒░░█
░░█░░░░░░▄██▀▄▄░░░░░▄▄▄░░░█
░▀▒▄▄▄▒░█▀▀▀▀▄▄█░░░██▄▄█░░░█
█▒█▒▄░▀▄▄▄▀░░░░░░░░█░░░▒▒▒▒▒█
█▒█░█▀▄▄░░░░░█▀░░░░▀▄░░▄▀▀▀▄▒█
░█▀▄░█▄░█▀▄▄░▀░▀▀░▄▄▀░░░░█░░█
░░█░░▀▄▀█▄▄░█▀▀▀▄▄▄▄▀▀█▀██░█
░░░█░░██░░▀█▄▄▄█▄▄█▄████░█
░░░░█░░░▀▀▄░█░░░█░███████░█
░░░░░▀▄░░░▀▀▄▄▄█▄█▄█▄█▄▀░░█
░░░░░░░▀▄▄░▒▒▒▒░░░░░░░░░░█
░░░░░░░░░░▀▀▄▄░▒▒▒▒▒▒▒▒▒▒░█
░░░░░░░░░░░░░░▀▄▄▄▄▄░░░░░█");
Console.WriteLine($"");

Console.WriteLine($"Digite o nome do seu Personagem:");
rpg.nome = Console.ReadLine();
Console.WriteLine($"Digite a Idade dele:");
rpg.idade = int.Parse(Console.ReadLine());




Console.WriteLine($"!Digite o nome da armadura que ele ultiliza:");
rpg.armadura = Console.ReadLine();

Console.WriteLine($"!Digite o nome da Ia que ira ajuda-lo:");
rpg.IA = Console.ReadLine();

Console.Clear();
Console.Clear();

Console.WriteLine($"Seu nome é: {rpg.nome}");
Console.WriteLine($"Sua idade é: {rpg.idade}");
Console.WriteLine($"Esta usando a armadura: {rpg.armadura}");
Console.WriteLine($"IA que ira te acompanhar é: {rpg.IA}\r\n"); 

rpg.atacar();
rpg.defender();
rpg.RestaurarArmadura();
