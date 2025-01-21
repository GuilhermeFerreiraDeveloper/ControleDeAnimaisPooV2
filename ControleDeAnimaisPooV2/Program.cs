using System;

namespace ControleDeAnimaisPooV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 1;
            int quantidadeCachorro = 0, quantidadeGato = 0, quantidadePeixe = 0;

            Console.WriteLine("Controle de Animais \n");

            do
            {
                Animal animal = new Animal();

                Console.WriteLine("Digite o nome do " + contador + "° Animal");
                animal.Nome = Console.ReadLine();

                Console.WriteLine("Digite o tipo do " + contador + "° Animal");
                animal.Tipo = Console.ReadLine().ToUpper(); 

                if (animal.Tipo == "CACHORRO") quantidadeCachorro++;
                else if (animal.Tipo == "GATO") quantidadeGato++;
                else if (animal.Tipo == "PEIXE") quantidadePeixe++;

                contador++;
            } while (contador <= 5);

            Console.WriteLine($"\nCachorros: {quantidadeCachorro}, Gatos: {quantidadeGato}, Peixes: {quantidadePeixe}");
            Console.ReadKey();
        }
    }
}