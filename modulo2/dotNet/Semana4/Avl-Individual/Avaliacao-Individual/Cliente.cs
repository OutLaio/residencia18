namespace Avaliacao;
public class Cliente : Pessoa{
    private string _estadoCivil { get; set; }
    private string _profissao { get; set; }

    public Cliente(string nome, DateTime dtNasc, string cpf, string estadoCivil, string profissao) : base(nome, dtNasc, cpf){
        _estadoCivil = estadoCivil;
        _profissao = profissao;
    }

    public string EstadoCivil { get{return _estadoCivil;} set{ _estadoCivil = value;} }

    public string Profissao { get{}}
}
