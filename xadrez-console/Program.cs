// See https://aka.ms/new-console-template for more information

using xadrez;
using tabuleiro;
using xadrez_console;

Tabuleiro tabuleiro = new Tabuleiro(8, 8);


tabuleiro.InserirPeca(new Torre(tabuleiro, Cor.Preta), new Posicao(0,0));
tabuleiro.InserirPeca(new Torre(tabuleiro, Cor.Preta), new Posicao(1, 3));
tabuleiro.InserirPeca(new Rei(tabuleiro, Cor.Preta), new Posicao(2, 4));

Tela.ImprimirTabuleiro(tabuleiro);