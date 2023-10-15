namespace Model;

public class TypeA
{
    private int X;
    private protected int M; // C# 7.x Feature 
    protected int Y;
    internal int Z;
    protected internal int L;
    public int K;

    public override string ToString()
    {
        return $"{X} :: {Y} :: {Z} :: {K} :: {L} :: {M}";
    }
}