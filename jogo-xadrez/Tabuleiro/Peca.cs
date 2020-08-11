namespace Tabuleiro
{
    abstract class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QtdMovimento { get; protected set; }
        public TabuleiroXadrez Tab { get; protected set; }

        public Peca(TabuleiroXadrez tab, Cor cor)
        {
            Tab = tab;
            Cor = cor;
            Posicao = null;
            QtdMovimento = 0;
        }

        public void IncrementarQtdMovimentos()
        {
            QtdMovimento++;
        }

        public abstract bool[,] MovimentosPossiveis();
    }
}
