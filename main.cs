using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
  static void Main(string[] args)
  {
    bool showMenu = true;
      while (showMenu)
      {
        showMenu = MainMenu();
      }
  }
  private static bool MainMenu()
  {         
    Interador listinha = new Interador();

    Console.WriteLine("\r\nEscolha sua opção:");
    Console.WriteLine("1) Retângulo");
    Console.WriteLine("2) Triângulo");
    Console.WriteLine("3) Sair");
    Console.Write("\r\nDigite sua opção: ");
 
    switch (Console.ReadLine())
    {
      case "1":
      Console.Clear();
      Console.Write("\r\nEntre a base e depois entre com altura do retângulo.\n");
      Retangulo ret = new Retangulo(largura: Convert.ToDouble(Console.ReadLine()), altura: Convert.ToDouble(Console.ReadLine()));
      listinha.Figuras.Add(ret);

      // acessando métodos get
      Console.WriteLine("\r\nBase:\t\t{0:0.0}", ret.Largura);
      Console.WriteLine("Altura:\t\t{0:0.0}", ret.Altura);
      Console.WriteLine("Área:\t\t{0:0.0}", ret.Area);
      Console.WriteLine("Perímetro\t{0:0.0}", ret.Perimetro);

      listinha.ImprimirFiguras();
      return true;
      
      case "2":
      Console.Clear();
      Console.Write("\r\nEntre a base e depois entre com altura do triângulo.\n");
      Triangulo tri = new Triangulo(baset: Convert.ToDouble(Console.ReadLine()), altura: Convert.ToDouble(Console.ReadLine()));
      listinha.Figuras.Add(tri);

      // acessando métodos get
      Console.WriteLine("\r\nBase:\t\t{0:0.0}", tri.Baset);
      Console.WriteLine("Altura:\t\t{0:0.0}", tri.Altura);
      Console.WriteLine("Área:\t\t{0:0.0}",     tri.Area);
      Console.WriteLine("Perímetro\t{0:0.0}", tri.Perimetro);

      listinha.ImprimirFiguras();
      return true;
      
      case "3":
      listinha.ImprimirFiguras();
      Console.WriteLine("Obrigado e volte sempre :) !");
      return false;
      default:
      return true;
    }
  }
}
