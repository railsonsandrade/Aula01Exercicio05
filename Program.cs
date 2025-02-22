internal class Program
{
    static void Main(string[] args)
    {
        // cria uma instância da classe Random para gerar números aleatórios
        Random random = new Random();

        int numero = random.Next(1, 101);

        int palpite = 0;

        Console.WriteLine("Bem-vindo ao jogo do Negrettinho!");
        Console.WriteLine("Tente adivinhar meu número aleatório, digite um número entre 1 e 100!");

        while (palpite != numero)
        {
            Console.Write("Digite seu palpite: ");
            palpite = int.Parse(Console.ReadLine());
       

            if (palpite < numero)
            {
                Console.WriteLine("Palpite menor do que o número aleatório. Tente novamente!");
            }
            else if (palpite > numero)
            {
                Console.WriteLine("Palpite maior do que o número aleatório. Tente novamente!");
            }
            else
            {
                Console.WriteLine($"Parabéns! Você acertou o número aleatório {numero}!");
            }
        }
    }
}
