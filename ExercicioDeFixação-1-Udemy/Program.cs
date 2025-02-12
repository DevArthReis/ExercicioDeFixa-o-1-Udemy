using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}
