namespace Avaliacao;
public static class Relatorio{

    public static void ExibirRelatorioAdvogado(string titulo, IEnumerable<Advogado> relatorio){
        Console.WriteLine(titulo);
        foreach (var item in relatorio){
            Console.WriteLine($"{item.Nome} - CPF: {item.CPF} - CNA: {item.CNA}");
        }
    }

    public static void ExibirRelatorioCliente(string titulo, IEnumerable<Cliente> relatorio){
        Console.WriteLine(titulo);
        foreach (var item in relatorio){
            Console.WriteLine($"{item.Nome} - CPF: {item.CPF} - Profissão: {item.Profissao}");
        }
    }

    public static void AdvogadosPorIdade(int min, int max){
        var relatorio = ListaAdvogados.advogados.Where(a => a.Idade >= min && a.Idade <= max);
        ExibirRelatorioAdvogado($"Advogados com idade entre {min} e {max} anos:", relatorio);
    }

}
