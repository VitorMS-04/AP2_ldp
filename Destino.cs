public class Destino
{
    protected string NomeLocal { get; set; }
    protected string Pais { get; set; }
    public string Codigo { get; set; }
    protected string Descricao { get; set; }

    public Destino(string nomeLocal, string pais, string codigo, string descricao)
    {
        NomeLocal = nomeLocal;
        Pais = pais;
        Codigo = codigo;
        Descricao = descricao;
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Local do Destino: {NomeLocal}\nPaís: {Pais}\nCodigo do destino: {Codigo}\nDescrição: {Descricao}");
    }
}