namespace Exercicio;
public static class App{
    public static void Main(){
        Veiculo meu = new("HB20", 2015, "Branco");
        Console.WriteLine(meu.Modelo);
        Console.WriteLine(meu.IdadeVeiculo + " anos");
    }
}
