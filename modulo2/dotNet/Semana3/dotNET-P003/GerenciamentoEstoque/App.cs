using GerenciamentoEstoque;

public class App{
    public App(){
        Menu();
    }

    static void Menu(){
        while (true){
            Console.Clear();
            Console.WriteLine("1. Cadastrar Produto");
            Console.WriteLine("2. Consultar Produto por Código");
            Console.WriteLine("3. Atualizar Estoque");
            Console.WriteLine("4. Relatórios");
            Console.WriteLine("0. Sair");

            Console.Write("Escolha uma opção: ");
            string? opcao = Console.ReadLine();

            switch (opcao){
                case "1":
                    Produto.CadastrarProduto();
                    break;
                case "2":
                    Produto.ConsultarProduto();
                    break;
                case "3":
                    Produto.AtualizarEstoque();
                    break;
                case "4":
                    Produto.GerarRelatorios();
                    break;
                case "0":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
    
}
