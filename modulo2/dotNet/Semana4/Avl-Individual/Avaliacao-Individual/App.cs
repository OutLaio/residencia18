using System;
using System.Globalization;
namespace Avaliacao;

public static class App{
    public static void Main(){

    }

    static DateTime ConverterStringParaDateTime(string dataString){
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
