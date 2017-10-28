using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ServiceModel;
using ServicoClienteEstoque.ServicoEstoque;

namespace ServicoClienteEstoque
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.ReadLine();
            ServicoEstoqueClient proxy = new ServicoEstoqueClient();

            // Test the operations in the service
            // Obtain a list of all products
            Console.WriteLine("Test 1: List all products");
            List<String> products = proxy.ListarProdutos().ToList();
            foreach (string p in products)
            {
                Console.WriteLine(p);
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
