namespace FinancasPessoais;

public static class Menu
{
    public static void Show()
    {
        Console.Clear();
        Console.WriteLine("FINANÇAS PESSOAIS v.0.0.1");
        Console.WriteLine("------------------------- \n");
        Console.WriteLine("O que você deseja fazer: \n");
        Console.WriteLine("[1] - Gerenciar Receitas");
        Console.WriteLine("[2] - Gerenciar Despesas");
        Console.WriteLine("[3] - Mostrar Extrato");
        Console.WriteLine("[0] - Sair");          
    }

    public static void ShowGerenciarReceitas()
    {
        Console.Clear();
        Console.WriteLine("GERENCIADOR DE RECEITAS");
        Console.WriteLine("-----------------------");
        Console.WriteLine("O que você deseja fazer: \n");
        Console.WriteLine("[1] - Adicionar Receita");
        Console.WriteLine("[2] - Pesquisar Receitas por Categoria");
        Console.WriteLine("[3] - Pesquisar Receitas por Data");
        Console.WriteLine("[4] - Listar Todas as Receitas");
        Console.WriteLine("[5] - Excluir Receita");
        Console.WriteLine("[6] - Excluir Todas as Receitas");
    }

    public static void ShowGerenciarDespesas()
    {
        Console.Clear();
        Console.WriteLine("GERENCIADOR DE DESPESAS");
        Console.WriteLine("-----------------------");
        Console.WriteLine("O que você deseja fazer: \n");
        Console.WriteLine("[1] - Adicionar Despesa");
        Console.WriteLine("[2] - Pesquisar Despesa por Categoria");
        Console.WriteLine("[3] - Pesquisar Despesa por Data");
        Console.WriteLine("[4] - Listar Todasas Despesas");
        Console.WriteLine("[5] - Excluir Despesa");
        Console.WriteLine("[6] - Excluir Todas as Despesas");
    }

    public static void ShowAdicionarReceita()
    {
        Console.Clear();
        Console.WriteLine("GERENCIADOR DE RECEITAS");
        Console.WriteLine("-----------------------");
        Console.WriteLine("Adcionar Receita \n");
    }

    public static void ShowPesquisarReceitaPorCategoria()
    {
        Console.Clear();
        Console.WriteLine("GERENCIADOR DE RECEITAS");
        Console.WriteLine("-----------------------");
        Console.WriteLine("Receitas por Categoria \n");
    }

    public static void ShowPesquisarReceitaPorData()
    {
        Console.Clear();
        Console.WriteLine("GERENCIADOR DE RECEITAS");
        Console.WriteLine("-----------------------");
        Console.WriteLine("Receitas por Data \n");
    }

    public static void ShowPesquisarTodasAsReceitas()
    {
        Console.Clear();
        Console.WriteLine("GERENCIADOR DE RECEITAS");
        Console.WriteLine("-----------------------");
        Console.WriteLine("Receitas \n");
    }

    public static void ShowExcluirTodasAsReceitas()
    {
        Console.Clear();
        Console.WriteLine("GERENCIADOR DE RECEITAS");
        Console.WriteLine("-----------------------");
        Console.WriteLine("Excluir Receitas \n");
    }

    public static void ShowPesquisarDespesaPorCategoria()
    {
        Console.Clear();
        Console.WriteLine("GERENCIADOR DE DESPESAS");
        Console.WriteLine("-----------------------");
        Console.WriteLine("Despesas por Categoria \n");
    }

    public static void ShowPesquisarDespesaPorData()
    {
        Console.Clear();
        Console.WriteLine("GERENCIADOR DE DESPESAS");
        Console.WriteLine("-----------------------");
        Console.WriteLine("Despesas por Data \n");
    }

    public static void ShowPesquisarTodasAsDespesas()
    {
        Console.Clear();
        Console.WriteLine("GERENCIADOR DE DESPESAS");
        Console.WriteLine("-----------------------");
        Console.WriteLine("Despesas \n");
    }

    public static void ShowExcluirTodasAsDespesas()
    {
        Console.Clear();
        Console.WriteLine("GERENCIADOR DE DESPESAS");
        Console.WriteLine("-----------------------");
        Console.WriteLine("Excluir Despesas \n");
    }
}