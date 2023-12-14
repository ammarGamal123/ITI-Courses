namespace Day_08;


// Dev01
public interface ISeries
{
    int Current { get; }

    void GetNext();

    void Reset();
    
}