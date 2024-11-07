using Construtores.Classes;

Console.WriteLine(@$"
╔═══════════════╗
   MotorsRoad      
╚═══════════════╝");


Veiculo Moto1 = new Veiculo("BMW", "310GS", 2022, "Cosmic Black", "145KM", "313 cm³" );
Veiculo Moto2 = new Veiculo("Yamaha", "MT09", 2024, "Racing blue", "220 (Com limitador)", "849 cc");

// Moto1.marca = "BMW";
// Moto1.modelo = "310GS";
// Moto1.ano = 2022;
// Moto1.cor = "Cosmic Black";
// Moto1.VelocidadeMaxima = "145kM";
// Moto1.cilindradas = "313 cm³";

// Moto2.marca = "Yamaha";
// Moto2.modelo = "MT09";
// Moto2.ano = 2024;
// Moto1.cor = "Racing Blue";
// Moto2.VelocidadeMaxima = "220 (Com limitador)";
// Moto2.cilindradas = "849 cc";

Moto1.ExibirDados();
Moto1.Veiculo3();

Moto2.ExibirDados();
Moto2.Veiculo3();



Console.WriteLine(@$"
▂▃▄▅▆▇█▓▒░Menu de Opções░▒▓█▇▆▅▄▃▂
             ╔═══════════════╗
              1 Cadastrar Jogo
              2 Listar Jogos
              3 Sair
             ╚═══════════════╝");


Jogo GTA5  = new Jogo("Grand Theft Auto V (Gta 5)", "17/09/2013", "Mundo Aberto", 90);

GTA5.ExibirDados2();
GTA5.Jogos();





Console.WriteLine(@$"
╔═══════════════╗
    MATRICULA      
╚═══════════════╝");


Aluno nome = new Aluno("Guilherme", "030108/010508", 16);

nome.ExibirDados3();
nome.Alunos();




