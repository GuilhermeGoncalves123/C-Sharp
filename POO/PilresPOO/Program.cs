// using PilresPOO.Aprendizagem;
// using PilresPOO.Aprendizagem;
// using PilresPOO.Aprendizagem;
// using PilresPOO.Classes.Aprendizagem;



// Professor sam = new Professor(010508);
// sam.nome = "Samanta";
// sam.idade = 22;

// Aluno ggoncalves = new Aluno();
// ggoncalves.Nome = "Guilherme";
// ggoncalves.Idade = 16;
// ggoncalves.Matricula = 010508;
// ggoncalves.Curso = "Dev";
// ggoncalves.Media = 9;
// ggoncalves.Peso = 68;
// ggoncalves.Altura = 175;
// Console.WriteLine($"Curso: {ggoncalves.Curso}");
// Console.WriteLine($"    Professor {sam.nome}");
// Console.WriteLine($"     Identificação do Professor {}");


// Console.WriteLine($"Aluno: {ggoncalves.Nome}");
// Console.WriteLine($"Idade: {ggoncalves.Idade}");
// Console.WriteLine($"Peso {ggoncalves.Peso}");
// Console.WriteLine($"Altura {ggoncalves.Altura}");
// Console.WriteLine($"Matricula: {ggoncalves.Matricula}");
// Console.WriteLine($"Media do Aluno: {ggoncalves.Media}");

// using PilresPOO.Aprendizagem;

// Carro volkswagen = new Carro();
// volkswagen.modelo = "Golf GTI ClubSport 45";
// volkswagen.marca = "volkswagen";
// volkswagen.qntportas = 2;
// volkswagen.potencia = "300 cv";

// Console.WriteLine(@$"Modelo: {volkswagen.modelo}
// Marca:{volkswagen.marca}
// Portas:{volkswagen.qntportas}
// Potencia:{volkswagen.potencia}
// ");
// volkswagen.Ligar();
// volkswagen.Desligar();
// volkswagen.Buzinar();
// Console.WriteLine($"\r\n");

// Moto BMW = new Moto();
// BMW.modelo = "R1300GS";
// BMW.marca = "BMW";
// BMW.qntportas = 0;
// BMW.potencia = "1300 cc";

// Console.WriteLine(@$"Modelo: {BMW.modelo}
// Marca:{BMW.marca}
// Portas:{BMW.qntportas}
// Potencia:{BMW.potencia}
// ");
// BMW.Ligar();
// BMW.Desligar();
// BMW.Buzinar();

// Console.WriteLine($"\r\n");


// Aviao Boing = new Aviao();
// Boing.modelo = "Boeing 777";
// Boing.marca = "Boing";
// Boing.qntportas = 2;
// Boing.potencia = "175.000 cv";

// Console.WriteLine(@$"Modelo: {Boing.modelo}
// Marca:{Boing.marca}
// Portas:{Boing.qntportas}
// Potencia:{Boing.potencia}
// ");
// Boing.Ligar();
// Boing.Desligar();
// Boing.Buzinar();


// Console.Clear();

// Personagem PersonagemGenerico = new Personagem();


// Mago personagemMago = new Mago();

// PersonagemGenerico.Atacar();
// personagemMago.Atacar();
using PilaresPOO.Classes.Pilares;
Console.Clear();

contaCorrente ctGui = new contaCorrente();
ctGui.Titular = "Guilherme Gonçalves";
ctGui.Saldo = 1000000f;// Usuario colocou grana direto no saldo

Console.WriteLine($"Titular da Conta {ctGui.Titular}");
Console.WriteLine($"Saldo da Conta {ctGui.Saldo}");

float valorSacado = ctGui.Sacar(1200);

Console.WriteLine($"Valor do saque {valorSacado}");
Console.WriteLine($"Valor do saldo {ct.Gui.saldo} ");




















