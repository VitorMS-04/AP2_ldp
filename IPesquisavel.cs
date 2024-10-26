public interface IPesquisavel
{
    public void PesquisarReserva(int codigo);
    public void PesquisarPacotePorCodigo(string codigo);
    public void PesquisarPacotePorDesitno(string destino);
    public void PesquisarPacotePorData(DateOnly data);
    public void PesquisarPacotePorPreco(decimal preco);
    public void PesquisarClientePorId(string numeroIdentificacao);
}