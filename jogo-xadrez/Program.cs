using System;
using Tabuleiro;
using Xadrez;

namespace jogo_xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez pos = new PosicaoXadrez('a', 1);

            Console.WriteLine(pos);
            Console.WriteLine( pos.StringToPosicao());

            Console.ReadLine();
        }
    }
}
