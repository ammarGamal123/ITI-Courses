namespace Day_08;

public class FibSeries : ISeries
{
    private int current;
    private int prev;

    public FibSeries()
    {
        prev = 0;
        current = 1; 
    }
    public int Current
    {
        get { return current; }
    }
    public void GetNext()
    {
        int Temp = Current;
        current += prev;
        prev = Temp;
    }

    public void Reset()
    {
        prev = 0;
        current = 1;
    }
}