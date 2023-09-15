using EnglishLanguage.Phrases.Simple;
using EnglishLanguage.PhrasesGuide.Travel;

internal class Program
{
    private static void Main()
    {
        Console.WriteLine("-----------------------MENU------------------------");
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("1) - GUIA DE FRASES");
            Console.WriteLine("2) - JOGO");
            Console.WriteLine("3) - SAIR");
            Console.WriteLine();
            Console.WriteLine("Favor selecionar o número da opção desejada.");
            Console.Write("Sua resposta é: ");

            var resposta = Console.ReadLine();
            if (resposta is not null)
            {
                switch (resposta)
                {
                    case "1":
                        GuiaFrases();
                        break;
                    case "2":
                        Game();
                        break;
                    case "3":
                        Console.WriteLine();
                        Console.WriteLine("Finalizando...");
                        Console.WriteLine("Até logo!");
                        return;
                    default:
                        Console.WriteLine("-----------------------MENU------------------------");
                        Console.WriteLine("Resposta invalida, tente novamente!");
                        Console.WriteLine();
                        break;
                }
            }
        }
    }

    public static void Game()
    {
        Console.WriteLine("-----------------------JOGO------------------------");
        Console.WriteLine();
        Console.WriteLine("1) - Esta pronto, vamos começar?");
        Console.WriteLine("2) - Precisa de ajuda?");
        Console.WriteLine("3) - Voltar");
        Console.WriteLine("4) - Sair");
        Console.WriteLine();
        Console.Write("Sua resposta é: ");

        var resposta = Console.ReadLine();
        if (resposta is not null)
        {
            switch (resposta)
            {
                case "1":
                    IniciarJogo();
                    break;
                case "2":
                    ComoFunciona();
                    break;
                case "3":
                    Main();
                    break;
                case "4":
                    Console.WriteLine();
                    Console.WriteLine("Finalizando...");
                    Console.WriteLine("Até logo!");
                    Environment.Exit(0);
                    return;
                default:
                    Console.WriteLine("Resposta invalida, tente novamente!");
                    Console.WriteLine();
                    Game();
                    break;
            }
        }
    }

    public static void ComoFunciona()
    {
        Console.WriteLine();
        Console.WriteLine("-------------------COMO FUNCIONA-------------------");
        Console.WriteLine("1 - São diversas frases aleatórias.");
        Console.WriteLine("2 - Você terá que traduzir da maneira correta.");
        Console.WriteLine("3 - Português ----> Inglês OU Inglês ----> Português.");
        Console.WriteLine("4 - Para que sua frase esteja correta, use os caracteres especiais e acentos assim como nas frases - ('.', '?', '!', '´', '~').");
        Console.WriteLine("5 - Você poderá sair a qualquer momento é só digitar (Sair).");
        Console.WriteLine();
        Console.WriteLine("----------------------EXEMPLOS---------------------");
        Console.WriteLine("1 - What's your name? ------> Qual é o seu nome?");
        Console.WriteLine("2 - Eu não estou dormindo agora. ------> I'm not sleeping now.");
        Console.WriteLine();
        Console.WriteLine("---------------------PREPARADO?--------------------");
        Console.WriteLine("Agora vamos colocar em pratica! Se estiver pronto é so digitar (1), se não (2).");
        Console.WriteLine();
        Console.Write("Sua resposta é: ");

        var resposta = Console.ReadLine();

        if (resposta is not null && resposta.ToLower().Equals("1"))
        {
            IniciarJogo();
        }
        else
        {
            if (resposta is not null && resposta.ToLower().Equals("2"))
            {
                return;
            }
            Console.WriteLine("Resposta invalida, tente novamente!");
            ComoFunciona();
        }
    }

    public static void IniciarJogo()
    {
        Console.WriteLine();

        var ramdom = new Random();
        var list = new SimplePresent().List();

        //Preencher em ordem aleatória
        var listaSimplePresents = list.OrderBy(a => ramdom.Next()).ToList();

        Console.WriteLine("Se quiser desistir é só digitar (Sair)");
        Console.WriteLine("----------------------EXERCICIOS---------------------");
        Console.WriteLine();

        //Simple present 
        for (int i = 0; i < listaSimplePresents.Count;)
        {
            while (true)
            {
                Console.WriteLine("Frase: " + listaSimplePresents[i].Value);

                var traducao = Console.ReadLine();
                if (traducao.ToLower().Equals("sair"))
                    return;

                if (listaSimplePresents[i].Description.Trim().ToLower().Equals(traducao.Trim().ToLower()))
                {
                    Console.WriteLine();
                    Console.WriteLine("---------Correto, vamos para o proximo.----------");
                    Console.WriteLine();

                    i++;
                    break;
                }
                else
                {
                    Console.WriteLine("---------Tente novamente----------");
                    Console.WriteLine();
                    break;
                }
            }
        }
    }

    public static void GuiaFrases()
    {
        Console.WriteLine("------------------GUIA DE FRASES--------------------");
        Console.WriteLine();
        Console.WriteLine("Escolha uma opção:");
        Console.WriteLine("1) - Viagem -> Compras -> Básico");
        Console.WriteLine("2) - Viagem -> Compras -> Roupas");
        Console.WriteLine();
        Console.WriteLine("3) - Voltar");
        Console.WriteLine("4) - Sair");
        Console.WriteLine();
        Console.Write("Sua resposta é: ");

        var resposta = Console.ReadLine();
        if (resposta is not null)
        {
            switch (resposta)
            {
                case "1":
                    GuiaFrasesBasico();
                    break;
                //case "2":
                //    GuiaFrasesRoupas();
                //    break;
                case "3":
                    Main();
                    break;
                case "4":
                    Console.WriteLine();
                    Console.WriteLine("Finalizando...");
                    Console.WriteLine("Até logo!");
                    Environment.Exit(0);
                    return;
                default:
                    Console.WriteLine("Resposta invalida, tente novamente!");
                    Console.WriteLine();
                    Game();
                    break;
            }
        }
    }

    public static void GuiaFrasesBasico()
    {
        Console.WriteLine();

        var listaCompraBasico = new Purchase().ListShoppingBasic();

        Console.WriteLine("-----------------------BÁSICO-----------------------");
        Console.WriteLine();

        foreach (var item in listaCompraBasico)
        {
            Console.WriteLine(item.Id + ") - " + item.DescriptionBRL + "                        ->                        " + item.Value);
            Console.WriteLine(item.Id + ") - " + item.Description);
            Console.WriteLine();
            Console.WriteLine("-----");
            Console.WriteLine();
        }

        GuiaFrases();
    }
}