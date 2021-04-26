using System;

class Program
{
  static void Main(string[] args)
  {
    string alternativa;

    Console.Write("\r\nDigite (1) para começar ou qualquer outra coisa para fechar: ");
    alternativa = Console.ReadLine();
    if(alternativa == "1")
    {
      do{
        Console.Write("\r\nEntre a base e depois entre com altura do retângulo.\n");
        Retangulo ret = new Retangulo(largura: Convert.ToDouble(Console.ReadLine()), altura: Convert.ToDouble(Console.ReadLine()));

        // acessando métodos get
        Console.WriteLine("\r\nBase:\t\t{0:0.0}", ret.Largura);
        Console.WriteLine("Altura:\t\t{0:0.0}", ret.Altura);
        Console.WriteLine("Área:\t\t{0:0.0}", ret.Area);
        Console.WriteLine("Perímetro\t{0:0.0}", ret.Perimetro);

        Console.Write("Digite (1) para começar ou qualquer outra coisa para fechar: ");
        alternativa = Console.ReadLine();
      }
      while (alternativa == "1");
    }
    else
    {
      Console.WriteLine("Obrigado e volte sempre :) !");
    }
  }
}