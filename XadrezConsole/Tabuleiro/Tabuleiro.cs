namespace XadrezConsole.Tabuleiro;

public class Tabuleiro
{
    private Peca[,] pecas = new Peca[0, 0];

    public Tabuleiro(int numeroLinhas, int numeroColunas)
    {
        NumeroLinhas = numeroLinhas;
        NumeroColunas = numeroColunas;
        pecas = new Peca[NumeroLinhas, NumeroColunas];
    }

    public int NumeroLinhas { get; set; }
    public int NumeroColunas { get; set; }

    public Peca PegarPeca(int linha, int coluna)
    {
        return pecas[linha, coluna];
    }

    public void ColocarPeca(Peca peca, Posicao posicao)
    {
        pecas[posicao.Linha, posicao.Coluna] = peca;
        peca.Posicao = posicao;
    }
}
