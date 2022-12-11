using System;
using tabuleiro;
using xadrez;

namespace Xadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.terminada)
                {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);

                    Console.Write("Origem: ");
                    Posicao origem=Tela.lerPoiscaoXadrez().toPosicao();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.lerPoiscaoXadrez().toPosicao();

                    partida.executaMovimento(origem, destino);
                }   
            }
            catch(TabuleiroException e)
            {
                Console.WriteLine(e.Message);

            }

//             PosicaoXadrez pos = new PosicaoXadrez('c',1);

//             Console.WriteLine(pos);

// Console.WriteLine(pos.toPosicao());
//             Console.ReadLine();
        }
    }
}
