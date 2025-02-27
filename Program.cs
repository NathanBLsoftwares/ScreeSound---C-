using System.Net.Http.Headers;
using System.Reflection;

string mensagem = "SejamBem-vindos, a ScreenSound";
Dictionary<String, List<int>> BandasRegistradas = new Dictionary<string, List<int>>();
BandasRegistradas.Add("Black Sabbath", new List<int>());
BandasRegistradas.Add("Post Malone", new List<int>());

void ExibirMensagem()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");

    Console.WriteLine("\n********************************");
    Console.WriteLine(mensagem);
    Console.WriteLine("********************************");
}

ExibirMensagem();
ExibirOpcoesDoMenu();

void ExibirOpcoesDoMenu()
{
    ExibirMensagem();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para mostrar a média de visualizações de uma banda");
    Console.WriteLine("Digite 0 para sair");

    Console.Write("\nDigite sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);
    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            registrarBandas();
            break;
        case 2:
            mostrarBandasRegistradas();
            break;
        case 3:
            avaliarUmaBanda();
            break;
        case 4:
            mediaDasBandas();
            break;
        case 0:
            Console.WriteLine("Até mais :)");
            break;
        default:
            Console.WriteLine("Opção invalida");
            break;
    }
}

void registrarBandas()
{
    Console.Clear();
    exibirNomeDasOpcoes("RESGISTRAR BANDAS");
    Console.Write("Digite o nome da banda que você deseja registrar: ");
    string banda = Console.ReadLine()!;
    BandasRegistradas.Add(banda, new List<int>());
    Console.WriteLine($"A banda {banda} foi registrada com sucesso");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void mostrarBandasRegistradas()
{
    Console.Clear();
    exibirNomeDasOpcoes("EXIBIÇÃO DAS BANDAS REGISTRADAS");
    foreach (string banda in BandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.WriteLine("\nPrecione qualquer tecla para voltar par o menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void exibirNomeDasOpcoes(string titulo)
{
    int quatidadeDeLetras = titulo.Length;
    string asterisk = string.Empty.PadLeft(quatidadeDeLetras, '-');
    Console.WriteLine(asterisk);
    Console.WriteLine(titulo);
    Console.WriteLine(asterisk + "\n");
}

void avaliarUmaBanda()
{
    //Digitar a banda que deseja avaliar
    //verificar se a banda existe dentro do dicionario
    //voltar para o menu principal

    Console.Clear();
    exibirNomeDasOpcoes("AVALIAR BANDA");
    Console.Write("Digte o nome da banda que voce queira avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (BandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        BandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nA banda {nomeDaBanda} foi avaliada com sucesso");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"\n A banda {nomeDaBanda} não foi encontrada");
        Console.Write("Preciona qualquer tecla para voltar para o menu principal: ");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();

    }
}

void mediaDasBandas()
{
    Console.Clear();
    exibirNomeDasOpcoes("MÉDIAS DAS BANDAS");
    Console.Write("Digite o nome da banda que deseja ver a médias as notas: ");
    string mediaBanda = Console.ReadLine()!;
    if (BandasRegistradas.ContainsKey(mediaBanda))
    {
        List<int> notasDasBandas = BandasRegistradas[mediaBanda];
        Console.WriteLine($"\nA média da {mediaBanda} é: {notasDasBandas.Average()}");
        Console.WriteLine("Pressione qualquer tecla para voltar para o menu principal ....");
        Console.ReadKey();
        Console.Clear();
    }
    else
    {
        Console.WriteLine($"A banda {mediaBanda} não foi encontrada");
        Console.WriteLine("Pressione qualquer tecla para sair  ....");
        Console.ReadKey();
        Console.Clear();
    }

}