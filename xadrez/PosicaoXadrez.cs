using System;
using tabuleiro;
namespace xadrez {
    class PosicaoXadrez
    {
        public  char coluna{get;set;}
        public  int linha {get;set;}

        public PosicaoXadrez(char coluna, int linha)

        {
            this.coluna=coluna;
            this.linha=linha;   
        }

public Posicao toPosicao(){ // try
            // {
            //     Tabuleiro tab = new Tabuleiro(8, 8);

               
            //     tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
            //     tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
            //     tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));

            //     Tela.imprimirTabuleiro(tab);
            // }
            // catch(TabuleiroException e)
            // {
            //     Console.WriteLine(e.Message);

            // }

    return new Posicao(8-linha, coluna-'a');
}

        public override string ToString(){
            return ""+coluna+linha;
        }
        
    }

}