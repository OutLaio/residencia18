namespace Avaliacao;
public static class ListaAdvogados{
    public static List<Advogado> advogados = new List<Advogado>();

    public static void AdicionarAdvogado(string nome, string dtNasc, string cpf, string cna){
        
        if(!Pessoa.ValidaCPF(cpf)){
            Console.WriteLine("CPF inválido!");
            return;
        }
        
        advogados.Add(advogado);
    }


}
