using Display;

class Program{
    static void Main(){
        string? op = "1";
        Console.Clear();
        do{
            Menu.dispMenuPrincipal();
            op = Console.ReadLine();
            Console.Clear();
            if(op != null)
                Menu.menuPrincipal(op);
        }while(op != "7");
    }
}