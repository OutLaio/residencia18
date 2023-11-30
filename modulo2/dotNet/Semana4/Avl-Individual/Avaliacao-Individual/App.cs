using System.Globalization;
namespace Avaliacao;

public static class App{
    public static void Main(){
        Lista.AdicionarAdvogado("Laio", "06/01/2000", "12345678910", "557");
        Lista.AdicionarCliente("Laio", "06/01/2000", "98282697652", "Solteiro", "Engenheiro Civil");
        Lista.AdicionarAdvogado("Andre", "13/04/2001", "01234567890", "512");
        Lista.AdicionarCliente("Laio", "06/01/2000", "09867366812", "Solteiro", "Engenheiro Eletricista");
        Lista.AdicionarAdvogado("Joao", "28/03/1999", "11122233344", "532");
        Lista.AdicionarCliente("Laio", "06/01/2000", "12418761234", "Solteiro", "Engenheiro Mecânico");
        Lista.AdicionarAdvogado("Matheus", "10/03/2001", "78945612301", "548");

        Relatorio.AdvogadosPorIdade(18, 35);
        Relatorio.ClientesPorIdade(18, 35);
        Relatorio.ClientesPorEstadoCivil("Solteiro");
        Relatorio.ClientesEmOrdemAlfabetica();
        Relatorio.ClientesPorProfissao("Engenheiro");
        Relatorio.AniversariantesDoMes(3);
    }

    public static DateTime ConverterStringParaDateTime(string dataString){
        string formato = "dd/MM/yyyy";

        if (DateTime.TryParseExact(dataString, formato, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime resultado)){
            return resultado;
        }
        else{
            Console.WriteLine("Formato de data inválido!");
            return DateTime.MinValue; 
        }
    }
}
