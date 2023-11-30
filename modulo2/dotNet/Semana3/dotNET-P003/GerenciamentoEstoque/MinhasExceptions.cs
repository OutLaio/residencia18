namespace GerenciamentoEstoque;

class ProdutoNaoEncontradoException : Exception{
    public ProdutoNaoEncontradoException(string message) : base(message){}
}

class QuantidadeInsuficienteException : Exception{
    public QuantidadeInsuficienteException(string message) : base(message){}
}