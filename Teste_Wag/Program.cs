
using System.Globalization;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.IO;

Console.WriteLine("Digite qunatos inteiros que você precisa.");

int numero = int.Parse(Console.ReadLine());
int[] vetor = new int[numero];

for (int i = 0; i < numero; i++)
{
    Console.WriteLine($"Digite o {i}º valor.");
    vetor[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Numeros Digitados");
Array.Sort(vetor);
foreach (var item in vetor)
{
    Console.WriteLine(item);
}

Console.WriteLine("Soma dos números digitados:");

int soma = 0;
for (int i = 0; i < numero; i++)
{
    soma += vetor[i];
}
Console.WriteLine(soma);

Console.WriteLine("Média dos valores:");
double media = soma / numero;

Console.WriteLine("Média do valores = " + media.ToString("F2", CultureInfo.InvariantCulture));

Console.WriteLine("Exibindo o maior número");

int maior = 0;
int menor = 0;

for (int i = 0; i < numero; i++)
{
    if (i == 0)
    {
        menor = vetor[0];
        maior = vetor[0];
    }
    if (vetor[i] < menor)
    {
        menor = vetor[i];
    }
    else if (vetor[i] > maior)
    {
        maior = vetor[i];
    }
}
Console.WriteLine("O menor número é:" + menor);
Console.WriteLine("O maior número é:" + maior);

string path = @"C:\Windows\Temp\MyTest.txt";
if (!File.Exists(path))
{
    // Create a file to write to.
    using (StreamWriter sw = File.CreateText(path))
    {
        sw.WriteLine($"Valor somado {soma}");
        sw.WriteLine($"Valor médio {media}");
        sw.WriteLine($"Maior valor {maior}");
        sw.WriteLine($"Maior valor {menor}");
    }
}