// See https://aka.ms/new-console-template for more information
   int Datanascimento;

Console.WriteLine($@"Ola, Boas Vindas!
    Preencha os Dados a Seguir ");

    Console.WriteLine("Seu nome:");
string nome = Console.ReadLine();


    Console.WriteLine("Seu Email:");
string email = Console.ReadLine();


    Console.WriteLine("Seu Numero de Telefone:");
 UInt128 telefone = UInt128.Parse(Console.ReadLine()!);


    Console.WriteLine("Seu CPF:");
 UInt128 cpf = UInt128.Parse (Console.ReadLine());


    Console.WriteLine("Endereço de Residencia:");
 string endereço = Console.ReadLine();

    Console.WriteLine("Qual Seu Estado Civil?:");
string Estadocivil = Console.ReadLine();

    Console.WriteLine("Em que ano voce nasceu:");
    int anoNascimento = int.Parse(Console.ReadLine()!);
    int anoAtual = DateTime.Now.Year;
    int idade = anoAtual - anoNascimento;



   