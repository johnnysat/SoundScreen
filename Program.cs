// Screen Sound
string mensagemBoasVindas = "Boas vindas ao Screen Sound";
List<string> bandasRegistradas = new List<string>{"Avenged Sevenfold", "NX Zero", "Guerreiros do Trovão", "Pizadeiro do Luffy"};

void ExibirLogo()
{
    Console.WriteLine(@"    
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
    ");
    Console.WriteLine(mensagemBoasVindas);
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite sua opção:");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNum  = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNum){
        case 1: RegistrarBanda();
            break;
        case 2: MostrarBandasRegistradas();
            break;
        case 3: Console.WriteLine("Você escolheu a opção " + opcaoEscolhida);
            break;
        case 4: Console.WriteLine("Você escolheu a opção " + opcaoEscolhida);
            break;
        case -1: Console.WriteLine("Até a próxima! :D");
            break;
        default: Console.WriteLine("Opção Inválida");
            break;
    }
}   

void RegistrarBanda(){
    Console.Clear();
    Console.WriteLine("Registro de Bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda);
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso");
    Thread.Sleep(2000);
    Console.Clear();

    ExibirOpcoesDoMenu();
}

void MostrarBandasRegistradas(){
    Console.Clear();
    Console.WriteLine("Essas são todas as bandas registradas até agora: ");
    for (int i = 0; i < bandasRegistradas.Count; i++) 
    {
        int indice = i + 1;
        Console.WriteLine($"Banda {indice}: {bandasRegistradas[i]}");
    }
    Console.WriteLine("Aperte qualquer tecla para retornar ao menu principal");
    Console.ReadKey();
    Console.Clear();

    ExibirOpcoesDoMenu();
}

ExibirLogo();
ExibirOpcoesDoMenu();