

Console.WriteLine(@"
*-----------------*
*  pesquisa da    *
*   empresa       *
*-----------------*
");

int qtdGostadeProdutos = 0;
int qtdNaoGostadoProduto = 0;

int qtdHomem = 0;
int qtdMulher = 0;

Console.WriteLine($"quantas pessoas tem na sua empresa");
int qtddeEntrevistados = int.Parse(Console.ReadLine()!);

for (int i = 1; i <= qtddeEntrevistados; i++){

    Console.WriteLine($"qual seu sexo? m/f");
    string sexo = Console.ReadLine()!;

    Console.WriteLine($"voce gostou do novo produto sim/nao?");
    string Produto = Console.ReadLine()!;}

    if (sexo == "f")

    {
        qtdMulher++;
    }else
    {
        qtdHomem++;
    }

    if( Produto == "sim" ){
        qtdGostadeProdutos++;
    }

    else  {
    qtdNaoGostadoProduto++;
    }