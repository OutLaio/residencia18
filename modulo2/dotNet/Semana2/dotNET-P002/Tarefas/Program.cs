using Display;

class Program{
    static void Main(){
        string? op = "1";
        do{
            Menu.dispMenuPrincipal();
            op = Console.ReadLine();
            if(op != null)
                Menu.menuPrincipal(op);
        }while(op != "7");
    }
}