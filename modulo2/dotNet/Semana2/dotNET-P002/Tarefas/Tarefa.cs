namespace Tarefas;
public class Tarefa{
    private static List<Tarefa> listaTarefas = new List<Tarefa>();
    private static int proxID = 1;
    public int Id{get;}
    public string Titulo{get; set;}
    public string Descricao{get; set;}
    public DateTime Data{get; set;}
    public bool Status{get; set;}

    public Tarefa(string _titulo, string _desc, DateTime _data){
        Id = proxID++;
        Titulo = _titulo;
        Descricao = _desc;
        Data = _data;
        Status = false;
    }

    public override string ToString(){
        string texto = "[";
        texto = this.Status ? texto + "x" : texto + " ";
        texto = texto + "], ID: " + this.Id + ", Titulo: " + this.Titulo
                + ", Descrição: " + this.Descricao + ", Vencimento: "
                + this.Data.ToShortDateString();
        return texto;
    }

    static void cxMsg(string texto){
        Console.Clear();
        Console.WriteLine(texto);
        Console.ReadLine();
        Console.Clear();
    }

    public static void novaTarefa(){
        string? titulo , desc, s;
        DateTime data;
        Console.Clear();
        do{
            Console.Write("Digite o título da tarefa: ");
            titulo = Console.ReadLine();
        }while(titulo == null);
        do{
            Console.Write("Digite a descrição da tarefa: ");
            desc = Console.ReadLine();
        }while(desc == null);
        do{
            Console.Write("Digite a data de vencimento (formato: dd/mm/aaaa): ");
            s = Console.ReadLine();
        }while(s == null);
        data = DateTime.Parse(s);
        
        Tarefa nova = new(titulo, desc, data);
        listaTarefas.Add(nova);
        cxMsg("Nova Tarefa Adicionada com Sucesso!");
    }

    public static void listarTarefas(){
        Console.Clear();
        Console.WriteLine("===== Todas as Tarefas =====");
        foreach (var item in listaTarefas.Where(Tarefa => !Tarefa.Status)){
            Console.WriteLine(item);
            Console.WriteLine("================================");
        }
        foreach (var item in listaTarefas.Where(Tarefa => Tarefa.Status)){
            Console.WriteLine(item);
            Console.WriteLine("================================");
        }
        Console.ReadLine();
    }

    public static void tarefaConcluida(){
        int? id;
        string? s;
        Console.Clear();
        Console.Write("Digite o ID da tarefa que deseja marcar como concluída: ");
        s = Console.ReadLine();
        if(s == null)
            return;
        id = int.Parse(s);

        Tarefa? concluida = listaTarefas.FirstOrDefault(Tarefa => Tarefa.Id == id);

        if(concluida == null){
            cxMsg("Tarefa não encontrada!");
            return;
        }

        if(concluida.Status){
            cxMsg("Tarefa já concluída!");
            return;
        }
        
        concluida.Status = true;
        cxMsg("Tarefa marcada como concluída!");
    }

    public static void excluirTarefa(){
        int id;
        string? s;
        Console.Clear();
        Console.Write("Digite o ID da tarefa que deseja excluir: ");
        s = Console.ReadLine();
        if(s == null)
            return;
        id = int.Parse(s);

        Tarefa? apagar = listaTarefas.FirstOrDefault(Tarefa => Tarefa.Id == id);

        if(apagar == null){
            cxMsg("Tarefa não encontrada!");
            return;
        }

        listaTarefas.Remove(apagar);
        cxMsg("Tarefa excluída com sucesso!");
    }

    public static void pesquisarTarefa(){
        string? palavra;
        Console.Clear();
        do{
            Console.Clear();
            Console.Write("Digite uma palavra-chave para pesquisar: ");
            palavra = Console.ReadLine();
        }while(palavra == null);

        var encontradas = listaTarefas.Where(Tarefa => 
            Tarefa.Titulo.Contains(palavra, StringComparison.OrdinalIgnoreCase) ||
            Tarefa.Descricao.Contains(palavra, StringComparison.OrdinalIgnoreCase)
        );

        if(encontradas.Count() == 0){
            cxMsg("Nenhuma tarefa encontrada com a palavra-chave!");
            return;
        }

        Console.WriteLine("===== Resultados da Pesquisa =====");
        foreach(var item in encontradas.Where(Tarefa => !Tarefa.Status)){
            Console.WriteLine(item);
            Console.WriteLine("================================");
        }
        foreach(var item in encontradas.Where(Tarefa => Tarefa.Status)){
            Console.WriteLine(item);
            Console.WriteLine("================================");
        }
        Console.ReadLine();
    }

    public static void estatisticas(){
        Console.Clear();
        int tarefasTotais = listaTarefas.Count();
        int tarefasConcluida = listaTarefas.Count(Tarefa => Tarefa.Status);
        int tarefasPendentes = listaTarefas.Count(Tarefa => !Tarefa.Status);
        DateTime tarefaAntiga = listaTarefas.Min(Tarefa => Tarefa.Data);
        DateTime tarefaNova = listaTarefas.Max(Tarefa => Tarefa.Data);

        Console.WriteLine("Total de Tarefas: " + tarefasTotais);
        Console.WriteLine("Tarefas Concluídas: " + tarefasConcluida);
        Console.WriteLine("Tarefas Pendentes: " + tarefasPendentes);
        Console.WriteLine("Tarefa Mais Antiga: " + tarefaAntiga.ToShortDateString());
        Console.WriteLine("Tarefa Mais Nova: " + tarefaNova.ToShortDateString());
        Console.ReadLine();
    }
}
