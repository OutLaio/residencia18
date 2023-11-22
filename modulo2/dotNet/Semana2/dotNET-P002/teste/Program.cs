// using System;
// using System.Collections.Generic;
// using System.Linq;

class Program
{
    static List<TaskItem> tasks = new List<TaskItem>();

    static void Main()
    {
        while (true)
        {
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

            Console.Write("Escolha uma opção: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddTask();
                    break;
                case "2":
                    ListAllTasks();
                    break;
                case "3":
                    MarkTaskAsCompleted();
                    break;
                case "4":
                    ListPendingTasks();
                    break;
                case "5":
                    ListCompletedTasks();
                    break;
                case "6":
                    DeleteTask();
                    break;
                case "7":
                    SearchTasks();
                    break;
                case "8":
                    ShowStatistics();
                    break;
                case "9":
                    Environment.Exit(0);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }

    static void AddTask()
    {
        Console.Write("Digite o título da tarefa: ");
        string title = Console.ReadLine();
        Console.Write("Digite a descrição da tarefa: ");
        string description = Console.ReadLine();
        Console.Write("Digite a data de vencimento (formato: yyyy-MM-dd): ");
        DateTime dueDate = DateTime.Parse(Console.ReadLine());

        TaskItem newTask = new TaskItem
        {
            Title = title,
            Description = description,
            DueDate = dueDate
        };

        tasks.Add(newTask);
        Console.WriteLine("Tarefa adicionada com sucesso!");
    }

    static void ListAllTasks()
    {
        Console.WriteLine("===== Todas as Tarefas =====");
        foreach (var task in tasks)
        {
            Console.WriteLine(task);
        }
    }

    static void MarkTaskAsCompleted()
    {
        Console.Write("Digite o ID da tarefa que deseja marcar como concluída: ");
        int taskId = int.Parse(Console.ReadLine());

        TaskItem taskToMark = tasks.FirstOrDefault(task => task.Id == taskId);

        if (taskToMark != null)
        {
            taskToMark.Completed = true;
            Console.WriteLine("Tarefa marcada como concluída!");
        }
        else
        {
            Console.WriteLine("Tarefa não encontrada.");
        }
    }

    static void ListPendingTasks()
    {
        Console.WriteLine("===== Tarefas Pendentes =====");
        foreach (var task in tasks.Where(task => !task.Completed))
        {
            Console.WriteLine(task);
        }
    }

    static void ListCompletedTasks()
    {
        Console.WriteLine("===== Tarefas Concluídas =====");
        foreach (var task in tasks.Where(task => task.Completed))
        {
            Console.WriteLine(task);
        }
    }

    static void DeleteTask()
    {
        Console.Write("Digite o ID da tarefa que deseja excluir: ");
        int taskId = int.Parse(Console.ReadLine());

        TaskItem taskToDelete = tasks.FirstOrDefault(task => task.Id == taskId);

        if (taskToDelete != null)
        {
            tasks.Remove(taskToDelete);
            Console.WriteLine("Tarefa excluída com sucesso!");
        }
        else
        {
            Console.WriteLine("Tarefa não encontrada.");
        }
    }

    static void SearchTasks()
    {
        Console.Write("Digite uma palavra-chave para pesquisar: ");
        string keyword = Console.ReadLine();

        var matchingTasks = tasks.Where(task =>
            task.Title.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
            task.Description.Contains(keyword, StringComparison.OrdinalIgnoreCase)
        );

        Console.WriteLine("===== Resultados da Pesquisa =====");
        foreach (var task in matchingTasks)
        {
            Console.WriteLine(task);
        }
    }

    static void ShowStatistics()
    {
        int totalTasks = tasks.Count;
        int completedTasks = tasks.Count(task => task.Completed);
        int pendingTasks = tasks.Count(task => !task.Completed);
        DateTime oldestTask = tasks.Min(task => task.DueDate);
        DateTime newestTask = tasks.Max(task => task.DueDate);

        Console.WriteLine($"Total de Tarefas: {totalTasks}");
        Console.WriteLine($"Tarefas Concluídas: {completedTasks}");
        Console.WriteLine($"Tarefas Pendentes: {pendingTasks}");
        Console.WriteLine($"Tarefa Mais Antiga: {oldestTask:yyyy-MM-dd}");
        Console.WriteLine($"Tarefa Mais Recente: {newestTask:yyyy-MM-dd}");
    }
}

class TaskItem
{
    private static int nextId = 1;

    public int Id { get; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime DueDate { get; set; }
    public bool Completed { get; set; }

    public TaskItem()
    {
        Id = nextId++;
    }

    public override string ToString()
    {
        return $"ID: {Id}, Título: {Title}, Descrição: {Description}, Vencimento: {DueDate:yyyy-MM-dd}, Concluída: {Completed}";
    }
}
