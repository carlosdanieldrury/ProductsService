
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ServiceModel;
using ServicoClient.ServicoEstoqueV2;
using Servico;


namespace ServicoClienteVendas
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Servico Cliente Vendas - Enter para iniciar");
            Console.ReadLine();
            ServicoEstoqueV2Client proxy = new ServicoEstoqueV2Client("WS2007HttpBinding_IServicoEstoque");

            int quantidade = 0;
 

            Console.WriteLine("Teste 1: Estoque do Produto 1");
            quantidade = proxy.ConsultarEstoque("1000");
            Console.WriteLine("Quantidade: {0}", quantidade);
            Console.WriteLine();


            Console.WriteLine("Teste 2: Adicionar 20 itens ao Produto 1");
            if (proxy.AdicionarEstoque("1000", 20))
            {
                quantidade = proxy.ConsultarEstoque("1000");
                Console.WriteLine("20 Itens adicionados");
            }
            else
            {
                Console.WriteLine("Houve algum erro ao tentar adicionar 20 itens");
            }
            Console.WriteLine();


            Console.WriteLine("Teste 3: Consultar o estoque do Produto 1");
            quantidade = proxy.ConsultarEstoque("1000");
            Console.WriteLine("Quantidade: {0}", quantidade);
            Console.WriteLine();

            Console.WriteLine("Teste 4: Consultar o estoque do Produto 5");
            quantidade = proxy.ConsultarEstoque("5000");
            Console.WriteLine("Quantidade: {0}", quantidade);
            Console.WriteLine();

            Console.WriteLine("Teste 5: Remover 10 itens do Produto 5");
            if (proxy.RemoverEstoque("5000", 10))
            {
                Console.WriteLine("10 Itens removidos");
            }
            else
            {
                Console.WriteLine("Houve algum erro ao remover 10 itens do Produto 5");
            }
            Console.WriteLine();

            Console.WriteLine("Teste 6: Consultar o estoque do Produto 5");
            quantidade = proxy.ConsultarEstoque("5000");
            Console.WriteLine("Quantidade: {0}", quantidade);
            Console.WriteLine();


            proxy.Close();
            Console.WriteLine("Enter para encerrar");
            Console.ReadLine();
        }
    }
}
