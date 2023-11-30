namespace Exercicio;
public class Veiculo{
    private string _modelo {set; get;}
    private int _ano {set; get;}
    private string _cor {set; get;}

    public Veiculo(string modelo, int ano, string cor){
        this._modelo = modelo;
        this._ano = ano;
        this._cor = cor;
    }

    public string Modelo {get {return _modelo;}}
    public int Ano {get {return _ano;}}
    public string Cor {get {return _cor;}}
    public int IdadeVeiculo{
        get {
            DateTime hoje = DateTime.Now;
            return hoje.Year - _ano;
        }
    }
}
