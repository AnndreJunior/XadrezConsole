namespace XadrezConsole.Tabuleiro;

public class Peca
{
    public Peca(Posicao posicao, Tabuleiro tabuleiro, Cor cor)
    {
        Posicao = posicao;
        Tabuleiro = tabuleiro;
        Cor = cor;
        QuantidadeMovimentos = 0;
    }

    public Posicao Posicao { get; set; } = null!;
    public Cor Cor { get; protected set; }
    public int QuantidadeMovimentos { get; protected set; }
    public Tabuleiro Tabuleiro { get; set; } = null!;
}
