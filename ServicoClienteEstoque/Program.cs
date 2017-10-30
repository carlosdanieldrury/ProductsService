using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ServiceModel;
using ServicoClienteEstoque.ServicoEstoque;
using Servico;

namespace ServicoClienteEstoque
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.ReadLine();
            ServicoEstoqueClient proxy = new ServicoEstoqueClient("BasicHttpBinding_IServicoEstoque");

            // Project Tests

            // Incluir Produto
            Console.WriteLine("Teste 1: Adicionar produto 11");
            ProdutoEstoqueData produto = new ProdutoEstoqueData();
            produto.NumeroProduto = "11000";
            produto.NomeProduto = "Produto 11";
            produto.DescricaoProduto = "Produto 11";
            produto.EstoqueProduto = 2000;

            if (proxy.IncluirProduto(produto) == true)
            {
                Console.WriteLine("Produto Adicionado");
            }
            else
            {
                Console.WriteLine("Erro ao adicionar o Produto");
            }
            Console.WriteLine();

            // Remover Produto 10
            Console.WriteLine("Teste 2: Remova o produto 10");
            if (proxy.RemoverProduto("10000") == true)
            {
                Console.WriteLine("Produto removido com sucesso");
            }
            else
            {
                Console.WriteLine("Houve algum erro ao remover o Produto 10");
            }
            Console.WriteLine();

            // Listar os produtos
            Console.WriteLine("Teste 3: Listar todos os produtos");
            List<string> produtos = proxy.ListarProdutos().ToList();
            foreach (string p in produtos)
            {
                Console.WriteLine("Nome Produto {0}", p);
                Console.WriteLine();
            }
            Console.WriteLine();

            // Detalhes do Produto 2
            Console.WriteLine("Teste 4: Detalhes produto 2");
            ProdutoEstoqueData produto2 = proxy.VerProduto("2000");
            Console.WriteLine("Numero Produto: {0}", produto2.NumeroProduto);
            Console.WriteLine("Nome Produto: {0}", produto2.NomeProduto);
            Console.WriteLine("Descricao Produto: {0}", produto2.DescricaoProduto);
            Console.WriteLine("Estoque Produto: {0}", produto2.EstoqueProduto);
            Console.WriteLine();

            int quantidade;

            // Adicionar estoque para o produto 2
            Console.WriteLine("Teste 5: Adicionar estoque para o produto 2");
            if (proxy.AdicionarEstoque("2000", 10))
            {
                quantidade = proxy.ConsultarEstoque("2000");
                Console.WriteLine("Quantidade Produto 2: ", quantidade);
            }
            else
            {
                Console.WriteLine("Não foi possivel consultar a quantidade do item 2");
            }
            Console.WriteLine();

            // Verificar estoque item 2
            Console.WriteLine("Teste 6: quantidade do produto 2");
            quantidade = proxy.ConsultarEstoque("2000");
            Console.WriteLine("Quantidade: {0}", quantidade);
            Console.WriteLine();

            // Verificar estoque item 1
            Console.WriteLine("Teste 7: quantidade do produto 1");
            quantidade = proxy.ConsultarEstoque("1000");
            Console.WriteLine("Quantidade: {0}", quantidade);
            Console.WriteLine();

            // Remover 20 items do Produto 1
            Console.WriteLine("Teste 8: Remover 20 items do Produto 1");
            if (proxy.RemoverEstoque("1000", 20))
            {
                Console.WriteLine("Itens removidos");
            }
            else
            {
                Console.WriteLine("Houve algum erro ao remover os itens do estoque");
            }
            Console.WriteLine();

            // Verificar Estoque Produto 1
            Console.WriteLine("Teste 9: quantidade do produto 1");
            quantidade = proxy.ConsultarEstoque("1000");
            Console.WriteLine("Current stock: {0}", quantidade);
            Console.WriteLine();

            // Get details of this product
            Console.WriteLine("Teste 10: Verificar as informacoes do Produto 1");
            produto = proxy.VerProduto("1000");
            Console.WriteLine("Numero Produto: {0}", produto.NumeroProduto);
            Console.WriteLine("Nome Produto: {0}", produto.NomeProduto);
            Console.WriteLine("Descricao Produto: {0}", produto.DescricaoProduto);
            Console.WriteLine("Estoque Produto: {0}", produto.EstoqueProduto);
            Console.WriteLine();


            Console.WriteLine("Press ENTER to finish");
            Console.ReadLine();
        }
    }
}
