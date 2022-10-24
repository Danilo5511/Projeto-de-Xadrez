

namespace tabuleiro
{
    class Tabuleiro
    {
        public int linha { get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas;

        public Tabuleiro(int linha, int colunas, Peca[,] pecas)
        {
            this.linha = linha;
            this.colunas = colunas;
            pecas = new Peca[linha,colunas];
        }
    }
}
