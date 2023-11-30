namespace Avaliacao;
public static class ListaAdvogados{
    public static List<Advogado> advogados = new List<Advogado>();

    public static void AdicionarAdvogado(string nome, string dtNasc, string cpf, string cna){
        if(!Pessoa.ValidaCPF(cpf)){
            Console.WriteLine("CPF inválido!");
            return;
        }
        
        if(hasAdvogado(cpf, cna)){
            Console.WriteLine("Advogado já cadastrado!");
            return;
        }

        Advogado novo = new(nome, App.ConverterStringParaDateTime(dtNasc), cpf, cna);
        advogados.Add(novo);
        Console.WriteLine("Advogado adicionado com sucesso!");
    }

    public static bool hasAdvogado(string cpf, string cna){
        return advogados.Any(x => x.CPF.Equals(cpf, StringComparison.OrdinalIgnoreCase) || x.CNA.Equals(cna, StringComparison.OrdinalIgnoreCase));
    }

}

public static class ListaClientes{
    public static List<Cliente> clientes = new List<Cliente>();

    public static void AdicionarCliente(string nome, string dtNasc, string cpf, string estadoCivil, string profissao){
        if(!Pessoa.ValidaCPF(cpf)){
            Console.WriteLine("CPF inválido!");
            return;
        }
        
        if(hasCliente(cpf)){
            Console.WriteLine("Cliente já cadastrado!");
            return;
        }

        Cliente novo = new(nome, App.ConverterStringParaDateTime(dtNasc), cpf, estadoCivil, profissao);
        clientes.Add(novo);
        Console.WriteLine("Cliente adicionado com sucesso!");
    }

    public static bool hasCliente(string cpf){
        return clientes.Any(x => x.CPF.Equals(cpf, StringComparison.OrdinalIgnoreCase));
    }

}
