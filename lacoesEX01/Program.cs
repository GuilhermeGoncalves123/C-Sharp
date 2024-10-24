Console.WriteLine(@$"
+------------------------------+
|    Bem vindo ao programa     |
|           Contador           |
|              de              |
|            Pessoas           |
+------------------------------+
");

int Percentual = 0;

int QtdNaoGostaEsporte = 0;

int QtdGostaEsporte = 0;

int QtdMulher = 0;

Console.WriteLine($"Quantas pessoas tem na sua mesa?");
int QtdDeEntrevistados = int.Parse(Console.ReadLine()!);

int QtdHomem = 0;

for (int i = 1; i <= QtdDeEntrevistados; i++)
{
    Console.WriteLine($"Qual é o seu sexo ? m/f");
    string sexo = Console.ReadLine()!;
    

    Console.WriteLine($"VOce gosta de esporte? sim/nao");
    string esporte = Console.ReadLine()!;
    

    if(sexo== "f"){
        QtdMulher++;

    }else{
        QtdHomem++;
    }

    if (esporte == "sim"){
        QtdGostaEsporte++;
    }

}

Console.WriteLine($"Quantidade de Mulheres : {QtdMulher}");
Console.WriteLine($"Quantidade de Homens : {QtdHomem}");
Console.WriteLine($"Total de Entrevistados: {QtdMulher + QtdHomem}");
Console.WriteLine($"Total de pessoas que gostam de Esportes: {QtdGostaEsporte}");
Console.WriteLine($"Total de pessoas que NÃO gostam de Esportes: {QtdNaoGostaEsporte}");
Console.WriteLine($"Percentual de pessoas que gostam de esportes: {Percentual} %");