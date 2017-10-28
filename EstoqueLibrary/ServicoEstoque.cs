using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using EstoqueEntityModel;
using System.ServiceModel.Activation;

namespace Servico
{
    // WCF service that implements the service contract 
    // This implementation performs minimal error checking and exception handling 
    [AspNetCompatibilityRequirements( RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class ServicoEstoque : IServicoEstoque, IServicoEstoqueV2
    {
        public List<string> ListarProdutos()
        {
            // Create a list of products
            List<string> productsList = new List<string>();
            try
            {
                using (ProvedorEstoque database = new ProvedorEstoque())
                {
                    // Fetch the products in the database
                    productsList = (from pe in database.ProdutoEstoques select pe.NomeProduto).ToList();
                }
            }
            catch
            {
                // Ignore exceptions in this implementation
            }
            // Return the list of products
            return productsList;
        }

        public bool IncluirProduto(ProdutoEstoqueData produto)
        {
            try
            {
                // Connect to the ProductsModel database
                using (ProvedorEstoque database = new ProvedorEstoque())
                {

                    ProdutoEstoque produtoEstoque = new ProdutoEstoque()
                    {
                        NumeroProduto = produto.NumeroProduto,
                        NomeProduto = produto.NomeProduto,
                        DescricaoProduto = produto.DescricaoProduto,
                        EstoqueProduto = produto.EstoqueProduto

                    };

                    database.ProdutoEstoques.Add(produtoEstoque);
                    database.SaveChanges();
                }
            }
            catch
            {
                // If an exception occurs, return false to indicate failure
                return false;
            }
            return true;
        }

        public bool RemoverProduto(string NumeroProduto)
        {
            try
            {
                // Connect to the ProductsModel database
                using (ProvedorEstoque database = new ProvedorEstoque())
                {
                    ProdutoEstoque produtoEstoque = database.ProdutoEstoques.First(pi => pi.NumeroProduto == NumeroProduto);
                    database.ProdutoEstoques.Remove(produtoEstoque);
                        database.SaveChanges();
                }
            }
            catch
            {
                // If an exception occurs, return false to indicate failure
                return false;
            }
            return true;
        }

        public int ConsultarEstoque(string NumeroProduto)
        {
            int quantidade = 0;
            try
            {
                // Connect to the ProductsModel database
                using (ProvedorEstoque database = new ProvedorEstoque())
                {
                    // Calculate the sum of all quantities for the specified product
                    quantidade = (from p in database.ProdutoEstoques
                                     where String.Compare(p.NumeroProduto, NumeroProduto) == 0
                                     select (int)p.EstoqueProduto).Sum();
                }
            }
            catch
            {
                // Ignore exceptions in this implementation
            }
            return quantidade;
        }

        public bool AdicionarProduto(string NumeroProduto, int quantidade)
        {
            try
            {
                // Connect to the ProductsModel database
                using (ProvedorEstoque database = new ProvedorEstoque())
                {
                    ProdutoEstoque produtoEstoque = database.ProdutoEstoques.First(pi => pi.NumeroProduto == NumeroProduto);
                    produtoEstoque.EstoqueProduto = produtoEstoque.EstoqueProduto + quantidade;
                    // Save the change back to the database
                    database.SaveChanges();

                }
            }
            catch
            {
                // If an exception occurs, return false to indicate failure
                return false;
            }
            return true;
        }

        public bool RemoverEstoque(string NumeroProduto, int quantidade)
        {
            try
            {
                // Connect to the ProductsModel database
                using (ProvedorEstoque database = new ProvedorEstoque())
                {
                    // Find the first product that matches the specified product code
                 
                   ProdutoEstoque produtoEstoque = database.ProdutoEstoques.First(pi => pi.NumeroProduto == NumeroProduto);
                    database.ProdutoEstoques.Remove(produtoEstoque);
                    // Save the change back to the database
                    database.SaveChanges();

                }
            }
            catch
            {
                // If an exception occurs, return false to indicate failure
                return false;
            }

            return true;
        }

        public ProdutoEstoqueData VerProduto(string NumeroProduto)
        {
            ProdutoEstoqueData productData = null;
            try
            {
                
                using (ProvedorEstoque database = new ProvedorEstoque())
                {
                    // Find the first product that matches the specified product code
                    ProdutoEstoque productEstoque = database.ProdutoEstoques.First(
                    p => String.Compare(p.NumeroProduto, NumeroProduto) == 0);
                    productData = new ProdutoEstoqueData()
                    {
                        NumeroProduto = productEstoque.NumeroProduto,
                        NomeProduto = productEstoque.NomeProduto,
                        DescricaoProduto = productEstoque.DescricaoProduto,
                        EstoqueProduto = productEstoque.EstoqueProduto
                    };
                }
            }
            catch
            {
                // Ignore exceptions in this implementation
            }
            // Return the product
            return productData;
        }


    }
}

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.

