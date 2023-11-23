namespace Display;

using Tarefas;
public static class Menu{
    public static void menuPrincipal(string op){
        switch (op){
                case "1":
                    Tarefa.novaTarefa();
                    Console.Clear();
                    break;
                case "2":
                    Tarefa.listarTarefas();
                    Console.Clear();
                    break;
                case "3":
                    Tarefa.tarefaConcluida();
                    Console.Clear();
                    break;
                case "4":
                    Tarefa.excluirTarefa();
                    Console.Clear();
                    break;
                case "5":
                    Tarefa.pesquisarTarefa();
                    Console.Clear();
                    break;
                case "6":
                    Tarefa.estatisticas();
                    Console.Clear();
                    break;
                case "7":
                    break;
                default:
                    Console.WriteLine("Opção Inválida!");
                    break;
            }
    }

    public static void dispMenuPrincipal(){
        Console.WriteLine("===== Sistema de Gerenciamento de Tarefas =====");
        Console.WriteLine("1. Adicionar Tarefa");
        Console.WriteLine("2. Listar Todas as Tarefas");
        Console.WriteLine("3. Marcar Tarefa como Concluída");
        Console.WriteLine("4. Excluir Tarefa");
        Console.WriteLine("5. Pesquisar Tarefas por Palavra-chave");
        Console.WriteLine("6. Estatísticas");
        Console.WriteLine("7. Sair");
        Console.WriteLine("");
        Console.Write("Escolha uma opção: ");
    }




}
