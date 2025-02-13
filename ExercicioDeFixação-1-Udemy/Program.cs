using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ex1
            string Produto1 = "Computador";
            string Produto2 = "Mesa de escritório";
            int idade = 30;
            int codigo = 5290;
            char genero = 'M';
            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;
            Console.WriteLine("Produtos:");
            Console.WriteLine($"{Produto1}, cujo preço é $ {preco1:F2}");
            Console.WriteLine($"{Produto2}, cujo preço é $ {preco2}");
            Console.WriteLine($"Registro{idade} anos  de idade,codigo {codigo} e genero {genero}");
            Console.WriteLine($"Medida com oito casas decimais: {medida:F8}");
            Console.WriteLine($"Arredondado (três casas decimais): {medida:F3}");
            Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F3", System.Globalization.CultureInfo.InvariantCulture));
            //Ex2
            Console.WriteLine("Entre com seu nome completo:");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto:");
            double preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha):");
            string[] vet = Console.ReadLine().Split(' ');
            string ultimoNome = vet[0];
            int idade2 = int.Parse(vet[1]);
            double altura = double.Parse(vet[2]);
            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine($"{ preco:F2}");
            Console.WriteLine(ultimoNome);
            Console.WriteLine(idade2);
            Console.WriteLine(altura);

        }
    }
}
