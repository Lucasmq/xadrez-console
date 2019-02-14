using System;
using System.Collections.Generic;
using System.Text;

namespace xadrez_console.tabuleiro
{
    class Tabuleiro
    {
        public int linhas { get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }

        public Peca peca(int linha, int coluna)
        {
            return pecas[linha, coluna];
        }

        public void colocarPeca(Peca p, Posicao pos)
        {
            pecas[pos.Linha, pos.Coluna] = p;       // a string da peça p é colocada na posiçao[linha,coluna]
            p.posicao = pos;                        // é definida a posição da peça p
        }
    }
}
