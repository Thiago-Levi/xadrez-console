﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xadrez_console
{
    internal class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor {  get; set; }
        public int quantidadeDeMovimentos { get; set; }
        public Tabuleiro tabuleiro { get; protected set; }

        public Peca(Posicao posicao, Tabuleiro tabuleiro, Cor cor) 
        { 
            this.posicao = posicao;
            this.tabuleiro = tabuleiro;
            this.cor = cor;
            this.quantidadeDeMovimentos = 0;
        }
        
       


    }
}
