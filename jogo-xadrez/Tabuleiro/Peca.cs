﻿namespace Tabuleiro
{
    class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QtdMovimento { get; protected set; }
        public TabuleiroXadrez Tab { get; protected set; }

        public Peca(Posicao posicao, Cor cor, TabuleiroXadrez tab)
        {
            Posicao = posicao;
            Cor = cor;
            Tab = tab;
            this.QtdMovimento = 0;
        }
    }
}
