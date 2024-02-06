namespace FinancasPessoais;

public class Despesa
{
    public int Id { get; set; }
    public string Categoria { get; set; }
    public string Descricao { get; set; }
    public decimal Valor { get; set; }
    public DateTime Data { get; set; }
  
    public Despesa(string categoria, string descricao, decimal valor)
    {    
        Categoria = categoria;
        Descricao = descricao;
        Valor = valor;
        Data = DateTime.Now.Date;
    }

    public Despesa() { }

    public List<Despesa> despesas = new();

    public void Adicionar(Despesa despesa)
    {
        var temItemNaLista = despesas.Any();
        if(!temItemNaLista)
        {
            despesa.Id = 1;
            despesas.Add(despesa);
        }
        else
        {
            var _despesa = despesas.Last();
            despesa.Id = _despesa.Id + 1;
            despesas.Add(despesa);
        }
    }

    public List<Despesa> Listar()
    {
        return despesas.ToList();
    }

    public List<Despesa> ListarPorCategoria(string categoria)
    {
        var pesquisa = despesas.Where(x => x.Categoria == categoria);
        return pesquisa.ToList();
    }

    public List<Despesa> ListarPorData(DateTime data)
    {
        var pesquisa = despesas.Where(x => x.Data.Date == data.Date);
        return pesquisa.ToList();
    }

    public void Excluir(short id)
    {
        var _despesa = despesas.Find(x => x.Id == id);
        despesas.Remove(_despesa);
    }

    public void Excluir()
    {
        despesas.Clear();
    }
}