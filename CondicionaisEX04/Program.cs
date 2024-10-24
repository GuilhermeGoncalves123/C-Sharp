// See https://aka.ms/new-console-template for more information
int Senha = 1234;
Console.WriteLine($"Digite sua Senha");
int ConfirmarSenha = int.parse(console.ReadLine()!);

if (Senha == ConfirmarSenha){
    Console.WriteLine($"ACESSO PERMITIDO");

}else{
 Console.WriteLine($"ACESSO NEGADO");
    
};
