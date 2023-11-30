namespace GerenciamentoEstoque;

public class Produto{
    static List<(int codigo, string nome, int quantidade, double preco)> estoque = new List<(int, string, int, double)>();

    public static void CadastrarProduto(){
        Console.Clear();
        try{
            string? texto, nome;
            do{
                Console.Write("Código do Produto: ");
                texto = Console.ReadLine();
            }while(texto == null);
            int codigo = int.Parse(texto);

            do{
                Console.Write("Nome do Produto: ");
                nome = Console.ReadLine();
            }while(nome == null);

            do{
                Console.Write("Quantidade em Estoque: ");
                texto = Console.ReadLine();
            }while(texto == null);
            int quantidade = int.Parse(texto);

            do{
                Console.Write("Preço Unitário: ");
                texto = Console.ReadLine();
            }while(texto == null);
            double preco = double.Parse(texto);

            estoque.Add((codigo, nome, quantidade, preco));

            Console.WriteLine("Produto cadastrado com sucesso!");
            Console.ReadLine();
        }
        catch (Exception ex){
            Console.WriteLine($"Erro ao cadastrar produto: {ex.Message}");
            Console.ReadLine();
        }
    }

    public static void ConsultarProduto(){
        Console.Clear();
        try{
            string? texto;
            do{
                Console.Write("Digite o Código do Produto: ");
                texto = Console.ReadLine();
            } while (texto == null);
            int codigo = int.Parse(texto);

            var produto = estoque.FirstOrDefault(p => p.codigo == codigo);

            if (produto.Equals(default((int, string, int, double))))
                throw new ProdutoNaoEncontradoException("Produto não encontrado!");

            Console.WriteLine($"Nome: {produto.nome}, Quantidade: {produto.quantidade}, Preço: {produto.preco:C}");
            Console.ReadLine();
        }
        catch (Exception ex){
            Console.WriteLine($"Erro ao consultar produto: {ex.Message}");
            Console.ReadLine();
        }
    }

    public static void AtualizarEstoque(){
        Console.Clear();
        try{
            string? texto;

            do{
                Console.Write("Digite o Código do Produto: ");
                texto = Console.ReadLine();
            } while (texto == null);
            int codigo = int.Parse(texto);

            var produto = estoque.FirstOrDefault(p => p.codigo == codigo);

            if (produto.Equals(default((int, string, int, double))))
                throw new ProdutoNaoEncontradoException("Produto não encontrado!");

            do{
                Console.Write("Digite a Quantidade a ser adicionada (+) ou removida (-): ");
                texto = Console.ReadLine();
            } while (texto == null);
            int quantidadeAtualizacao = int.Parse(texto);

            if (produto.quantidade + quantidadeAtualizacao < 0)
                throw new QuantidadeInsuficienteException("Quantidade insuficiente em estoque para essa operação!");

            estoque.Remove(produto);
            produto.quantidade += quantidadeAtualizacao;
            estoque.Add(produto);

            Console.WriteLine("Estoque atualizado com sucesso!");
            Console.ReadLine();
        }
        catch (Exception ex){
            Console.WriteLine($"Erro ao atualizar estoque: {ex.Message}");
            Console.ReadLine();
        }
    }

    public static void GerarRelatorios(){
        Console.Clear();
        string? texto;
        try{
            do{
                Console.Write("Limite de Quantidade para Relatório 1: ");
                texto = Console.ReadLine();
            } while (texto == null);
            int limiteQuantidade = int.Parse(texto);

            var relatorio1 = estoque.Where(p => p.quantidade < limiteQuantidade);

            do{
                Console.Write("Valor Mínimo para Relatório 2: ");
                texto = Console.ReadLine();
            } while (texto == null);
            double valorMinimo = double.Parse(texto);

            do{
                Console.Write("Valor Máximo para Relatório 2: ");
                texto = Console.ReadLine();
            } while (texto == null);
            double valorMaximo = double.Parse(texto);

            var relatorio2 = estoque.Where(p => p.preco >= valorMinimo && p.preco <= valorMaximo);
            var relatorio3 = from p in estoque select new { Nome = p.nome, ValorTotal = p.quantidade * p.preco };

            Console.Clear();
            ExibirRelatorio("Produtos com quantidade abaixo do limite:", relatorio1);
            Console.WriteLine();
            ExibirRelatorio("Produtos com valor entre o mínimo e o máximo:", relatorio2);
            Console.WriteLine();
            Console.WriteLine("Valor Total do Estoque e Valor Total por Produto:");

            double total = 0;
            foreach (var item in relatorio3){
                Console.WriteLine($"Produto: {item.Nome}, Valor Total: {item.ValorTotal:C}");
                total += item.ValorTotal;
            }
            Console.WriteLine($"Valor Total do Estoque: {total:C}");
            Console.ReadLine();
        }catch(Exception ex){
            Console.WriteLine($"Erro ao gerar o relatório: {ex.Message}");
            Console.ReadLine();
        }
    }

    public static void ExibirRelatorio(string titulo, IEnumerable<(int, string, int, double)> relatorio){
        Console.WriteLine(titulo);
        foreach (var item in relatorio){
            Console.WriteLine($"Código: {item.Item1}, Nome: {item.Item2}, Quantidade: {item.Item3}, Preço: {item.Item4:C}");
        }
    }
}
