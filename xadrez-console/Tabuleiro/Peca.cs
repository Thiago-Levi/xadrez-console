using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xadrez_console.Tabuleiro
{
    internal class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor {  get; set; }
        public int QuantidadeDeMovimentos { get; set; }
        public Tabuleiro Tabuleiro { get; set; }

        public Peca(Posicao posicao, Tabuleiro tabuleiro, Cor cor) 
        { 
            Posicao = posicao;
            Tabuleiro = tabuleiro;
            Cor = cor;
            QuantidadeDeMovimentos = 0;
        }
        


    }
}
