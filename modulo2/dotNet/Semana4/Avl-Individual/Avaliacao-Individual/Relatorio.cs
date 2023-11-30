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

    public static void ClientesPorIdade(int min, int max){
        var relatorio = ListaClientes.clientes.Where(c => c.Idade >= min && c.Idade <= max);
        ExibirRelatorioCliente($"Clientes com idade entre {min} e {max} anos:", relatorio);
    }

    public static void ClientesPorEstadoCivil(string estadoCivil){
        var relatorio = ListaClientes.clientes.Where(c => c.EstadoCivil.Equals(estadoCivil, StringComparison.OrdinalIgnoreCase));
        ExibirRelatorioCliente($"Clientes com estado civil {estadoCivil}:", relatorio);
    }

    public static void ClientesEmOrdemAlfabetica(){
        var relatorio = ListaClientes.clientes.OrderBy(c => c.Nome);
        ExibirRelatorioCliente("Clientes em ordem alfabética:", relatorio);
    }

    public static void ClientesPorProfissao(string texto){
        var relatorio = ListaClientes.clientes.Where(c => c.Profissao.Contains(texto, StringComparison.OrdinalIgnoreCase));
        ExibirRelatorioCliente($"Clientes cuja profissão contém \"{texto}\":", relatorio);
    }

    public static void AniversariantesDoMes(int mes){
        var advogadosRelatorio = ListaAdvogados.advogados.Where(a => a.DtNasc.Month == mes);
        ExibirRelatorioAdvogado($"Advogados aniversariantes do mês {mes}:", advogadosRelatorio);

        var clientesRelatorio = ListaClientes.clientes.Where(c => c.DtNasc.Month == mes);
        ExibirRelatorioCliente($"Clientes aniversariantes do mês {mes}:", clientesRelatorio);
    }



}
