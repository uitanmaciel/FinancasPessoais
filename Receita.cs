namespace FinancasPessoais;

public class Receita
{
    public int Id { get; set; }
    public string Categoria { get; set; }
    public string Descricao { get; set; }
    public decimal Valor { get; set; }
    public DateTime Data { get; set; }

    public Receita(string categoria, string descricao, decimal valor, DateTime data)
    {
        Categoria = categoria;
        Descricao = descricao;
        Valor = valor;
        Data = data;
    }

    public Receita() { }

    public List<Receita> receitas = new();
  
    public void Adicionar(Receita receita)
    {
        var temItemNaLista = receitas.Any();
        if (!temItemNaLista)
        {
            receita.Id = 1;
            receitas.Add(receita);
        }
        else
        {
            var _receita = receitas.Last();
            receita.Id = _receita.Id + 1;
            receitas.Add(receita);
        }
    }

    public List<Receita> Listar()
    {
        return receitas.ToList();
    }

    public List<Receita> ListarPorCategoria(string categoria)
    {
        var pesquisa = receitas.Where(x => x.Categoria == categoria);
        return pesquisa.ToList();
    }

    public List<Receita> ListarPorData(DateTime data)
    {
        var pesquisa = receitas.Where(x => x.Data.Date == data.Date);
        return pesquisa.ToList();
    }

    public void Excluir(short id)
    {
        var _receita = receitas.Find(x => x.Id == id);
        receitas.Remove(_receita);
    }

    public void Excluir()
    {
        receitas.Clear();
    }
}