using XadrezConsole;
using XadrezConsole.Tabuleiro;
using XadrezConsole.Xadrez;

try
{
    Tabuleiro tabuleiro = new(8, 8);

    tabuleiro.ColocarPeca(new Torre(tabuleiro, Cor.Preta), new Posicao(0, 0));
    // tabuleiro.ColocarPeca(new Rei(tabuleiro, Cor.Preta), new Posicao(0, 0)); lança um erro pois já existe uma peça aqui
    // tabuleiro.ColocarPeca(new Rei(tabuleiro, Cor.Preta), new Posicao(3, 20)); lança um erro pois não existe uma coluna 20
    // tabuleiro.ColocarPeca(new Rei(tabuleiro, Cor.Preta), new Posicao(30, 5)); lança um erro pois não existe linha 30
    tabuleiro.ColocarPeca(new Torre(tabuleiro, Cor.Preta), new Posicao(1, 3));
    tabuleiro.ColocarPeca(new Rei(tabuleiro, Cor.Preta), new Posicao(2, 4));
    Tela.ImprimirTabuleiro(tabuleiro);

    Console.ReadLine();
}
catch (TabuleiroException ex)
{
    Console.WriteLine(ex.Message);
}
