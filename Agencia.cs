public class Agencia
{
    private List<Destino> Destinos { get; set; }
    private List<Cliente> Clientes { get; set; }
    private List<PacoteTuristico> Pacotes { get; set; }
    private List<Reserva> Reservas { get; set; }

    public Agencia(List<Destino> destinos, List<Cliente> clientes, List<PacoteTuristico> pacotes, List<Reserva> reservas)
    {
        Destinos = destinos;
        Clientes = clientes;
        Pacotes = pacotes;
        Reservas = reservas;
    }

    //Gerenciamento de Destinos

    public void CadastrarDestino(Destino destino)
    {
        if(destino == null)
        {
            Console.WriteLine("Destino Inválido.");
        }else{
            Destinos.Add(destino);
        }
    }

    public void ConsultarDestinoPorCodigo(string codigo)
    {
        string? status = null;
        foreach(var item in Destinos)
        {
            string cod = item.Codigo;
            if(codigo == cod)
            {
                item.ExibirInformacoes();
                status = "Concluido";
            }else{
                continue;
            }
        }
        switch(status)
        {
            case null:
            Console.WriteLine("Destino não encontado.");
            break;

            case "Concluido":
            break;
        }
    }

    public void ListarDestinos()
    {
        foreach(var item in Destinos)
        {
            item.ExibirInformacoes();
            Console.WriteLine("\n\n");
        }
    }

    // Gerenciamento de Clientes

    public void CadastrarCliente(Cliente cliente)
    {
        var statusCliente = false;
        foreach(var item in Clientes)
        {
            var codigo = item.NumeroIdentificacao;
            if(cliente.NumeroIdentificacao == codigo)
            {
                Console.WriteLine("Número de identificação já utilizado.");
                statusCliente = true;
            }else{
                continue;
            }
        }

        if (cliente == null)
        {
            Console.WriteLine("Usuário Inválido.");
        }else if (statusCliente == false){
            Clientes.Add(cliente);
            Console.WriteLine("Cliente Cadastrado com sucesso!");
        }
    }

    public void PesquisarClientePorId(string numeroIdentificacao)
    {
        string? status = null;
        foreach(var item in Clientes)
        {
            string num = item.NumeroIdentificacao;
            if(numeroIdentificacao == num)
            {
                item.ExibirInformacoes();
                status = "Concluido";
            }
        }
        switch(status)
        {
            case null:
            Console.WriteLine("Cliente não encontado.");
            break;

            case "Concluido":
            break;
        }
    }

    public void ListarClientes()
    {
        foreach(var item in Clientes)
        {
            item.ExibirInformacoesProtegidas();
            Console.WriteLine("\n\n");
        }
    }

    // Gerenciamento de Pacotes

    public void CadastrarPacote(PacoteTuristico pacote)
    {
            if (pacote == null)
            {
                Console.WriteLine("Pacote Inválido.");
            }else{
                Pacotes.Add(pacote);        
            }
    }

    public void PesquisarPacotePorCodigo(string codigo)
    {
        string? status = null;
        foreach(var item in Pacotes)
        {
            var cod = item.Codigo;
            if(codigo == cod)
            {
                Console.WriteLine($"Pacote encontrado\nDestino: {item.Destino}\nData: {item.Datas}\nPreço: {item.Preco}\nVagas Disponíveis: {item.VagasDisponiveis}");
                status = "Concluido";
                break;
            }else{
                continue;
            }
        }
        switch(status)
        {
            case null:
            Console.WriteLine("Pacote não encontado.");
            break;

            case "Concluido":
            break;
        }
    }

    public void PesquisarPacotePorDestino(string destino)
    {
        string? status = null;
        foreach(var item in Pacotes)
        {
            var des = item.Destino;
            if(destino == des)
            {
                Console.WriteLine($"Pacote encontrado\nDestino: {item.Destino}\nData: {item.Datas}\nPreço: {item.Preco}\nVagas Disponíveis: {item.VagasDisponiveis}");
                status = "Concluido";
                break;
            }else{
                continue;
            }
        }
        switch(status)
        {
            case null:
            Console.WriteLine("Pacote não encontado.");
            break;

            case "Concluido":
            break;
        }
    }

    public void PesquisarPacotePorData(DateOnly data)
    {
        string? status = null;
        foreach(var item in Pacotes)
        {
            var d = item.Datas;
            if(d == data)
            {
                Console.WriteLine($"Pacote encontrado\nDestino: {item.Destino}\nData: {item.Datas}\nPreço: {item.Preco}\nVagas Disponíveis: {item.VagasDisponiveis}");
                status = "Concluido";
                break;
            }else{
                continue;
            }
        }
        switch(status)
        {
            case null:
            Console.WriteLine("Pacote não encontado.");
            break;

            case "Concluido":
            break;
        }
    }

    public void PesquisarPacotePorPreco(decimal preco)
    {
        string? status = null;
        foreach(var item in Pacotes)
        {
            var prec = item.Preco;
            if(prec == preco)
            {
                Console.WriteLine($"Pacote encontrado\nDestino: {item.Destino}\nData: {item.Datas}\nPreço: {item.Preco}\nVagas Disponíveis: {item.VagasDisponiveis}");
                status = "Concluido";
                break;
            }else{
                continue;
            }
        }
        switch(status)
        {
            case null:
            Console.WriteLine("Pacote não encontado.");
            break;

            case "Concluido":
            break;
        }
    }

    public void ListarPacotes()
    {
        Console.WriteLine("Pacotes:");
        foreach(var item in Pacotes)
        {
            Console.WriteLine($"Destino: {item.Destino}\nDatas: {item.Datas}\nPreço: {item.Preco}\nVagas Disponíveis: {item.VagasDisponiveis}\n\n");
        }
    }

    // Gerenciamento de Reservas

    public void ReservarPacote(string codigoPacote, string codCliente)
    {
        string? status = null;
        string? status2 = null;
        var statusReservas = true;
        foreach(var pac in Pacotes)
        {
            var cod = pac.Codigo;
            var dest = pac.Destino;
            var data = pac.Datas;
            var preco = pac.Preco;
            var vagas = pac.VagasDisponiveis;
            var desc = pac.Descricao;
            var codigoReserva = 1;
            if(codigoPacote == cod)
            {
                foreach(var cli in Clientes)
                {
                    var usuario = cli.NumeroIdentificacao;
                    if (usuario == codCliente)
                    {
                        status2 = "Concluido";
                        foreach(var res in Reservas)
                        {
                            if (codigoReserva == res.CodigoReserva)
                            {
                                codigoReserva += 1;
                                statusReservas = false;
                            }else{
                                statusReservas = true;
                            }
                        }
                        
                        if (pac.VagasDisponiveis == 0)
                        {
                            Console.WriteLine("Perdão, mas não há vagas disponíveis para este pacote.");
                            status = "Concluido";
                            break;
                        }else if(statusReservas = true){
                            Reserva reserva = new Reserva(codCliente, codigoReserva, dest, data, preco, vagas, cod, desc);
                            Reservas.Add(reserva);
                            pac.Reservar();
                            Console.WriteLine("Reserva Concluida com sucesso!");
                            Console.WriteLine($"Codigo da reserva: {codigoReserva}");
                            status = "Concluido";
                            break;
                        }
                    }else if(usuario == null){
                        Console.WriteLine("Usuário inválido.");
                        status = "Concluido";
                        break;
                    }
                }
            }else if(codigoPacote == null){
                Console.WriteLine("Codigo do Pacote inválido.");
            }
            continue;
        }
        switch(status2)
            {
                case null:
                Console.WriteLine("Cliente não encontado.");
                break;

                case "Concluido":
                break;
            }

        switch(status)
        {
            case null:
            Console.WriteLine("Pacote não encontado.");
            break;

            case "Concluido":
            break;
        }
    }

    public void CancelarReserva(int codigoReserva)
    {
        string? status = null;
        foreach(var item in Reservas)
        {
            var res = item.CodigoReserva;
            var cod = item.Codigo;
            if(res == codigoReserva)
            {
                foreach(var pac in Pacotes)
                {
                    var codPac = pac.Codigo;
                    if(cod == codPac)
                    {
                        pac.Cancelar();
                        status = "Concluido";
                        break;
                    }
                }
                Reservas.Remove(item);
                break;
            }else{
                continue;
            }
        }
        switch(status)
        {
            case null:
            Console.WriteLine("Reserva não encontada.");
            break;

            case "Concluido":
            break;
        }
    }


    public void PesquisarReserva(int codigo)
    {
        string? status = null;
        foreach(var item in Reservas)
        {
            var cod = item.CodigoReserva;
            if(cod == codigo)
            {
                Console.WriteLine($"\nReserva encontrada\nDestino: {item.Destino}\nData: {item.Datas}\nDescrição: {item.Descricao}");
                status = "Concluido";
                break;
            }else{
                continue;
            }
        }
        switch(status)
        {
            case null:
            Console.WriteLine("Reserva não encontada.");
            break;

            case "Concluido":
            break;
        }
    }
}

