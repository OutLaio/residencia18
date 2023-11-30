namespace Avaliacao;

public class Advogado : Pessoa{
    private string _cna { get; }

    public Advogado(string nome, DateTime dtNasc, string cpf, string cna) : base(nome, dtNasc, cpf){
        _cna = nome;
    }

    public string CNA { get{ return _cna;}}
}
