namespace Display;

using Tarefas;
public static class Menu{
    public static void menuPrincipal(string op){
        switch (op){
                case "1":
                    
                    break;
                case "2":

                    break;
                case "3":

                    break;
                case "4":

                    break;
                case "5":

                    break;
                case "6":

                    break;
                case "7":

                    break;
                default:
                    break;
            }
    }

    public static void dispMenuPrincipal(){
        Console.Clear();
        Console.WriteLine("===== Sistema de Gerenciamento de Tarefas =====");
        Console.WriteLine("1. Adicionar Tarefa");
        Console.WriteLine("2. Listar Todas as Tarefas");
        Console.WriteLine("3. Marcar Tarefa como Concluída");
        Console.WriteLine("4. Listar Tarefas Pendentes");
        Console.WriteLine("5. Listar Tarefas Concluídas");
        Console.WriteLine("6. Excluir Tarefa");
        Console.WriteLine("7. Pesquisar Tarefas por Palavra-chave");
        Console.WriteLine("8. Estatísticas");
        Console.WriteLine("9. Sair");
        Console.WriteLine("");
        Console.Write("Escolha uma opção: ");
    }




}
