namespace Day_08;

public struct SeriesByTwo : ISeries
{
    private int current; 
    public int Current
    {
        get { return current; }
    }
    
    
    
    public void GetNext()
    {
        current += 2;
    }

    public void Reset()
    {
        current = 0;
    }
}