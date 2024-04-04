using System;
using System.Data;



namespace tabuleiro
{
    internal class Tabuleiro
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

        public Peca ObterPeca(int linha, int coluna)
        {
            return pecas[linha, coluna];
        }
        
        public Peca ObterPeca(Posicao posicao)
        {
            return pecas[posicao.linha, posicao.coluna];
        }

        public bool ExistePeca(Posicao posicao)
        {
            ValidarPosicao(posicao);
            return ObterPeca(posicao) != null;
        }


        public void InserirPeca(Peca peca, Posicao posicao)
        {
            if (ExistePeca(posicao))
            {
                throw new TabuleiroException($"Já existe uma peça nessa posição (posição -> linha: {posicao.linha} coluna: {posicao.coluna})");
            }

            pecas[posicao.linha, posicao.coluna] = peca;
            peca.posicao = posicao;
        }

        public bool PosicaoValida(Posicao posicao)
        {
            if (posicao.linha < 0 || posicao.linha >= linhas || posicao.coluna < 0 || posicao.coluna >= colunas)
            {
                return false;
            }
            return true;
        }

        public void ValidarPosicao(Posicao posicao)
        {
            if (!PosicaoValida(posicao))
            {
                throw new TabuleiroException($"Posição inválida! (posição -> linha: {posicao.linha} coluna: {posicao.coluna})");
            }
        }
        
    
    }
}
