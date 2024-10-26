using System.Data;
using System.Diagnostics;
using System.Net;

Agencia agencia = new Agencia([], [], [], []);

Destino dest1 = new Destino("Orlando", "Estados Unidos", "1", "Resort à beira mar próximo à Disneylândia");
Destino dest2 = new Destino("Tóquio", "Japão", "2", "Hotel cinco estrelas no centro de Tóquio");
Destino dest3 = new Destino("Paris", "França", "3", "Hotel 5 estrelas em frente à torre Eifell");

agencia.CadastrarDestino(dest1);
agencia.CadastrarDestino(dest2);
agencia.CadastrarDestino(dest3);

DateOnly data1 = new DateOnly(2027, 3, 22);
DateOnly data2 = new DateOnly(2035, 10, 5);
DateOnly data3 = new DateOnly(2029, 7, 19);

PacoteTuristico pacote1 = new PacoteTuristico("Orlando", data1, 20000, 10, "1", "Pacote com direito a dois dias na Disneylândia");
PacoteTuristico pacote2 = new PacoteTuristico("Tóquio", data2, 12000, 1, "2", "Pacote com passeios guiados por Shibuya e Yamamoto");
PacoteTuristico pacote3 = new PacoteTuristico("Paris", data3, 31500, 0, "3","Pacote com paseio guiado pelos pontos turísticos");

agencia.CadastrarPacote(pacote1);
agencia.CadastrarPacote(pacote2);
agencia.CadastrarPacote(pacote3);

bool status = true;
while (status == true)
{
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("█▀▀█ █▀▀ █▀▄▀█   █░░▒█ ░▀░ █▀▀▄ █▀▀▄ █▀▀█");
    Console.WriteLine("█▀▀▄ █▀▀ █░▀░█   ▒█▒█░ ▀█▀ █░░█ █░░█ █░░█");
    Console.WriteLine("█▄▄█ ▀▀▀ ▀░░░▀   ░▀▄▀░ ▀▀▀ ▀░░▀ ▀▀▀░ ▀▀▀▀");

    Console.WriteLine("Agência de Turismo da Ulbra - Torres");

    Console.WriteLine("1 - Cadastrar");
    Console.WriteLine("2 - Buscar");
    Console.WriteLine("3 - Listar");
    Console.WriteLine("4 - Reservar");
    Console.WriteLine("5 - Cancelar Reserva");
    Console.WriteLine("6 - Sair");

    var opc = Console.ReadLine();

    switch (opc)
    {
        case "1":
        Console.WriteLine("");
        Console.WriteLine("Fazer Cadastro:");
        Console.WriteLine("");
        
            
        Console.WriteLine("Digite o nome do cliente:");
        var nome = Console.ReadLine();

        Console.WriteLine("Digite o numero de identificação do cliente:");
        var num = Console.ReadLine();

        Console.WriteLine("Digite o contato:");
        var contato = Console.ReadLine();
            
        if(nome == null | num == null | contato == null)
        {
                Console.WriteLine("Erro ao Cadastrar, há espaços em branco.");
                break;
        }else{
                Cliente cliente = new Cliente(nome, num, contato);
                agencia.CadastrarCliente(cliente);
        }
        break;

        case "2":
        Console.WriteLine("");
        Console.WriteLine("Buscar:");
        Console.WriteLine("");

        Console.WriteLine("1 - Buscar Cliente");
        Console.WriteLine("2 - Buscar Destino");
        Console.WriteLine("3 - Buscar Pacote");
        Console.WriteLine("4 - Buscar Reserva");

        var opc3 = Console.ReadLine();

        switch(opc3)
        {
            case "1":

            Console.WriteLine("Digite o número de Identificação do cliente:");
            var numCliente = Console.ReadLine();

            if(numCliente == null)
            {
                Console.WriteLine("Erro na busca, há espaços em branco");
                continue;
            }else{
                agencia.PesquisarClientePorId(numCliente);
            }
            continue;

            case "2":

            Console.WriteLine("Digite o codigo do destino:");
            var codDestino = Console.ReadLine();

            if(codDestino == null)
            {
                Console.WriteLine("Erro na busca, há espaços em branco");
            }else{
                agencia.ConsultarDestinoPorCodigo(codDestino);
            }
            continue;

            case "3":
            Console.WriteLine("");
            Console.WriteLine("Buscar pacote:");
            Console.WriteLine("");
            Console.WriteLine("1 - Buscar por código");
            Console.WriteLine("2 - Buscar por Destino");
            Console.WriteLine("3 - Buscar por Preço");
            Console.WriteLine("4 - Buscar por data");

            var opc4 = Console.ReadLine();

            switch(opc4)
            {
                case "1":

                Console.WriteLine("Digite o código do pacote:");
                var codPacote = Console.ReadLine();

                if(codPacote == null)
                {
                    Console.WriteLine("Erro na busca, há espaçoes em branco");
                }else{
                    agencia.PesquisarPacotePorCodigo(codPacote);
                }
                continue;

                case "2":

                Console.WriteLine("Digite o destino do pacote:");
                var destinoPacote = Console.ReadLine();

                if(destinoPacote == null)
                {
                    Console.WriteLine("Erro na busca, há espaçoes em branco");
                }else{
                    agencia.PesquisarPacotePorDestino(destinoPacote);
                }
                continue;

                case "3":

                Console.WriteLine("Digite o preço desejado:");
                var precoPacote = Convert.ToDecimal(Console.ReadLine());

                agencia.PesquisarPacotePorPreco(precoPacote);
            
                continue;

                case "4":

                Console.WriteLine("Digite o ano desejado:");
                var anoPacote = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite o mês desejado:");
                var mesPacote = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite o dia desejado");
                var diaPacote = Convert.ToInt32(Console.ReadLine());

                DateOnly dataPacote = new DateOnly(anoPacote, mesPacote, diaPacote);

                agencia.PesquisarPacotePorData(dataPacote);
                
                continue;
            }
            continue;

            case "4":

            Console.WriteLine("Digite o codigo da Reserva:");
            var codigoReserva = Convert.ToInt32(Console.ReadLine());
            agencia.PesquisarReserva(codigoReserva);
            continue;
        }
        break;

        case "3":
        Console.WriteLine("");
        Console.WriteLine("Listar");
        Console.WriteLine("");
        Console.WriteLine("1 - Listar Destinos");
        Console.WriteLine("2 - Listar Pacotes");
        Console.WriteLine("3 - Listar Clientes");

        var opc5 = Console.ReadLine();

        switch(opc5)
        {
            case "1":

            agencia.ListarDestinos();
            continue;

            case "2":

            agencia.ListarPacotes();
            continue;

            case "3":

            agencia.ListarClientes();
            continue;
        }
        continue;

        case "4":

        Console.WriteLine("Digite o código do pacote escolhido:");
        var pacEscolhido = Console.ReadLine();

        Console.WriteLine("Digite o código de identificação do cliente");
        var codigoCliente = Console.ReadLine();

        agencia.ReservarPacote(pacEscolhido, codigoCliente);
        continue;

        case "5":

        Console.WriteLine("Digite o código da reserva:");
        int opc6 = Convert.ToInt32(Console.ReadLine());
        
        agencia.CancelarReserva(opc6);
        break;

        case "6":
        status = false;
        break;

        default:
        Console.WriteLine("\nDigite uma opção válida");
        break;
    }
}