namespace Avaliacao;
public static class Relatorio{

    public static void ExibirRelatorioAdvogado(string titulo, IEnumerable<Advogado> relatorio){
        Console.WriteLine(titulo);
        foreach (var item in relatorio){
            Console.WriteLine($"");
        }
    }

    public static void ExibirRelatorioCliente(string titulo, IEnumerable<Cliente> relatorio){
        Console.WriteLine(titulo);
        foreach (var item in relatorio){
            Console.WriteLine($"");
        }
    }

    public static void porIdade(int idade){
        var relatorio1 = ListaAdvogados.advogados.Where(a => a.Idade >= idade);
    }
}
