class Program
{
    static void Main(string[] args)
    {
        ExibirBoasVindas();

        string nomeUsuario = PerguntarNomeUsuario();
        int numeroFavorito = PerguntarNumeroFavorito();
        int numeroAoQuadrado = ElevarAoQuadrado(numeroFavorito);

        ExibirResultado(nomeUsuario, numeroAoQuadrado);
    }

    static void ExibirBoasVindas()
    {
        Console.WriteLine("Bem-vindo ao programa!");
    }

    static string PerguntarNomeUsuario()
    {
        Console.Write("Por favor, insira seu nome: ");
        return Console.ReadLine() ?? "";
    }

    static int PerguntarNumeroFavorito()
    {
        Console.Write("Por favor, insira seu número favorito: ");
        return int.Parse(Console.ReadLine() ?? "0");
    }

    static int ElevarAoQuadrado(int numero)
    {
        return numero * numero;
    }

    static void ExibirResultado(string nomeUsuario, int numeroAoQuadrado)
    {
        Console.WriteLine($"{nomeUsuario}, o quadrado do seu número é {numeroAoQuadrado}");
    }
}
