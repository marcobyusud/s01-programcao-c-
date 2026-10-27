using System.Collections.Generic;

List<int> numeros = new List<int>();

Console.WriteLine("Insira uma lista de números e digite 0 quando terminar.");

int numero = -1;

while (numero != 0)
{
    Console.Write("Insira o número: ");
    numero = int.Parse(Console.ReadLine() ?? "0");

    if (numero != 0)
    {
        numeros.Add(numero);
    }
}

if (numeros.Count == 0)
{
    Console.WriteLine("Nenhum número foi inserido.");
}
else
{
    int soma = 0;
    int maiorNumero = numeros[0];

    foreach (int item in numeros)
    {
        soma += item;

        if (item > maiorNumero)
        {
            maiorNumero = item;
        }
    }

    double media = (double)soma / numeros.Count;

    Console.WriteLine($"A soma é: {soma}");
    Console.WriteLine($"A média é: {media}");
    Console.WriteLine($"O maior número é: {maiorNumero}");
}
