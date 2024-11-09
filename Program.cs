using DesafioEstacionamento.Models;

Console.WriteLine("Seja bem vindo ao Sistema de Estacionamento");
Console.WriteLine("Digite o valor inicial: ");
decimal valorInicial = decimal.Parse(Console.ReadLine());

Console.WriteLine("Agora digite o preço por hora: ");
decimal valorPorHora = decimal.Parse(Console.ReadLine());


Estacionamento est = new Estacionamento(valorInicial, valorPorHora);

string opcao = string.Empty;
bool exibeMenu = true;
while (exibeMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar Veículo");
    Console.WriteLine("2 - Remover Veículo");
    Console.WriteLine("3 - Listar Veículos");
    Console.WriteLine("4 - Encerrar");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            est.CadastrarVeiculo();
            break;

        case "2":
            est.RemoverVeiculo();
             Console.ReadKey();
            break;

        case "3":
            est.ListarVeiculos();
            Console.ReadKey();
            break;

        case "4":
            exibeMenu = false;
        break;
        
        default:
            Console.WriteLine("Opção inválida!");
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            break;
    }
}

