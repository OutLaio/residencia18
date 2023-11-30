namespace Avaliacao;
public static class Lista{
    public static List<Pessoa> pessoas = new List<Pessoa>();

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
        pessoas.Add(novo);
        Console.WriteLine("Advogado adicionado com sucesso!");
    }

    public static bool hasAdvogado(string cpf, string cna){
        List<Advogado> advogados = pessoas.OfType<Advogado>().ToList();
        return advogados.Any(x => x.CPF == cpf || x.CNA == cna);
    }

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
        pessoas.Add(novo);
        Console.WriteLine("Cliente adicionado com sucesso!");
    }

    public static bool hasCliente(string cpf){
        List<Cliente> clientes = pessoas.OfType<Cliente>().ToList();
        return clientes.Any(x => x.CPF.Equals(cpf, StringComparison.OrdinalIgnoreCase));
    }

}
