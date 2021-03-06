using System;

class MainClass {

  //Exercício 01
  public static double calculadora (char operador,double n1,double n2) {

    switch (operador) {

      case '+':
        return n1 + n2;
      
      case '-':
        return n1 - n2;

      case '*':
        return n1 * n2;
      
      case '/':
        return n1 / n2;
      
      default:
        Console.WriteLine ("Operador inválido");
        return 0;
    }
  }

  //Exercício 02
  public static double cardapio (int codigo, int quant) {

    switch (codigo) {
      case 100:
        return quant * 1.70;

      case 101:
        return quant * 2.30;

      case 102:
        return quant * 2.60;

      case 103:
        return quant * 2.40;
      
      case 104:
        return quant * 2.50;

      case 105:
        return quant * 1;

      default:
        Console.WriteLine ("Código inválido!");
        return 0;
    }
  }

  //Exercício 03
  public static string urna (int JoseCouve, int JoanaBravo, int RobertoNove) {
    int maior = JoseCouve;
    string vencedor;

    if (maior < JoanaBravo) {
      maior = JoanaBravo;
    }

    else {
      if (maior < RobertoNove) {
        maior = RobertoNove;
      }
    }

    if (maior == JoseCouve) {
      vencedor = "José Couve";
      return vencedor;
    }

    else {
      if (maior == JoanaBravo) {
        vencedor = "Joana Bravo";
        return vencedor;
      }
    
      else {
        vencedor = "Roberto Nove";
        return vencedor;
      }
    }
/*
    else {
      vencedor = "Roberto Nove";
      return vencedor;
    }*/
  }


  public static void Main () {
    //Variáveis
    int resposta;
    double n1, n2;
    char operador;
    //Variáveis

    Console.WriteLine ("Digíte o número do Exercício (Caso queira sair digite 0) >> ");
    resposta = int.Parse(Console.ReadLine());

      switch (resposta) {
        case 1:
          Console.WriteLine ("Escolha um dos operadores.\n + Soma\n - Subtração\n * Multiplicação\n / Divisão");
          operador = char.Parse(Console.ReadLine());

          Console.WriteLine ("Digite o primeiro Valor: ");
          n1 = double.Parse (Console.ReadLine());

          Console.WriteLine ("Digite o primeiro Valor: ");
          n2 = double.Parse (Console.ReadLine());

          Console.WriteLine(calculadora (operador, n1, n2));
          break;
        
        case 2:
          Console.WriteLine ("Qual o seu pedido (Digite o código e a quantidade)? \n Código Produto Preço Unitário (R$)\n ---------------------------------\n 100  Cachorro quente   R$ 1,70\n 101   Bauru Simples    R$ 2,30\n 102   Bauru com ovo    R$ 2,60\n 103   Hamburguer       R$ 2,40\n 104   Cheeseburguer    R$ 2,50\n 105   Refrigerante     R$ 1,00");

          int codigo = int.Parse(Console.ReadLine());

          Console.WriteLine ("Digite a quantidade: ");
          int quant = int.Parse(Console.ReadLine());

          Console.WriteLine (cardapio (codigo, quant));
          break;

        case 3:
        //Variáveis
        int sentinela = 1;
        int JoseCouve = 0;
        int JoanaBravo = 0;
        int RobertoNove = 0;
        int Branco = 0;
        int Nulo = 0;
        //Variáveis
        while (sentinela == 1) {
          Console.WriteLine ("Digite o número do candidato (Caso não hoaja eleitores digite 1): \n 33 - José Couve\n 25 - Joana Bravo\n 10 - Roberto Nove\n 0 - Voto branco\n 4 - Voto nulo");
          int candidato = int.Parse(Console.ReadLine());

          switch (candidato) {
            case 33:
              ++JoseCouve;
              break;

            case 25:
              ++JoanaBravo;
              break;

            case 10:
              ++RobertoNove;
              break;

            case 0:
              ++Branco;
              break;

            case 4:
              ++Nulo;
              break;

            case 1:
              sentinela = 0;
              break;
            
            default:
              Console.WriteLine("Candidato inválido");
              break;
          }
        }

        Console.WriteLine ("O candidato vencedor foi {0}", urna(JoseCouve, JoanaBravo, RobertoNove));
        Console.WriteLine ("O total de votos em branco foi de {0}", Branco);
        Console.WriteLine ("O total de votos Nulos foi de {0}", Nulo);
        break;

    } 
  }
}