using System;
using System.Collections.Generic;
using System.Text;
using xadrez_console.tabuleiro;

namespace xadrez_console.xadrez
{
    class Cavalo : Peca
    {
        public Cavalo(Tabuleiro tab, Cor cor) : base(cor, tab)
        {
        }

        public override string ToString()
        {
            return "C";
        }

        private bool podeMover(Posicao pos)
        {
            Peca p = tab.peca(pos);
            return p == null || p.cor != cor;
        }



        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tab.linhas, tab.colunas];

            Posicao pos = new Posicao(0, 0);


            // frente direita
            pos.definirValores(posicao.Linha - 2, posicao.Coluna + 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
               
            }
            // frente direita
            pos.definirValores(posicao.Linha - 1, posicao.Coluna + 2);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;

            }
            // frente esquerda
            pos.definirValores(posicao.Linha - 2, posicao.Coluna - 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;

            }
            // frente esquerda
            pos.definirValores(posicao.Linha - 1, posicao.Coluna - 2);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;

            }

            // tras direita
            pos.definirValores(posicao.Linha + 2, posicao.Coluna + 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;

            }
            // tras direita
            pos.definirValores(posicao.Linha + 1, posicao.Coluna + 2);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;

            }

            // tras esquerda
            pos.definirValores(posicao.Linha + 2, posicao.Coluna - 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;

            }
            // tras esquerda
            pos.definirValores(posicao.Linha + 1, posicao.Coluna - 2);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;

            }



            return mat;
        }
    }
}
