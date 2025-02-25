string mensagem = "SejamBem-vindos, a ScreenSound";
List<string> listaDasBandas = new List<string>();

void ExibirMensagem(){
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");

    Console.WriteLine("********************************");
    Console.WriteLine(mensagem);
    Console.WriteLine("********************************");
}

void ExibirOpcoesDoMenu (){
    ExibirMensagem();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para mostrar a média de visualizações de uma banda");
    Console.WriteLine("Digite 0 para sair");

    Console.Write("\nDigite sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);
    switch(opcaoEscolhidaNumerica){
        case 1 : registrarBandas();
            break;
        case 2 : mostrarBandasRegistradas();
            break;
        case 3 : Console.WriteLine("Você escolher a opção: " + opcaoEscolhida);
            break;
        case 4 : Console.WriteLine("Você escolheu a opção: " + opcaoEscolhida);
            break;
        case 0 : Console.WriteLine("Até mais :)");
            break;
        default : Console.WriteLine("Opção invalida");
            break;
    }

}

ExibirMensagem();
ExibirOpcoesDoMenu();

void registrarBandas(){
    Console.Clear();
    Console.WriteLine("****************");
    Console.WriteLine("REGISTRAR BANDAS");
    Console.WriteLine("****************");
    Console.Write("Digite o nome da banda que você deseja registrar: ");
    string banda = Console.ReadLine()!;
    listaDasBandas.Add (banda);
    Console.WriteLine($"A banda {banda} foi registrada com sucesso");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void mostrarBandasRegistradas(){

}