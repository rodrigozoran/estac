using Estacionamento.Models;

Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoHora = 5;
decimal estadia = 0;
decimal valorTotal = 0;

Console.WriteLine("Bem vindo ao Estacionamento!\nDigite o tempo de estadia: ");

estadia = Convert.ToDecimal(estadia);

Console.WriteLine("Tempo de Estadia: " + estadia);

valorTotal = Convert.ToDecimal(precoHora*estadia);

Estac es = new Estac(precoHora,estadia,valorTotal);

string opcao = string.Empty;
bool exibirMenu = true;

while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar por placa");
    Console.WriteLine("4 - Listar todos os veículos");
    Console.WriteLine("5 - Valor a pagar");
    Console.WriteLine("6 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            es.AdicionarVeiuclo();
            break;
        case "2":
            es.RemoverVeiculos();
            break;
        case "3":
            es.ListarPorPlaca();
            break;
        case "4":
            es.ListarTodos();
            break;
        case "5":
            es.totalPg();
            break;
        case "6":
            exibirMenu = false;
            break;
        default:
            Console.WriteLine("Opção Inválida!");
            break;
    }

    Console.WriteLine("Pressione alguma tecla para continuar...");
    Console.ReadLine();
}

Console.WriteLine("Fim da Execução do Programa.");
