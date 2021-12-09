using System;

namespace Projeto_Calculadora
{
  class Program
  {
    static void Main(string[] args)
    {
      String opcao = $"{-1}";
      string opcaoselecionada = $"{-1}";

      Console.Clear();

      menuInicial();
      Console.Write("\nDigite sua opção: ");
      opcao = Console.ReadLine().ToUpper();


      if (opcao == "S")
      {
        Console.Clear();
        Console.WriteLine("Obrigado por utilizar o programa!!");
        Environment.Exit(-1);
      }

      else if (opcao == "1")
      {
        Console.Clear();

        do
        {
          menuOPbasicas();
          opcaoselecionada = selecioneOpcao();
          ExecutaOpcaoBASICA(opcaoselecionada);
        } while (opcaoselecionada != "S");
      }

      else if (opcao == "2")
      {
        Console.Clear();

        do
        {
          menuOPavancadas();
          opcaoselecionada = selecioneOpcao();
          ExecutaOpcaoAvancada(opcaoselecionada);
        } while (opcaoselecionada != "S");
      }

      else if (opcao == "3")
      {
        Console.Clear();

        do
        {
          menuEXRA();
          opcaoselecionada = selecioneOpcao();
          ExecutaOpEXRA(opcaoselecionada);
        } while (opcaoselecionada != "S");
      }

      else if (opcao == "4")
      {
        Console.Clear();

        do
        {
          menuCREDITOS();
          opcaoselecionada = selecioneOpcao();
          ExecutaOpCREDITO(opcaoselecionada);
        } while (opcaoselecionada != "S");
      }





      static void menuCREDITOS()
      {
        string menuCREDITOS =
@"
| ==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-|
| - - - - - Creditos     - - - - - - - - - - - - - - - - - - - - - - - |  
|                                                                      |
| ->> William Itália Nogueira                                          |
| ->> Site do projeto: https://github.com/William-italia/Calculadora   |
|                                                                      |
|  - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - |
| V - Voltar                                                           |      
|  - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - |
| S - Sair                                                             |
|  - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - |
| ==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-|
";

        Console.WriteLine(menuCREDITOS);
      }

      static void menuInicial()
      {
        string menuInicial =
  @"
|================================|
|     ===== Calculadora =====    |
|================================|
|    ===== Menu Opções =====     |
|================================|
| 1 - Operações Basicas          |
|  ----------------------------- |
| 2 - Operações Avançadas        |
|  ----------------------------- |
| 3 - Exponenciação e Radiciação |
|  ----------------------------- |
| 4 - Creditos                   |
|  ----------------------------- |
| S - Sair                       |
|  ----------------------------- |
|================================|";

        Console.WriteLine(menuInicial);
      }

      static void menuOPbasicas()
      {
        string menuOPbasicas =
   @"
|===============================|
|    ===== Calculadora =====    |
|===============================|
|    ===== Op. Basicas =====    |
|===============================|
| 1 - Soma                      |
|  ---------------------------  |
| 2 - Subtração                 |
|  ---------------------------  |
| 3 - Multiplicação             |
|  ---------------------------  |
| 4 - Divisão                   |
|  ---------------------------  |
| V - Voltar                    |
|  ---------------------------  |
| S - SAIR                      |
|  ---------------------------  |
|===============================|";

        Console.WriteLine(menuOPbasicas);
      }

      static void menuOPavancadas()
      {

        string menuOPavancadas =
        @"
|===============================|
|   ===== Calculadora  =====    |
|===============================|
|   ===== Op.Avançadas =====    |
|===============================|
| 1 - Equação do 2º Grau        |
|  ---------------------------  |
| 2 - Media Decimal             |
|  ---------------------------  |
| 3 - Heron (Triangulo)         |
|  ---------------------------  |
| V - Voltar                    |
|  ---------------------------  |
| S - SAIR                      |
|  ---------------------------  |
|===============================|";

        Console.WriteLine(menuOPavancadas);
      }

      static void menuEXRA()
      {
        string menuEXRA =
  @"
|=============================================|
|           ===== Calculadora  =====          |
|=============================================|
|   ===== Exponenciação e Radiciação =====    |
|=============================================|
| 1 - Radiciação                              |
|  ------------------------------------------ |
| 2 - Exponenciação                           |
|  -----------------------------------------  |
| V - Voltar                                  |
|  -----------------------------------------  |
| S - SAIR                                    |
|  -----------------------------------------  |
|=============================================|";

        Console.WriteLine(menuEXRA);
      }



      static string selecioneOpcao()
      {
        Console.Write("\nDigite sua opção: ");
        string opcao = Console.ReadLine().ToUpper();
        return opcao;
      }



      static void ExecutaOpCREDITO(string opcao)
      {

        switch (opcao)
        {

          case "V":

            string opcaoselecionada = $"{-1}";
            Console.Clear();
            menuInicial();
            Console.Write("\nDigite sua opção: ");
            opcao = Console.ReadLine().ToUpper();

            if (opcao == "S")
            {
              Console.Clear();
              Console.WriteLine("Obrigado por utilizar o programa!!");
              Environment.Exit(-1);
            }

            if (opcao == "1")
            {
              Console.Clear();
              do
              {
                menuOPbasicas();
                opcaoselecionada = selecioneOpcao();
                ExecutaOpcaoBASICA(opcaoselecionada);
              } while (opcaoselecionada != "S");

            }

            else if (opcao == "2")
            {
              Console.Clear();
              do
              {
                menuOPavancadas();
                opcaoselecionada = selecioneOpcao();
                ExecutaOpcaoAvancada(opcaoselecionada);
              } while (opcaoselecionada != "S");
            }

            else if (opcao == "3")
            {
              Console.Clear();
              do
              {
                menuEXRA();
                opcaoselecionada = selecioneOpcao();
                ExecutaOpEXRA(opcaoselecionada);
              } while (opcaoselecionada != "S");
            }

            else if (opcao == "4")
            {
              Console.Clear();

              do
              {
                menuCREDITOS();
                opcaoselecionada = selecioneOpcao();
                ExecutaOpCREDITO(opcaoselecionada);
              } while (opcaoselecionada != "S");
            }

            break;

          case "S":
            Console.Clear();
            Console.WriteLine("Obrigado por utilizar o programa!!");
            Environment.Exit(-1);

            break;
        }
      }

      static void ExecutaOpcaoBASICA(string opcao)
      {
        switch (opcao)
        {

          case "1":
            string opcaorepetirsoma;
            do
            {
              efetuasoma();

              Console.Write("\nDeseja continuar? [S/N]");
              opcao = Console.ReadLine().ToUpper();
              opcaorepetirsoma = opcao;
              Console.Clear();
            } while (opcaorepetirsoma != "N");
            break;

          case "2":
            string opcaorepetirsub;

            do
            {
              efetuasubtracao();

              Console.Write("\nDeseja continuar? [S/N]");
              opcao = Console.ReadLine().ToUpper();
              opcaorepetirsub = opcao;
              Console.Clear();
            } while (opcaorepetirsub != "N");

            break;

          case "3":
            string opcaorepetirMUL;
            do
            {
              efetuamultiplicacao();
              Console.Write("\nDeseja continuar? [S/N]");
              opcao = Console.ReadLine().ToUpper();
              opcaorepetirMUL = opcao;
              Console.Clear();

            } while (opcaorepetirMUL != "N");

            break;

          case "4":
            string opcaorepetirDIV;
            do
            {
              efetuadivisao();
              Console.Write("\nDeseja continuar? [S/N]");
              opcao = Console.ReadLine().ToUpper();
              opcaorepetirDIV = opcao;
              Console.Clear();

            } while (opcaorepetirDIV != "N");

            break;

          case "V":

            string opcaoselecionada = $"{-1}";
            Console.Clear();
            menuInicial();
            Console.Write("\nDigite sua opção: ");
            opcao = Console.ReadLine().ToUpper();

            if (opcao == "S")
            {
              Console.Clear();
              Console.WriteLine("Obrigado por utilizar o programa!!");
              Environment.Exit(-1);
            }

            if (opcao == "1")
            {
              Console.Clear();
              do
              {
                menuOPbasicas();
                opcaoselecionada = selecioneOpcao();
                ExecutaOpcaoBASICA(opcaoselecionada);
              } while (opcaoselecionada != "S");

            }

            else if (opcao == "2")
            {
              Console.Clear();
              do
              {
                menuOPavancadas();
                opcaoselecionada = selecioneOpcao();
                ExecutaOpcaoAvancada(opcaoselecionada);
              } while (opcaoselecionada != "S");
            }

            else if (opcao == "3")
            {
              Console.Clear();
              do
              {
                menuEXRA();
                opcaoselecionada = selecioneOpcao();
                ExecutaOpEXRA(opcaoselecionada);
              } while (opcaoselecionada != "S");
            }

            else if (opcao == "4")
            {
              Console.Clear();

              do
              {
                menuCREDITOS();
                opcaoselecionada = selecioneOpcao();
                ExecutaOpCREDITO(opcaoselecionada);
              } while (opcaoselecionada != "S");
            }

            break;

          case "S":
            Console.Clear();
            Console.WriteLine("Obrigado por utilizar o programa!!");
            Environment.Exit(-1);

            break;
        }
      }

      static void ExecutaOpEXRA(string opcao)
      {
        switch (opcao)
        {

          case "1":
            string opcaorepetirRaiz;

            do
            {
              efetuaraiz();

              Console.Write("\nDeseja continuar? [S/N]");
              opcao = Console.ReadLine().ToUpper();
              opcaorepetirRaiz = opcao;
              Console.Clear();
            } while (opcaorepetirRaiz != "N");
            break;

          case "2":
            string opcaorepetirEX;
            do
            {
              efetuaExponenciação();

              Console.Write("\nDeseja continuar? [S/N]");
              opcao = Console.ReadLine().ToUpper();
              opcaorepetirEX = opcao;
              Console.Clear();
            } while (opcaorepetirEX != "N");
            break;


          case "V":

            string opcaoselecionada = $"{-1}";
            Console.Clear();
            menuInicial();
            Console.Write("\nDigite sua opção: ");
            opcao = Console.ReadLine().ToUpper();

            if (opcao == "S")
            {
              Console.Clear();
              Console.WriteLine("Obrigado por utilizar o programa!!");
              Environment.Exit(-1);
            }

            if (opcao == "1")
            {
              do
              {
                Console.Clear();
                menuOPbasicas();
                opcaoselecionada = selecioneOpcao();
                ExecutaOpcaoBASICA(opcaoselecionada);
              } while (opcaoselecionada != "S");

            }
            else if (opcao == "2")
            {
              do
              {
                Console.Clear();
                menuOPavancadas();
                opcaoselecionada = selecioneOpcao();
                ExecutaOpcaoAvancada(opcaoselecionada);
              } while (opcaoselecionada != "S");
            }

            else if (opcao == "3")
            {
              Console.Clear();
              do
              {
                menuEXRA();
                opcaoselecionada = selecioneOpcao();
                ExecutaOpEXRA(opcaoselecionada);
              } while (opcaoselecionada != "S");
            }

            else if (opcao == "4")
            {
              Console.Clear();

              do
              {
                menuCREDITOS();
                opcaoselecionada = selecioneOpcao();
                ExecutaOpCREDITO(opcaoselecionada);
              } while (opcaoselecionada != "S");
            }

            break;

          case "S":
            Console.Clear();
            Console.WriteLine("Obrigado por utilizar o programa!!");
            Environment.Exit(-1);

            break;
        }
      }

      static void ExecutaOpcaoAvancada(string opcao)
      {
        switch (opcao)
        {

          case "1":
            string opcaorepetirequa;
            do
            {
              efetuaequacao2();

              Console.Write("\nDeseja continuar? [S/N]");
              opcao = Console.ReadLine().ToUpper();
              opcaorepetirequa = opcao;
              Console.Clear();
            } while (opcaorepetirequa != "N");

            break;

          case "2":
            string opcaorepetirmedia;
            do
            {
              efetuamediaDecimal();

              Console.Write("\nDeseja continuar? [S/N]");
              opcao = Console.ReadLine().ToUpper();
              opcaorepetirmedia = opcao;
              Console.Clear();
            } while (opcaorepetirmedia != "N");


            break;

          case "3":
            string opcaorepetirHERON;
            do
            {
              efetuaHeron();
              Console.Write("\nDeseja continuar? [S/N]");
              opcao = Console.ReadLine().ToUpper();
              opcaorepetirHERON = opcao;
              Console.Clear();
            } while (opcaorepetirHERON != "N");

            break;

          case "V":

            string opcaoselecionada = $"{-1}";
            Console.Clear();
            menuInicial();
            Console.Write("\nDigite sua opção: ");
            opcao = Console.ReadLine().ToUpper();

            if (opcao == "S")
            {
              Console.Clear();
              Console.WriteLine("Obrigado por utilizar o programa!!");
              Environment.Exit(-1);
            }

            if (opcao == "1")
            {
              Console.Clear();
              do
              {
                menuOPbasicas();
                opcaoselecionada = selecioneOpcao();
                ExecutaOpcaoBASICA(opcaoselecionada);
              } while (opcaoselecionada != "S");

            }
            else if (opcao == "2")
            {
              Console.Clear();
              do
              {
                menuOPavancadas();
                opcaoselecionada = selecioneOpcao();
                ExecutaOpcaoAvancada(opcaoselecionada);
              } while (opcaoselecionada != "S");
            }

            else if (opcao == "3")
            {
              Console.Clear();
              do
              {
                menuEXRA();
                opcaoselecionada = selecioneOpcao();
                ExecutaOpEXRA(opcaoselecionada);
              } while (opcaoselecionada != "S");
            }

            else if (opcao == "4")
            {
              Console.Clear();

              do
              {
                menuCREDITOS();
                opcaoselecionada = selecioneOpcao();
                ExecutaOpCREDITO(opcaoselecionada);
              } while (opcaoselecionada != "S");
            }

            break;

          case "S":
            Console.Clear();
            Console.WriteLine("Obrigado por utilizar o programa!!");
            Environment.Exit(-1);

            break;
        }
      }



    }

