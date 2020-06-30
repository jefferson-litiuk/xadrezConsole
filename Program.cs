using System;
using tabuleiro;
using xadrez;


namespace Xadrez.console
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8,8);

            tab.colocarPeca(new Torre(tab,Cor.Preta), new Posicao(0, 0));
            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(2, 4));
            tab.colocarPeca(new Rei(tab, Cor.Branca), new Posicao(8,8));

            Tela.imprimirTabuleiro(tab);

            Console.ReadLine();

        }

    }
}
