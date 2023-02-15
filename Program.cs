string nome;
int idade;



    Console.WriteLine("Bem vindo ao meu primeiro projeto de 2023.");
    Console.WriteLine("Por favor digite seu nome: ");
    nome = Console.ReadLine()!;

    Console.WriteLine("Por favor digite sua idade: ");
    idade = Convert.ToInt32(Console.ReadLine());

 Console.Clear();   

    if (idade >= 18)
        {
        Console.WriteLine($"Seja bem vindo {nome}! ");
        }

    else 

    Console.WriteLine("IDADE NÃO PERMITIDA!");