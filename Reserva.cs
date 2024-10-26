using System.Xml.Serialization;

public class Reserva : PacoteTuristico
{
    private string NumeroIdentificacaoCliente { get; set; }
    public int CodigoReserva { get; set; }

    public Reserva(string numeroIdentificacaoCliente, int codReserva, string destino, DateOnly datas, decimal preco, int vagasDisponiveis, string codigo, string descricao):base(destino, datas, preco, vagasDisponiveis, codigo, descricao)
    {
        CodigoReserva = codReserva;
        NumeroIdentificacaoCliente = numeroIdentificacaoCliente;
    }
}