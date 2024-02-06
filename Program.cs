using FinancasPessoais;

short opcao;
var receita = new Receita();
do
{
    Menu.Show();
    opcao = short.Parse(Console.ReadLine());
    switch (opcao)
    {
        case 1:
            Console.Clear();
            Menu.ShowGerenciarReceitas();
            short opcaoReceita = short.Parse(Console.ReadLine());
            if (opcaoReceita == 1)
            {
                Console.Clear();
                Menu.ShowAdicionarReceita();
                var _receita = new Receita();
                Console.WriteLine("Informe a categoria:");
                _receita.Categoria = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Informe um descrição:");
                _receita.Descricao = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Informe o valor da receita:");
                _receita.Valor = decimal.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Informe a data da receita:");
                _receita.Data = DateTime.Parse(Console.ReadLine());
                receita.Adicionar(_receita);
                Console.WriteLine();
                Console.WriteLine("Receita adicionada com sucesso!");
                Console.WriteLine("Pressione qualquer tecla para continuar...");
            }
            if (opcaoReceita == 2)
            {
                Menu.ShowPesquisarReceitaPorCategoria();
                Console.WriteLine("Informe a categoria");
                string categoria = Console.ReadLine();
                var _receitas = receita.ListarPorCategoria(categoria);
                foreach (var _receita in _receitas)
                {
                    Console.WriteLine(_receita.Id);
                    Console.WriteLine(_receita.Data);
                    Console.WriteLine(_receita.Categoria);
                    Console.WriteLine(_receita.Descricao);
                    Console.WriteLine(_receita.Valor);
                    Console.WriteLine();
                }
                Console.WriteLine("Pressione qualquer tecla para continuar...");
            }
            if(opcaoReceita == 3)
            {
                Menu.ShowPesquisarReceitaPorData();
                Console.WriteLine("Informe a data:");
                DateTime data = DateTime.Parse(Console.ReadLine());
                var _receitas = receita.ListarPorData(data.Date);
                foreach (var _receita in _receitas)
                {                    
                    Console.WriteLine(_receita.Id);
                    Console.WriteLine(_receita.Data);
                    Console.WriteLine(_receita.Categoria);
                    Console.WriteLine(_receita.Descricao);
                    Console.WriteLine(_receita.Valor);
                    Console.WriteLine();
                }
                Console.WriteLine("Pressione qualquer tecla para continuar...");
            }
            if (opcaoReceita == 4)
            {
                Menu.ShowPesquisarTodasAsReceitas();
                foreach (var _receita in receita.Listar())
                {
                    Console.WriteLine(_receita.Id);
                    Console.WriteLine(_receita.Data);
                    Console.WriteLine(_receita.Categoria);
                    Console.WriteLine(_receita.Descricao);
                    Console.WriteLine(_receita.Valor);
                    Console.WriteLine();
                }
            }
            if (opcaoReceita == 5)
            {
                Menu.ShowExcluirTodasAsReceitas();
                Console.WriteLine("Informe o id da receita:");
                short id = short.Parse(Console.ReadLine());
                receita.Excluir(id);
                Console.WriteLine("Receita excluída com sucesso!");
                Console.WriteLine("Pressione qualquer tecla para continuar...");
            }
            if(opcaoReceita == 6)
            {
                Menu.ShowExcluirTodasAsReceitas();
                receita.Excluir();
                Console.WriteLine("Todas as receitas foram excluídas com sucesso!");
                Console.WriteLine("Pressione qualquer tecla para continuar...");
            }
            Console.ReadKey();
            break;
        // Seu desafio é implementar a lógica para a gestão das despesas
        // Tenha como exemplo a lógica implementada para a gestão das receitas
        case 2:

            break;
    }
} while (opcao != 0);