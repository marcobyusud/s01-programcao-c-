Random random = new Random();
int numeroMagico = random.Next(1, 101);

Console.Write("Adivinhe o número mágico entre 1 e 100: ");
int palpite = int.Parse(Console.ReadLine() ?? "0");

while (palpite != numeroMagico)
{
    if (palpite < numeroMagico)
    {
        Console.WriteLine("Digite um número maior.");
    }
    else
    {
        Console.WriteLine("Digite um número menor.");
    }

    Console.Write("Digite outro palpite: ");
    palpite = int.Parse(Console.ReadLine() ?? "0");
}

Console.WriteLine("Parabéns, você adivinhou o número mágico!");
