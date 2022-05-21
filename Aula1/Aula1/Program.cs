// See https://aka.ms/new-console-template for more information

/*
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

    // DECISAO SIMPLES
    if ( media % 2 == 0 )
    {   //  VERDADEIRO
        Console.WriteLine("NOTA PAR");
    }

    // DECISAO COMPOSTA
    if ( media >= 6 )
    {   //  VERDADEIRO
        Console.WriteLine("APROVADO!");
    }
    else
    {   // FALSO
        Console.WriteLine("REPROVADO!");
    }

    int dia;
    Console.Write("Digite um dia: ");
    dia = Convert.ToInt32(Console.ReadLine());
// DECISAO ENCADEADA
if (dia == 1)
    {
        Console.WriteLine("Hoje é Domingo!");
    }
    else
    {
        if (dia == 2)
        {
            Console.WriteLine("Hoje é segunda-feira!");
        }
        else
            if (dia == 3)
            {
                Console.WriteLine("Hoje é terça-feira!");
            }
            else
                if (dia == 4)
                {
                    Console.WriteLine("Hoje é quarta-feira!");
                }
                else
                    if (dia == 5)
                    {
                        Console.WriteLine("Hoje é quinta-feira!");
                    }
                    else
                        if (dia == 6)
                        {
                            Console.WriteLine("Hoje é sexta-feira!");
                        }
                        else
                            if (dia == 7)
                            {
                                Console.WriteLine("Hoje é Sábado!");
                            }   
                            else                           
                            {
                                Console.WriteLine("dia Incorreto");
                            }
        
    }

    //  DECISAO DE MULTIPLA ESCOLHA
    Console.Write("Digite um dia: ");
    dia = Convert.ToInt32(Console.ReadLine());
    
    //Console.Write("Hoje é ");
    switch (dia)
    {
        case 1:     Console.WriteLine("Domingo");           break;
        case 2:     Console.WriteLine("Segunda");           break;
        case 3:     Console.WriteLine("Terça");             break;
        case 4:     Console.WriteLine("Quarta");            break;
        case 5:     Console.WriteLine("Quinta");            break;
        case 6:     Console.WriteLine("Sexta");             break;
        case 7:     Console.WriteLine("Sábado");            break;
        default:    Console.WriteLine("Valor incorreto!");  break;
    }


*/

//  REPETIÇÃO

// WHILE    (ENQUANTO)
// DO WHILE (REPITA)
// FOR      (PARA)

/*
    int n=1;
    while ( n <= 10 ) {
        Console.WriteLine("n = " + n);
        n++;    //  n = n+1;
    }

    Console.WriteLine("*********************");
    int d = 1;
    do
    {
        Console.WriteLine("d = " + d);
        d++;
    }while( d <= 10 );

    Console.WriteLine("*********************");
    int i;
    for ( i = 1; i <= 10; i++) { 
        Console.WriteLine("i = " + i);   
    }

//***********************************************************

    int tabuada, i, n=1;

    do
    {
        Console.WriteLine("**********************");
        Console.Write("Escolha uma tabuada: ");
        tabuada = Convert.ToInt32(Console.ReadLine());
        for (i = 1; i <= 10; i++)
        {
            Console.WriteLine("{0} x {1} = {2}", tabuada, i, tabuada * i);
            //  2  x  1  =  2
        }

        Console.Write("\nDigite 1 para uma nova tabuada: ");
        n = Convert.ToInt32(Console.ReadLine());
        Console.Clear();

    } while ( n == 1 );

    Console.WriteLine("Obrigado por utilizar a nossa tabuada.");

// ***************************************


*/


/*
 
    Console.WriteLine(" *");  ("  ");
 
    N = Numero de repetições
    N = 3

1 -
    * * *

2 -  
    * * *
    * * * 
    * * * 
     
    
    * * * * *
    * * * * *
    * * * * *
    * * * * *
    
 
3 -
    *
    * *
    * * *

4 -
        *
      * *
    * * *
    
5 - 
    * * *
      * *
        *
        
6 - 
    * * *
    * *
    * 
      
7 - 
    
        *
      * * *  
    * * * * *
     
    
8 - 
    *
      *    
        *
        
9 - N = 5

      *   *  
    * * * * *
      *   *
    * * * * *  
      *   *
         
 */

int i, L, C, n=5;

    Console.WriteLine("1 - ");
    for (i = 0; i < n; i++) {
        Console.Write(" X");
    }


    Console.Write("\n\n2-\n");
    for (L = 0; L < n; L++)
    {
        for (C = 0; C < n; C++)
        {
            Console.Write(" X");
        }
        Console.Write("\n");
    }

    Console.Write("\n\n3-\n");
    for (L = 0; L < n; L++)
    {
        for (C = 0; C < n; C++)
        {
        if ( L >= C )
            Console.Write(" X");
        else
            Console.Write("  ");
        }
        Console.Write("\n");
    }

    Console.Write("\n\n4-\n");
    for (L = 0; L < n; L++)
    {
        for (C = 0; C < n; C++)
        {
            if (L <= C)
                Console.Write(" X");
            else
                Console.Write("  ");
        }
        Console.Write("\n");
    }

    Console.Write("\n\n5-\n");
    for (L = 0; L < n; L++)
    {
        for (C = 0; C < n; C++)
        {
            if ( L+C >= n-1 )
                Console.Write(" X");
            else
                Console.Write("  ");
        }
        Console.Write("\n");
    }

    Console.Write("\n\n6-\n");
    for (L = 0; L < n; L++)
    {
        for (C = 0; C < n; C++)
        {
            if (L + C <= n - 1)
                Console.Write(" X");
            else
                Console.Write("  ");
        }
        Console.Write("\n");
    }

    Console.Write("\n\n7-\n");
    for (L = 0; L < n; L++)
    {
        for (C = 0; C < (n*2 -1); C++)
        {
            if ( ( L + C >= n - 1 ) ^ ( C >= n+L ) ) 
                Console.Write(" X");
            else
                Console.Write("  ");
        }
        Console.Write("\n");
    }

    Console.Write("\n\n8-\n");
    for (L = 0; L < n; L++)
    {
        for (C = 0; C < n; C++)
        {
        if ( L == C )
            Console.Write(" X");
        else
            Console.Write("  ");
    }
        Console.Write("\n");
    }

    Console.Write("\n\n9-\n");
    for (L = 0; L < n; L++)
    {
        for (C = 0; C < n; C++)
        {
            if (L != C)
                Console.Write(" X");
            else
                Console.Write("  ");
        }
        Console.Write("\n");
    }

    Console.Write("\n\n10-\n");
    n = 5;
    for (L = 0; L < n; L++)
    {
        for (C = 0; C < n; C++)
        {
            if ( L % 2 == 1 || C % 2 == 1 )
                Console.Write(" X");
            else
                Console.Write("  ");
        }
        Console.Write("\n");
    }
Console.WriteLine("\n\n\n");
/*
5 - 
     *
   * *
 * * *

6 - 
 * * *
 * *
 * 
    

7 - 
        *
      * * *
    * * * * *
    

 */