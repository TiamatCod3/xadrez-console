using System;
using tabuleiro;
using xadrez_console;



class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");

    Tabuleiro tab = new Tabuleiro(8,8);
    
    Tela.imprimirTabuleiro(tab);

  }
}