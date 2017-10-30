using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Servico
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
    [ServiceContract(Namespace = "http://projetoavaliativo.dm113/01")]
    public interface IServicoEstoque
    {
        // Get all products
        [OperationContract]
        List<String> ListarProdutos();

        [OperationContract]
        bool IncluirProduto(ProdutoEstoqueData produto);

        [OperationContract]
        bool RemoverProduto(string NumeroProduto);

        [OperationContract]
        int ConsultarEstoque(string NumeroProduto);

        [OperationContract]
        bool AdicionarEstoque(string NumeroProduto, int quantidade);

        [OperationContract]
        bool RemoverEstoque(string NumeroProduto, int quantidade);

        [OperationContract]
        ProdutoEstoqueData VerProduto(string NumeroProduto);

        // TODO: Add your service operations here
    }

    [ServiceContract(Namespace = "http://projetoavaliativo.dm113/02")]
    public interface IServicoEstoqueV2
    {
        [OperationContract]
        bool AdicionarEstoque(string NumeroProduto, int quantidade);

        [OperationContract]
        bool RemoverEstoque(string NumeroProduto, int quantidade);

        [OperationContract]
        ProdutoEstoqueData VerProduto(string NumeroProduto);
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class ProdutoEstoqueData
    {

        [DataMember]
        public string NumeroProduto;
        [DataMember]
        public string NomeProduto;
        [DataMember]
        public string DescricaoProduto;
        [DataMember]
        public int EstoqueProduto;


    }
}
    