    static void efetuasoma()
    {
      try
      {

        Console.Clear();
        Console.WriteLine("- - -          SOMA          - - -");
        Console.Write("\nDigite um numero: ");
        double numeroUm = Convert.ToDouble(Console.ReadLine());
        Console.Write("Digite mais um numero: ");
        double numeroDois = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"\nResulado:\n{numeroUm} + {numeroDois} = {numeroUm + numeroDois}");
      }
      catch (FormatException)
      {
        Console.Clear();
        Console.WriteLine("Número em formato inválido.");
      }
    }

    static void efetuasubtracao()
    {
      try
      {

        Console.Clear();
        Console.WriteLine("- - -          SUBTRAÇÃO          - - -");
        Console.Write("\nDigite um numero: ");
        double numeroUmSub = Convert.ToDouble(Console.ReadLine());
        Console.Write("Digite mais um numero: ");
        double numeroDoisSub = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"\nResultado de {numeroUmSub} - {numeroDoisSub} = {numeroUmSub - numeroDoisSub}");
      }
      catch (FormatException)
      {
        Console.Clear();
        Console.WriteLine("Número em formato inválido.");
      }
    }

    static void efetuamultiplicacao()
    {
      try
      {

        Console.Clear();
        Console.WriteLine("- - -          MULTIPLICAÇÃO          - - -");
        Console.Write("\nDigite um numero: ");
        double numeroUmMUL = Convert.ToDouble(Console.ReadLine());
        Console.Write("Digite mais um numero: ");
        double numeroDoisMUL = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"\nResultado de {numeroUmMUL} * {numeroDoisMUL} = {numeroUmMUL * numeroDoisMUL}");
      }
      catch (FormatException)
      {
        Console.Clear();
        Console.WriteLine("Número em formato inválido.");
      }
    }

    static void efetuadivisao()
    {
      try
      {

        int Numerador, Denominador;

        //Receba um numerador e um denominador. Exiba o resultado da divisão ou "Não é possível dividir por zero.", conforme o caso.
        Console.Clear();
        Console.WriteLine("--- Divisao ---\n");

        Console.Write("Digite o numerador....: ");
        bool numeradorV = Int32.TryParse(Console.ReadLine(), out Numerador);

        Console.Write("Digite o denominador...: ");
        bool DenominadorV = Int32.TryParse(Console.ReadLine(), out Denominador);



        if (!numeradorV || !DenominadorV)
        {
          Console.WriteLine("Numero invalido.");
          Environment.Exit(-1);
        }
        else if (Denominador == 0 || Denominador == -0)
        {
          Console.WriteLine("Não é possível dividir por zero");
        }
        else
        {
          Console.WriteLine($"\n{Numerador} dividido por {Denominador} é {Numerador / Denominador}");
        }
      }
      catch (FormatException)
      {
        Console.Clear();
        Console.WriteLine("Número em formato inválido.");
      }
    }

    static void efetuaequacao2()
    {
      try
      {

        Console.Clear();
        double a, b, c, delta, x1, x2;

        Console.WriteLine("- - - Equação do segundo grau - - -");
        Console.WriteLine("Digite o valor das letras a, b, c.\n");
        Console.Write("(a): ");
        a = double.Parse(Console.ReadLine());
        Console.Write("(b): ");
        b = Double.Parse(Console.ReadLine());
        Console.Write("(c): ");
        c = Double.Parse(Console.ReadLine());

        delta = Math.Pow(b, 2) - 4 * a * c;
        x1 = (-b + Math.Sqrt(delta)) / (2 * a);
        x2 = (-b - Math.Sqrt(delta)) / (2 * a);

        if (a == 0)
        {
          Console.WriteLine("Não é uma equação de segundo grau!");
        }
        else if (delta < 0)
        {
          Console.WriteLine($"Como delta é igual a {delta:N2} a equação não possui raízes reais!");
        }
        else
        {
          Console.WriteLine($"\nO valor de delta é: {delta:N2}");
          Console.WriteLine($"x¹ = {x1:N2}");
          Console.WriteLine($"x² = {x2:N2}");
        }
      }
      catch (FormatException)
      {
        Console.Clear();
        Console.WriteLine("Número em formato inválido.");
      }
    }

    static void efetuaraiz()
    {
      try
      {

        Console.Clear();


        Console.WriteLine("= = = Radiciação = = =");

        Console.Write("\nQuaL numero você deseja: ");
        double Numero = int.Parse(Console.ReadLine());
        double resposta = Math.Sqrt(Numero);

        Console.WriteLine($"\nRaiz quadrada de {Numero} é igual a: {resposta:N2}");
      }
      catch (FormatException)
      {
        Console.Clear();
        Console.WriteLine("Número em formato inválido.");
      }
    }

    static void efetuamediaDecimal()
    {
      try
      {
        Console.Clear();

        int i;
        decimal maior = 0;
        decimal menor = 0;
        decimal nr = 0;
        Decimal soma = 0;
        Decimal media = 0;


        Console.WriteLine("= = = Media Decimal = = =");

        Console.Write("Quantos numeros quer utilizar [entre 1 e 10]? ");
        int Quantidade = int.Parse(Console.ReadLine());

        if (Quantidade <= 10)
        {

          for (i = 1; i <= Quantidade; i++)
          {
            Console.Write("Número #0" + i + ": ");
            nr = Convert.ToDecimal(Console.ReadLine());


            if (i == 1)
            {
              maior = nr;
              menor = nr;
            }
            if (nr < menor)
            {
              menor = nr;
            }
            if (nr > maior)
            {
              maior = nr;
            }

            soma = soma + nr;
          }
          media = soma / Quantidade;
          Console.WriteLine($"\nTotal: {soma}");
          Console.WriteLine($"Media: {media:N2}");
          Console.WriteLine($"maior numero: {maior}");
          Console.WriteLine($"menor numero: {menor}");

        }
        else
        {
          Console.WriteLine("\nDigite apenas numeros entre 1 e 10, Obrigado!");
        }

      }
      catch (FormatException)
      {
        Console.Clear();
        Console.WriteLine("Número em formato inválido.");
      }


    }

    static void efetuaExponenciação()
    {
      try
      {
        Console.Clear();
        Console.WriteLine("- - -          potencia          - - -");
        Console.Write("\nnumero base: ");
        double numeroUm = Convert.ToDouble(Console.ReadLine());
        Console.Write("Expoente: ");
        double numeroDois = Convert.ToDouble(Console.ReadLine());
        double resultado = Math.Pow(numeroUm, numeroDois);
        Console.WriteLine($"\nResulado: {resultado}");
      }
      catch (FormatException)
      {
        Console.Clear();
        Console.WriteLine("Número em formato inválido.");
      }
    }


    static void efetuaHeron()
    {
      Double a, b, c;
      try
      {

        Console.Clear();
        Console.WriteLine("- - - Exercicio heron triangulo - - -");

        Console.Write("(a): ");
        a = double.Parse(Console.ReadLine());
        Console.Write("(b): ");
        b = double.Parse(Console.ReadLine());
        Console.Write("(c): ");
        c = double.Parse(Console.ReadLine());

        if (!trianguloReal(a, b, c))
        {
          Console.WriteLine($"\nNão é um triângulo");
        }
        else
        {
          string tipo = modelotriangulo(a, b, c);
          double area = areadotriangulo(a, b, c);

          Console.WriteLine($"\nO triângulo {a}, {b}, {c} é do tipo {tipo} e tem àrea de {area:N2}.");
        }
      }

      catch (FormatException)
      {
        Console.Clear();
        Console.WriteLine("Numero em formato invalido");
      }
    }
    static bool trianguloReal(double a, double b, double c)
    {
      bool trianguloValido = (
          a < (b + c)
          && a > Math.Abs(b - c)
          && b < (a + c)
          && b > Math.Abs(a - c)
          && c < (a + b)
          && c > Math.Abs(a - b)
      );
      return trianguloValido;
    }
    static string modelotriangulo(double a, double b, double c)
    {
      if (a == b && b == c)
      {
        return "Equilátero";
      }
      else if (a != b && a != c && b != c)
      {
        return "escaleno";
      }
      else
      {
        return "isósceles";
      }
    }
    static double areadotriangulo(double a, double b, double c)
    {
      double s = (a + b + c) / 2;
      return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
    }
  }
}