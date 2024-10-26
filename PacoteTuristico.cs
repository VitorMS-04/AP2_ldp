public class PacoteTuristico : ServicoViagem, IResevavel
{
    public string Destino { get; set; }
    public DateOnly Datas { get; set; }
    public decimal Preco { get; set; }
    public int VagasDisponiveis { get; set; }

    public PacoteTuristico(string destino, DateOnly datas, decimal preco, int vagasDisponiveis, string codigo, string descricao):base(codigo,descricao)
    {
        Destino = destino;
        Datas = datas;
        Preco = preco;
        VagasDisponiveis = vagasDisponiveis;
    }

    public override void Reservar()
    {
        if(VagasDisponiveis > 0)
        {
            VagasDisponiveis =- 1;
        }else
        {
        }
    }


    public override void Cancelar()
    {
        VagasDisponiveis =+1;
    }
}