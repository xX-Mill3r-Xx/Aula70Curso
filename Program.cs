using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Aula70Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a quantidade de Produdos que deseja Add: ");
            int qte = int.Parse(Console.ReadLine());

            Console.WriteLine($"Entre com o nome de {qte} Produtos: ");
            Product[] product = new Product[qte];

            for(int i =0; i < qte; i++)
            {
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Preço: $");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                product[i] = new Product { Name = name, Price = price };
            }

            double soma = 0.0;
            for(int i = 0; i < qte; i++)
            {
                soma += product[i].Price;
            }

            double avg = soma / qte;

            Console.WriteLine($"AVERAGE PRICE = {avg.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.ReadLine();
        }
    }
}
