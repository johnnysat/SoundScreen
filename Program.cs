// Screen Sound
string mensagemBoasVindas = "Boas vindas ao Screen Sound";
//List<string> bandasRegistradas = new List<string>{"Avenged Sevenfold", "NX Zero", "Guerreiros do Trovão", "Pizadeiro do Luffy"};

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Linkin Park", new List<int>{10, 8, 6});
bandasRegistradas.Add("Avenged Sevenfold", new List<int>{8, 9, 9, 10});
bandasRegistradas.Add("Mamonas Assassinas", new List<int>{10, 1, 7});



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
        case 3: AvaliarBanda();
            break;
        case 4: MediaBanda();
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
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso");
    Thread.Sleep(2000);
    Console.Clear();

    ExibirOpcoesDoMenu();
}

void MostrarBandasRegistradas(){
    Console.Clear();
    Console.WriteLine("Essas são todas as bandas registradas até agora: ");
    //for (int i = 0; i < bandasRegistradas.Count; i++) 
   // {
    //    int indice = i + 1;
    //    Console.WriteLine($"Banda {indice}: {bandasRegistradas[i]}");
   // }

    int indice = 1;
    foreach(string banda in bandasRegistradas.Keys){
        Console.WriteLine($"Banda {indice}: {banda}");
        indice++;
    }

    Console.WriteLine("Aperte qualquer tecla para retornar ao menu principal");
    Console.ReadKey();
    Console.Clear();

    ExibirOpcoesDoMenu();
}

void AvaliarBanda(){
    Console.Clear();
    Console.WriteLine("Avalie sua banda");
    Console.Write("Digite qual banda deseja avaliar: ");
    string bandaAvaliada = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(bandaAvaliada)){
        Console.Write($"Qual nota você quer dar para a {bandaAvaliada}?");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[bandaAvaliada].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a {bandaAvaliada}!");

        Console.WriteLine("\nAperte qualquer tecla para retornar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    } else  {
        Console.WriteLine($"\n A banda {bandaAvaliada} não foi encontrada");
        Console.WriteLine("Aperte qualquer tecla para retornar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    
}

void MediaBanda()
{
    Console.Clear();
    Console.WriteLine("Cálculo da Média de uma Banda");
    Console.Write("Digite o nome da banda: ");
    string nomeDaBanda = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        List<int> notas = bandasRegistradas[nomeDaBanda];
        if (notas.Count > 0)
        {
            double media = notas.Average();
            Console.WriteLine($"A média das notas da banda {nomeDaBanda} é: {media.ToString("0.00")}");
        }
        else
        {
            Console.WriteLine($"Nenhuma nota registrada para a banda {nomeDaBanda}.");
        }
    }
    else
    {
        Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada.");
    }

    Console.WriteLine("\nAperte qualquer tecla para retornar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}


ExibirLogo();
ExibirOpcoesDoMenu();