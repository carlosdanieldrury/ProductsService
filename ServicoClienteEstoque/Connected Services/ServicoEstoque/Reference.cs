﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServicoClienteEstoque.ServicoEstoque {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://projetoavaliativo.dm113/01", ConfigurationName="ServicoEstoque.IServicoEstoque")]
    public interface IServicoEstoque {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IServicoEstoque/ListarProdutos", ReplyAction="http://projetoavaliativo.dm113/01/IServicoEstoque/ListarProdutosResponse")]
        string[] ListarProdutos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IServicoEstoque/ListarProdutos", ReplyAction="http://projetoavaliativo.dm113/01/IServicoEstoque/ListarProdutosResponse")]
        System.Threading.Tasks.Task<string[]> ListarProdutosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IServicoEstoque/IncluirProduto", ReplyAction="http://projetoavaliativo.dm113/01/IServicoEstoque/IncluirProdutoResponse")]
        bool IncluirProduto(Servico.ProdutoEstoqueData produto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IServicoEstoque/IncluirProduto", ReplyAction="http://projetoavaliativo.dm113/01/IServicoEstoque/IncluirProdutoResponse")]
        System.Threading.Tasks.Task<bool> IncluirProdutoAsync(Servico.ProdutoEstoqueData produto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IServicoEstoque/RemoverProduto", ReplyAction="http://projetoavaliativo.dm113/01/IServicoEstoque/RemoverProdutoResponse")]
        bool RemoverProduto(string NumeroProduto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IServicoEstoque/RemoverProduto", ReplyAction="http://projetoavaliativo.dm113/01/IServicoEstoque/RemoverProdutoResponse")]
        System.Threading.Tasks.Task<bool> RemoverProdutoAsync(string NumeroProduto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IServicoEstoque/ConsultarEstoque", ReplyAction="http://projetoavaliativo.dm113/01/IServicoEstoque/ConsultarEstoqueResponse")]
        int ConsultarEstoque(string NumeroProduto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IServicoEstoque/ConsultarEstoque", ReplyAction="http://projetoavaliativo.dm113/01/IServicoEstoque/ConsultarEstoqueResponse")]
        System.Threading.Tasks.Task<int> ConsultarEstoqueAsync(string NumeroProduto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IServicoEstoque/AdicionarEstoque", ReplyAction="http://projetoavaliativo.dm113/01/IServicoEstoque/AdicionarEstoqueResponse")]
        bool AdicionarEstoque(string NumeroProduto, int quantidade);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IServicoEstoque/AdicionarEstoque", ReplyAction="http://projetoavaliativo.dm113/01/IServicoEstoque/AdicionarEstoqueResponse")]
        System.Threading.Tasks.Task<bool> AdicionarEstoqueAsync(string NumeroProduto, int quantidade);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IServicoEstoque/RemoverEstoque", ReplyAction="http://projetoavaliativo.dm113/01/IServicoEstoque/RemoverEstoqueResponse")]
        bool RemoverEstoque(string NumeroProduto, int quantidade);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IServicoEstoque/RemoverEstoque", ReplyAction="http://projetoavaliativo.dm113/01/IServicoEstoque/RemoverEstoqueResponse")]
        System.Threading.Tasks.Task<bool> RemoverEstoqueAsync(string NumeroProduto, int quantidade);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IServicoEstoque/VerProduto", ReplyAction="http://projetoavaliativo.dm113/01/IServicoEstoque/VerProdutoResponse")]
        Servico.ProdutoEstoqueData VerProduto(string NumeroProduto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IServicoEstoque/VerProduto", ReplyAction="http://projetoavaliativo.dm113/01/IServicoEstoque/VerProdutoResponse")]
        System.Threading.Tasks.Task<Servico.ProdutoEstoqueData> VerProdutoAsync(string NumeroProduto);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicoEstoqueChannel : ServicoClienteEstoque.ServicoEstoque.IServicoEstoque, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicoEstoqueClient : System.ServiceModel.ClientBase<ServicoClienteEstoque.ServicoEstoque.IServicoEstoque>, ServicoClienteEstoque.ServicoEstoque.IServicoEstoque {
        
        public ServicoEstoqueClient() {
        }
        
        public ServicoEstoqueClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicoEstoqueClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicoEstoqueClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicoEstoqueClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string[] ListarProdutos() {
            return base.Channel.ListarProdutos();
        }
        
        public System.Threading.Tasks.Task<string[]> ListarProdutosAsync() {
            return base.Channel.ListarProdutosAsync();
        }
        
        public bool IncluirProduto(Servico.ProdutoEstoqueData produto) {
            return base.Channel.IncluirProduto(produto);
        }
        
        public System.Threading.Tasks.Task<bool> IncluirProdutoAsync(Servico.ProdutoEstoqueData produto) {
            return base.Channel.IncluirProdutoAsync(produto);
        }
        
        public bool RemoverProduto(string NumeroProduto) {
            return base.Channel.RemoverProduto(NumeroProduto);
        }
        
        public System.Threading.Tasks.Task<bool> RemoverProdutoAsync(string NumeroProduto) {
            return base.Channel.RemoverProdutoAsync(NumeroProduto);
        }
        
        public int ConsultarEstoque(string NumeroProduto) {
            return base.Channel.ConsultarEstoque(NumeroProduto);
        }
        
        public System.Threading.Tasks.Task<int> ConsultarEstoqueAsync(string NumeroProduto) {
            return base.Channel.ConsultarEstoqueAsync(NumeroProduto);
        }
        
        public bool AdicionarEstoque(string NumeroProduto, int quantidade) {
            return base.Channel.AdicionarEstoque(NumeroProduto, quantidade);
        }
        
        public System.Threading.Tasks.Task<bool> AdicionarEstoqueAsync(string NumeroProduto, int quantidade) {
            return base.Channel.AdicionarEstoqueAsync(NumeroProduto, quantidade);
        }
        
        public bool RemoverEstoque(string NumeroProduto, int quantidade) {
            return base.Channel.RemoverEstoque(NumeroProduto, quantidade);
        }
        
        public System.Threading.Tasks.Task<bool> RemoverEstoqueAsync(string NumeroProduto, int quantidade) {
            return base.Channel.RemoverEstoqueAsync(NumeroProduto, quantidade);
        }
        
        public Servico.ProdutoEstoqueData VerProduto(string NumeroProduto) {
            return base.Channel.VerProduto(NumeroProduto);
        }
        
        public System.Threading.Tasks.Task<Servico.ProdutoEstoqueData> VerProdutoAsync(string NumeroProduto) {
            return base.Channel.VerProdutoAsync(NumeroProduto);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://projetoavaliativo.dm113/02", ConfigurationName="ServicoEstoque.IServicoEstoqueV2")]
    public interface IServicoEstoqueV2 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/02/IServicoEstoqueV2/AdicionarEstoque", ReplyAction="http://projetoavaliativo.dm113/02/IServicoEstoqueV2/AdicionarEstoqueResponse")]
        bool AdicionarEstoque(string NumeroProduto, int quantidade);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/02/IServicoEstoqueV2/AdicionarEstoque", ReplyAction="http://projetoavaliativo.dm113/02/IServicoEstoqueV2/AdicionarEstoqueResponse")]
        System.Threading.Tasks.Task<bool> AdicionarEstoqueAsync(string NumeroProduto, int quantidade);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/02/IServicoEstoqueV2/RemoverEstoque", ReplyAction="http://projetoavaliativo.dm113/02/IServicoEstoqueV2/RemoverEstoqueResponse")]
        bool RemoverEstoque(string NumeroProduto, int quantidade);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/02/IServicoEstoqueV2/RemoverEstoque", ReplyAction="http://projetoavaliativo.dm113/02/IServicoEstoqueV2/RemoverEstoqueResponse")]
        System.Threading.Tasks.Task<bool> RemoverEstoqueAsync(string NumeroProduto, int quantidade);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/02/IServicoEstoqueV2/VerProduto", ReplyAction="http://projetoavaliativo.dm113/02/IServicoEstoqueV2/VerProdutoResponse")]
        Servico.ProdutoEstoqueData VerProduto(string NumeroProduto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/02/IServicoEstoqueV2/VerProduto", ReplyAction="http://projetoavaliativo.dm113/02/IServicoEstoqueV2/VerProdutoResponse")]
        System.Threading.Tasks.Task<Servico.ProdutoEstoqueData> VerProdutoAsync(string NumeroProduto);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicoEstoqueV2Channel : ServicoClienteEstoque.ServicoEstoque.IServicoEstoqueV2, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicoEstoqueV2Client : System.ServiceModel.ClientBase<ServicoClienteEstoque.ServicoEstoque.IServicoEstoqueV2>, ServicoClienteEstoque.ServicoEstoque.IServicoEstoqueV2 {
        
        public ServicoEstoqueV2Client() {
        }
        
        public ServicoEstoqueV2Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicoEstoqueV2Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicoEstoqueV2Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicoEstoqueV2Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool AdicionarEstoque(string NumeroProduto, int quantidade) {
            return base.Channel.AdicionarEstoque(NumeroProduto, quantidade);
        }
        
        public System.Threading.Tasks.Task<bool> AdicionarEstoqueAsync(string NumeroProduto, int quantidade) {
            return base.Channel.AdicionarEstoqueAsync(NumeroProduto, quantidade);
        }
        
        public bool RemoverEstoque(string NumeroProduto, int quantidade) {
            return base.Channel.RemoverEstoque(NumeroProduto, quantidade);
        }
        
        public System.Threading.Tasks.Task<bool> RemoverEstoqueAsync(string NumeroProduto, int quantidade) {
            return base.Channel.RemoverEstoqueAsync(NumeroProduto, quantidade);
        }
        
        public Servico.ProdutoEstoqueData VerProduto(string NumeroProduto) {
            return base.Channel.VerProduto(NumeroProduto);
        }
        
        public System.Threading.Tasks.Task<Servico.ProdutoEstoqueData> VerProdutoAsync(string NumeroProduto) {
            return base.Channel.VerProdutoAsync(NumeroProduto);
        }
    }
}
