using System.Globalization;
namespace Avaliacao;

public static class App{
    public static void Main(){
        Lista.AdicionarAdvogado("Laio", "06/01/2000", "12345678910", "557");
        Lista.AdicionarAdvogado("Andre", "13/04/2001", "01234567890", "557");
        Lista.AdicionarAdvogado("Joao", "28/03/1999", "11122233344", "557");
        Lista.AdicionarAdvogado("Matheus", "10/03/2001", "78945612301", "557");
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
