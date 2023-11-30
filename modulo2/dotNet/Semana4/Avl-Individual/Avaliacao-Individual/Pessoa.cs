namespace Avaliacao;

public abstract class Pessoa{
    private string _nome { get; }
    private DateTime _dtNasc { get; }
    private string _cpf { get; } 

    public Pessoa(string nome, DateTime dtNasc, string cpf){
        _nome = nome;
        _dtNasc = dtNasc;
        _cpf = cpf;
    }

    public string Nome { get{ return _nome; }}

    public DateTime DtNasc { get{return _dtNasc; }}

    public string CPF { get{return _cpf;}}

    public int Idade { 
        get{ 
            DateTime temp = DateTime.Now.AddYears(-this._dtNasc.Year);
            
        }
    }
}
