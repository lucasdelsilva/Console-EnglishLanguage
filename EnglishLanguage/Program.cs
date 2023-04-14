using EnglishLanguage.Phrases.SimplePresent;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("-----------------------MENU------------------------");
        while (true)
        {
            Console.WriteLine("1 - Se já sabe como funciona é so digitar (S).");
            Console.WriteLine("2 - Se ainda não sabe é so digitar (N).");
            Console.WriteLine();
            Console.Write("Sua resposta é: ");

            var resposta = Console.ReadLine();
            if (resposta is not null)
                resposta = resposta.ToString().ToLower();

            switch (resposta)
            {
                case "s":
                    LetsBora();
                    break;
                case "n":
                    ComoFunciona();
                    break;
                case "sair":
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
        Console.WriteLine("---------------------BOA SORTE!--------------------");
        Console.WriteLine("Agora vamos colocar em pratica! Se estiver pronto é so digitar (S), se não (N).");
        Console.WriteLine();

        Console.Write("Sua resposta é: ");

        var resposta = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("-----------------------MENU------------------------");

        if (resposta is not null && resposta.ToLower().Equals("s"))
            LetsBora();
        else
            return;
    }

    public static void LetsBora()
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
}