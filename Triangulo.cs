using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Triangulo : Figura 
{
  private double _altura; // atributo
  private double _baset; // atributo

  public double Altura // propriedade
  {
    // leitura do atributo correspondente
    get
    {
      return this._altura;
    } 

    // escrita do atributo correspondente
    set
    {
      if (value <= 0)
      {
        Console.Write("Altura inválida\t");
      }
      else
      {
        this._altura = value;
        this.AtualizarArea();
        this.AtualizarPerimetro();
      }
    }
  }
  public double Baset // propriedade
  {
    // leitura do atributo correspondente
    get
    {
      return this._baset;
    }

    // escrita do atributo correspondente
    set
    {
      if (value <= 0)
      {
        Console.WriteLine("Base inválida");
      }
      else
      {
        this._baset = value;
        this.AtualizarArea();
        this.AtualizarPerimetro();
      }
    }
  }
  
  public Triangulo(double altura, double baset)
  {
    // escrita utilizando método set da propriedade
    this.Altura = altura;
    this.Baset = baset;
  }
  
  private void AtualizarArea()
  {
    this._area = (this._baset * this._altura) / 2;
  }
  
  private void AtualizarPerimetro()
  {
    this._perimetro.ToString("ef");
  }
}
