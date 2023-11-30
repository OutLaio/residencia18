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

    public static void ExibirRelatorioPessoa(string titulo, IEnumerable<Pessoa> relatorio){
        Console.WriteLine(titulo);
        foreach (var item in relatorio){
            Console.WriteLine($"{item.Nome} - CPF: {item.CPF} - Dia do aniversário: {item.DtNasc.Day}");
        }
    }

    public static void AdvogadosPorIdade(int min, int max){
        List<Advogado> advogados = Lista.pessoas.OfType<Advogado>().ToList();
        var relatorio = advogados.Where(a => a.Idade >= min && a.Idade <= max);
        ExibirRelatorioAdvogado($"Advogados com idade entre {min} e {max} anos:", relatorio);
    }

    public static void ClientesPorIdade(int min, int max){
        List<Cliente> clientes = Lista.pessoas.OfType<Cliente>().ToList();
        var relatorio = clientes.Where(c => c.Idade >= min && c.Idade <= max);
        ExibirRelatorioCliente($"Clientes com idade entre {min} e {max} anos:", relatorio);
    }

    public static void ClientesPorEstadoCivil(string estadoCivil){
        List<Cliente> clientes = Lista.pessoas.OfType<Cliente>().ToList();
        var relatorio = clientes.Where(c => c.EstadoCivil.Equals(estadoCivil, StringComparison.OrdinalIgnoreCase));
        ExibirRelatorioCliente($"Clientes com estado civil {estadoCivil}:", relatorio);
    }

    public static void ClientesEmOrdemAlfabetica(){
        List<Cliente> clientes = Lista.pessoas.OfType<Cliente>().ToList();
        var relatorio = clientes.OrderBy(c => c.Nome);
        ExibirRelatorioCliente("Clientes em ordem alfabética:", relatorio);
    }

    public static void ClientesPorProfissao(string texto){
        List<Cliente> clientes = Lista.pessoas.OfType<Cliente>().ToList();
        var relatorio = clientes.Where(c => c.Profissao.Contains(texto, StringComparison.OrdinalIgnoreCase));
        ExibirRelatorioCliente($"Clientes cuja profissão contém \"{texto}\":", relatorio);
    }

    public static void AniversariantesDoMes(int mes){
        var relatorio = Lista.pessoas.Where(a => a.DtNasc.Month == mes);
        ExibirRelatorioPessoa($"Advogados aniversariantes do mês {mes}:", relatorio);
    }



}
