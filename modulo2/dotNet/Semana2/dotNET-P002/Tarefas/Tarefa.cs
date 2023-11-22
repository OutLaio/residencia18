namespace Tarefas;
public class Tarefa{
    private static List<Tarefa> listaTarefas = new List<Tarefa>();
    private static int proxID = 1;
    private int Id;
    private string Titulo;
    private string Descricao;
    private DateTime Data;
    private bool Status;

    public Tarefa(string _titulo, string _desc, DateTime _data){
        Id = proxID++;
        Titulo = _titulo;
        Descricao = _desc;
        Data = _data;
        Status = false;
    }

    

}
