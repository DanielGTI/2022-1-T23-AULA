// See https://aka.ms/new-console-template for more information


    int valor1, valor2, total;
    String valor3, valor4, nome;
    double av1, av2, media;


    //  Inteiro
    valor1 = 10;
    valor2 = 20;

    //  String (Texto)
    valor3 = "5";

    Console.Write("Digite o seu nome: ");
    nome = Console.ReadLine();

    Console.Write("Digite um valor para somar: ");
    valor4 = Console.ReadLine();

                              //    Converter em INT  
    total = valor1 + valor2 + Convert.ToInt32( valor3 ) + Convert.ToInt32(valor4);

    Console.WriteLine("\nBem vindo " + nome + ", está e a sua calculadora.");
    Console.WriteLine("A soma dos valores: " + total);


    Console.WriteLine("\n\n**************** CALCULAR A MEDIA ********************\n\n");

    Console.Write("Digite a nota da AV1 = ");
    av1 = Convert.ToDouble( Console.ReadLine() );

    Console.Write("Digite a nota da AV2 = ");
    av2 = Convert.ToDouble( Console.ReadLine() );

    media = ( av1 + av2 ) / 2;

    Console.WriteLine("Valor da média = " + media);
    
    if( media >= 6)
    {   //  VERDADEIRO
        Console.WriteLine("APROVADO!");
    }
    else
    {   // FALSO
        Console.WriteLine("REPROVADO!");
    }


    /*
     
    se ( media >= 6 )
        APROVADOR

    senao
        REPROVADO

     
     */