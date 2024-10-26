using System.Net;

public class Cliente
{
    private string Nome { get; set; }
    public string NumeroIdentificacao { get; set; }
    private string Contato { get; set; }

    public Cliente(string nome, string numeroIdentificacao, string contato)
    {
        Nome = nome;
        NumeroIdentificacao = numeroIdentificacao;
        Contato = contato;
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Nome do cliente: {Nome}\nNumero de identificação: {NumeroIdentificacao}\nContato: {Contato}");
    }

    public void ExibirInformacoesProtegidas()
    {
        Console.WriteLine($"Nome do cliente: {Nome}\nContato: {Contato}");
    }
}